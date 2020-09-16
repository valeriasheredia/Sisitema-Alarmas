Public Class FRM_GESTION_USUARIOS
    Dim datacontext As New DC_AdminDataContext
    Private Sub BTN_USU_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_GUARDAR.Click
        Try
            Dim buscausu = (From usu In datacontext.USUARIOS Select usu.USU_USUARIO Where USU_USUARIO = TB_USU_USUARIO.Text.ToUpper).Any
            If buscausu = True Then
                MsgBox("El ususario ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If TB_USU_USUARIO.Text.Length = 0 Or TB_USU_CONTRASEÑA.Text.Length = 0 Or TB_USU_REPETIR_CONTRASEÑA.Text.Length = 0 Or CB_USU_PERFIL.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            If TB_USU_CONTRASEÑA.Text <> TB_USU_REPETIR_CONTRASEÑA.Text Then
                MsgBox("Las contraseñas no coinciden")
                TB_USU_CONTRASEÑA.Clear()
                TB_USU_REPETIR_CONTRASEÑA.Clear()
                Exit Sub
            Else

                Dim usu = New USUARIOS

                usu.USU_USUARIO = TB_USU_USUARIO.Text
                usu.USU_CONTRASEÑA = TB_USU_CONTRASEÑA.Text
                usu.USU_PERFIL = CB_USU_PERFIL.Text

                datacontext.USUARIOS.InsertOnSubmit(usu)
                datacontext.SubmitChanges()
                MsgBox("El usuario se ha creado correctamente", vbInformation)

                limpiarcontroles()
            End If
        Catch ex As Exception

            MsgBox("El usuario NO fue creado")
            limpiarcontroles()
        End Try

    End Sub

    Sub limpiarcontroles()
        TB_USU_CONTRASEÑA.Clear()
        TB_USU_USUARIO.Clear()
        CB_USU_PERFIL.SelectedIndex = -1
        TB_USU_REPETIR_CONTRASEÑA.Clear()
    End Sub

    Private Sub TB_USU_USUARIO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_USU_USUARIO.LostFocus
        TB_USU_USUARIO.Text = TB_USU_USUARIO.Text.ToUpper
    End Sub

    
    Private Sub FRM_GESTION_USUARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TB_USU_USUARIO.Focus()
        Label5.Visible = False
        TB_USU_ID.Visible = False
    End Sub

    Private Sub BTN_USU_ACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_ACTUALIZAR.Click
       
        If TB_USU_CONTRASEÑA.Text.Length = 0 Or TB_USU_REPETIR_CONTRASEÑA.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        If TB_USU_CONTRASEÑA.Text = TB_USU_REPETIR_CONTRASEÑA.Text Then
            Try
                Dim Actualizarcontraseña = (From P In datacontext.USUARIOS Where P.USU_USUARIO = (TB_USU_USUARIO.Text.ToUpper)).ToList()(0)

                Actualizarcontraseña.USU_CONTRASEÑA = TB_USU_CONTRASEÑA.Text
                Actualizarcontraseña.USU_PERFIL = CB_USU_PERFIL.Text
                datacontext.SubmitChanges()
                MsgBox("Los datos se han modificado correctamente")
                FRM_INGRESO.limpiarcontroles()
                Me.Close()

            Catch ex As Exception
                MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
                FRM_INGRESO.limpiarcontroles()
                Me.Close()
            End Try
        Else
            MsgBox("Las contraseñas no coinciden")
            TB_USU_CONTRASEÑA.Clear()
            TB_USU_REPETIR_CONTRASEÑA.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub BTN_USU_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_CANCELAR.Click
        FRM_INGRESO.limpiarcontroles()
        Me.Close()
        Me.Dispose()
    End Sub
End Class