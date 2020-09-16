<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_VENTAS_BUSCAR_M_B
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
        Me.BTN_VENTA_BUS_ELIMINAR = New System.Windows.Forms.Button()
        Me.DGV_VENTA_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_VENT_FECHA_BUSCAR = New System.Windows.Forms.RadioButton()
        Me.RB_CLI_DNI_BUSCAR = New System.Windows.Forms.RadioButton()
        Me.DTP_FECHA_VENTA_BUSCAR = New System.Windows.Forms.DateTimePicker()
        Me.TB_VENTA_BUSCAR_DNI_CLI = New System.Windows.Forms.TextBox()
        Me.BTN_VENTA_BUS_SALIR = New System.Windows.Forms.Button()
        Me.DGV_VENTA_DETALLE = New System.Windows.Forms.DataGridView()
        Me.BTN_VENTA_BUS_IMPRIMIR = New System.Windows.Forms.Button()
        CType(Me.DGV_VENTA_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_VENTA_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_VENTA_BUS_ELIMINAR
        '
        Me.BTN_VENTA_BUS_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_ELIMINAR.Location = New System.Drawing.Point(358, 470)
        Me.BTN_VENTA_BUS_ELIMINAR.Name = "BTN_VENTA_BUS_ELIMINAR"
        Me.BTN_VENTA_BUS_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_ELIMINAR.TabIndex = 13
        Me.BTN_VENTA_BUS_ELIMINAR.Text = "Eliminar"
        Me.BTN_VENTA_BUS_ELIMINAR.UseVisualStyleBackColor = True
        '
        'DGV_VENTA_BUSCAR
        '
        Me.DGV_VENTA_BUSCAR.AllowUserToAddRows = False
        Me.DGV_VENTA_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VENTA_BUSCAR.Location = New System.Drawing.Point(12, 108)
        Me.DGV_VENTA_BUSCAR.MultiSelect = False
        Me.DGV_VENTA_BUSCAR.Name = "DGV_VENTA_BUSCAR"
        Me.DGV_VENTA_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VENTA_BUSCAR.Size = New System.Drawing.Size(522, 193)
        Me.DGV_VENTA_BUSCAR.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_VENT_FECHA_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.RB_CLI_DNI_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.DTP_FECHA_VENTA_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_BUSCAR_DNI_CLI)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 76)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Venta"
        '
        'RB_VENT_FECHA_BUSCAR
        '
        Me.RB_VENT_FECHA_BUSCAR.AutoSize = True
        Me.RB_VENT_FECHA_BUSCAR.Location = New System.Drawing.Point(7, 48)
        Me.RB_VENT_FECHA_BUSCAR.Name = "RB_VENT_FECHA_BUSCAR"
        Me.RB_VENT_FECHA_BUSCAR.Size = New System.Drawing.Size(100, 22)
        Me.RB_VENT_FECHA_BUSCAR.TabIndex = 16
        Me.RB_VENT_FECHA_BUSCAR.TabStop = True
        Me.RB_VENT_FECHA_BUSCAR.Text = "Fecha Venta"
        Me.RB_VENT_FECHA_BUSCAR.UseVisualStyleBackColor = True
        '
        'RB_CLI_DNI_BUSCAR
        '
        Me.RB_CLI_DNI_BUSCAR.AutoSize = True
        Me.RB_CLI_DNI_BUSCAR.Location = New System.Drawing.Point(11, 23)
        Me.RB_CLI_DNI_BUSCAR.Name = "RB_CLI_DNI_BUSCAR"
        Me.RB_CLI_DNI_BUSCAR.Size = New System.Drawing.Size(92, 22)
        Me.RB_CLI_DNI_BUSCAR.TabIndex = 15
        Me.RB_CLI_DNI_BUSCAR.TabStop = True
        Me.RB_CLI_DNI_BUSCAR.Text = "Dni Cliente"
        Me.RB_CLI_DNI_BUSCAR.UseVisualStyleBackColor = True
        '
        'DTP_FECHA_VENTA_BUSCAR
        '
        Me.DTP_FECHA_VENTA_BUSCAR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_VENTA_BUSCAR.Location = New System.Drawing.Point(118, 48)
        Me.DTP_FECHA_VENTA_BUSCAR.Name = "DTP_FECHA_VENTA_BUSCAR"
        Me.DTP_FECHA_VENTA_BUSCAR.Size = New System.Drawing.Size(129, 26)
        Me.DTP_FECHA_VENTA_BUSCAR.TabIndex = 14
        '
        'TB_VENTA_BUSCAR_DNI_CLI
        '
        Me.TB_VENTA_BUSCAR_DNI_CLI.Location = New System.Drawing.Point(118, 22)
        Me.TB_VENTA_BUSCAR_DNI_CLI.Name = "TB_VENTA_BUSCAR_DNI_CLI"
        Me.TB_VENTA_BUSCAR_DNI_CLI.Size = New System.Drawing.Size(129, 26)
        Me.TB_VENTA_BUSCAR_DNI_CLI.TabIndex = 2
        '
        'BTN_VENTA_BUS_SALIR
        '
        Me.BTN_VENTA_BUS_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_SALIR.Location = New System.Drawing.Point(449, 470)
        Me.BTN_VENTA_BUS_SALIR.Name = "BTN_VENTA_BUS_SALIR"
        Me.BTN_VENTA_BUS_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_SALIR.TabIndex = 10
        Me.BTN_VENTA_BUS_SALIR.Text = "Salir"
        Me.BTN_VENTA_BUS_SALIR.UseVisualStyleBackColor = True
        '
        'DGV_VENTA_DETALLE
        '
        Me.DGV_VENTA_DETALLE.AllowUserToAddRows = False
        Me.DGV_VENTA_DETALLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VENTA_DETALLE.Location = New System.Drawing.Point(12, 320)
        Me.DGV_VENTA_DETALLE.MultiSelect = False
        Me.DGV_VENTA_DETALLE.Name = "DGV_VENTA_DETALLE"
        Me.DGV_VENTA_DETALLE.ReadOnly = True
        Me.DGV_VENTA_DETALLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VENTA_DETALLE.Size = New System.Drawing.Size(441, 140)
        Me.DGV_VENTA_DETALLE.TabIndex = 14
        '
        'BTN_VENTA_BUS_IMPRIMIR
        '
        Me.BTN_VENTA_BUS_IMPRIMIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_IMPRIMIR.Location = New System.Drawing.Point(267, 470)
        Me.BTN_VENTA_BUS_IMPRIMIR.Name = "BTN_VENTA_BUS_IMPRIMIR"
        Me.BTN_VENTA_BUS_IMPRIMIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_IMPRIMIR.TabIndex = 15
        Me.BTN_VENTA_BUS_IMPRIMIR.Text = "Imprimir"
        Me.BTN_VENTA_BUS_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'FRM_VENTAS_BUSCAR_M_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 509)
        Me.Controls.Add(Me.BTN_VENTA_BUS_IMPRIMIR)
        Me.Controls.Add(Me.DGV_VENTA_DETALLE)
        Me.Controls.Add(Me.BTN_VENTA_BUS_ELIMINAR)
        Me.Controls.Add(Me.DGV_VENTA_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_VENTA_BUS_SALIR)
        Me.Name = "FRM_VENTAS_BUSCAR_M_B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_VENTAS_BUSCAR_M_B"
        CType(Me.DGV_VENTA_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_VENTA_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_VENTA_BUS_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents DGV_VENTA_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_VENTA_BUSCAR_DNI_CLI As System.Windows.Forms.TextBox
    Friend WithEvents BTN_VENTA_BUS_SALIR As System.Windows.Forms.Button
    Friend WithEvents DTP_FECHA_VENTA_BUSCAR As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGV_VENTA_DETALLE As System.Windows.Forms.DataGridView
    Friend WithEvents RB_CLI_DNI_BUSCAR As System.Windows.Forms.RadioButton
    Friend WithEvents RB_VENT_FECHA_BUSCAR As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_VENTA_BUS_IMPRIMIR As System.Windows.Forms.Button
End Class
