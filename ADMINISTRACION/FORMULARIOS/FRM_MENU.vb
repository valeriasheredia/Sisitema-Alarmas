Public Class FRM_MENU

    Public QUIENLLAMOMODIFICARCLIENTE As Form

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
        Me.Dispose()
    End Sub

    Private Sub CargarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarClienteToolStripMenuItem.Click
        FRM_CLIENTES_A_M.BTN_CLIE_ACTUALIZAR.Visible = False
        FRM_CLIENTES_A_M.Show()

    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.Text = "ELIMINAR CLIENTES"
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_EDITAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_IMPRIMIR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()

    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.Text = "MODIFICAR CLIENTES"
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_ELIMINAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_IMPRIMIR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub FRM_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        FRM_GESTION_USUARIOS.BTN_USU_ACTUALIZAR.Visible = False
        FRM_GESTION_USUARIOS.Show()

    End Sub

    'CIERRE DE SESION
    Public formularios As New List(Of Form)

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'LISTA DE FORMULARIOS ABIERTOS
        Dim fr As Form
        For Each fr In Application.OpenForms
            formularios.Add(fr)
        Next
        'ABRE FORMULARIO DE INICIO DE SESION
        Dim frinicio As New FRM_INGRESO
        frinicio.Show()
        'CIERRRA TODOS LOS FORMS ABIERTOS
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub

    Private Sub ConsultarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarUsuariosToolStripMenuItem.Click
        FRM_GESTION_USUARIOS_B.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FRM_PRODUCTOS.TB_PROD_AUMENTAR_STOCK.Visible = False
        FRM_PRODUCTOS.Label12.Visible = False
        FRM_PRODUCTOS.BTN_PROD_AGREGAR_STOCK.Visible = False
        FRM_PRODUCTOS.BTN_PROD_ACTUALIZAR.Visible = False
        FRM_PRODUCTOS.Show()
    End Sub

    Private Sub ConsultarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarClientesToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.Text = "CONSULTAR CLIENTES"
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_EDITAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_ELIMINAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        FRM_PROVEEDORES.BTN_PROV_ACTUALIZAR.Visible = False
        FRM_PROVEEDORES.Show()
    End Sub

    Private Sub ConsultarProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarProveedoresToolStripMenuItem.Click
        FRM_PROVEEDORES_BUSCAR_B_M.Text = "CONSULTAR PROVEEDORES"
        FRM_PROVEEDORES_BUSCAR_B_M.BTN_PROV_BUS_EDITAR.Visible = False
        FRM_PROVEEDORES_BUSCAR_B_M.BTN_PROV_BUS_ELIMINAR.Visible = False
        FRM_PROVEEDORES_BUSCAR_B_M.Show()
    End Sub

    Private Sub ConsultarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarProductoToolStripMenuItem.Click
        FRM_PRODUCTOS_BUSCAR_B_M.Text = "CONSULTAR PRODUCTOS"
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ACTUALIZAR_STOCK.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ELIMINAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_EDITAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = False

        FRM_PRODUCTOS_BUSCAR_B_M.Show()
    End Sub

    Private Sub ModificarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarProveedorToolStripMenuItem.Click
        FRM_PROVEEDORES_BUSCAR_B_M.Text = "MODIFICAR PROVEEDORES"
        FRM_PROVEEDORES_BUSCAR_B_M.BTN_PROV_BUS_ELIMINAR.Visible = False
        FRM_PROVEEDORES_BUSCAR_B_M.Show()
    End Sub

    Private Sub EliminarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarProveedorToolStripMenuItem.Click
        FRM_PROVEEDORES_BUSCAR_B_M.Text = "ELIMINAR PROVEEDORES"
        FRM_PROVEEDORES_BUSCAR_B_M.BTN_PROV_BUS_EDITAR.Visible = False
        FRM_PROVEEDORES_BUSCAR_B_M.Show()
    End Sub

    Private Sub PrecioDólarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrecioDólarToolStripMenuItem.Click
        FRM_VALOR_DOLAR_PESO_B_M.Show()
    End Sub

    Private Sub ActualizarStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizarStockToolStripMenuItem.Click
        FRM_PRODUCTOS_BUSCAR_B_M.Text = "ACTUALIZAR STOCK"
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_EDITAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ELIMINAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_VER.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.Show()

    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        FRM_PRODUCTOS_BUSCAR_B_M.Text = "MODIFICAR PRODUCTO"
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ACTUALIZAR_STOCK.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ELIMINAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_VER.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.Show()
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarProductoToolStripMenuItem.Click
        FRM_PRODUCTOS_BUSCAR_B_M.Text = "ELIMINAR PRODUCTO"
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_AGREGAR_A_VENTA.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_ACTUALIZAR_STOCK.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_EDITAR.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.BTN_PROD_BUS_VER.Visible = False
        FRM_PRODUCTOS_BUSCAR_B_M.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        FRM_VENTAS.Text = "CARGAR VENTAS"
        FRM_VENTAS.Show()
    End Sub

    Private Sub EliminarVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarVentaToolStripMenuItem.Click

        FRM_VENTAS_BUSCAR_M_B.Text = "ELIMINAR VENTAS"
        FRM_VENTAS_BUSCAR_M_B.Show()
    End Sub

    Private Sub ConsultarVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarVentaToolStripMenuItem.Click
        FRM_VENTAS_BUSCAR_M_B.Text = "CONSULTAR VENTAS"
        FRM_VENTAS_BUSCAR_M_B.Show()
    End Sub
End Class

