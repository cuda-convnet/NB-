Partial Class Rt_DetectDataSet
    Partial Public Class OkMeterDataTable
        Private Sub OkMeterDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.表号Column.ColumnName) Then
                '在此处添加用户代码
            End If

        End Sub

    End Class
End Class

Namespace Rt_DetectDataSetTableAdapters

    Partial Public Class OkMeterTableAdapter
    End Class
End Namespace
