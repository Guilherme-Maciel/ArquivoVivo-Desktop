Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Module ModuleDB
    Public Function GetConnectionMysql() As MySqlConnection
        Dim sql As String = "SERVER=localhost; DATABASE=arquivovivomv;Uid=root;Pwd="
        Return New MySqlConnection(sql)
    End Function
End Module
