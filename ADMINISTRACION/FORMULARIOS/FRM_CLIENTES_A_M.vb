Public Class FRM_CLIENTES_A_M
    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_CLIENTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TB_CLIE_DNI.Focus()
        GB_CLIE_ABONADO.Enabled = False

    End Sub

    'GUARDAR
    Private Sub BTN_CLIE_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLIE_GUARDAR.Click
        Dim BUSCARCLIENTE = (From CLIE In datacontext.CLIENTES Select CLIE.CLI_DNI Where CLI_DNI = TB_CLIE_DNI.Text).Any
        Dim BUSCARCONTRATO = (From CONT In datacontext.CLIENTES Select CONT.CLI_CONTRATO Where CLI_CONTRATO = TB_CLIE_CONTRATO.Text).Any
        If BUSCARCLIENTE = True Then
            MsgBox("El DNI ingresado ya pertence a un cliente")
            Exit Sub
        End If

        If TB_CLIE_DNI.Text.Length = 0 Or TB_CLIE_APELLIDO.Text.Length = 0 Or TB_CLIE_NOMBRES.Text.Length = 0 Or TB_CLIE_DIRECCION.Text.Length = 0 Or TB_CLIE_TEL_1.Text.Length = 0 Or TB_CLIE_LOCALIDAD.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        If CHB_CLIE_ABONADO.Checked = True Then
            If BUSCARCONTRATO = True Then
                MsgBox("El CONTRATO ingresado ya pertence a un cliente")
                Exit Sub
            Else
                If TB_CLIE_CONTRATO.Text.Length = 0 Or CB_CLIE_TIPO.Text.Length = 0 Then
                    MsgBox("Debe completar todos los campos requeridos1")
                    Exit Sub
                End If
            End If
        End If
        Try
            Dim CLIENTE = New CLIENTES

            CLIENTE.CLI_APELLIDO = TB_CLIE_APELLIDO.Text
            CLIENTE.CLI_NOMBRES = TB_CLIE_NOMBRES.Text
            CLIENTE.CLI_DIRECCION = TB_CLIE_DIRECCION.Text
            CLIENTE.CLI_DNI = CInt(TB_CLIE_DNI.Text)
            CLIENTE.CLI_LOCALIDAD = TB_CLIE_LOCALIDAD.Text
            CLIENTE.CLI_TEL_1 = TB_CLIE_TEL_1.Text
            CLIENTE.CLI_TEL_2 = TB_CLIE_TEL_2.Text
            CLIENTE.CLI_MAIL = TB_CLIE_MAIL.Text

            If CHB_CLIE_ABONADO.Checked = True Then
                CLIENTE.CLI_CONTRATO = TB_CLIE_CONTRATO.Text
                CLIENTE.CLI_FECHA_ALTA = DTP_CLIE_FECHA_ALTA.Text
                CLIENTE.CLI_TIPO = CB_CLIE_TIPO.Text
            End If
            TB_CLIE_ID.Text = CLIENTE.ID_CLIENTE

            datacontext.CLIENTES.InsertOnSubmit(CLIENTE)
            datacontext.SubmitChanges()

            Select Case MsgBox("El Cliente fue creado, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo cliente")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    limpiar_campos()
            End Select

        Catch ex As Exception
            MsgBox("El cliente no fue cargado, pongase en contacto con el administrador")
            Exit Sub
        End Try

    End Sub

    Private Sub BTN_CLIE_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLIE_CANCELAR.Click
        Me.Close()
    End Sub

    Private Sub BTN_CLIE_LIMPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLIE_LIMPIAR.Click
        limpiar_campos()
    End Sub

    Private Sub BTN_CLIE_ACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLIE_ACTUALIZAR.Click
        If TB_CLIE_DNI.Text.Length = 0 Or TB_CLIE_APELLIDO.Text.Length = 0 Or TB_CLIE_NOMBRES.Text.Length = 0 Or TB_CLIE_DIRECCION.Text.Length = 0 Or TB_CLIE_TEL_1.Text.Length = 0 Or TB_CLIE_LOCALIDAD.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim Actualizarcliente = (From P In datacontext.CLIENTES Where P.ID_CLIENTE = (TB_CLIE_ID.Text)).ToList()(0)

            Actualizarcliente.CLI_NOMBRES = TB_CLIE_NOMBRES.Text
            Actualizarcliente.CLI_APELLIDO = TB_CLIE_APELLIDO.Text
            Actualizarcliente.CLI_DIRECCION = TB_CLIE_DIRECCION.Text
            Actualizarcliente.CLI_DNI = TB_CLIE_DNI.Text
            Actualizarcliente.CLI_LOCALIDAD = TB_CLIE_LOCALIDAD.Text
            Actualizarcliente.CLI_TEL_1 = TB_CLIE_TEL_1.Text
            Actualizarcliente.CLI_TEL_2 = TB_CLIE_TEL_2.Text
            Actualizarcliente.CLI_MAIL = TB_CLIE_MAIL.Text
            Actualizarcliente.CLI_TIPO = CB_CLIE_TIPO.Text
            Actualizarcliente.CLI_FECHA_ALTA = DTP_CLIE_FECHA_ALTA.Text
            Actualizarcliente.CLI_CONTRATO = TB_CLIE_CONTRATO.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            FRM_CLIENTES_BUSCAR_B_M.cargargrilla()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
        End Try
    End Sub
    Private Sub limpiar_campos()
        TB_CLIE_DNI.Clear()
        TB_CLIE_NOMBRES.Clear()
        TB_CLIE_APELLIDO.Clear()
        TB_CLIE_DIRECCION.Clear()
        TB_CLIE_LOCALIDAD.Clear()
        TB_CLIE_TEL_1.Clear()
        TB_CLIE_TEL_2.Clear()
        TB_CLIE_MAIL.Clear()
        TB_CLIE_CONTRATO.Clear()
        DTP_CLIE_FECHA_ALTA.Value = Date.Now
        CB_CLIE_TIPO.SelectedIndex = -1
        CHB_CLIE_ABONADO.Checked = False
    End Sub

    Private Sub CB_CLIE_ABONADO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_CLIE_ABONADO.CheckedChanged
        If CHB_CLIE_ABONADO.Checked = True Then
            GB_CLIE_ABONADO.Enabled = True
        Else
            GB_CLIE_ABONADO.Enabled = False
            TB_CLIE_CONTRATO.Clear()
            DTP_CLIE_FECHA_ALTA.Value = Date.Now
            CB_CLIE_TIPO.SelectedIndex = -1

        End If
    End Sub
End Class
