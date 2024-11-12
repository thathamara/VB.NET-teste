Imports System.Data.SqlClient

Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnLogar_Click(sender As Object, e As EventArgs) Handles BtnLogar.Click


        ' Exemplo de operação de salvamento
        Dim senha As String = TxtSenha.Text()
        Dim email As String = TxtEmail.Text()

        ' Verifica se o usuário já existe
        If UsuarioExiste(email) Then
            MsgBox("Usuário já existe no banco de dados.")
        Else
            MsgBox("Usuário disponível para cadastro.")
        End If

        SalvarDadosLogin(email, senha)

    End Sub

    Private Sub SalvarDadosLogin(email As String, senha As String)
        ' Define a string de conexão com o banco de dados
        Dim connectionString As String = "Data Source=DESKTOP-53O4LN7\SQLEXPRESS;Initial Catalog=aaaaaaaaaaaaa;Integrated Security=True ; User ID=sa; Password=dim@admin2008"

        ' Cria a conexão com o banco de dados
        Using connection As New SqlConnection(connectionString)
            ' Define o comando SQL de inserção
            Dim query As String = "INSERT INTO USUARIO (email,senha) VALUES (@email,@senha)"

            ' Cria o comando e associa os parâmetros
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@senha", senha)

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

    Private Function UsuarioExiste(email As String) As Boolean
        ' Defina a string de conexão para o seu banco de dados
        Dim connectionString As String = "Data Source=DESKTOP-53O4LN7\SQLEXPRESS;Initial Catalog=aaaaaaaaaaaaa;Integrated Security=True;User ID=sa; Password=dim@admin2008"

        ' Variável para armazenar o resultado
        Dim existe As Boolean = False

        ' Comando SQL para verificar se o usuário existe
        Dim query As String = "SELECT COUNT(*) FROM usuario WHERE email = @email"

        ' Estabelece a conexão com o banco de dados
        Using connection As New SqlConnection(connectionString)
            ' Cria o comando com o parâmetro necessário
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@email", email)

                Try
                    ' Abre a conexão e executa o comando
                    connection.Open()
                    Dim resultado As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Se o resultado for maior que zero, o usuário já existe
                    If resultado > 0 Then
                        existe = True
                    End If
                Catch ex As Exception
                    ' Em caso de erro, exibe uma mensagem para o desenvolvedor
                    MsgBox("Erro ao verificar o usuário: " & ex.Message)
                End Try
            End Using
        End Using

        ' Retorna o valor indicando se o usuário existe ou não
        Return existe
    End Function





End Class