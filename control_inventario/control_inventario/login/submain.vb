Public Class submain
    <STAThread()> _
    Shared Sub main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim star As login = New login
        star.ShowDialog()

        If (star.DialogResult = DialogResult.OK) Then
            Application.Run(New FormPrincipal)
        End If

    End Sub
End Class
