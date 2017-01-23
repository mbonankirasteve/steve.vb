﻿Imports MySql.Data.MySqlClient
Public Class Report_Add_Flight

    Private Sub CrystalReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from  add.flight;", mycon)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Add_Flight_Details.Show()
        Me.Hide()

    End Sub
End Class