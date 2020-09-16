<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MENU
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrecioDólarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrecioMonitoreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_MENU_USU = New System.Windows.Forms.Label()
        Me.LBL_MENU_PERFIL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.VentasToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1339, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem, Me.ConsultarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CargarClienteToolStripMenuItem
        '
        Me.CargarClienteToolStripMenuItem.Name = "CargarClienteToolStripMenuItem"
        Me.CargarClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CargarClienteToolStripMenuItem.Text = "Nuevo cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar cliente"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockToolStripMenuItem, Me.ModificarProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem, Me.ConsultarProductoToolStripMenuItem, Me.ActualizarStockToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.StockToolStripMenuItem.Text = "Nuevo producto"
        '
        'ModificarProductoToolStripMenuItem
        '
        Me.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        Me.ModificarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ModificarProductoToolStripMenuItem.Text = "Modificar producto"
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar producto"
        '
        'ConsultarProductoToolStripMenuItem
        '
        Me.ConsultarProductoToolStripMenuItem.Name = "ConsultarProductoToolStripMenuItem"
        Me.ConsultarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConsultarProductoToolStripMenuItem.Text = "Consultar producto"
        '
        'ActualizarStockToolStripMenuItem
        '
        Me.ActualizarStockToolStripMenuItem.Name = "ActualizarStockToolStripMenuItem"
        Me.ActualizarStockToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ActualizarStockToolStripMenuItem.Text = "Actualizar stock"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProveedorToolStripMenuItem, Me.ModificarProveedorToolStripMenuItem, Me.EliminarProveedorToolStripMenuItem, Me.ConsultarProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'NuevoProveedorToolStripMenuItem
        '
        Me.NuevoProveedorToolStripMenuItem.Name = "NuevoProveedorToolStripMenuItem"
        Me.NuevoProveedorToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor"
        '
        'ModificarProveedorToolStripMenuItem
        '
        Me.ModificarProveedorToolStripMenuItem.Name = "ModificarProveedorToolStripMenuItem"
        Me.ModificarProveedorToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ModificarProveedorToolStripMenuItem.Text = "Modificar proveedor"
        '
        'EliminarProveedorToolStripMenuItem
        '
        Me.EliminarProveedorToolStripMenuItem.Name = "EliminarProveedorToolStripMenuItem"
        Me.EliminarProveedorToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EliminarProveedorToolStripMenuItem.Text = "Eliminar proveedor"
        '
        'ConsultarProveedoresToolStripMenuItem
        '
        Me.ConsultarProveedoresToolStripMenuItem.Name = "ConsultarProveedoresToolStripMenuItem"
        Me.ConsultarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ConsultarProveedoresToolStripMenuItem.Text = "Consultar proveedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ModificarVentaToolStripMenuItem, Me.EliminarVentaToolStripMenuItem, Me.ConsultarVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'ModificarVentaToolStripMenuItem
        '
        Me.ModificarVentaToolStripMenuItem.Name = "ModificarVentaToolStripMenuItem"
        Me.ModificarVentaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ModificarVentaToolStripMenuItem.Text = "Modificar venta"
        '
        'EliminarVentaToolStripMenuItem
        '
        Me.EliminarVentaToolStripMenuItem.Name = "EliminarVentaToolStripMenuItem"
        Me.EliminarVentaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EliminarVentaToolStripMenuItem.Text = "Eliminar venta"
        '
        'ConsultarVentaToolStripMenuItem
        '
        Me.ConsultarVentaToolStripMenuItem.Name = "ConsultarVentaToolStripMenuItem"
        Me.ConsultarVentaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConsultarVentaToolStripMenuItem.Text = "Consultar venta"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeUsuariosToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem, Me.ConsultarUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GestiónDeUsuariosToolStripMenuItem
        '
        Me.GestiónDeUsuariosToolStripMenuItem.Name = "GestiónDeUsuariosToolStripMenuItem"
        Me.GestiónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestiónDeUsuariosToolStripMenuItem.Text = "Alta de usuarios"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario"
        '
        'ConsultarUsuariosToolStripMenuItem
        '
        Me.ConsultarUsuariosToolStripMenuItem.Name = "ConsultarUsuariosToolStripMenuItem"
        Me.ConsultarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarUsuariosToolStripMenuItem.Text = "Consultar usuarios"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrecioDólarToolStripMenuItem, Me.PrecioMonitoreoToolStripMenuItem})
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'PrecioDólarToolStripMenuItem
        '
        Me.PrecioDólarToolStripMenuItem.Name = "PrecioDólarToolStripMenuItem"
        Me.PrecioDólarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrecioDólarToolStripMenuItem.Text = "Precio Dólar"
        '
        'PrecioMonitoreoToolStripMenuItem
        '
        Me.PrecioMonitoreoToolStripMenuItem.Name = "PrecioMonitoreoToolStripMenuItem"
        Me.PrecioMonitoreoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrecioMonitoreoToolStripMenuItem.Text = "Precio Monitoreo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 9)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 9)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Perfil:"
        '
        'LBL_MENU_USU
        '
        Me.LBL_MENU_USU.AutoSize = True
        Me.LBL_MENU_USU.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_USU.Location = New System.Drawing.Point(35, 13)
        Me.LBL_MENU_USU.Name = "LBL_MENU_USU"
        Me.LBL_MENU_USU.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_USU.TabIndex = 3
        Me.LBL_MENU_USU.Text = "Label3"
        '
        'LBL_MENU_PERFIL
        '
        Me.LBL_MENU_PERFIL.AutoSize = True
        Me.LBL_MENU_PERFIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_PERFIL.Location = New System.Drawing.Point(35, 24)
        Me.LBL_MENU_PERFIL.Name = "LBL_MENU_PERFIL"
        Me.LBL_MENU_PERFIL.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_PERFIL.TabIndex = 4
        Me.LBL_MENU_PERFIL.Text = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_MENU_PERFIL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LBL_MENU_USU)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 673)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1339, 38)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'FRM_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRM_MENU"
        Me.Text = "MENU PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBL_MENU_USU As System.Windows.Forms.Label
    Friend WithEvents LBL_MENU_PERFIL As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecioDólarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecioMonitoreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
