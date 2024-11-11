Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SqlDataSourceUsuarios_Inserted(sender As Object, e As SqlDataSourceStatusEventArgs) Handles SqlDataSourceUsuarios.Inserted


        ' if(e.Exception != Null)
        'e.Exception = Console.WriteLine("Erro!Digite outro email:")
        ' e.Exception =True; COMO TRATAR ERRO EM VB?

        ' Try
        'Exception(Not Nothing)


        '  Catch ex As Exception
        'Console.WriteLine("Erro!Digite outro email:")


        ' End Try



    End Sub

    Private Sub Exception(p1 As Integer)
        Throw New NotImplementedException
    End Sub

    Protected Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class