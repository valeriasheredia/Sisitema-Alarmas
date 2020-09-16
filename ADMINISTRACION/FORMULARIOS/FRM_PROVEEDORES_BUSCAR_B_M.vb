Public Class FRM_PROVEEDORES_BUSCAR_B_M

    Dim datacontext As New DC_AdminDataContext
    Shared Property Tipo As TipoFormulario

    Private Sub FRM_PROVEEDORES_BUSCAR_B_M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarGrillaProveedor()
        ArmarGrillaProveedor()
    End Sub

    'Private Sub PrepararFormulario()
    '    Select Case Tipo
    '        Case TipoFormulario.ModificarProveedor
    '            BTN_PROV_BUS_EDITAR.Visible = True
    '            BTN_PROV_BUS_ELIMINAR.Visible = True
    '            BTN_PROV_BUS_SALIR.Visible = True

    '        Case TipoFormulario.EliminarProveedor

    '            BTN_PROV_BUS_EDITAR.Visible = True
    '            BTN_PROV_BUS_ELIMINAR.Visible = True
    '            BTN_PROV_BUS_SALIR.Visible = True
    '    End Select
    'End Sub

    Private Sub ArmarGrillaProveedor()
        DGV_PROV_BUSCAR.Enabled = True
        DGV_PROV_BUSCAR.AutoGenerateColumns = False
        DGV_PROV_BUSCAR.Columns.Clear()

        DGV_PROV_BUSCAR.Columns.Add("ID_PROVEEDOR", "ID_PROVEEDOR")
        DGV_PROV_BUSCAR.Columns.Add("PROV_NOMBRE", "NOMBRES")
        DGV_PROV_BUSCAR.Columns.Add("PROV_DIRECCION", "DIRECCION")
        DGV_PROV_BUSCAR.Columns.Add("PROV_TEL_1", "TELEFONO 1")
        DGV_PROV_BUSCAR.Columns.Add("PROV_TEL_2", "TELEFONO 2")
        DGV_PROV_BUSCAR.Columns.Add("PROV_MAIL", "MAIL")
        DGV_PROV_BUSCAR.Columns.Add("PROV_URL", "URL")
        DGV_PROV_BUSCAR.Columns.Add("PROV_LOCALIDAD", "LOCALIDAD")
        DGV_PROV_BUSCAR.Columns.Add("PROV_CODIGO", "CODIGO")

        DGV_PROV_BUSCAR.Columns(0).DataPropertyName = "ID_PROVEEDOR"
        DGV_PROV_BUSCAR.Columns(0).Visible = False
        DGV_PROV_BUSCAR.Columns(1).DataPropertyName = "PROV_NOMBRE"
        DGV_PROV_BUSCAR.Columns(1).Width = 150
        DGV_PROV_BUSCAR.Columns(2).DataPropertyName = "PROV_DIRECCION"
        DGV_PROV_BUSCAR.Columns(2).Width = 150
        DGV_PROV_BUSCAR.Columns(3).DataPropertyName = "PROV_TEL_1"
        DGV_PROV_BUSCAR.Columns(4).DataPropertyName = "PROV_TEL_2"
        DGV_PROV_BUSCAR.Columns(5).DataPropertyName = "PROV_MAIL"
        DGV_PROV_BUSCAR.Columns(5).Width = 150
        DGV_PROV_BUSCAR.Columns(6).DataPropertyName = "PROV_URL"
        DGV_PROV_BUSCAR.Columns(6).Width = 150
        DGV_PROV_BUSCAR.Columns(7).DataPropertyName = "PROV_LOCALIDAD"
        DGV_PROV_BUSCAR.Columns(8).DataPropertyName = "PROV_CODIGO"

        DGV_PROV_BUSCAR.ClearSelection()
    End Sub

    Public Sub CargarGrillaProveedor()
        Dim ConsultaProveedor = From U In datacontext.PROVEEDORES Select U.ID_PROVEEDOR, U.PROV_NOMBRE, U.PROV_DIRECCION, U.PROV_TEL_1, U.PROV_TEL_2, U.PROV_MAIL, U.PROV_URL, U.PROV_LOCALIDAD, U.PROV_CODIGO
        DGV_PROV_BUSCAR.DataSource = ConsultaProveedor
    End Sub

    Private Sub BTN_PROV_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROV_BUS_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TB_PROV_BUSCAR_NOMBRE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_PROV_BUSCAR_NOMBRE.TextChanged
        Dim buscar As String
        If RB_PROV_BUSCAR_NOMBRE.Checked = True Then
            ArmarGrillaProveedor()
            buscar = Me.TB_PROV_BUSCAR_NOMBRE.Text & "*"
            Dim consulta_nombre = From U In datacontext.PROVEEDORES Select U.ID_PROVEEDOR, U.PROV_NOMBRE, U.PROV_DIRECCION, U.PROV_TEL_1, U.PROV_TEL_2, U.PROV_MAIL, U.PROV_URL, U.PROV_LOCALIDAD, U.PROV_CODIGO Where PROV_NOMBRE Like buscar.ToString
            DGV_PROV_BUSCAR.DataSource = consulta_nombre
        End If
    End Sub

    Private Sub TB_PROV_BUSCAR_CODIGO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_PROV_BUSCAR_CODIGO.TextChanged
        Dim buscar As String
        If RB_PROV_BUSCAR_CODIGO.Checked = True Then
            ArmarGrillaProveedor()
            buscar = "*" & Me.TB_PROV_BUSCAR_CODIGO.Text & "*"
            Dim consulta_codigo = From U In datacontext.PROVEEDORES Select U.ID_PROVEEDOR, U.PROV_NOMBRE, U.PROV_DIRECCION, U.PROV_TEL_1, U.PROV_TEL_2, U.PROV_MAIL, U.PROV_URL, U.PROV_LOCALIDAD, U.PROV_CODIGO Where PROV_CODIGO Like buscar.ToString
            DGV_PROV_BUSCAR.DataSource = consulta_codigo
        End If
    End Sub

    Private Sub BTN_PROV_BUS_EDITAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROV_BUS_EDITAR.Click

        If DGV_PROV_BUSCAR.SelectedRows.Count > 0 Then
           
            FRM_PROVEEDORES.TB_PROV_ID.Text = DGV_PROV_BUSCAR.Item("ID_PROVEEDOR", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_NOMBRE.Text = DGV_PROV_BUSCAR.Item("PROV_NOMBRE", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_DIRECCION.Text = DGV_PROV_BUSCAR.Item("PROV_DIRECCION", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_TEL_1.Text = DGV_PROV_BUSCAR.Item("PROV_TEL_1", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_TEL_2.Text = DGV_PROV_BUSCAR.Item("PROV_TEL_2", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_MAIL.Text = DGV_PROV_BUSCAR.Item("PROV_MAIL", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_URL.Text = DGV_PROV_BUSCAR.Item("PROV_URL", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_LOCALIDAD.Text = DGV_PROV_BUSCAR.Item("PROV_LOCALIDAD", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value
            FRM_PROVEEDORES.TB_PROV_CODIGO.Text = DGV_PROV_BUSCAR.Item("PROV_CODIGO", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value

        End If
        FRM_PROVEEDORES.Text = "ACTUALIZAR PROVEEDORES"
        FRM_PROVEEDORES.BTN_PROV_GUARDAR.Visible = False
        FRM_PROVEEDORES.BTN_PROV_ACTUALIZAR.Visible = True

        FRM_PROVEEDORES.Show()
    End Sub

    'ELIMINA SOLO LOS PROVEEDORES QUE NO HAN REPARTIDO PRODUCTOS 
    Private Sub BTN_PROV_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROV_BUS_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.PROVEEDORES Where C.ID_PROVEEDOR = CInt(DGV_PROV_BUSCAR.Item("ID_PROVEEDOR", DGV_PROV_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará el Proveedor seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar proveedor")
            Case MsgBoxResult.Yes
                datacontext.PROVEEDORES.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("El Proveedor ha sido eliminado")
                Me.CargarGrillaProveedor()
        End Select
    End Sub

    Private Sub RB_PROV_BUSCAR_NOMBRE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROV_BUSCAR_NOMBRE.CheckedChanged
        TB_PROV_BUSCAR_CODIGO.Enabled = False
        TB_PROV_BUSCAR_CODIGO.Clear()
        TB_PROV_BUSCAR_NOMBRE.Enabled = True
    End Sub

    Private Sub RB_PROV_BUSCAR_CODIGO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROV_BUSCAR_CODIGO.CheckedChanged
        TB_PROV_BUSCAR_NOMBRE.Enabled = False
        TB_PROV_BUSCAR_NOMBRE.Clear()
        TB_PROV_BUSCAR_CODIGO.Enabled = True
    End Sub
End Class