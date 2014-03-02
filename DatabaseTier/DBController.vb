Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe

Public Class DBController

    Private Shared cn As SqlCeConnection
    Private Shared cnString As String = ""
    Private Shared insertCommand As SqlCeCommand
    Private Shared deleteCommand As SqlCeCommand

    'Opens the DB connection
    Public Shared Sub Open()
        'First instantiate the connection to the database
        cn = New SqlCeConnection()
        'Second set the connection string to the DB connection String
        cn.ConnectionString = cnString
        'Lastly open the connection 
        cn.Open()
    End Sub

    'closes the connection
    Public Shared Sub Close()
        cn.Close()
    End Sub


End Class
