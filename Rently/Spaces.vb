Imports System.Data.OleDb
Public Class Spaces
    Private cmd As New OleDb.OleDbCommand
    Private da As New OleDb.OleDbDataAdapter
    Private connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\vb\VB-Rently\Rently\Rently.accdb")

    Private Sub Spaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim spacesQuery As String = "SELECT * FROM spaces"

        Dim spacesCommand As New OleDbCommand(spacesQuery, connection)

        'setting the adapters
        Dim spacesAdapter As New OleDbDataAdapter(spacesCommand)

        Dim spacesDataSet As New DataSet()

        Dim spacesDataTable As New DataTable()

        Try
            connection.Open()
            spacesAdapter.Fill(spacesDataSet, "spaces")
            spacesDataTable = spacesDataSet.Tables("spaces")
            SpacesView.DataSource = spacesDataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error")
        Finally
            connection.Close()
        End Try
    End Sub
End Class