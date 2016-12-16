

'Processo de alteração de dados numa BD usando OLEDB e VB2008


'1-	No inicio do código do formulário colocar os comandos abaixo para o sistema importar informações relativas as livrarias de ligação à BD: 

Imports System.Data.OleDb

Imports System.Data

'2-	No botão de gravação dde dados colocar o seguinte código:

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
	'Definição das variaveis de ligação
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projectovideoclube\BaseDadosvideoclube.mdb"

        Dim sql_1 As String
        Dim oConn As New OleDb.OleDbConnection
      oConn.ConnectionString = strConn
        Dim cmd As OleDbCommand = oConn.CreateCommand

'Comando SQL para a inserção (adaptar segundo o vosso caso)
        sql_1 = "delete from Filmes where nfilmes=”+ textbox1.text
        'MsgBox(sql_1)
        cmd.CommandText = sql_1

'Execução do comando de inserção        
Try

            oConn.Open()

            cmd.ExecuteNonQuery()

            oConn.Close()

            MsgBox("Registo incluido com sucesso !", MsgBoxStyle.Information, "Incluindo registros")


        Catch erro As Exception

            MsgBox("Erro " & vbCrLf & erro.ToString, MsgBoxStyle.Critical, "Erro")

        End Try


    End Sub

