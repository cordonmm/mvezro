Partial Class tallerDataSet
    Partial Public Class ProductoDataTable
        Private Sub ProductoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ObservacionesColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Public Class PresupuestoDataTable
        Private Sub PresupuestoDataTable_PresupuestoRowChanging(sender As Object, e As PresupuestoRowChangeEvent) Handles Me.PresupuestoRowChanging

        End Sub

    End Class
End Class

Namespace tallerDataSetTableAdapters
    Partial Public Class PatrimonioTableAdapter
    End Class

    Partial Public Class ConsFacturaRTableAdapter
    End Class
End Namespace
