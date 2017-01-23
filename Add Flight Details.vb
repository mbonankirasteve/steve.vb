Imports MySql.Data.MySqlClient
Public Class Add_Flight_Details

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  Add.Flight(Flightnumber,Flightname,StartPlace,DestinationPlace,Price) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "') ", mycon)
            Dim myReader As IDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been saved")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Add_Fight_Views.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Report_Add_Flight.Show()
        Me.Hide()

    End Sub
End Class