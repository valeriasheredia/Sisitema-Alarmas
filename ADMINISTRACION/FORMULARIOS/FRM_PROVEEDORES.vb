Public Class FRM_PROVEEDORES

    Dim datacontext As New DC_AdminDataContext
    Shared Property Tipo As TipoFormulario

    Private Sub BTN_PROV_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BUSCARPORVEEDOR = (From PROV In datacontext.PROVEEDORES Select PROV.PROV_CODIGO Where PROV_CODIGO = TB_PROV_CODIGO.Text).Any
        If BUSCARPORVEEDOR = True Then
            MsgBox("El código ingresado ya pertence a un porveedor")
            Exit Sub
        End If
        Try
            If TB_PROV_CODIGO.Text.Length = 0 Or TB_PROV_DIRECCION.Text.Length = 0 Or TB_PROV_LOCALIDAD.Text.Length = 0 Or TB_PROV_NOMBRE.Text.Length = 0 Or TB_PROV_TEL_1.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim PORVEEDOR = New PROVEEDORES

                PORVEEDOR.PROV_NOMBRE = TB_PROV_NOMBRE.Text
                PORVEEDOR.PROV_DIRECCION = TB_PROV_DIRECCION.Text
                PORVEEDOR.PROV_TEL_1 = TB_PROV_TEL_1.Text
                PORVEEDOR.PROV_TEL_2 = TB_PROV_TEL_2.Text
                PORVEEDOR.PROV_CODIGO = TB_PROV_CODIGO.Text
                PORVEEDOR.PROV_MAIL = TB_PROV_MAIL.Text
                PORVEEDOR.PROV_URL = TB_PROV_URL.Text
                PORVEEDOR.PROV_LOCALIDAD = TB_PROV_LOCALIDAD.Text
                I = PORVEEDOR.ID_PROVEEDOR

                datacontext.PROVEEDORES.InsertOnSubmit(PORVEEDOR)
                datacontext.SubmitChanges()
                MsgBox("El proveedor se ha cargado correctamente")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_PROV_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Sub limpiar_campos()
        TB_PROV_CODIGO.Clear()
        TB_PROV_DIRECCION.Clear()
        TB_PROV_ID.Clear()
        TB_PROV_LOCALIDAD.Clear()
        TB_PROV_MAIL.Clear()
        TB_PROV_NOMBRE.Clear()
        TB_PROV_TEL_1.Clear()
        TB_PROV_TEL_2.Clear()
        TB_PROV_URL.Clear()
    End Sub

    Private Sub FRM_PROVEEDORES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "CARGAR PROVEEDORES" Then
            BTN_PROV_ACTUALIZAR.Visible = False
        ElseIf Me.Text = "ACTUALIZAR PROVEEDORES" Then
            BTN_PROV_ACTUALIZAR.Visible = True
        End If
    End Sub

    Private Sub BTN_PROV_ACTUALIZAR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_PROV_ACTUALIZAR.Click
        If TB_PROV_CODIGO.Text.Length = 0 Or TB_PROV_DIRECCION.Text.Length = 0 Or TB_PROV_LOCALIDAD.Text.Length = 0 Or TB_PROV_NOMBRE.Text.Length = 0 Or TB_PROV_TEL_1.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProveedor = (From P In datacontext.PROVEEDORES Where P.ID_PROVEEDOR = (TB_PROV_ID.Text)).ToList()(0)
            ActualizarProveedor.PROV_NOMBRE = TB_PROV_NOMBRE.Text
            ActualizarProveedor.PROV_DIRECCION = TB_PROV_DIRECCION.Text
            ActualizarProveedor.PROV_TEL_1 = TB_PROV_TEL_1.Text
            ActualizarProveedor.PROV_TEL_2 = TB_PROV_TEL_2.Text
            ActualizarProveedor.PROV_CODIGO = TB_PROV_CODIGO.Text
            ActualizarProveedor.PROV_MAIL = TB_PROV_MAIL.Text
            ActualizarProveedor.PROV_URL = TB_PROV_URL.Text
            ActualizarProveedor.PROV_LOCALIDAD = TB_PROV_LOCALIDAD.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            FRM_PROVEEDORES_BUSCAR_B_M.CargarGrillaProveedor()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar proveedor")
        End Try
    End Sub
End Class