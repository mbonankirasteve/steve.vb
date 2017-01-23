Imports MySql.Data.MySqlClient
Public Class Reserve_Ticket1
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReserveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveToolStripMenuItem.Click





        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from  reserve.ticket;", mycon)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
            mycon.Open()
            Dim ds As DataSet = New DataSet()
            myDataAdapter.Fill(ds)
            Dim crp As CrystalReport1 = New CrystalReport1()
            crp.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crp
            CrystalReportViewer1.Show()
            CrystalReportViewer1.Refresh()
            mycon.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reserve_Ticket.Show()
        Me.Hide()

    End Sub
End Class