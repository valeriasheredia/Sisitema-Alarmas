Public Class FRM_PRODUCTOS_BUSCAR_B_M

    Dim datacontext As New DC_AdminDataContext

    'CARGA DEL FORM DE PRODUCTOS CON SUS DATOS
    Private Sub BTN_PROD_BUS_EDITAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_EDITAR.Click

        If DGV_PROD_BUSCAR.SelectedRows.Count > 0 Then
            FRM_PRODUCTOS.TB_PROD_ID.Text = DGV_PROD_BUSCAR.Item("ID_PRODUCTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_CODIGO.Text = DGV_PROD_BUSCAR.Item("PROD_CODIGO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Text = DGV_PROD_BUSCAR.Item("PROD_DESCRIPCION", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_COSTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_VTA", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_STOCK.Text = DGV_PROD_BUSCAR.Item("PROD_STOCK", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_PROVEEDOR.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROVEEDOR", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_DEPOSITO.SelectedValue = DGV_PROD_BUSCAR.Item("ID_DEPOSITO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_TIPO_PROD.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROD_TIPO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        End If

        'LOGICA DE BOTONES
        FRM_PRODUCTOS.Text = "ACTUALIZAR PRODUCTO"
        FRM_PRODUCTOS.BTN_PROD_GUARDAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_ACTUALIZAR.Visible = True
        FRM_PRODUCTOS.BTN_PROD_CONFIRMAR_PRODUCTO.Visible = False
        FRM_PRODUCTOS.Label11.Visible = False
        FRM_PRODUCTOS.TB_PROD_CANTIDAD.Visible = False
        FRM_PRODUCTOS.TB_PROD_STOCK.Enabled = False
        FRM_PRODUCTOS.TB_PROD_AUMENTAR_STOCK.Visible = False
        FRM_PRODUCTOS.BTN_PROD_AGREGAR_STOCK.Visible = False
        FRM_PRODUCTOS.Label12.Visible = False
        FRM_PRODUCTOS.Show()
    End Sub

    'CARGA DATAGRIDVIEW Y LOGICA DE BOTONES
    Private Sub FRM_PRODUCTOS_BUSCAR_B_M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CargarGrillaProducto()
        ArmarGrillaProducto()
        If Me.Text = "BUSCAR PRODUCTO" Then
            BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = True
        ElseIf Me.Text = "MODIFICAR Y ELIMINAR PRODUCTOS" Then
            BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = False
        End If
    End Sub

    'ARMA DATAGRIDVIEW
    Private Sub ArmarGrillaProducto()
        DGV_PROD_BUSCAR.Enabled = True
        DGV_PROD_BUSCAR.AutoGenerateColumns = False
        DGV_PROD_BUSCAR.Columns.Clear()

        DGV_PROD_BUSCAR.Columns.Add("ID_PRODUCTO", "ID_PRODUCTO")
        DGV_PROD_BUSCAR.Columns.Add("PROD_CODIGO", "CODIGO")
        DGV_PROD_BUSCAR.Columns.Add("PROD_DESCRIPCION", "DESCRIPCION")
        DGV_PROD_BUSCAR.Columns.Add("PROD_PRECIO_COSTO", "PRECIO DE COSTO")
        DGV_PROD_BUSCAR.Columns.Add("PROD_PRECIO_VTA", "PRECIO DE VENTA")
        DGV_PROD_BUSCAR.Columns.Add("PROD_STOCK", "STOCK")
        DGV_PROD_BUSCAR.Columns.Add("ID_PROVEEDOR", "ID_PROVEEDOR")
        DGV_PROD_BUSCAR.Columns.Add("ID_DEPOSITO", "ID_DEPOSITO")
        DGV_PROD_BUSCAR.Columns.Add("ID_PROD_TIPO", "ID_PROD_TIPO")

        DGV_PROD_BUSCAR.Columns(0).DataPropertyName = "ID_PRODUCTO"
        DGV_PROD_BUSCAR.Columns(0).Visible = False
        DGV_PROD_BUSCAR.Columns(1).DataPropertyName = "PROD_CODIGO"
        DGV_PROD_BUSCAR.Columns(2).DataPropertyName = "PROD_DESCRIPCION"
        DGV_PROD_BUSCAR.Columns(2).Width = 200
        DGV_PROD_BUSCAR.Columns(3).DataPropertyName = "PROD_PRECIO_COSTO"
        DGV_PROD_BUSCAR.Columns(4).DataPropertyName = "PROD_PRECIO_VTA"
        DGV_PROD_BUSCAR.Columns(5).DataPropertyName = "PROD_STOCK"
        DGV_PROD_BUSCAR.Columns(6).DataPropertyName = "ID_PROVEEDOR"
        DGV_PROD_BUSCAR.Columns(6).Visible = False
        DGV_PROD_BUSCAR.Columns(7).DataPropertyName = "ID_DEPOSITO"
        DGV_PROD_BUSCAR.Columns(7).Visible = False
        DGV_PROD_BUSCAR.Columns(8).DataPropertyName = "ID_PROD_TIPO"
        DGV_PROD_BUSCAR.Columns(8).Visible = False

        DGV_PROD_BUSCAR.ClearSelection()
    End Sub

    'CARGA DATAGRIDVIEW
    Public Sub CargarGrillaProducto()
        Dim consulta_producto = From U In datacontext.PRODUCTOS Select U.ID_PRODUCTO, U.PROD_CODIGO, U.PROD_DESCRIPCION, U.PROD_PRECIO_COSTO, U.PROD_PRECIO_VTA, U.PROD_STOCK, U.ID_PROVEEDOR, U.ID_DEPOSITO, U.ID_PROD_TIPO
        DGV_PROD_BUSCAR.DataSource = consulta_producto
    End Sub

    'BOTON SALIR
    Private Sub BTN_PROD_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'BUSCA POR NOMBRE DEL PRODUCTO
    Private Sub TB_PROD_BUSCAR_NOMBRE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_PROD_BUSCAR_NOMBRE.TextChanged
        Dim buscar As String
        If RB_PROD_BUSCAR_NOMBRE.Checked = True Then
            ArmarGrillaProducto()
            buscar = Me.TB_PROD_BUSCAR_NOMBRE.Text & "*"
            Dim consulta_nombre = From U In datacontext.PRODUCTOS Select U.ID_PRODUCTO, U.PROD_CODIGO, U.PROD_DESCRIPCION, U.PROD_PRECIO_COSTO, U.PROD_PRECIO_VTA, U.PROD_STOCK, U.ID_PROVEEDOR, U.ID_DEPOSITO, U.ID_PROD_TIPO Where PROD_DESCRIPCION Like buscar.ToString
            DGV_PROD_BUSCAR.DataSource = consulta_nombre
        End If
    End Sub

    'BUSCA POR CODIGO DEL PRODUCTO
    Private Sub TB_PROD_BUSCAR_CODIGO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_PROD_BUSCAR_CODIGO.TextChanged
        Dim buscar As String
        If RB_PROD_BUSCAR_CODIGO.Checked = True Then
            ArmarGrillaProducto()
            buscar = "*" & Me.TB_PROD_BUSCAR_CODIGO.Text & "*"
            Dim consulta_codigo = From U In datacontext.PRODUCTOS Select U.ID_PRODUCTO, U.PROD_CODIGO, U.PROD_DESCRIPCION, U.PROD_PRECIO_COSTO, U.PROD_PRECIO_VTA, U.PROD_STOCK, U.ID_PROVEEDOR, U.ID_DEPOSITO, U.ID_PROD_TIPO Where PROD_CODIGO Like buscar.ToString
            DGV_PROD_BUSCAR.DataSource = consulta_codigo
        End If
    End Sub

    'BOTON ELIMINAR
    Private Sub BTN_PROD_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.PRODUCTOS Where C.ID_PRODUCTO = CInt(DGV_PROD_BUSCAR.Item("ID_PRODUCTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará el Producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente")
            Case MsgBoxResult.Yes
                datacontext.PRODUCTOS.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                Me.CargarGrillaProducto()
                MsgBox("El Producto ha sido eliminado")
        End Select
    End Sub

    'LOGICA DE BOTONES
    Private Sub RB_PROD_BUSCAR_NOMBRE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROD_BUSCAR_NOMBRE.CheckedChanged
        TB_PROD_BUSCAR_CODIGO.Enabled = False
        TB_PROD_BUSCAR_CODIGO.Clear()
        TB_PROD_BUSCAR_NOMBRE.Enabled = True
    End Sub

    'LOGICA DE BOTONES
    Private Sub RB_PROD_BUSCAR_CODIGO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROD_BUSCAR_CODIGO.CheckedChanged
        TB_PROD_BUSCAR_NOMBRE.Enabled = False
        TB_PROD_BUSCAR_NOMBRE.Clear()
        TB_PROD_BUSCAR_CODIGO.Enabled = True
    End Sub

    'CARGA AL FORM "AGREGAR VENTA" LOS DATOS NECESARIOS DEL PRODUCTO QUE SE VA A VENDER
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_AGREGAR_A_VENTA.Click
        If DGV_PROD_BUSCAR.SelectedRows.Count > 0 Then
            FRM_PRODUCTOS.Text = "SELECCIONAR DETALLES DE VENTA"
            FRM_PRODUCTOS.TB_PROD_ID.Text = DGV_PROD_BUSCAR.Item("ID_PRODUCTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_CODIGO.Text = DGV_PROD_BUSCAR.Item("PROD_CODIGO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Text = DGV_PROD_BUSCAR.Item("PROD_DESCRIPCION", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_COSTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_VTA", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_STOCK.Text = DGV_PROD_BUSCAR.Item("PROD_STOCK", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_PROVEEDOR.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROVEEDOR", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_DEPOSITO.SelectedValue = DGV_PROD_BUSCAR.Item("ID_DEPOSITO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_TIPO_PROD.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROD_TIPO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        End If
        TextAgregarVenta()
        FRM_PRODUCTOS.Show()
    End Sub

    'LOGICA DE BOTONES
    Private Sub TextAgregarVenta()
        FRM_PRODUCTOS.TB_PROD_CODIGO.Enabled = False
        FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Enabled = False
        FRM_PRODUCTOS.CB_PROD_PROVEEDOR.Enabled = False
        FRM_PRODUCTOS.TB_PROD_STOCK.Enabled = False
        FRM_PRODUCTOS.CB_PROD_DEPOSITO.Enabled = False
        FRM_PRODUCTOS.CB_PROD_TIPO_PROD.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Enabled = False
        FRM_PRODUCTOS.TB_PROD_CANTIDAD.Enabled = True
        FRM_PRODUCTOS.BTN_PROD_GUARDAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_ACTUALIZAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_CONFIRMAR_PRODUCTO.Visible = True
        FRM_PRODUCTOS.TB_PROD_AUMENTAR_STOCK.Visible = False
        FRM_PRODUCTOS.Label12.Visible = False
        FRM_PRODUCTOS.BTN_PROD_AGREGAR_STOCK.Visible = False

    End Sub

    'CARGA EL FORM "PRODUCTOS" CON LOS DATOS DEL PRODUCTO SELECCIONADO
    Private Sub BTN_PROD_BUS_ACTUALIZAR_STOCK_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_ACTUALIZAR_STOCK.Click

        FRM_PRODUCTOS.TB_PROD_ID.Text = DGV_PROD_BUSCAR.Item("ID_PRODUCTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.TB_PROD_CODIGO.Text = DGV_PROD_BUSCAR.Item("PROD_CODIGO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Text = DGV_PROD_BUSCAR.Item("PROD_DESCRIPCION", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_COSTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_VTA", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.TB_PROD_STOCK.Text = DGV_PROD_BUSCAR.Item("PROD_STOCK", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.CB_PROD_PROVEEDOR.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROVEEDOR", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.CB_PROD_DEPOSITO.SelectedValue = DGV_PROD_BUSCAR.Item("ID_DEPOSITO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        FRM_PRODUCTOS.CB_PROD_TIPO_PROD.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROD_TIPO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value

        'LOGICA DE BOTONES
        FRM_PRODUCTOS.BTN_PROD_ACTUALIZAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_GUARDAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_CONFIRMAR_PRODUCTO.Visible = False

        FRM_PRODUCTOS.TB_PROD_CODIGO.Enabled = False
        FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Enabled = False
        FRM_PRODUCTOS.CB_PROD_PROVEEDOR.Enabled = False
        FRM_PRODUCTOS.CB_PROD_DEPOSITO.Enabled = False
        FRM_PRODUCTOS.CB_PROD_TIPO_PROD.Enabled = False
        FRM_PRODUCTOS.Label11.Visible = False
        FRM_PRODUCTOS.TB_PROD_CANTIDAD.Visible = False
        FRM_PRODUCTOS.TB_PROD_STOCK.Enabled = False
        FRM_PRODUCTOS.Show()
    End Sub

    Private Sub BTN_PROD_BUS_VER_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_BUS_VER.Click

        If DGV_PROD_BUSCAR.SelectedRows.Count > 0 Then
            FRM_PRODUCTOS.TB_PROD_ID.Text = DGV_PROD_BUSCAR.Item("ID_PRODUCTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_CODIGO.Text = DGV_PROD_BUSCAR.Item("PROD_CODIGO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Text = DGV_PROD_BUSCAR.Item("PROD_DESCRIPCION", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_COSTO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Text = DGV_PROD_BUSCAR.Item("PROD_PRECIO_VTA", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.TB_PROD_STOCK.Text = DGV_PROD_BUSCAR.Item("PROD_STOCK", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_PROVEEDOR.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROVEEDOR", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_DEPOSITO.SelectedValue = DGV_PROD_BUSCAR.Item("ID_DEPOSITO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
            FRM_PRODUCTOS.CB_PROD_TIPO_PROD.SelectedValue = DGV_PROD_BUSCAR.Item("ID_PROD_TIPO", DGV_PROD_BUSCAR.SelectedRows(0).Index).Value
        End If

        'LOGICA DE BOTONES
        FRM_PRODUCTOS.Text = "VER PRODUCTO"
        FRM_PRODUCTOS.BTN_PROD_GUARDAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_ACTUALIZAR.Visible = False
        FRM_PRODUCTOS.BTN_PROD_CONFIRMAR_PRODUCTO.Visible = False
        FRM_PRODUCTOS.Label11.Visible = False
        FRM_PRODUCTOS.TB_PROD_CANTIDAD.Visible = False
        FRM_PRODUCTOS.TB_PROD_STOCK.Enabled = False
        FRM_PRODUCTOS.TB_PROD_AUMENTAR_STOCK.Visible = False
        FRM_PRODUCTOS.BTN_PROD_AGREGAR_STOCK.Visible = False
        FRM_PRODUCTOS.Label12.Visible = False

        FRM_PRODUCTOS.TB_PROD_CODIGO.Enabled = False
        FRM_PRODUCTOS.TB_PROD_DESCRIPCION.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_COSTO.Enabled = False
        FRM_PRODUCTOS.TB_PROD_PRECIO_VENTA.Enabled = False
        FRM_PRODUCTOS.CB_PROD_DEPOSITO.Enabled = False
        FRM_PRODUCTOS.CB_PROD_PROVEEDOR.Enabled = False
        FRM_PRODUCTOS.CB_PROD_TIPO_PROD.Enabled = False
        FRM_PRODUCTOS.Show()
    End Sub
End Class