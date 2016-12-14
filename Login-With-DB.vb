'Define:
Imports System.Data.OleDb
Imports System.Data

Public Class login

    Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=basededados.mdb"
    Dim oConn As New OleDb.OleDbConnection
    Dim AdminCommand As OleDbCommand
    Dim AdminAdapter As OleDbDataAdapter
    Dim AdminTabela As DataTable
    Dim linha As OleDbDataReader
    Dim x As DataTableReader 

'''''''''''''''''''''''


Dim logg As String
        Dim entrada As Integer
        oConn.ConnectionString = strConn
        oConn.Open()
        If oConn.State = ConnectionState.Open Then
            logg = "SELECT * FROM login where user='" + log.Text + "' and password='" + pass.Text + "'"
            AdminCommand = New OleDbCommand(logg, oConn)
            AdminAdapter = New OleDbDataAdapter()
            AdminAdapter.SelectCommand = AdminCommand
            AdminTabela = New DataTable()
            x = AdminTabela.CreateDataReader
            linha = AdminCommand.ExecuteReader
            While linha.Read()
                entrada = 1
                'MsgBox("Welcome " + log.Text + "  ")

                Me.Visible = True
                Principal.Visible = True
                Me.Visible = False

            End While
            If entrada = 0 Then
                MsgBox("Wrong login or Password")
            End If
        End If

        log.Clear()
        pass.Clear()

        oConn.Close()
