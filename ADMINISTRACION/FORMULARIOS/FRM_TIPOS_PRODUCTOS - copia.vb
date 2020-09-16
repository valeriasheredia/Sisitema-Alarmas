Public Class FRM_TIPOS_PRODUCTOS
    Dim datacontext As New DC_AdminDataContext
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROD_TIPO_GUARDAR.Click
        Dim BUSCARCODIGO = (From PRODTIPO In datacontext.PRODUCTOS_TIPOS Select PRODTIPO.PROD_TIPO_CODIGO Where PROD_TIPO_CODIGO = TB_PROD_TIPO_CODIGO.Text).Any
        If BUSCARCODIGO = True Then
            MsgBox("El DNI ingresado ya pertence a un cliente")
            Exit Sub
        End If
        Try
            If TB_PROD_TIPO_CODIGO.Text.Length = 0 Or TB_PROD_TIPO_DESCRIPCION.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim TIPOSDEPROD = New PRODUCTOS_TIPOS

                TIPOSDEPROD.PROD_TIPO_DESC = TB_PROD_TIPO_DESCRIPCION.Text
                TIPOSDEPROD.PROD_TIPO_CODIGO = TB_PROD_TIPO_CODIGO.Text

                I = TIPOSDEPROD.ID_PROD_TIPO


                datacontext.PRODUCTOS_TIPOS.InsertOnSubmit(TIPOSDEPROD)
                datacontext.SubmitChanges()
                MsgBox("El tipo de producto se ha creado correctamente", vbInformation)

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_PROD_TIPO_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROD_TIPO_SALIR.Click
        Me.Close()
    End Sub

    Private Sub FRM_TIPOS_PRODUCTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class