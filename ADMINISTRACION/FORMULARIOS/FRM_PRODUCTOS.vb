Public Class FRM_PRODUCTOS

    Dim datacontext As New DC_AdminDataContext


    Private Sub FRM_PRODUCTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'LOGICA DE BOTONES
        TB_PROD_CODIGO.Focus()
        If Me.Text = "CARGAR PRODUCTO" Then
            BTN_PROD_ACTUALIZAR.Visible = False
            BTN_PROD_CONFIRMAR_PRODUCTO.Visible = False
            Label11.Visible = False
            TB_PROD_CANTIDAD.Visible = False
        ElseIf Me.Text = "ACTUALIZAR PRODUCTO" Then
            BTN_PROD_ACTUALIZAR.Visible = True
            BTN_PROD_CONFIRMAR_PRODUCTO.Visible = False
        ElseIf Me.Text = "CONFIRMAR PRODUCTO" Then
            BTN_PROD_ACTUALIZAR.Visible = False
            BTN_PROD_CONFIRMAR_PRODUCTO.Visible = True
            BTN_PROD_GUARDAR.Visible = False
        End If

        'CARGA COMBO DEPOSITO
        Dim COMBODEPOSITO = (From DEP In datacontext.DEPOSITOS Select DEP.ID_DEPOSITO, DEP.DEPO_NOMBRE)
        CB_PROD_DEPOSITO.DataSource = COMBODEPOSITO
        CB_PROD_DEPOSITO.DisplayMember = "DEPO_NOMBRE"
        CB_PROD_DEPOSITO.ValueMember = "ID_DEPOSITO"
        CB_PROD_DEPOSITO.SelectedIndex = 0


        'CARGA COMBO PROVEEDOR
        Dim COMBOPROVEEDOR = (From PROV In datacontext.PROVEEDORES Select PROV.ID_PROVEEDOR, PROV.PROV_NOMBRE)
        CB_PROD_PROVEEDOR.DataSource = COMBOPROVEEDOR
        CB_PROD_PROVEEDOR.DisplayMember = "PROV_NOMBRE"
        CB_PROD_PROVEEDOR.ValueMember = "ID_PROVEEDOR"
        CB_PROD_PROVEEDOR.SelectedIndex = 0
        'CARGA COMBO TIPO_PRODUCTO
        Dim COMBOTIPO_PRODUCTO = (From TIPO_PROD In datacontext.PRODUCTOS_TIPOS Select TIPO_PROD.ID_PROD_TIPO, TIPO_PROD.PROD_TIPO_DESC)
        CB_PROD_TIPO_PROD.DataSource = COMBOTIPO_PRODUCTO
        CB_PROD_TIPO_PROD.DisplayMember = "PROD_TIPO_DESC"
        CB_PROD_TIPO_PROD.ValueMember = "ID_PROD_TIPO"
        CB_PROD_TIPO_PROD.SelectedIndex = 0
    End Sub

    Private Sub BTN_PROD_CONFIRMAR_PRODUCTO_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_CONFIRMAR_PRODUCTO.Click

        'VALIDA QUE LA CANTIDAD DE PRODUCTOS NO EXCEDA AL STOCK DISPONIBLE
        If Val(TB_PROD_CANTIDAD.Text) > Val(TB_PROD_STOCK.Text) Then
            MsgBox("La cantidad de productos que desea vender excede al stock disponble")
            TB_PROD_CANTIDAD.Clear()
            Exit Sub
        End If

        'VALIDA QUE SE INGRESE LA CANTIDAD DE UNIDADES DEL PRODUCTO A VENDER
        If TB_PROD_CANTIDAD.Text = "" Then
            MsgBox("Debe ingresar la cantidad de productos a vender")
            TB_PROD_CANTIDAD.Focus()
            Exit Sub
        End If

        'CARGA EL DGV DE VENTAS
        Dim id_producto, cantidad As Integer
        Dim descripcion_producto As String
        Dim precio_venta As Double

        id_producto = TB_PROD_ID.Text
        descripcion_producto = TB_PROD_DESCRIPCION.Text
        precio_venta = TB_PROD_PRECIO_VENTA.Text
        cantidad = TB_PROD_CANTIDAD.Text
        FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Add(id_producto, cantidad, descripcion_producto, precio_venta)

        PrecioCantidad()
        CantidadProductos()
        Subtotal()
        FRM_VENTAS.TB_VENTA_DESCUENTO.Clear()
        FRM_VENTAS.TB_VENTA_TOTAL.Clear()
        FRM_PRODUCTOS_BUSCAR_B_M.Close()
        Me.Hide()
        TB_PROD_CANTIDAD.Clear()
    End Sub

    'SUMA LA CANTIDAD DE PRODUCTOS DE LA VENTA
    Public Sub CantidadProductos()
        Dim Cantidad_venta As Integer = 0
        Dim iCantidad_Venta As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
        Dim c As Integer
        For c = 0 To iCantidad_Venta - 1
            Cantidad_venta = Cantidad_venta + Integer.Parse(FRM_VENTAS.DGV_VENTAS_BUSCAR(1, c).Value)
        Next
        FRM_VENTAS.LBL_VENTA_CANT_PROD.Text = Format(Cantidad_venta)
    End Sub

    'CALCULA PRECIO DE VENTA * LA CANTIDAD DE PRODUCTOS
    Private Sub PrecioCantidad()
        Dim total As Double = 0
        Dim ATotal As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
        Dim A As Integer
        For A = 0 To ATotal - 1
            total = FRM_VENTAS.DGV_VENTAS_BUSCAR(3, A).Value * Double.Parse(FRM_VENTAS.DGV_VENTAS_BUSCAR(1, A).Value)
            FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows(A).Cells(4).Value = Format(total)
        Next
        FRM_VENTAS.TB_SUBTOTAL_VENTA.Text = Format(total)
    End Sub

    ' CALCULA(SUBTOTAL)
    Public Sub Subtotal()
        Dim suma As Double = 0
        Dim ATot As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
        Dim Aa As Integer
        For Aa = 0 To ATot - 1
            suma = suma + FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows(Aa).Cells(4).Value
        Next
        If Not String.IsNullOrEmpty(FRM_VENTAS.TB_SUBTOTAL_VENTA.Text) Then
            FRM_VENTAS.TB_SUBTOTAL_VENTA.Text = Format(suma)
        End If
    End Sub

    'GUARDAR PRODUCTO
    Private Sub BTN_PROD_GUARDAR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_GUARDAR.Click

        Dim BUSCARPRODUCTO = (From PROD In datacontext.PRODUCTOS Select PROD.PROD_CODIGO Where PROD_CODIGO = TB_PROD_CODIGO.Text).Any
        If BUSCARPRODUCTO = True Then
            MsgBox("El código de producto ingresado ya existe")
            Exit Sub
        End If
        Try
            If TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim PRODUCTO = New PRODUCTOS

                PRODUCTO.PROD_CODIGO = TB_PROD_CODIGO.Text
                PRODUCTO.PROD_DESCRIPCION = TB_PROD_DESCRIPCION.Text
                PRODUCTO.PROD_PRECIO_COSTO = TB_PROD_PRECIO_COSTO.Text
                PRODUCTO.PROD_PRECIO_VTA = TB_PROD_PRECIO_VENTA.Text
                PRODUCTO.PROD_STOCK = TB_PROD_STOCK.Text
                PRODUCTO.ID_PROVEEDOR = CB_PROD_PROVEEDOR.SelectedValue
                PRODUCTO.ID_DEPOSITO = CB_PROD_DEPOSITO.SelectedValue
                PRODUCTO.ID_PROD_TIPO = CB_PROD_TIPO_PROD.SelectedValue

                I = PRODUCTO.ID_PRODUCTO

                datacontext.PRODUCTOS.InsertOnSubmit(PRODUCTO)
                datacontext.SubmitChanges()
                MsgBox("El producto se ha creado correctamente", vbInformation)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    'VALIDA EL INGRESO DE SOLO NUMEROS Y LA COMA (PARA PRECIO_COMPRA Y PRECIO_VENTA)
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not CajaTexto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TB_PROD_PRECIO_COSTO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TB_PROD_PRECIO_COSTO.KeyPress
        NumerosyDecimal(TB_PROD_PRECIO_COSTO, e)
    End Sub

    Private Sub TB_PROD_PRECIO_VENTA_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TB_PROD_PRECIO_VENTA.KeyPress
        NumerosyDecimal(TB_PROD_PRECIO_VENTA, e)
    End Sub

    'BOTON ACTUALIZAR
    Private Sub BTN_PROD_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_ACTUALIZAR.Click
        If TB_PROD_ID.Text.Length = 0 Or TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProducto = (From P In datacontext.PRODUCTOS Where P.ID_PRODUCTO = (TB_PROD_ID.Text)).ToList()(0)

            ActualizarProducto.ID_PRODUCTO = TB_PROD_ID.Text
            ActualizarProducto.PROD_CODIGO = TB_PROD_CODIGO.Text
            ActualizarProducto.PROD_DESCRIPCION = TB_PROD_DESCRIPCION.Text
            ActualizarProducto.PROD_PRECIO_COSTO = CDbl(TB_PROD_PRECIO_COSTO.Text)
            ActualizarProducto.PROD_PRECIO_VTA = CDbl(TB_PROD_PRECIO_VENTA.Text)
            ActualizarProducto.PROD_STOCK = TB_PROD_STOCK.Text
            ActualizarProducto.ID_PROVEEDOR = CB_PROD_PROVEEDOR.SelectedValue
            ActualizarProducto.ID_DEPOSITO = CB_PROD_DEPOSITO.SelectedValue
            ActualizarProducto.ID_PROD_TIPO = CB_PROD_TIPO_PROD.SelectedValue
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            FRM_PRODUCTOS_BUSCAR_B_M.CargarGrillaProducto()

            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
        End Try
    End Sub

    'INGRESO DE SOLO NUMEROS
    Private Sub TB_PROD_CANTIDAD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TB_PROD_CANTIDAD.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'DISMINUIR STOCK
    Public Sub DisminuirStock()
        Dim ActualizarProducto = (From P In datacontext.PRODUCTOS Where P.ID_PRODUCTO = (TB_PROD_ID.Text)).ToList()(0)
        Dim stock As Integer = CDbl(TB_PROD_STOCK.Text)
        Dim cantidad As Integer = CDbl(TB_PROD_CANTIDAD.Text)
        Dim NuevoStock As Integer
        NuevoStock = CDbl(TB_PROD_STOCK.Text) - CDbl(TB_PROD_CANTIDAD.Text)
        TB_PROD_STOCK.Text = NuevoStock
        ActualizarProducto.PROD_STOCK = NuevoStock
        datacontext.SubmitChanges()
        ' MsgBox("stock modificado")
    End Sub

    'AUMENTAR STOCK
    Public Sub AumentarStock()
        Dim ActualizarStock = (From P In datacontext.PRODUCTOS Where P.PROD_STOCK = (TB_PROD_STOCK.Text)).ToList()(0)
        Dim stock As Integer = CDbl(TB_PROD_STOCK.Text)
        Dim cantidad As Integer = CDbl(TB_PROD_AUMENTAR_STOCK.Text)
        Dim NuevoStock As Integer

        NuevoStock = CDbl(TB_PROD_STOCK.Text) + CDbl(TB_PROD_AUMENTAR_STOCK.Text)
        TB_PROD_STOCK.Text = NuevoStock
        TB_PROD_AUMENTAR_STOCK.Clear()
        ActualizarStock.PROD_STOCK = NuevoStock
        datacontext.SubmitChanges()
        MsgBox("El stock ha sido actualizado correctamente!!")
        Me.Close()
        FRM_PRODUCTOS_BUSCAR_B_M.CargarGrillaProducto()
        ' FRM_PRODUCTOS_BUSCAR_B_M.Close()
    End Sub

    'BOTON SALIR
    Private Sub BTN_PROD_SALIR_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'BOTON AGREGAR STOCK
    Private Sub BTN_PROD_AGREGAR_STOCK_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_AGREGAR_STOCK.Click
        AumentarStock()
    End Sub
End Class

