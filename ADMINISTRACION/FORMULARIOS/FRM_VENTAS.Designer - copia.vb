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
        Me.BTN_VENT_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_VENT_SALIR = New System.Windows.Forms.Button()
        Me.BTN_VENT_AGREGAR_PROD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TB_VENT_FECHA = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_VENT_GUARDAR
        '
        Me.BTN_VENT_GUARDAR.Location = New System.Drawing.Point(26, 234)
        Me.BTN_VENT_GUARDAR.Name = "BTN_VENT_GUARDAR"
        Me.BTN_VENT_GUARDAR.Size = New System.Drawing.Size(78, 28)
        Me.BTN_VENT_GUARDAR.TabIndex = 0
        Me.BTN_VENT_GUARDAR.Text = "Guardar"
        Me.BTN_VENT_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_VENT_SALIR
        '
        Me.BTN_VENT_SALIR.Location = New System.Drawing.Point(123, 234)
        Me.BTN_VENT_SALIR.Name = "BTN_VENT_SALIR"
        Me.BTN_VENT_SALIR.Size = New System.Drawing.Size(78, 28)
        Me.BTN_VENT_SALIR.TabIndex = 1
        Me.BTN_VENT_SALIR.Text = "Salir"
        Me.BTN_VENT_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_VENT_AGREGAR_PROD
        '
        Me.BTN_VENT_AGREGAR_PROD.Location = New System.Drawing.Point(171, 40)
        Me.BTN_VENT_AGREGAR_PROD.Name = "BTN_VENT_AGREGAR_PROD"
        Me.BTN_VENT_AGREGAR_PROD.Size = New System.Drawing.Size(109, 28)
        Me.BTN_VENT_AGREGAR_PROD.TabIndex = 2
        Me.BTN_VENT_AGREGAR_PROD.Text = "Agregar producto"
        Me.BTN_VENT_AGREGAR_PROD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Detalle de la venta"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(309, 115)
        Me.DataGridView1.TabIndex = 6
        '
        'TB_VENT_FECHA
        '
        Me.TB_VENT_FECHA.Location = New System.Drawing.Point(24, 45)
        Me.TB_VENT_FECHA.Name = "TB_VENT_FECHA"
        Me.TB_VENT_FECHA.Size = New System.Drawing.Size(105, 20)
        Me.TB_VENT_FECHA.TabIndex = 7
        '
        'FRM_VENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 272)
        Me.Controls.Add(Me.TB_VENT_FECHA)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_VENT_AGREGAR_PROD)
        Me.Controls.Add(Me.BTN_VENT_SALIR)
        Me.Controls.Add(Me.BTN_VENT_GUARDAR)
        Me.Name = "FRM_VENTAS"
        Me.Text = "VENTAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_VENT_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_VENT_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_VENT_AGREGAR_PROD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TB_VENT_FECHA As System.Windows.Forms.TextBox
End Class
