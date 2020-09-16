<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TIPOS_PRODUCTOS
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
        Me.BTN_PROD_TIPO_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_TIPO_SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_PROD_TIPO_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TB_PROD_TIPO_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_PROD_TIPO_GUARDAR
        '
        Me.BTN_PROD_TIPO_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_TIPO_GUARDAR.Location = New System.Drawing.Point(23, 180)
        Me.BTN_PROD_TIPO_GUARDAR.Name = "BTN_PROD_TIPO_GUARDAR"
        Me.BTN_PROD_TIPO_GUARDAR.Size = New System.Drawing.Size(74, 32)
        Me.BTN_PROD_TIPO_GUARDAR.TabIndex = 0
        Me.BTN_PROD_TIPO_GUARDAR.Text = "Guardar"
        Me.BTN_PROD_TIPO_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_TIPO_SALIR
        '
        Me.BTN_PROD_TIPO_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_TIPO_SALIR.Location = New System.Drawing.Point(115, 180)
        Me.BTN_PROD_TIPO_SALIR.Name = "BTN_PROD_TIPO_SALIR"
        Me.BTN_PROD_TIPO_SALIR.Size = New System.Drawing.Size(74, 32)
        Me.BTN_PROD_TIPO_SALIR.TabIndex = 1
        Me.BTN_PROD_TIPO_SALIR.Text = "Salir"
        Me.BTN_PROD_TIPO_SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción del tipo de producto*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código de tipo de producto*"
        '
        'TB_PROD_TIPO_DESCRIPCION
        '
        Me.TB_PROD_TIPO_DESCRIPCION.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_TIPO_DESCRIPCION.Location = New System.Drawing.Point(31, 108)
        Me.TB_PROD_TIPO_DESCRIPCION.Name = "TB_PROD_TIPO_DESCRIPCION"
        Me.TB_PROD_TIPO_DESCRIPCION.Size = New System.Drawing.Size(163, 26)
        Me.TB_PROD_TIPO_DESCRIPCION.TabIndex = 4
        '
        'TB_PROD_TIPO_CODIGO
        '
        Me.TB_PROD_TIPO_CODIGO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_TIPO_CODIGO.Location = New System.Drawing.Point(33, 42)
        Me.TB_PROD_TIPO_CODIGO.Name = "TB_PROD_TIPO_CODIGO"
        Me.TB_PROD_TIPO_CODIGO.Size = New System.Drawing.Size(163, 26)
        Me.TB_PROD_TIPO_CODIGO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*Datos obligatorios"
        '
        'FRM_TIPOS_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 226)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_PROD_TIPO_CODIGO)
        Me.Controls.Add(Me.TB_PROD_TIPO_DESCRIPCION)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_PROD_TIPO_SALIR)
        Me.Controls.Add(Me.BTN_PROD_TIPO_GUARDAR)
        Me.Name = "FRM_TIPOS_PRODUCTOS"
        Me.Text = "TIPOS DE PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_PROD_TIPO_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_TIPO_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_TIPO_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_TIPO_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
