
Namespace SQLite
    Public Class SQLiteConnection

        Private _p1 As Object
        Friend CreateCommand As Object

        Sub New(p1 As Object)
            ' TODO: Complete member initialization 
            _p1 = p1
        End Sub

        Sub Open()
            Throw New NotImplementedException
        End Sub

        Sub Close()
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace
