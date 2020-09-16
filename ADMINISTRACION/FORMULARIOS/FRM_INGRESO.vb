Public Class FRM_INGRESO
    Dim datacontext As New DC_AdminDataContext

    Private Sub BTN_USU_ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_INGR_ACEPTAR.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIOS Where I.USU_USUARIO = (TB_USU_USUARIO.Text) And I.USU_CONTRASEÑA = (TB_USU_CONTRASEÑA.Text)).ToList()(0)


            If Buscausuario.USU_PERFIL = "ADMINISTRADOR" Then

                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(0).Visible = True
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(1).Visible = True
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(2).Visible = True
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.UsuariosToolStripMenuItem.DropDownItems(0).Visible = True

            ElseIf Buscausuario.USU_PERFIL = "LIMITADO" Then
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(0).Visible = True
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.UsuariosToolStripMenuItem.Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(0).Visible = True
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(0).Visible = True
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(0).Visible = True
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(3).Visible = True

            ElseIf Buscausuario.USU_PERFIL = "CONSULTA" Then
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(0).Visible = False
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ClientesToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.UsuariosToolStripMenuItem.Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(0).Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ProductosToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(0).Visible = False
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.ProveedoresToolStripMenuItem.DropDownItems(3).Visible = True
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(0).Visible = False
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(1).Visible = False
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(2).Visible = False
                FRM_MENU.VentasToolStripMenuItem.DropDownItems(3).Visible = True

            End If

            'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
            'ACTUALIZAR PASS DESDE ADENTRO
            FRM_MENU.LBL_MENU_PERFIL.Text = Buscausuario.USU_PERFIL.ToString
            FRM_MENU.LBL_MENU_USU.Text = Buscausuario.USU_USUARIO.ToString


            FRM_MENU.Show()
            Me.Finalize()
            Me.Close()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            TB_USU_USUARIO.Select()
            limpiarcontroles()
        End Try
    End Sub

    Public Sub limpiarcontroles()
        TB_USU_CONTRASEÑA.Clear()
        TB_USU_USUARIO.Clear()

    End Sub

    Private Sub BTN_USU_CAMBIO_PASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ING_CAMBIO_PASS.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIOS Where I.USU_USUARIO = (TB_USU_USUARIO.Text.ToUpper) And I.USU_CONTRASEÑA = (TB_USU_CONTRASEÑA.Text)).ToList()(0)
            FRM_GESTION_USUARIOS.TB_USU_USUARIO.Text = Buscausuario.USU_USUARIO
            FRM_GESTION_USUARIOS.CB_USU_PERFIL.Text = Buscausuario.USU_PERFIL
            FRM_GESTION_USUARIOS.CB_USU_PERFIL.Enabled = False
            FRM_GESTION_USUARIOS.TB_USU_USUARIO.Enabled = False
            FRM_GESTION_USUARIOS.BTN_USU_GUARDAR.Visible = False
            FRM_GESTION_USUARIOS.Show()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            TB_USU_USUARIO.Select()
            limpiarcontroles()
        End Try
    End Sub

    Private Sub TB_USU_USUARIO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_USU_USUARIO.LostFocus
        TB_USU_USUARIO.Text = TB_USU_USUARIO.Text.ToUpper
    End Sub


    Private Sub BTN_INGR_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_INGR_CANCELAR.Click
        Me.Close()
        Application.Exit()
        Me.Dispose()
    End Sub

    Private Sub FRM_INGRESO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TB_USU_USUARIO.Focus()
    End Sub

End Class