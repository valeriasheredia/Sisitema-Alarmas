Public Class FRM_VENTAS

    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_VENTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'LOGICA DE BOTONES
        BTN_VENTA_PRESUPUESTO.Visible = False
        BTN_VENTA_IMPRIMIR.Enabled = False
        TB_CLIENTE_APELLIDO.Enabled = False
        TB_CLIENTE_NOMBRE.Enabled = False
        TB_CLIENTE_DNI.Enabled = False
        TB_CLIENTE_DIRECCION.Enabled = False
        TB_CLIENTE_TELEFONO.Enabled = False

        TB_VENTA_DESCUENTO.Clear()
        TB_VENTA_TOTAL.Clear()
        TB_SUBTOTAL_VENTA.Clear()

        armargrilla()

        'CARGA COMBO DEPOSITO
        Dim COMBOFORMAPAGO = (From FDP In datacontext.FORMAS_DE_PAGO Select FDP.ID_FORM_DE_PAGO, FDP.FDP_DESCRIPCION)
        CB_VENTA_FORMAPAGO.DataSource = COMBOFORMAPAGO
        CB_VENTA_FORMAPAGO.DisplayMember = "FDP_DESCRIPCION"
        CB_VENTA_FORMAPAGO.ValueMember = "ID_FORM_DE_PAGO"
    End Sub

    'ARMA DATAGRIDVIEW
    Private Sub armargrilla()
        DGV_VENTAS_BUSCAR.Enabled = True
        DGV_VENTAS_BUSCAR.AutoGenerateColumns = False
        DGV_VENTAS_BUSCAR.Columns.Clear()

        DGV_VENTAS_BUSCAR.Columns.Add("ID_PRODUCTO", "ID_PRODUCTO")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_CANTIDAD", "CANTIDAD")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_DESCRIPCION", "DESCRIPCION")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_PRECIO_COSTO", "PRECIO UNITARIO")
        DGV_VENTAS_BUSCAR.Columns.Add("PRECIO TOTAL", "PRECIO TOTAL")

        DGV_VENTAS_BUSCAR.Columns(0).DataPropertyName = "ID_PRODUCTO"
        DGV_VENTAS_BUSCAR.Columns(0).Visible = False
        DGV_VENTAS_BUSCAR.Columns(1).DataPropertyName = "PROD_CANTIDAD"
        DGV_VENTAS_BUSCAR.Columns(2).DataPropertyName = "PROD_DESCRIPCION"
        DGV_VENTAS_BUSCAR.Columns(2).Width = 200
        DGV_VENTAS_BUSCAR.Columns(3).DataPropertyName = "PROD_PRECIO_COSTO"
        DGV_VENTAS_BUSCAR.Columns(3).Width = 150
        DGV_VENTAS_BUSCAR.Columns(4).Width = 150

        DGV_VENTAS_BUSCAR.ClearSelection()
    End Sub

    'QUITA EL PRODUCTO SELECCIONADO DEL DATAGRIDVIEW 
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_QUITAR_PROD.Click

        If DGV_VENTAS_BUSCAR.Rows.Count = 0 Then
            MsgBox("No existen productos por quitar")
        Else
            DGV_VENTAS_BUSCAR.Rows.RemoveAt(DGV_VENTAS_BUSCAR.CurrentRow.Index)
            FRM_PRODUCTOS.Subtotal()                              'ACTUALIZA SUB TOTAL DEL DATAGRIDVIEW AL QUITAR UN PRODUCTO DE LA VENTA
            FRM_PRODUCTOS.CantidadProductos()                     'ACTUALIZA LA CANTIDAD DE PRODUCTOS AL QUITAR UN PRODUCTO DE LA VENTA
            Exit Sub
        End If
    End Sub

    'ABRE EL FORM DE CLIENTES
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_CARGAR_CLIENTE.Click
        FRM_CLIENTES_BUSCAR_B_M.Text = "SELECCIONAR CLIENTE"
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    'CALCULO DEL TOTAL DE LA VENTA
    Private Sub TB_VENTA_DESCUENTO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_VENTA_DESCUENTO.TextChanged
        If TB_VENTA_DESCUENTO.Text = "" Then
            TB_VENTA_TOTAL.Text = TB_SUBTOTAL_VENTA.Text
        Else
            Dim vsubtotal As Double = TB_SUBTOTAL_VENTA.Text
            Dim vdescuento As Double = TB_VENTA_DESCUENTO.Text
            Dim vporcentaje As Double
            Dim vtotal As Double
            vporcentaje = vsubtotal * vdescuento / 100
            vtotal = vsubtotal - vporcentaje
            TB_VENTA_TOTAL.Text = vtotal
        End If
    End Sub

    Private Sub BTN_VENTA_GUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_GUARDAR.Click

        'VALIDA LA CARGA DE CLIENTE
        If TB_CLIENTE_APELLIDO.Text.Length = 0 Or TB_CLIENTE_NOMBRE.Text.Length = 0 Or TB_CLIENTE_DNI.Text.Length = 0 Or TB_CLIENTE_DIRECCION.Text.Length = 0 Or TB_CLIENTE_TELEFONO.Text.Length = 0 Then
            MsgBox("Debe seleccionar un cliente")
            BTN_VENT_CARGAR_CLIENTE.Focus()
            Exit Sub
        End If

        'VALIDA CARGA DE PRODUCTOS PARA LA VENTA
        If DGV_VENTAS_BUSCAR.Rows.Count = 0 Then
            MsgBox("Debe ingresar productos a la venta")
            BTN_VENT_AGREGAR_PROD.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL TEXTBOX DE DESCUENTO NO ESTE VACIO PARA PODER CALCULAR EL MONTO FINAL DE LA VENTA
        If TB_VENTA_DESCUENTO.Text = "" Then
            MsgBox("Debe ingresar el descuento aplicado a la venta")
            TB_VENTA_DESCUENTO.Focus()
            Exit Sub
        End If
        Try
            Dim VEN = New VENTAS

            'GUARDA EN LA TABLA VENTAS
            VEN.ID_CLIENTE = TB_CLIENTE_ID.Text
            VEN.VENT_FECHA = DTP_FECHA_VENTA.Text
            VEN.VENT_SUBTOTAL = TB_SUBTOTAL_VENTA.Text
            VEN.VENT_TOTAL = TB_VENTA_TOTAL.Text
            VEN.VENT_CANTIDAD = LBL_VENTA_CANT_PROD.Text
            VEN.ID_FORM_DE_PAGO = CB_VENTA_FORMAPAGO.SelectedValue

            datacontext.VENTAS.InsertOnSubmit(VEN)
            datacontext.SubmitChanges()

            'GUARDA EN LA TABLA PROD_X_VTA
            For Each rows As DataGridViewRow In Me.DGV_VENTAS_BUSCAR.Rows
                Dim P_X_V = New PROD_X_VTA

                P_X_V.ID_PRODUCTO = rows.Cells(0).Value
                P_X_V.PXV_CANTIDAD = rows.Cells(1).Value
                P_X_V.PXV_PRECIO_X_PRODUCTO = rows.Cells(3).Value
                TB_VENTA_ID.Text = VEN.ID_VENTA
                P_X_V.ID_VENTA = TB_VENTA_ID.Text
                TB_PROD_X_VTA_ID.Text = P_X_V.ID_PROD_X_VTA
                datacontext.PROD_X_VTA.InsertOnSubmit(P_X_V)
                datacontext.SubmitChanges()
            Next

            MsgBox("La venta fue realizada correctamente", vbInformation)
            FRM_PRODUCTOS.DisminuirStock()
            BTN_VENTA_IMPRIMIR.Enabled = True
            BTN_VENTA_GUARDAR.Enabled = False

        Catch ex As Exception
            MsgBox("La venta no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try
    End Sub

    'LOGICA DE BOTONES
    Private Sub BTN_VENT_AGREGAR_PROD_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_AGREGAR_PROD.Click
        FRM_PRODUCTOS_BUSCAR_B_M.Text = "BUSCAR PRODUCTO"
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = True
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_EDITAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ELIMINAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ACTUALIZAR_STOCK.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_VER.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.DGV_PROD_BUSCAR.ClearSelection()
        FRM_PRODUCTOS_BUSCAR_B_M.ShowDialog()
    End Sub

    'BOTON IMPRIMIR
    Private Sub BTN_VENTA_IMPRIMIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_IMPRIMIR.Click
        Dim objForm As New Reporte_Venta
        Dim e1 As Integer = TB_VENTA_ID.Text
        FRM_REPORTE_VENTA.id_venta = e1
        FRM_REPORTE_VENTA.Show()
    End Sub

    'BOTON SALIR
    Private Sub BTN_VENTA_SALIR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class