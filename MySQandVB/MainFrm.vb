Imports MySql.Data.MySqlClient
Public Class MainFrm
    Dim query As String
    'clear all the contents in textbox
    Sub clearall()
        fnameTxt.Clear()
        mnameTxt.Clear()
        lnameTxt.Clear()
        ID_Label.ResetText()
    End Sub
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readData()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
    End Sub
    'Create data to Database
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        query = "INSERT INTO names (FIRSTNAME,MIDDLENAME,LASTNAME) VALUES (@fname,@mname,@lname)"
        cmd = New MySqlCommand(query, connect)
        cmd.Parameters.AddWithValue("@fname", fnameTxt.Text)
        cmd.Parameters.AddWithValue("@mname", mnameTxt.Text)
        cmd.Parameters.AddWithValue("@lname", lnameTxt.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        readData()
    End Sub
    'Read Data from database
    Sub readData()
        dataList.Rows.Clear()
        query = "SELECT * FROM names"
        cmd = New MySqlCommand(query, connect)
        dr = cmd.ExecuteReader
        While dr.Read
            dataList.Rows.Add(dr.Item("ID").ToString, dr.Item("FIRSTNAME").ToString, dr.Item("MIDDLENAME").ToString, dr.Item("LASTNAME").ToString)
        End While
        dr.Close()
    End Sub
    'update data from database
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        query = "UPDATE names SET FIRSTNAME=@fname, MIDDLENAME=@mname, LASTNAME=@lname WHERE ID = @id"
        cmd = New MySqlCommand(query, connect)
        cmd.Parameters.AddWithValue("@id", ID_Label.Text)
        cmd.Parameters.AddWithValue("@fname", fnameTxt.Text)
        cmd.Parameters.AddWithValue("@mname", mnameTxt.Text)
        cmd.Parameters.AddWithValue("@lname", lnameTxt.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data updated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        readData()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        addBtn.Enabled = True
    End Sub
    'double click the datagridview to transfer the data to textbox
    Private Sub dataList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataList.CellDoubleClick
        ID_Label.Text = dataList.Rows(e.RowIndex).Cells(0).Value.ToString
        fnameTxt.Text = dataList.Rows(e.RowIndex).Cells(1).Value.ToString
        mnameTxt.Text = dataList.Rows(e.RowIndex).Cells(2).Value.ToString
        lnameTxt.Text = dataList.Rows(e.RowIndex).Cells(3).Value.ToString
        updateBtn.Enabled = True
        deleteBtn.Enabled = True
        addBtn.Enabled = False
    End Sub
    'delete data from database
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        query = "DELETE FROM names WHERE ID=@id"
        cmd = New MySqlCommand(query, connect)
        cmd.Parameters.AddWithValue("@id", ID_Label.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        readData()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        addBtn.Enabled = True
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearall()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        addBtn.Enabled = True
    End Sub
End Class
