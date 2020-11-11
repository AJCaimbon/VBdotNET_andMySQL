Imports MySql.Data.MySqlClient
Module connectionModule
    'declare variables for global call
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader


    'connection of database 
    Public Function connect() As MySqlConnection
        connect = New MySqlConnection
        'checking if database is connected to application
        Try
            connect.ConnectionString = "server=localhost;uid=root;database=demo2"
            connect.Open()
        Catch ex As Exception
            'throw a message if their have a problem in connection
            MessageBox.Show(ex.Message)
            connect.Close()
        End Try
        Return connect
    End Function
End Module
