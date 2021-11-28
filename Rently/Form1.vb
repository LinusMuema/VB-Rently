Public Class Form1
    Private cmd As New OleDb.OleDbCommand
    Private da As New OleDb.OleDbDataAdapter
    Private con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\moose\Documents\Rently.accdb")

    Private Sub Add_User_Click(sender As Object, e As EventArgs) Handles Add_User.Click
        Try
            Dim name = "test"
            Dim balance = 15000
            Dim email = "testing@mail.com"
            Dim phone = "+254759458280"

            con.Open()
            cmd.Connection = con
            cmd.CommandText = $"insert into users (fullname, email, phone, balance) values ('{name}', '{email}', '{phone}', '{balance}')"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"{name} has been created successfully!")
            Else
                MsgBox("Oops! something happened. Try again later.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Add_Space_Click(sender As Object, e As EventArgs) Handles Add_Space.Click
        Try
            Dim name = "H05"
            Dim rent = 15000
            Dim description = "another 2 b/r but this time, from the app..."

            con.Open()
            cmd.Connection = con
            cmd.CommandText = $"insert into spaces (housename, rent, description) values ('{name}', '{rent}', '{description}')"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"{name} has been created successfully!")
            Else
                MsgBox("Oops! something happened. Try again later.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class