Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class Impresion


    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private dt As DataTable
    Private reportName As String

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream

        Dim stream As Stream = New FileStream("..\..\" + name + "." + fileNameExtension, FileMode.Create)

        m_streams.Add(stream)

        Return stream

    End Function



    Private Sub Export(ByVal report As LocalReport)

        Dim deviceInfo As String = "<DeviceInfo>" & " <OutputFormat>EMF</OutputFormat>" & " <PageWidth>8.268in</PageWidth>" & " <PageHeight>11.693in</PageHeight>" & " <MarginTop>0in</MarginTop>" & " <MarginLeft>0in</MarginLeft>" & " <MarginRight>0in</MarginRight>" & " <MarginBottom>0in</MarginBottom>" & "</DeviceInfo>"

        Dim warnings() As Warning = Nothing

        m_streams = New List(Of Stream)()

        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        Dim stream As Stream

        For Each stream In m_streams

            stream.Position = 0

        Next

    End Sub



    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1

        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)

    End Sub



    Public Sub Print(ByVal report As LocalReport)
        Dim instance As New Printing.PrinterSettings
        Dim impresora As String = instance.PrinterName
        'Const printerName As String = Impresora

        If m_streams Is Nothing Or m_streams.Count = 0 Then

            Return

        End If

        Dim printDoc As New PrintDocument()

        printDoc.PrinterSettings.PrinterName = Impresora

        If Not printDoc.PrinterSettings.IsValid Then

            Dim msg As String = String.Format("No se ha podido encontrar la impresora", Impresora)

            MessageBox.Show(msg)

            Return

        End If

        AddHandler printDoc.PrintPage, AddressOf PrintPage

        printDoc.Print()

    End Sub



End Class
