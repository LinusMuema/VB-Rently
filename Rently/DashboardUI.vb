Imports System.Data.OleDb
Public Class DashboardUI
    Private cmd As New OleDb.OleDbCommand
    Private da As New OleDb.OleDbDataAdapter
    Private connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\vb\VB-Rently\Rently\Rently.accdb")
    Private myDataSet As New DataSet()
    Private myDataTable As New DataTable()
    Private Sub DashboardUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim selectQuery As String = "SELECT TOP 5 * FROM users"
        Dim myCommand As New OleDbCommand(selectQuery, connection)
        Dim myDataAdapter As New OleDbDataAdapter(myCommand)
        Dim myDataSet As New DataSet()
        Dim myDataTable As New DataTable()
        Try
            connection.Open()
            myDataAdapter.Fill(myDataSet, "users")
            myDataTable = myDataSet.Tables("users")
            TenantsPreview.DataSource = myDataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error")
        Finally
            connection.Close()
        End Try

    End Sub
End Class