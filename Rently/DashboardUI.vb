Imports System.Data.OleDb
Public Class DashboardUI
    Private cmd As New OleDb.OleDbCommand
    Private da As New OleDb.OleDbDataAdapter
    Private connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\vb\VB-Rently\Rently\Rently.accdb")

    Private Sub DashboardUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading the first 5 tenants and 5 spaces
        Me.CenterToScreen()
        Dim tenantsQuery As String = "SELECT TOP 5 * FROM users"
        Dim spacesQuery As String = "SELECT TOP 5 * FROM spaces"

        Dim tenantCommand As New OleDbCommand(tenantsQuery, connection)
        Dim spacesCommand As New OleDbCommand(spacesQuery, connection)

        'setting the adapters
        Dim tenantAdapter As New OleDbDataAdapter(tenantCommand)
        Dim spacesAdapter As New OleDbDataAdapter(spacesCommand)

        Dim tenantDataSet As New DataSet()
        Dim spacesDataSet As New DataSet()


        Dim tenantDataTable As New DataTable()
        Dim spacesDataTable As New DataTable()

        Try
            connection.Open()
            tenantAdapter.Fill(tenantDataSet, "users")
            tenantDataTable = tenantDataSet.Tables("users")
            TenantsPreview.DataSource = tenantDataTable

            spacesAdapter.Fill(spacesDataSet, "spaces")
            spacesDataTable = spacesDataSet.Tables("spaces")
            SpacesPreview.DataSource = spacesDataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error")
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub ViewMoreTenantsButton_Click(sender As Object, e As EventArgs) Handles ViewMoreTenantsButton.Click
        Tenants.Show()
    End Sub

    Private Sub ViewMoreSpacesButton_Click(sender As Object, e As EventArgs) Handles ViewMoreSpacesButton.Click
        Spaces.Show()
    End Sub
End Class