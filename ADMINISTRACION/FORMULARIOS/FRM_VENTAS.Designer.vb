<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_VENTAS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_VENTAS_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_VENTA_DESCUENTO = New System.Windows.Forms.TextBox()
        Me.TB_VENTA_ID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_VENT_AGREGAR_PROD = New System.Windows.Forms.Button()
        Me.TB_PROD_X_VTA_ID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBL_VENTA_CANT_PROD = New System.Windows.Forms.Label()
        Me.BTN_VENT_QUITAR_PROD = New System.Windows.Forms.Button()
        Me.TB_VENTA_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_SUBTOTAL_VENTA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_ID = New System.Windows.Forms.TextBox()
        Me.TB_CLIENTE_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TB_CLIENTE_DNI = New System.Windows.Forms.TextBox()
        Me.BTN_VENT_CARGAR_CLIENTE = New System.Windows.Forms.Button()
        Me.BTN_VENTA_IMPRIMIR = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_TELEFONO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_DIRECCION = New System.Windows.Forms.TextBox()
        Me.BTN_VENTA_PRESUPUESTO = New System.Windows.Forms.Button()
        Me.CB_VENTA_FORMAPAGO = New System.Windows.Forms.ComboBox()
        Me.BTN_VENTA_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_VENTA_SALIR = New System.Windows.Forms.Button()
        Me.DTP_FECHA_VENTA = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV_VENTAS_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'DGV_VENTAS_BUSCAR
        '
        Me.DGV_VENTAS_BUSCAR.AllowUserToAddRows = False
        Me.DGV_VENTAS_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VENTAS_BUSCAR.Location = New System.Drawing.Point(15, 63)
        Me.DGV_VENTAS_BUSCAR.Name = "DGV_VENTAS_BUSCAR"
        Me.DGV_VENTAS_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VENTAS_BUSCAR.Size = New System.Drawing.Size(594, 193)
        Me.DGV_VENTAS_BUSCAR.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "*Datos obligatorios"
        '
        'TB_VENTA_DESCUENTO
        '
        Me.TB_VENTA_DESCUENTO.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VENTA_DESCUENTO.Location = New System.Drawing.Point(520, 288)
        Me.TB_VENTA_DESCUENTO.Name = "TB_VENTA_DESCUENTO"
        Me.TB_VENTA_DESCUENTO.Size = New System.Drawing.Size(90, 23)
        Me.TB_VENTA_DESCUENTO.TabIndex = 31
        '
        'TB_VENTA_ID
        '
        Me.TB_VENTA_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VENTA_ID.Location = New System.Drawing.Point(91, 21)
        Me.TB_VENTA_ID.Name = "TB_VENTA_ID"
        Me.TB_VENTA_ID.Size = New System.Drawing.Size(37, 26)
        Me.TB_VENTA_ID.TabIndex = 30
        Me.TB_VENTA_ID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Forma de Pago*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cantidad de Productos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(447, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Descuento %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Id Venta*"
        Me.Label12.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_VENT_AGREGAR_PROD)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_X_VTA_ID)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LBL_VENTA_CANT_PROD)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BTN_VENT_QUITAR_PROD)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_SUBTOTAL_VENTA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGV_VENTAS_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_DESCUENTO)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_ID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 342)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Venta"
        '
        'BTN_VENT_AGREGAR_PROD
        '
        Me.BTN_VENT_AGREGAR_PROD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENT_AGREGAR_PROD.Location = New System.Drawing.Point(323, 19)
        Me.BTN_VENT_AGREGAR_PROD.Name = "BTN_VENT_AGREGAR_PROD"
        Me.BTN_VENT_AGREGAR_PROD.Size = New System.Drawing.Size(140, 28)
        Me.BTN_VENT_AGREGAR_PROD.TabIndex = 52
        Me.BTN_VENT_AGREGAR_PROD.Text = "Agregar Producto"
        Me.BTN_VENT_AGREGAR_PROD.UseVisualStyleBackColor = True
        '
        'TB_PROD_X_VTA_ID
        '
        Me.TB_PROD_X_VTA_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_X_VTA_ID.Location = New System.Drawing.Point(253, 21)
        Me.TB_PROD_X_VTA_ID.Name = "TB_PROD_X_VTA_ID"
        Me.TB_PROD_X_VTA_ID.Size = New System.Drawing.Size(37, 26)
        Me.TB_PROD_X_VTA_ID.TabIndex = 51
        Me.TB_PROD_X_VTA_ID.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(143, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Id Prod_x_Vta*"
        Me.Label15.Visible = False
        '
        'LBL_VENTA_CANT_PROD
        '
        Me.LBL_VENTA_CANT_PROD.AutoSize = True
        Me.LBL_VENTA_CANT_PROD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_VENTA_CANT_PROD.Location = New System.Drawing.Point(180, 273)
        Me.LBL_VENTA_CANT_PROD.Name = "LBL_VENTA_CANT_PROD"
        Me.LBL_VENTA_CANT_PROD.Size = New System.Drawing.Size(2, 15)
        Me.LBL_VENTA_CANT_PROD.TabIndex = 49
        '
        'BTN_VENT_QUITAR_PROD
        '
        Me.BTN_VENT_QUITAR_PROD.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENT_QUITAR_PROD.Location = New System.Drawing.Point(469, 19)
        Me.BTN_VENT_QUITAR_PROD.Name = "BTN_VENT_QUITAR_PROD"
        Me.BTN_VENT_QUITAR_PROD.Size = New System.Drawing.Size(140, 28)
        Me.BTN_VENT_QUITAR_PROD.TabIndex = 48
        Me.BTN_VENT_QUITAR_PROD.Text = "Quitar producto"
        Me.BTN_VENT_QUITAR_PROD.UseVisualStyleBackColor = True
        '
        'TB_VENTA_TOTAL
        '
        Me.TB_VENTA_TOTAL.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VENTA_TOTAL.Location = New System.Drawing.Point(520, 312)
        Me.TB_VENTA_TOTAL.Name = "TB_VENTA_TOTAL"
        Me.TB_VENTA_TOTAL.Size = New System.Drawing.Size(90, 23)
        Me.TB_VENTA_TOTAL.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(470, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Total $"
        '
        'TB_SUBTOTAL_VENTA
        '
        Me.TB_SUBTOTAL_VENTA.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUBTOTAL_VENTA.Location = New System.Drawing.Point(520, 264)
        Me.TB_SUBTOTAL_VENTA.Name = "TB_SUBTOTAL_VENTA"
        Me.TB_SUBTOTAL_VENTA.Size = New System.Drawing.Size(90, 23)
        Me.TB_SUBTOTAL_VENTA.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "SubTotal $"
        '
        'TB_CLIENTE_ID
        '
        Me.TB_CLIENTE_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_ID.Location = New System.Drawing.Point(593, 125)
        Me.TB_CLIENTE_ID.Name = "TB_CLIENTE_ID"
        Me.TB_CLIENTE_ID.Size = New System.Drawing.Size(42, 26)
        Me.TB_CLIENTE_ID.TabIndex = 47
        Me.TB_CLIENTE_ID.Visible = False
        '
        'TB_CLIENTE_APELLIDO
        '
        Me.TB_CLIENTE_APELLIDO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_APELLIDO.Location = New System.Drawing.Point(79, 21)
        Me.TB_CLIENTE_APELLIDO.Name = "TB_CLIENTE_APELLIDO"
        Me.TB_CLIENTE_APELLIDO.Size = New System.Drawing.Size(160, 26)
        Me.TB_CLIENTE_APELLIDO.TabIndex = 48
        '
        'TB_CLIENTE_DNI
        '
        Me.TB_CLIENTE_DNI.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_DNI.Location = New System.Drawing.Point(502, 18)
        Me.TB_CLIENTE_DNI.Name = "TB_CLIENTE_DNI"
        Me.TB_CLIENTE_DNI.Size = New System.Drawing.Size(107, 26)
        Me.TB_CLIENTE_DNI.TabIndex = 49
        '
        'BTN_VENT_CARGAR_CLIENTE
        '
        Me.BTN_VENT_CARGAR_CLIENTE.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENT_CARGAR_CLIENTE.Location = New System.Drawing.Point(502, 55)
        Me.BTN_VENT_CARGAR_CLIENTE.Name = "BTN_VENT_CARGAR_CLIENTE"
        Me.BTN_VENT_CARGAR_CLIENTE.Size = New System.Drawing.Size(108, 37)
        Me.BTN_VENT_CARGAR_CLIENTE.TabIndex = 50
        Me.BTN_VENT_CARGAR_CLIENTE.Text = "Cargar Cliente"
        Me.BTN_VENT_CARGAR_CLIENTE.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_IMPRIMIR
        '
        Me.BTN_VENTA_IMPRIMIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_IMPRIMIR.Location = New System.Drawing.Point(454, 506)
        Me.BTN_VENTA_IMPRIMIR.Name = "BTN_VENTA_IMPRIMIR"
        Me.BTN_VENTA_IMPRIMIR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_IMPRIMIR.TabIndex = 51
        Me.BTN_VENTA_IMPRIMIR.Text = "Imprimir"
        Me.BTN_VENTA_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(532, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Id Cliente"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Apellido"
        '
        'TB_CLIENTE_NOMBRE
        '
        Me.TB_CLIENTE_NOMBRE.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_NOMBRE.Location = New System.Drawing.Point(311, 18)
        Me.TB_CLIENTE_NOMBRE.Name = "TB_CLIENTE_NOMBRE"
        Me.TB_CLIENTE_NOMBRE.Size = New System.Drawing.Size(154, 26)
        Me.TB_CLIENTE_NOMBRE.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(250, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(471, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Dni"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TB_CLIENTE_TELEFONO)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_CLIENTE_DIRECCION)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TB_CLIENTE_NOMBRE)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BTN_VENT_CARGAR_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.TB_CLIENTE_DNI)
        Me.GroupBox2.Controls.Add(Me.TB_CLIENTE_APELLIDO)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 107)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(315, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 18)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Teléfono"
        '
        'TB_CLIENTE_TELEFONO
        '
        Me.TB_CLIENTE_TELEFONO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_TELEFONO.Location = New System.Drawing.Point(384, 61)
        Me.TB_CLIENTE_TELEFONO.Name = "TB_CLIENTE_TELEFONO"
        Me.TB_CLIENTE_TELEFONO.Size = New System.Drawing.Size(107, 26)
        Me.TB_CLIENTE_TELEFONO.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Dirección"
        '
        'TB_CLIENTE_DIRECCION
        '
        Me.TB_CLIENTE_DIRECCION.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_DIRECCION.Location = New System.Drawing.Point(78, 61)
        Me.TB_CLIENTE_DIRECCION.Name = "TB_CLIENTE_DIRECCION"
        Me.TB_CLIENTE_DIRECCION.Size = New System.Drawing.Size(227, 26)
        Me.TB_CLIENTE_DIRECCION.TabIndex = 57
        '
        'BTN_VENTA_PRESUPUESTO
        '
        Me.BTN_VENTA_PRESUPUESTO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_PRESUPUESTO.Location = New System.Drawing.Point(359, 505)
        Me.BTN_VENTA_PRESUPUESTO.Name = "BTN_VENTA_PRESUPUESTO"
        Me.BTN_VENTA_PRESUPUESTO.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_PRESUPUESTO.TabIndex = 58
        Me.BTN_VENTA_PRESUPUESTO.Text = "Presupuesto"
        Me.BTN_VENTA_PRESUPUESTO.UseVisualStyleBackColor = True
        '
        'CB_VENTA_FORMAPAGO
        '
        Me.CB_VENTA_FORMAPAGO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_VENTA_FORMAPAGO.FormattingEnabled = True
        Me.CB_VENTA_FORMAPAGO.Location = New System.Drawing.Point(139, 123)
        Me.CB_VENTA_FORMAPAGO.Name = "CB_VENTA_FORMAPAGO"
        Me.CB_VENTA_FORMAPAGO.Size = New System.Drawing.Size(181, 26)
        Me.CB_VENTA_FORMAPAGO.TabIndex = 59
        '
        'BTN_VENTA_GUARDAR
        '
        Me.BTN_VENTA_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_GUARDAR.Location = New System.Drawing.Point(15, 506)
        Me.BTN_VENTA_GUARDAR.Name = "BTN_VENTA_GUARDAR"
        Me.BTN_VENTA_GUARDAR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_GUARDAR.TabIndex = 60
        Me.BTN_VENTA_GUARDAR.Text = "Guardar"
        Me.BTN_VENTA_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_SALIR
        '
        Me.BTN_VENTA_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_SALIR.Location = New System.Drawing.Point(551, 506)
        Me.BTN_VENTA_SALIR.Name = "BTN_VENTA_SALIR"
        Me.BTN_VENTA_SALIR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_SALIR.TabIndex = 61
        Me.BTN_VENTA_SALIR.Text = "Salir"
        Me.BTN_VENTA_SALIR.UseVisualStyleBackColor = True
        '
        'DTP_FECHA_VENTA
        '
        Me.DTP_FECHA_VENTA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FECHA_VENTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_VENTA.Location = New System.Drawing.Point(399, 123)
        Me.DTP_FECHA_VENTA.Name = "DTP_FECHA_VENTA"
        Me.DTP_FECHA_VENTA.Size = New System.Drawing.Size(130, 26)
        Me.DTP_FECHA_VENTA.TabIndex = 62
        '
        'FRM_VENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 549)
        Me.Controls.Add(Me.DTP_FECHA_VENTA)
        Me.Controls.Add(Me.BTN_VENTA_SALIR)
        Me.Controls.Add(Me.BTN_VENTA_GUARDAR)
        Me.Controls.Add(Me.CB_VENTA_FORMAPAGO)
        Me.Controls.Add(Me.BTN_VENTA_PRESUPUESTO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_VENTA_IMPRIMIR)
        Me.Controls.Add(Me.TB_CLIENTE_ID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FRM_VENTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        CType(Me.DGV_VENTAS_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_VENTAS_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_VENTA_DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents TB_VENTA_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_CLIENTE_ID As System.Windows.Forms.TextBox
    Friend WithEvents TB_SUBTOTAL_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_VENT_QUITAR_PROD As System.Windows.Forms.Button
    Friend WithEvents TB_VENTA_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIENTE_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIENTE_DNI As System.Windows.Forms.TextBox
    Friend WithEvents BTN_VENT_CARGAR_CLIENTE As System.Windows.Forms.Button
    Friend WithEvents LBL_VENTA_CANT_PROD As System.Windows.Forms.Label
    Friend WithEvents BTN_VENTA_IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIENTE_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIENTE_TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIENTE_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_X_VTA_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BTN_VENTA_PRESUPUESTO As System.Windows.Forms.Button
    Friend WithEvents CB_VENTA_FORMAPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_VENTA_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_VENTA_SALIR As System.Windows.Forms.Button
    Friend WithEvents DTP_FECHA_VENTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTN_VENT_AGREGAR_PROD As System.Windows.Forms.Button
End Class
