
' Como ler dados de uma tabela da base de dados e carregar esses dados para um formulário.
' 1.	Será necessário criar um formulário para cada tabela, do mesmo tipo dos formulários criados para o inserir. 
' 2.	No código Depois da definição da classe “form” devem ser definidas as variáveis:
Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projectovideoclube\BaseDadosvideoclube.mdb"
' Conexão à base de dados
    Dim oConn As New OleDb.OleDbConnection
'  Variável que guardará a conexão
    Dim FilmesCommand As OleDbCommand
'  Variável que guardará o comando SQL
    Dim FilmesAdapter As OleDbDataAdapter
    Dim FilmesTabela As DataTable
'  Variaveis que guardaram os dados da Tabela no VB
    Dim linha As OleDbDataReader
    Dim x As DataTableReader
'  Variáveis para apresentar os dados no formulário

    Dim i As Integer 
' 3.	No evento “form_load” deve ser colocado o seguinte código com as alterações necessárias para a vossa base de dados. Não esquecer de colocar os “imports” antes do inicio da classe form. 
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        oConn.ConnectionString = strConn

        oConn.Open()

        If oConn.State = ConnectionState.Open Then

            'MsgBox("Conexão efetuada com sucesso!")
            FilmesCommand = New OleDbCommand("SELECT * FROM Filmes ORDER BY Nome", oConn)

            'define um dataAdapter

            FilmesAdapter = New OleDbDataAdapter()

            FilmesAdapter.SelectCommand = FilmesCommand

            'define e preenche um DataTable com os dados

            FilmesTabela = New DataTable()
            'FilmesAdapter.Fill(FilmesTabela)
            ' associar campos a base de dados
            x = FilmesTabela.CreateDataReader


            ' Ler da tabela

            linha = FilmesCommand.ExecuteReader
            If linha.Read() Then

                numero.Text = linha("Nfilmes")
                nome.Text = linha("Nome")
                TextBox1.Text = linha("Realizacao")
                TextBox3.Text = linha("Genero")
                TextBox4.Text = linha("Classificacao")

            End If





        End If

    End Sub

' 4.	Criar um botão para navegar pelos registos da BD. Colocar no click do botão o seguinte código (Adaptado a cada tabela).
If linha.Read() Then

            numero.Text = linha("Nfilmes")
            nome.Text = linha("Nome")
            TextBox1.Text = linha("Realizacao")
            TextBox3.Text = linha("Genero")
            TextBox4.Text = linha("Classificacao")

        End If
