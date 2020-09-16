Public Class FRM_SERVICIOS
    Dim datacontext As New DC_AdminDataContext
    Private Sub BTN_SERV_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SERV_GUARDAR.Click
       
        Try
            If TB_SERV_DIRECCION.Text.Length = 0 Or TB_SERV_LOCALIDAD.Text.Length = 0 Or TB_SERV_TEL_1.Text.Length = 0 Or TB_SERV_DESCRIPCION.Text.Length = 0 Or CB_SERV_DNI_CLIENTE.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim SERVICIO = New SERVICIOS

                SERVICIO.SERV_DIRECCION = TB_SERV_DIRECCION.Text
                SERVICIO.SERV_LOCALIDAD = TB_SERV_LOCALIDAD.Text
                SERVICIO.SERV_TEL_1 = TB_SERV_TEL_1.Text
                SERVICIO.SERV_TEL_2 = TB_SERV_TEL_2.Text
                SERVICIO.SERV_TEL_3 = TB_SERV_TEL_3.Text
                SERVICIO.SERV_DESCRIPCION = TB_SERV_DESCRIPCION.Text
                SERVICIO.ID_CLIENTE = CB_SERV_DNI_CLIENTE.SelectedIndex

                I = SERVICIO.ID_SERVICIO


                datacontext.SERVICIOS.InsertOnSubmit(SERVICIO)
                datacontext.SubmitChanges()
                MsgBox("El servicio se ha creado correctamente", vbInformation)

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_SERV_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SERV_SALIR.Click
        Me.Close()
    End Sub

    Private Sub FRM_SERVICIOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class