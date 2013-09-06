Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Conexion
    'propiedades de conexion
    Private MYSQLSERVER As String = "127.0.0.1"
    Private MYSQLPORT As Integer = 3306
    Private MYSQLUSER As String = "root"
    Private MYSQLPASS As String = ""
    Private MYSQLDB As String = "dbfiat"
    Private STRINGCOX As String = "Server=" & MYSQLSERVER & ";PORT=" & MYSQLPORT & "; USER Id=" & MYSQLUSER & ";Password=" & MYSQLPASS & "; DATABASE=" & MYSQLDB
    Private cox As New MySqlConnection

    'Prueba de conexion 
    Public Function prueba()
        Dim estado As Boolean
        estado = False
        Dim cox As New MySqlConnection
        cox.ConnectionString = STRINGCOX
        cox.Open()
        If cox.State Then
            estado = True
        Else
            estado = False
        End If
        Return estado
    End Function
    'abrir conexion a la bd
    Public Sub startCox()
        cox.ConnectionString = STRINGCOX
        Try
            cox.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Cerrar la conexion
    Public Sub closeCox()
        Try
            cox.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Comprobacion de usuario y contraseña
   
    
End Class
