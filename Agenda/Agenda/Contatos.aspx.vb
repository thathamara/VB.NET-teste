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






    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Exemplo de operação de salvamento
        Dim nome As String = TextBox1.Text()
        Dim email As String = TextBox2.Text()
        Dim telefone As String = TextBox3.Text()

        SalvarDados(nome, email, telefone)

    End Sub




    Private Sub SalvarDados(nome As String, email As String, telefone As String)
        ' Define a string de conexão com o banco de dados
        Dim connectionString As String = "Data Source=DESKTOP-53O4LN7\SQLEXPRESS;Initial Catalog=aaaaaaaaaaaaa;Integrated Security=True ; User ID=sa; Password=dim@admin2008"

        ' Cria a conexão com o banco de dados
        Using connection As New SqlConnection(connectionString)
            ' Define o comando SQL de inserção
            Dim query As String = "INSERT INTO aaa (nome,email,telefone) VALUES (@nome, @email,@telefone)"

            ' Cria o comando e associa os parâmetros
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nome", nome)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@telefone", telefone)

                Try
                    ' Abre a conexão e executa o comando
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Dados salvos com sucesso!")
                Catch ex As Exception
                    ' Tratamento de erro em caso de falha
                    MsgBox("Erro ao salvar dados: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class