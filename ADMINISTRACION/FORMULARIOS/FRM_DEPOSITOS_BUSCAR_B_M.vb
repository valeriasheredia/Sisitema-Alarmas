Public Class FRM_DEPOSITOS_BUSCAR_B_M

    Dim datacontext As New DC_AdminDataContext
    Shared Property Tipo As TipoFormulario

    Private Sub TB_PROV_BUSCAR_NOMBRE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_DEPO_BUSCAR_NOMBRE.TextChanged
        Dim buscar As String
        If RB_DEPO_BUSCAR_NOMBRE.Checked = True Then
            ArmarGrillaDeposito()
            buscar = Me.TB_DEPO_BUSCAR_NOMBRE.Text & "*"
            Dim consulta_nombre = From U In datacontext.DEPOSITOS Select U.ID_DEPOSITO, U.DEPO_NOMBRE, U.DEPO_DIRECCION, U.DEPO_LOCALIDAD, U.DEPO_CODIGO Where DEPO_NOMBRE Like buscar.ToString
            DGV_DEPO_BUSCAR.DataSource = consulta_nombre
        End If
    End Sub

    Private Sub TB_PROV_BUSCAR_CODIGO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_DEPO_BUSCAR_CODIGO.TextChanged
        Dim buscar As String
        If RB_DEPO_BUSCAR_CODIGO.Checked = True Then
            ArmarGrillaDeposito()
            buscar = "*" & Me.TB_DEPO_BUSCAR_CODIGO.Text & "*"
            Dim consulta_codigo = From U In datacontext.DEPOSITOS Select U.ID_DEPOSITO, U.DEPO_NOMBRE, U.DEPO_DIRECCION, U.DEPO_LOCALIDAD, U.DEPO_CODIGO Where DEPO_CODIGO Like buscar.ToString
            DGV_DEPO_BUSCAR.DataSource = consulta_codigo
        End If
    End Sub

    Private Sub RB_PROV_BUSCAR_NOMBRE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_DEPO_BUSCAR_NOMBRE.CheckedChanged
        TB_DEPO_BUSCAR_CODIGO.Enabled = False
        TB_DEPO_BUSCAR_CODIGO.Clear()
        TB_DEPO_BUSCAR_NOMBRE.Enabled = True
    End Sub

    Private Sub RB_PROV_BUSCAR_CODIGO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_DEPO_BUSCAR_CODIGO.CheckedChanged
        TB_DEPO_BUSCAR_NOMBRE.Enabled = False
        TB_DEPO_BUSCAR_NOMBRE.Clear()
        TB_DEPO_BUSCAR_CODIGO.Enabled = True
    End Sub

    Private Sub BTN_PROV_BUS_EDITAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_DEPO_BUS_EDITAR.Click

        FRM_DEPOSITOS.Tipo = TipoFormulario.ModificarDeposito

        FRM_DEPOSITOS.Text = "ACTUALIZAR DEPÓSITO"
        If DGV_DEPO_BUSCAR.SelectedRows.Count > 0 Then
            FRM_DEPOSITOS.TB_DEPO_ID.Text = DGV_DEPO_BUSCAR.Item("ID_DEPOSITO", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value
            FRM_DEPOSITOS.TB_DEPO_NOMBRE.Text = DGV_DEPO_BUSCAR.Item("DEPO_NOMBRE", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value
            FRM_DEPOSITOS.TB_DEPO_DIRECCION.Text = DGV_DEPO_BUSCAR.Item("DEPO_DIRECCION", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value
            FRM_DEPOSITOS.TB_DEPO_LOCALIDAD.Text = DGV_DEPO_BUSCAR.Item("DEPO_LOCALIDAD", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value
            FRM_DEPOSITOS.TB_DEPO_CODIGO.Text = DGV_DEPO_BUSCAR.Item("DEPO_CODIGO", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value
        End If
        FRM_DEPOSITOS.BTN_DEPO_GUARDAR.Visible = False
        FRM_DEPOSITOS.BTN_DEPO_ACTUALIZAR.Visible = True
        FRM_DEPOSITOS.Show()
    End Sub

    Private Sub BTN_PROV_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_DEPO_BUS_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.DEPOSITOS Where C.ID_DEPOSITO = CInt(DGV_DEPO_BUSCAR.Item("ID_DEPOSITO", DGV_DEPO_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará el Depósito seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar proveedor")
            Case MsgBoxResult.Yes
                datacontext.DEPOSITOS.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("El Depósito ha sido eliminado")
                Me.CargarGrillaDeposito()
        End Select
    End Sub

    Private Sub BTN_PROV_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_DEPO_BUS_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FRM_DEPOSITOS_BUSCAR_B_M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' PrepararFormulario()
        CargarGrillaDeposito()
        ArmarGrillaDeposito()
    End Sub

    'Private Sub PrepararFormulario()
    '    Select Case Tipo
    '        Case TipoFormulario.ModificarDeposito
    '            BTN_DEPO_BUS_EDITAR.Visible = True
    '            BTN_DEPO_BUS_ELIMINAR.Visible = True
    '            BTN_DEPO_BUS_SALIR.Visible = True

    '        Case TipoFormulario.EliminarDeposito

    '            BTN_DEPO_BUS_EDITAR.Visible = True
    '            BTN_DEPO_BUS_ELIMINAR.Visible = True
    '            BTN_DEPO_BUS_SALIR.Visible = True
    '    End Select
    'End Sub

    Private Sub ArmarGrillaDeposito()
        DGV_DEPO_BUSCAR.Enabled = True
        DGV_DEPO_BUSCAR.AutoGenerateColumns = False
        DGV_DEPO_BUSCAR.Columns.Clear()

        DGV_DEPO_BUSCAR.Columns.Add("ID_DEPOSITO", "ID_DEPOSITO")
        DGV_DEPO_BUSCAR.Columns(0).Visible = False
        DGV_DEPO_BUSCAR.Columns.Add("DEPO_NOMBRE", "NOMBRE")
        DGV_DEPO_BUSCAR.Columns(1).Width = 150
        DGV_DEPO_BUSCAR.Columns.Add("DEPO_DIRECCION", "DIRECCIÓN")
        DGV_DEPO_BUSCAR.Columns(2).Width = 150
        DGV_DEPO_BUSCAR.Columns.Add("DEPO_LOCALIDAD", "LOCALIDAD")
        DGV_DEPO_BUSCAR.Columns.Add("DEPO_CODIGO", "CÓDIGO")

        DGV_DEPO_BUSCAR.Columns(0).DataPropertyName = "ID_DEPOSITO"
        DGV_DEPO_BUSCAR.Columns(1).DataPropertyName = "DEPO_NOMBRE"
        DGV_DEPO_BUSCAR.Columns(2).DataPropertyName = "DEPO_DIRECCION"
        DGV_DEPO_BUSCAR.Columns(3).DataPropertyName = "DEPO_LOCALIDAD"
        DGV_DEPO_BUSCAR.Columns(4).DataPropertyName = "DEPO_CODIGO"

        DGV_DEPO_BUSCAR.ClearSelection()
    End Sub

    Public Sub CargarGrillaDeposito()
        Dim ConsultaDeposito = From U In datacontext.DEPOSITOS Select U.ID_DEPOSITO, U.DEPO_NOMBRE, U.DEPO_DIRECCION, U.DEPO_LOCALIDAD, U.DEPO_CODIGO
        DGV_DEPO_BUSCAR.DataSource = ConsultaDeposito
    End Sub
End Class