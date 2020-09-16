Public Class FRM_TIPOS_PRODUCTOS
    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_TIPOS_PRODUCTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "CARGAR TIPO DE PRODUCTO" Then
            BTN_PROD_TIPO_ACTUALIZAR.Visible = False
            TB_PROD_TIPO_CODIGO.Focus()
        ElseIf Me.Text = "ACTUALIZAR TIPO DE PRODUCTO" Then
            BTN_PROD_TIPO_ACTUALIZAR.Visible = True
        End If


    End Sub

    Private Sub BTN_PROD_TIPO_GUARDAR_Click(sender As System.Object, e As System.EventArgs)
        Dim BUSCARCODIGO = (From PRODTIPO In datacontext.PRODUCTOS_TIPOS Select PRODTIPO.PROD_TIPO_CODIGO Where PROD_TIPO_CODIGO = TB_PROD_TIPO_CODIGO.Text).Any
        If BUSCARCODIGO = True Then
            MsgBox("El Código del producto ya fue ingresado")
            Exit Sub
        End If
        Try
            If TB_PROD_TIPO_CODIGO.Text.Length = 0 Or TB_PROD_TIPO_DESCRIPCION.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim TIPOSDEPROD = New PRODUCTOS_TIPOS

                TIPOSDEPROD.PROD_TIPO_CODIGO = TB_PROD_TIPO_CODIGO.Text
                TIPOSDEPROD.PROD_TIPO_DESC = TB_PROD_TIPO_DESCRIPCION.Text
                I = TIPOSDEPROD.ID_PROD_TIPO

                datacontext.PRODUCTOS_TIPOS.InsertOnSubmit(TIPOSDEPROD)
                datacontext.SubmitChanges()
                MsgBox("El tipo de producto se ha creado correctamente", vbInformation)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_PROD_TIPO_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs)

        If TB_PROD_TIPO_CODIGO.Text.Length = 0 Or TB_PROD_TIPO_DESCRIPCION.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarTipoProducto = (From P In datacontext.PRODUCTOS_TIPOS Where P.ID_PROD_TIPO = (TB_PROD_TIPO_ID.Text)).ToList()(0)

            ActualizarTipoProducto.ID_PROD_TIPO = TB_PROD_TIPO_ID.Text
            ActualizarTipoProducto.PROD_TIPO_CODIGO = TB_PROD_TIPO_CODIGO.Text
            ActualizarTipoProducto.PROD_TIPO_DESC = TB_PROD_TIPO_DESCRIPCION.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
            FRM_TIPOS_PRODUCTOS_BUSCAR_B_M.cargargrilla()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
        End Try
    End Sub

    Private Sub BTN_PROD_TIPO_SALIR_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
End Class