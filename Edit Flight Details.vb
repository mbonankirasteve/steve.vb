Imports MySql.Data.MySqlClient
Public Class Edit_Flight_Details

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  add.flight set Flightnumber='" & TextBox1.Text & "',Flightname='" & TextBox2.Text & "',StartPlace='" & TextBox3.Text & "',DestinationPlace='" & TextBox4.Text & "',Price='" & TextBox5.Text & "' where Flightname='" & TextBox2.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been updated")


            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Function txtid() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from add.flight  where Flightname='" & TextBox2.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been deleted")

            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  add.flight ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class