

Partial Public Class GidrogasitelDataSet
    Partial Class mainDataTable

    End Class

    Partial Class RezultDataTable

        Private Sub RezultDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

        Private Sub RezultDataTable_RezultRowChanging(ByVal sender As System.Object, ByVal e As RezultRowChangeEvent) Handles Me.RezultRowChanging

        End Sub

    End Class

    Partial Class ApparatsDataTable

        Private Sub ApparatsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class

End Class

Namespace GidrogasitelDataSetTableAdapters
    
    Partial Class mainTableAdapter

    End Class

    Partial Class OperatorsTableAdapter

    End Class

    Partial Class ApparatTypeTableAdapter

    End Class

    Partial Public Class ApparatsTableAdapter
    End Class
End Namespace
