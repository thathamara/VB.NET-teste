Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Dim ConnectionString As String
    Dim DataSource As Object
    Dim Data As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click 'problema erro

        Sub ConectarAoBanco()
        ' Defina a string de conexão
        Dim connectionString As String = "Data Source=DESKTOP-53O4LN7\SQLEXPRESS; Initial Catalog=BancoDeDadosAgenda.mdf; Persist Security Info=True; User ID=sa; Password=dim@admin2008"

        ' Usa o bloco Using para garantir que a conexão seja fechada corretamente
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abre a conexão
                connection.Open()
                Console.WriteLine("Conexão aberta com sucesso!")

                ' Exemplo de consulta
                Dim query As String = "SELECT * FROM SuaTabela"

                ' Cria e executa o comando SQL
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Lê a primeira coluna da linha atual
                            Console.WriteLine(reader(0).ToString())
                        End While
                    End Using
                End Using

            Catch ex As Exception
                Console.WriteLine("Erro ao conectar: " & ex.Message)
            End Try
        End Using
    End Sub

End Class

