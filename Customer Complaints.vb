Imports MySql.Data.MySqlClient

Public Class Customer_Complaints

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  Customer.Complaint(Name,Address,Complaint) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "') ", mycon)
            Dim myReader As IDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been saved")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  Customer.Complaint where Name='" + TextBox1.Text + "' ;", conDatabase)
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