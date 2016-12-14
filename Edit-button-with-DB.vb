  'def connection to access database
        Dim cnt As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DATABASE.accdb")
        'open connection
        cnt.Open()
        Dim sql As String
        If ButtonX54.Text = "EDIT" Then
            'create sql
            sql = "update into alunos (nome_aluno, sexo_aluno, datanasc_aluno, morada_aluno, bi_aluno, utente_aluno, morada_mae_aluno, prof_mae_aluno, morada_pai_aluno, prof_pai_aluno, morada_enceduc_aluno, prof_enceduc_aluno, contacto_mae_aluno, contacto_pai_aluno, contacto_enceduc_aluno, niss_aluno, dataentrada_aluno, estado_aluno, turma_aluno, escolasfrequentadas_aluno, nome_pai_aluno, nome_mae_aluno) values( " + TextBox8.Text + " , '" + ComboBox2.Text + "' , '" + DateTimePicker2.Text + "' , '" + TextBox7.Text + "', '" + TextBox6.Text + "', '" + TextBox5.Text + "', '" + nomepai.Text + "', '" + profpai.Text + "', '" + moradapai.Text + "', '" + nomemae.Text + "', '" + profmae.Text + "', '" + moradamae.Text + "', '" + contactomae.Text + "', '" + contactopai.Text + "', '" + contactoenceduc.Text + "', '" + TextBox13.Text + "', '" + dataentrada.Text + "', '" + estado.Text + "', '" + turma_aluno.Text + "', '" + escolasfrequentadas.Text + "', '" + TextBox17.Text + "', '" + TextBox23.Text + "' )"
        Else
            'criar(sql)
             "Insert into alunos (nome_aluno, sexo_aluno, datanasc_aluno, morada_aluno, bi_aluno, utente_aluno, morada_mae_aluno, prof_mae_aluno, morada_pai_aluno, prof_pai_aluno, morada_enceduc_aluno, prof_enceduc_aluno, contacto_mae_aluno, contacto_pai_aluno, contacto_enceduc_aluno, niss_aluno, dataentrada_aluno, estado_aluno, turma_aluno, escolasfrequentadas_aluno, nome_pai_aluno, nome_mae_aluno) values('" + TextBox8.Text + " , '" + ComboBox2.Text + "' , '" + DateTimePicker2.Text + "' , '" + TextBox7.Text + "', '" + TextBox6.Text + "', '" + TextBox5.Text + "', '" + nomepai.Text + "', '" + profpai.Text + "', '" + moradapai.Text + "', '" + nomemae.Text + "', '" + profmae.Text + "', '" + moradamae.Text + "', '" + contactomae.Text + "', '" + contactopai.Text + "', '" + contactoenceduc.Text + "', '" + TextBox13.Text + "', '" + dataentrada.Text + "', '" + estado.Text + "', '" + turma_aluno.Text + "', '" + escolasfrequentadas.Text + "', '" + TextBox17.Text + "', '" + TextBox23.Text + "' )"
        End If

        'create command sql
        Dim cmd As New OleDb.OleDbCommand(sql, cnt)

        cmd.ExecuteNonQuery()

        cnt.Close()
