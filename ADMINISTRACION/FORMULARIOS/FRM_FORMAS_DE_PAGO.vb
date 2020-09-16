Public Class FRM_FORMAS_DE_PAGO
    Dim datacontext As New DC_AdminDataContext
    Shared Property Tipo As TipoFormulario

    Private Sub FRM_FORMAS_DE_PAGO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "CARGAR FORMA DE PAGO" Then
            BTN_FDP_ACTUALIZAR.Visible = False
        ElseIf Me.Text = "ACTUALIZAR FORMA DE PAGO" Then
            BTN_FDP_ACTUALIZAR.Visible = True
        End If
    End Sub

    'Private Sub PrepararFormulario()
    '    Select Case Tipo
    '        Case TipoFormulario.AltaFormaPago
    '            TB_FDP_ID.Visible = False
    '            Label2.Visible = False
    '            BTN_FDP_GUARDAR.Visible = True
    '            BTN_FDP_ACTUALIZAR.Visible = False
    '            BTN_FDP_SALIR.Visible = True
    '            TB_FDP_DESCRIPCION.Focus()

    '        Case TipoFormulario.ModificarFormaPago
    '            TB_FDP_ID.Visible = False
    '            Label2.Visible = False
    '            BTN_FDP_GUARDAR.Visible = False
    '            BTN_FDP_ACTUALIZAR.Visible = True
    '            BTN_FDP_SALIR.Visible = True
    '    End Select
    'End Sub

    Private Sub BTN_FDP_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FDP_ACTUALIZAR.Click
        If TB_FDP_DESCRIPCION.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarFormaPago = (From P In datacontext.FORMAS_DE_PAGO Where P.ID_FORM_DE_PAGO = (TB_FDP_ID.Text)).ToList()(0)
            ActualizarFormaPago.ID_FORM_DE_PAGO = TB_FDP_ID.Text
            ActualizarFormaPago.FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text
           
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
            FRM_FORMAS_DE_PAGO_BUSCAR_B_M.CargarGrillaFormaPago()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
        End Try
    End Sub

    Private Sub BTN_FDP_GUARDAR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_FDP_GUARDAR.Click
        Dim BUSCARFORMAPAGO = (From FDP In datacontext.FORMAS_DE_PAGO Select FDP.FDP_DESCRIPCION Where FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text).Any
        If TB_FDP_DESCRIPCION.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim i As Integer
            Dim FORMA_PAGO = New FORMAS_DE_PAGO
            FORMA_PAGO.FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text
            i = FORMA_PAGO.ID_FORM_DE_PAGO
            datacontext.FORMAS_DE_PAGO.InsertOnSubmit(FORMA_PAGO)
            datacontext.SubmitChanges()
            MsgBox("La forma de Pago fue cargada correctamente")
            TB_FDP_DESCRIPCION.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox("La forma de pago no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_FDP_SALIR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_FDP_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class