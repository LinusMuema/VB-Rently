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
            Dim receipt = "H05"
            Dim rent = 15000
            Dim description = "another 2 b/r but this time, from the app..."

            con.Open()
            cmd.Connection = con
            cmd.CommandText = $"insert into spaces (housename, rent, description) values ('{receipt}', '{rent}', '{description}')"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"{receipt} has been created successfully!")
            Else
                MsgBox("Oops! something happened. Try again later.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Add_Transaction_Click(sender As Object, e As EventArgs) Handles Add_Transaction.Click
        Try
            Dim name = "H05"
            Dim amount = 15000
            Dim paydate = "2021/11/28"

            con.Open()
            cmd.Connection = con
            cmd.CommandText = $"insert into transactions (receipt, amount, paydate, payer) values ('{name}', '{amount}', '{paydate}', '1')"

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

    Private Sub Edit_User_Click(sender As Object, e As EventArgs) Handles Edit_User.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update users Set email = 'another@mail.com', phone = '+254759458280' where ID = 1"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"user has been updated successfully!")
            Else
                MsgBox("Oops! something happened. Try again later.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Edit_Space_Click(sender As Object, e As EventArgs) Handles Edit_Space.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update spaces set rent = '36000', housename = 'H69' where ID = 1"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"space has been updated successfully!")
            Else
                MsgBox("Oops! something happened. Try again later.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Edit_Transaction_Click(sender As Object, e As EventArgs) Handles Edit_Transaction.Click
        Try

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update transactions set amount = '36000' where ID = 1"

            Dim result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox($"transaction has been updated successfully!")
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