Imports MySql.Data.MySqlClient
Public Class Reserve_Ticket

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  Reserve.Ticket(Pnrno,StartingPlace,EndingPlace,FlightId,Flightname,Dateofjourney,TicketPrice,NumberofTicket,Name,Address,Phone,Email) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "') ", mycon)
            Dim myReader As IDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Reservation successful")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reservation_View.Show()
        Me.Hide()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  Reserve.Ticket set Pnrno='" & TextBox1.Text & "',StartingPlace='" & TextBox2.Text & "',EndingPlace='" & TextBox3.Text & "',FlightId='" & TextBox4.Text & "',Flightname='" & TextBox5.Text & "',Dateofjourney='" & TextBox6.Text & "',TicketPrice='" & TextBox7.Text & "',NumberofTicket='" & TextBox8.Text & "',Name='" & TextBox9.Text & "',Address='" & TextBox10.Text & "',Phone='" & TextBox11.Text & "',Email='" & TextBox12.Text & "' where Pnrno='" & TextBox1.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been updated")


            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from Reserve.Ticket  where Pnrno='" & TextBox1.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been deleted")

            mycon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Reserve_Ticket1.Show()
        Me.Hide()

    End Sub
End Class