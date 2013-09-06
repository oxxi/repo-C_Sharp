Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class login
    Dim ex, ey As Integer
    Dim arrastre As Boolean
    Dim conex As New Conexion
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Focus()
        
    End Sub

    Private Sub btnacepta_Click(sender As Object, e As EventArgs) Handles btnacepta.Click
        ' Me.DialogResult = Windows.Forms.DialogResult.OK



    End Sub

    Private Sub login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        arrastre = True
    End Sub

    Private Sub login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If arrastre Then
            Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub login_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        arrastre = False
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim prueba As New Conexion
        If (prueba.prueba) Then
            MessageBox.Show("conexion establecida")
        End If
    End Sub
End Class