Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms

Public Class Impresion
    Implements IDisposable

    Private currentPageIndex As Integer
    Private tmpFileName As String = String.Empty
    Private streamList As List(Of Stream)

    '''<summary> 
    ''' Adiciona a Stream à lista de Streams 
    '''</summary> 
    Private Function CreateStream(ByVal name As String,
                                   ByVal fileNameExtension As String,
                                   ByVal encoding As Encoding,
                                   ByVal mimeType As String,
                                   ByVal willSeek As Boolean) As Stream

        tmpFileName = My.Computer.FileSystem.GetTempFileName()

        Dim s As New FileStream(tmpFileName, FileMode.Create)
        streamList.Add(s)
        Return s

    End Function

    '''<summary> 
    ''' Exporta o ficheiro para uma lista de Streams 
    '''</summary> 
    Private Sub ExportToStream(ByVal report As LocalReport)
        Dim deviceInfo As New StringBuilder
        With deviceInfo
            .Append("<DeviceInfo>")
            .Append(" <OutputFormat>EMF</OutputFormat>")
            .Append(" <PageWidth>8.5in</PageWidth>")
            .Append(" <PageHeight>11in</PageHeight>")
            .Append(" <MarginTop>0.25in</MarginTop>")
            .Append(" <MarginLeft>0.25in</MarginLeft>")
            .Append(" <MarginRight>0.25in</MarginRight>")
            .Append(" <MarginBottom>0.25in</MarginBottom>")
            .Append("</DeviceInfo>")
        End With

        Dim warnings() As Warning = Nothing
        report.Render("Image", deviceInfo.ToString,
                         AddressOf CreateStream, warnings)

        For Each s As Stream In streamList
            s.Position = 0
        Next
        deviceInfo = Nothing

    End Sub

    '''<summary> 
    ''' Quando o PrintDocument está a imprimir, desenha 
    ''' a página correspondente, da lista de Streams 
    '''</summary> 
    Private Sub PrintPage(ByVal sender As Object,
                           ByVal ev As PrintPageEventArgs)

        Using pageImage As New Metafile(streamList(currentPageIndex))
            currentPageIndex += 1

            ev.Graphics.DrawImage(pageImage, ev.PageBounds)
            ev.HasMorePages = (currentPageIndex < streamList.Count)
        End Using
    End Sub

    '''<summary> 
    ''' Imprime um relatório sem visualização 
    '''</summary> 
    '''<param name="report">Relatório a imprimir</param> 
    Public Sub Print(ByVal report As LocalReport)

        streamList = New List(Of Stream)

        ' Exporta o ficheiro para uma lista de Streams 
        Call ExportToStream(report)

        If streamList IsNot Nothing AndAlso streamList.Count > 0 Then

            ' Inicia o processo de impressão 
            Using printDoc As New PrintDocument()

                If Not printDoc.PrinterSettings.IsValid Then
                    Dim msg As String = "Impressora não disponível ou não válida!"
                    Throw New ArgumentException(msg)
                End If

                AddHandler printDoc.PrintPage, AddressOf PrintPage
                printDoc.Print()
            End Using

        End If

    End Sub

    Public Overloads Sub Dispose() Implements IDisposable.Dispose

        Try

            ' Fecha as streams e apaga a lista 
            If streamList IsNot Nothing Then
                For Each s As Stream In streamList
                    s.Close()
                Next
                streamList.Clear()
                streamList = Nothing
            End If

            ' Apaga o ficheiro temporário (caso exista) 
            If tmpFileName <> String.Empty AndAlso
                                               IO.File.Exists(tmpFileName) Then
                IO.File.Delete(tmpFileName)
            End If
            tmpFileName = String.Empty

        Catch ex As Exception : End Try
    End Sub

End Class
