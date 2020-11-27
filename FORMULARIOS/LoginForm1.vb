Public Class LoginForm1
    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        txtusuario.Text = "yesica gama" Or txtusuario.Text = "YESICA GAMA "
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged
        txtcontraseña.Text = "1022326860"
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim i As Integer
        For i = 1 To 3 Step 1
            If txtusuario.Text = "yesica gama " Or txtusuario.Text = "YESICA GAMA" Then
                If txtcontraseña.Text = "987654321" Then
                    MsgBox("BIENVENIDO :)")
                End If
                Exit For

            End If

            If txtusuario.Text <> "camilaperez" Or txtusuario.Text <> "CAMILAPEREZ" Then
                If txtcontraseña.Text <> "987654321" Then
                    MsgBox("Contraseña Invalida, usted lleva" & i & " intentos de 3", MsgBoxStyle.Information, "Acceso denegado")
                    txtusuario.Text = ""
                    txtcontraseña.Text = ""
                    txtusuario.Focus()
                End If
            End If
        Next
        If i >= 3 Then
            MsgBox("Acceso denegado")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Dispose()
    End Sub
End Class
