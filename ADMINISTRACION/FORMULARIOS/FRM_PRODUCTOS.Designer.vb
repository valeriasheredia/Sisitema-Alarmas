<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTOS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PROD_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_PROD_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TB_PROD_PRECIO_COSTO = New System.Windows.Forms.TextBox()
        Me.TB_PROD_PRECIO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_PROD_STOCK = New System.Windows.Forms.TextBox()
        Me.CB_PROD_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.CB_PROD_DEPOSITO = New System.Windows.Forms.ComboBox()
        Me.CB_PROD_TIPO_PROD = New System.Windows.Forms.ComboBox()
        Me.TB_PROD_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_PROD_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_PROD_AGREGAR_STOCK = New System.Windows.Forms.Button()
        Me.TB_PROD_AUMENTAR_STOCK = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_PROD_CONFIRMAR_PRODUCTO = New System.Windows.Forms.Button()
        Me.BTN_PROD_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_SALIR = New System.Windows.Forms.Button()
        Me.BTN_PROD_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio de costo*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio de venta*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Proveedor*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Depósito*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de producto*"
        '
        'TB_PROD_CODIGO
        '
        Me.TB_PROD_CODIGO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_CODIGO.Location = New System.Drawing.Point(79, 24)
        Me.TB_PROD_CODIGO.Name = "TB_PROD_CODIGO"
        Me.TB_PROD_CODIGO.Size = New System.Drawing.Size(121, 26)
        Me.TB_PROD_CODIGO.TabIndex = 8
        '
        'TB_PROD_DESCRIPCION
        '
        Me.TB_PROD_DESCRIPCION.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_DESCRIPCION.Location = New System.Drawing.Point(112, 75)
        Me.TB_PROD_DESCRIPCION.Name = "TB_PROD_DESCRIPCION"
        Me.TB_PROD_DESCRIPCION.Size = New System.Drawing.Size(443, 26)
        Me.TB_PROD_DESCRIPCION.TabIndex = 9
        '
        'TB_PROD_PRECIO_COSTO
        '
        Me.TB_PROD_PRECIO_COSTO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_PRECIO_COSTO.Location = New System.Drawing.Point(134, 124)
        Me.TB_PROD_PRECIO_COSTO.Name = "TB_PROD_PRECIO_COSTO"
        Me.TB_PROD_PRECIO_COSTO.Size = New System.Drawing.Size(118, 26)
        Me.TB_PROD_PRECIO_COSTO.TabIndex = 10
        '
        'TB_PROD_PRECIO_VENTA
        '
        Me.TB_PROD_PRECIO_VENTA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_PRECIO_VENTA.Location = New System.Drawing.Point(424, 124)
        Me.TB_PROD_PRECIO_VENTA.Name = "TB_PROD_PRECIO_VENTA"
        Me.TB_PROD_PRECIO_VENTA.Size = New System.Drawing.Size(117, 26)
        Me.TB_PROD_PRECIO_VENTA.TabIndex = 11
        '
        'TB_PROD_STOCK
        '
        Me.TB_PROD_STOCK.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_STOCK.Location = New System.Drawing.Point(65, 171)
        Me.TB_PROD_STOCK.Name = "TB_PROD_STOCK"
        Me.TB_PROD_STOCK.Size = New System.Drawing.Size(102, 26)
        Me.TB_PROD_STOCK.TabIndex = 12
        '
        'CB_PROD_PROVEEDOR
        '
        Me.CB_PROD_PROVEEDOR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PROD_PROVEEDOR.FormattingEnabled = True
        Me.CB_PROD_PROVEEDOR.Location = New System.Drawing.Point(361, 226)
        Me.CB_PROD_PROVEEDOR.Name = "CB_PROD_PROVEEDOR"
        Me.CB_PROD_PROVEEDOR.Size = New System.Drawing.Size(180, 26)
        Me.CB_PROD_PROVEEDOR.TabIndex = 13
        '
        'CB_PROD_DEPOSITO
        '
        Me.CB_PROD_DEPOSITO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PROD_DEPOSITO.FormattingEnabled = True
        Me.CB_PROD_DEPOSITO.Location = New System.Drawing.Point(85, 223)
        Me.CB_PROD_DEPOSITO.Name = "CB_PROD_DEPOSITO"
        Me.CB_PROD_DEPOSITO.Size = New System.Drawing.Size(183, 26)
        Me.CB_PROD_DEPOSITO.TabIndex = 14
        '
        'CB_PROD_TIPO_PROD
        '
        Me.CB_PROD_TIPO_PROD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PROD_TIPO_PROD.FormattingEnabled = True
        Me.CB_PROD_TIPO_PROD.Location = New System.Drawing.Point(138, 277)
        Me.CB_PROD_TIPO_PROD.Name = "CB_PROD_TIPO_PROD"
        Me.CB_PROD_TIPO_PROD.Size = New System.Drawing.Size(224, 26)
        Me.CB_PROD_TIPO_PROD.TabIndex = 15
        '
        'TB_PROD_ID
        '
        Me.TB_PROD_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_ID.Location = New System.Drawing.Point(443, 280)
        Me.TB_PROD_ID.Name = "TB_PROD_ID"
        Me.TB_PROD_ID.Size = New System.Drawing.Size(98, 26)
        Me.TB_PROD_ID.TabIndex = 20
        Me.TB_PROD_ID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "*Datos obligatorios"
        '
        'TB_PROD_CANTIDAD
        '
        Me.TB_PROD_CANTIDAD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_CANTIDAD.Location = New System.Drawing.Point(264, 321)
        Me.TB_PROD_CANTIDAD.Multiline = True
        Me.TB_PROD_CANTIDAD.Name = "TB_PROD_CANTIDAD"
        Me.TB_PROD_CANTIDAD.Size = New System.Drawing.Size(98, 36)
        Me.TB_PROD_CANTIDAD.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(131, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cantidad a Vender*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_PROD_AGREGAR_STOCK)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_AUMENTAR_STOCK)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_CANTIDAD)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_ID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CB_PROD_TIPO_PROD)
        Me.GroupBox1.Controls.Add(Me.CB_PROD_DEPOSITO)
        Me.GroupBox1.Controls.Add(Me.CB_PROD_PROVEEDOR)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_STOCK)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_PRECIO_VENTA)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_PRECIO_COSTO)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_CODIGO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 370)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'BTN_PROD_AGREGAR_STOCK
        '
        Me.BTN_PROD_AGREGAR_STOCK.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_AGREGAR_STOCK.Location = New System.Drawing.Point(452, 168)
        Me.BTN_PROD_AGREGAR_STOCK.Name = "BTN_PROD_AGREGAR_STOCK"
        Me.BTN_PROD_AGREGAR_STOCK.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_AGREGAR_STOCK.TabIndex = 26
        Me.BTN_PROD_AGREGAR_STOCK.Text = "Agregar"
        Me.BTN_PROD_AGREGAR_STOCK.UseVisualStyleBackColor = True
        '
        'TB_PROD_AUMENTAR_STOCK
        '
        Me.TB_PROD_AUMENTAR_STOCK.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_AUMENTAR_STOCK.Location = New System.Drawing.Point(341, 171)
        Me.TB_PROD_AUMENTAR_STOCK.Name = "TB_PROD_AUMENTAR_STOCK"
        Me.TB_PROD_AUMENTAR_STOCK.Size = New System.Drawing.Size(102, 26)
        Me.TB_PROD_AUMENTAR_STOCK.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(231, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Aumentar Stock"
        '
        'BTN_PROD_CONFIRMAR_PRODUCTO
        '
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.Location = New System.Drawing.Point(346, 391)
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.Name = "BTN_PROD_CONFIRMAR_PRODUCTO"
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.Size = New System.Drawing.Size(125, 31)
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.TabIndex = 25
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.Text = "Confirmar Pedido"
        Me.BTN_PROD_CONFIRMAR_PRODUCTO.UseVisualStyleBackColor = True
        '
        'BTN_PROD_GUARDAR
        '
        Me.BTN_PROD_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_GUARDAR.Location = New System.Drawing.Point(402, 391)
        Me.BTN_PROD_GUARDAR.Name = "BTN_PROD_GUARDAR"
        Me.BTN_PROD_GUARDAR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_GUARDAR.TabIndex = 26
        Me.BTN_PROD_GUARDAR.Text = "Guardar"
        Me.BTN_PROD_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_SALIR
        '
        Me.BTN_PROD_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_SALIR.Location = New System.Drawing.Point(497, 391)
        Me.BTN_PROD_SALIR.Name = "BTN_PROD_SALIR"
        Me.BTN_PROD_SALIR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_SALIR.TabIndex = 27
        Me.BTN_PROD_SALIR.Text = "Salir"
        Me.BTN_PROD_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_ACTUALIZAR
        '
        Me.BTN_PROD_ACTUALIZAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_ACTUALIZAR.Location = New System.Drawing.Point(393, 391)
        Me.BTN_PROD_ACTUALIZAR.Name = "BTN_PROD_ACTUALIZAR"
        Me.BTN_PROD_ACTUALIZAR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_ACTUALIZAR.TabIndex = 28
        Me.BTN_PROD_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_PROD_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'FRM_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 442)
        Me.Controls.Add(Me.BTN_PROD_ACTUALIZAR)
        Me.Controls.Add(Me.BTN_PROD_SALIR)
        Me.Controls.Add(Me.BTN_PROD_GUARDAR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_PROD_CONFIRMAR_PRODUCTO)
        Me.Name = "FRM_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGAR PRODUCTO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_PRECIO_COSTO As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_PRECIO_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_STOCK As System.Windows.Forms.TextBox
    Friend WithEvents CB_PROD_PROVEEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents CB_PROD_DEPOSITO As System.Windows.Forms.ComboBox
    Friend WithEvents CB_PROD_TIPO_PROD As System.Windows.Forms.ComboBox
    Friend WithEvents TB_PROD_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_CANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_PROD_CONFIRMAR_PRODUCTO As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_AGREGAR_STOCK As System.Windows.Forms.Button
    Friend WithEvents TB_PROD_AUMENTAR_STOCK As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
