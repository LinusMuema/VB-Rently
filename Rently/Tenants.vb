Imports System.Data.OleDb
Public Class Tenants
    Private cmd As New OleDb.OleDbCommand
    Private da As New OleDb.OleDbDataAdapter
    Private connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\vb\VB-Rently\Rently\Rently.accdb")

    Private Sub Tenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tenantsQuery As String = "SELECT * FROM users"

        Dim tenantCommand As New OleDbCommand(tenantsQuery, connection)

        'setting the adapters
        Dim tenantAdapter As New OleDbDataAdapter(tenantCommand)
        Dim tenantDataSet As New DataSet()
        Dim tenantDataTable As New DataTable()

        Try
            connection.Open()
            tenantAdapter.Fill(tenantDataSet, "users")
            tenantDataTable = tenantDataSet.Tables("users")
            TenantsView.DataSource = tenantDataTable


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error")
        Finally
            connection.Close()
        End Try
    End Sub
End Class