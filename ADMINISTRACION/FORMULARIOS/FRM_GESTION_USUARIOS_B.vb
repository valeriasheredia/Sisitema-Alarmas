Public Class FRM_GESTION_USUARIOS_B
    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_GESTION_USUARIOS_B_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub
    Private Sub armargrilla()
        DGV_USU_ELIMINAR.Enabled = True
        DGV_USU_ELIMINAR.AutoGenerateColumns = False
        DGV_USU_ELIMINAR.Columns.Clear()

        DGV_USU_ELIMINAR.Columns.Add("ID_USUARIO", "ID_USUARIO")
        DGV_USU_ELIMINAR.Columns.Add("USU_USUARIO", "USUSARIO")
        DGV_USU_ELIMINAR.Columns.Add("USU_CONTRASEÑA", "CONTRASEÑA")
        DGV_USU_ELIMINAR.Columns.Add("USU_PERFIL", "PERFIL")


        DGV_USU_ELIMINAR.Columns(0).DataPropertyName = "ID_USUARIO"
        DGV_USU_ELIMINAR.Columns(1).DataPropertyName = "USU_USUARIO"
        DGV_USU_ELIMINAR.Columns(2).DataPropertyName = "USU_CONTRASEÑA"
        DGV_USU_ELIMINAR.Columns(3).DataPropertyName = "USU_PERFIL"


        DGV_USU_ELIMINAR.ClearSelection()

    End Sub

    Public Sub cargargrilla()
        Dim consultausu = From U In datacontext.USUARIOS Select U.ID_USUARIO, U.USU_USUARIO, U.USU_CONTRASEÑA, U.USU_PERFIL
        DGV_USU_ELIMINAR.DataSource = consultausu
    End Sub

    Private Sub BTN_USU_BAJA_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_BAJA_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.USUARIOS Where C.ID_USUARIO = CInt(DGV_USU_ELIMINAR.Item("ID_USUARIO", DGV_USU_ELIMINAR.SelectedRows(0).Index).Value)).ToList()(0)

        'VALIDACIONES DE ELIMINAR CLIENTES
        'Dim comprobrar1 = (From C In datacontext.Alumno_x_curso Where C.id_alumno = CInt(txtidAlu.Text)).Any
        'Dim comprobrar2 = (From C In datacontext.Alumno_x_materia Where C.id_alumno = CInt(txtidAlu.Text)).Any

        'If comprobrar1 = True Or comprobrar2 = True Then
        'MsgBox("El registro no puede ser eliminado, posee inasistencia,notas y curso asociados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")

        'Else
        Select Case MsgBox("Se eliminará el usuario seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente")
            Case MsgBoxResult.Yes
                datacontext.USUARIOS.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("El usuario ha sido eliminado")
                Me.cargargrilla()
        End Select
    End Sub

    Private Sub BTN_USU_BAJA_CERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_BAJA_CERRAR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BTN_USU_BAJA_CAMBIAR_PASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_USU_BAJA_CAMBIAR_PASS.Click
        If DGV_USU_ELIMINAR.SelectedRows.Count > 0 Then
            FRM_GESTION_USUARIOS.TB_USU_ID.Text = DGV_USU_ELIMINAR.Item("ID_USUARIO", DGV_USU_ELIMINAR.SelectedRows(0).Index).Value
            FRM_GESTION_USUARIOS.TB_USU_USUARIO.Text = DGV_USU_ELIMINAR.Item("USU_USUARIO", DGV_USU_ELIMINAR.SelectedRows(0).Index).Value
            FRM_GESTION_USUARIOS.TB_USU_CONTRASEÑA.Text = DGV_USU_ELIMINAR.Item("USU_CONTRASEÑA", DGV_USU_ELIMINAR.SelectedRows(0).Index).Value
            FRM_GESTION_USUARIOS.CB_USU_PERFIL.Text = DGV_USU_ELIMINAR.Item("USU_PERFIL", DGV_USU_ELIMINAR.SelectedRows(0).Index).Value
        End If
        FRM_GESTION_USUARIOS.BTN_USU_GUARDAR.Visible = False
        FRM_GESTION_USUARIOS.Show()
    End Sub
End Class