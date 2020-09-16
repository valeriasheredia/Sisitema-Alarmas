Public Class FRM_FORMAS_DE_PAGO_BUSCAR_B_M

    Dim datacontext As New DC_AdminDataContext
    Shared Property Tipo As TipoFormulario

    Private Sub BTN_CLIE_BUS_EDITAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FORMA_PAGO_EDITAR.Click
        If DGV_FORMA_DE_PAGO_BUSCAR.SelectedRows.Count > 0 Then
            FRM_FORMAS_DE_PAGO.TB_FDP_ID.Text = DGV_FORMA_DE_PAGO_BUSCAR.Item("ID_FORM_DE_PAGO", DGV_FORMA_DE_PAGO_BUSCAR.SelectedRows(0).Index).Value
            FRM_FORMAS_DE_PAGO.TB_FDP_DESCRIPCION.Text = DGV_FORMA_DE_PAGO_BUSCAR.Item("FDP_DESCRIPCION", DGV_FORMA_DE_PAGO_BUSCAR.SelectedRows(0).Index).Value
        End If

        ' FRM_FORMAS_DE_PAGO.Tipo = TipoFormulario.ModificarFormaPago
        FRM_FORMAS_DE_PAGO.Text = "ACTUALIZAR FORMA DE PAGO"
        FRM_FORMAS_DE_PAGO.BTN_FDP_GUARDAR.Visible = False
        FRM_FORMAS_DE_PAGO.BTN_FDP_ACTUALIZAR.Visible = True
        FRM_FORMAS_DE_PAGO.Show()

    End Sub

    Private Sub BTN_CLIE_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FORMA_PAGO_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.FORMAS_DE_PAGO Where C.ID_FORM_DE_PAGO = CInt(DGV_FORMA_DE_PAGO_BUSCAR.Item("ID_FORM_DE_PAGO", DGV_FORMA_DE_PAGO_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará la forma de pago seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar forma de pago")
            Case MsgBoxResult.Yes
                datacontext.FORMAS_DE_PAGO.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("La forma de pago ha sido eliminada")
                Me.CargarGrillaFormaPago()
        End Select
    End Sub

    Public Sub CargarGrillaFormaPago()
        Dim ConsultaFormaPago = From U In datacontext.FORMAS_DE_PAGO Select U.ID_FORM_DE_PAGO, U.FDP_DESCRIPCION
        DGV_FORMA_DE_PAGO_BUSCAR.DataSource = ConsultaFormaPago
    End Sub

    Private Sub ArmarGrillaFormaPago()
        DGV_FORMA_DE_PAGO_BUSCAR.Enabled = True
        DGV_FORMA_DE_PAGO_BUSCAR.AutoGenerateColumns = False
        DGV_FORMA_DE_PAGO_BUSCAR.Columns.Clear()

        DGV_FORMA_DE_PAGO_BUSCAR.Columns.Add("ID_FORM_DE_PAGO", "ID_FORM_DE_PAGO")
        DGV_FORMA_DE_PAGO_BUSCAR.Columns(0).Visible = False
        DGV_FORMA_DE_PAGO_BUSCAR.Columns.Add("FDP_DESCRIPCION", "DESCRIPCION")
        DGV_FORMA_DE_PAGO_BUSCAR.Columns(1).Width = 150
        DGV_FORMA_DE_PAGO_BUSCAR.Columns(0).DataPropertyName = "ID_FORM_DE_PAGO"
        DGV_FORMA_DE_PAGO_BUSCAR.Columns(1).DataPropertyName = "FDP_DESCRIPCION"

        DGV_FORMA_DE_PAGO_BUSCAR.ClearSelection()
    End Sub

    Private Sub FRM_FORMAS_DE_PAGO_BUSCAR_B_M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarGrillaFormaPago()
        ArmarGrillaFormaPago()
    End Sub

    Private Sub PrepararFormulario()
        Select Case Tipo
            Case TipoFormulario.ModificarDeposito
                BTN_FORMA_PAGO_EDITAR.Visible = True
                BTN_FORMA_PAGO_ELIMINAR.Visible = True
                BTN_FORMA_PAGO_SALIR.Visible = True
                TB_FORMA_PAGO_BUSCAR_DESC.Focus()
            Case TipoFormulario.EliminarDeposito

                BTN_FORMA_PAGO_EDITAR.Visible = True
                BTN_FORMA_PAGO_ELIMINAR.Visible = True
                BTN_FORMA_PAGO_SALIR.Visible = True
                TB_FORMA_PAGO_BUSCAR_DESC.Focus()
        End Select
    End Sub

    Private Sub TB_CLIE_BUSCAR_DESCRIPCION_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_FORMA_PAGO_BUSCAR_DESC.TextChanged
        Dim buscar As String
        ArmarGrillaFormaPago()
        buscar = "*" & Me.TB_FORMA_PAGO_BUSCAR_DESC.Text & "*"
        Dim consulta_codigo = From U In datacontext.FORMAS_DE_PAGO Select U.ID_FORM_DE_PAGO, U.FDP_DESCRIPCION Where FDP_DESCRIPCION Like buscar.ToString
        DGV_FORMA_DE_PAGO_BUSCAR.DataSource = consulta_codigo
    End Sub

    Private Sub BTN_CLIE_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FORMA_PAGO_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
