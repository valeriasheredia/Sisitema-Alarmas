<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DEPOSITOS_BUSCAR_B_M
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
        Me.BTN_DEPO_BUS_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_DEPO_BUS_EDITAR = New System.Windows.Forms.Button()
        Me.DGV_DEPO_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_DEPO_BUSCAR_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_DEPO_BUSCAR_NOMBRE = New System.Windows.Forms.TextBox()
        Me.RB_DEPO_BUSCAR_CODIGO = New System.Windows.Forms.RadioButton()
        Me.RB_DEPO_BUSCAR_NOMBRE = New System.Windows.Forms.RadioButton()
        Me.BTN_DEPO_BUS_SALIR = New System.Windows.Forms.Button()
        CType(Me.DGV_DEPO_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_DEPO_BUS_ELIMINAR
        '
        Me.BTN_DEPO_BUS_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DEPO_BUS_ELIMINAR.Location = New System.Drawing.Point(72, 356)
        Me.BTN_DEPO_BUS_ELIMINAR.Name = "BTN_DEPO_BUS_ELIMINAR"
        Me.BTN_DEPO_BUS_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_DEPO_BUS_ELIMINAR.TabIndex = 18
        Me.BTN_DEPO_BUS_ELIMINAR.Text = "Eliminar"
        Me.BTN_DEPO_BUS_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_DEPO_BUS_EDITAR
        '
        Me.BTN_DEPO_BUS_EDITAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DEPO_BUS_EDITAR.Location = New System.Drawing.Point(26, 356)
        Me.BTN_DEPO_BUS_EDITAR.Name = "BTN_DEPO_BUS_EDITAR"
        Me.BTN_DEPO_BUS_EDITAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_DEPO_BUS_EDITAR.TabIndex = 17
        Me.BTN_DEPO_BUS_EDITAR.Text = "Modificar"
        Me.BTN_DEPO_BUS_EDITAR.UseVisualStyleBackColor = True
        '
        'DGV_DEPO_BUSCAR
        '
        Me.DGV_DEPO_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DEPO_BUSCAR.Location = New System.Drawing.Point(26, 94)
        Me.DGV_DEPO_BUSCAR.Name = "DGV_DEPO_BUSCAR"
        Me.DGV_DEPO_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DEPO_BUSCAR.Size = New System.Drawing.Size(739, 252)
        Me.DGV_DEPO_BUSCAR.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_DEPO_BUSCAR_CODIGO)
        Me.GroupBox1.Controls.Add(Me.TB_DEPO_BUSCAR_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.RB_DEPO_BUSCAR_CODIGO)
        Me.GroupBox1.Controls.Add(Me.RB_DEPO_BUSCAR_NOMBRE)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 76)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Depósito"
        '
        'TB_DEPO_BUSCAR_CODIGO
        '
        Me.TB_DEPO_BUSCAR_CODIGO.Location = New System.Drawing.Point(98, 46)
        Me.TB_DEPO_BUSCAR_CODIGO.Name = "TB_DEPO_BUSCAR_CODIGO"
        Me.TB_DEPO_BUSCAR_CODIGO.Size = New System.Drawing.Size(129, 26)
        Me.TB_DEPO_BUSCAR_CODIGO.TabIndex = 3
        '
        'TB_DEPO_BUSCAR_NOMBRE
        '
        Me.TB_DEPO_BUSCAR_NOMBRE.Location = New System.Drawing.Point(98, 22)
        Me.TB_DEPO_BUSCAR_NOMBRE.Name = "TB_DEPO_BUSCAR_NOMBRE"
        Me.TB_DEPO_BUSCAR_NOMBRE.Size = New System.Drawing.Size(129, 26)
        Me.TB_DEPO_BUSCAR_NOMBRE.TabIndex = 2
        '
        'RB_DEPO_BUSCAR_CODIGO
        '
        Me.RB_DEPO_BUSCAR_CODIGO.AutoSize = True
        Me.RB_DEPO_BUSCAR_CODIGO.Location = New System.Drawing.Point(11, 49)
        Me.RB_DEPO_BUSCAR_CODIGO.Name = "RB_DEPO_BUSCAR_CODIGO"
        Me.RB_DEPO_BUSCAR_CODIGO.Size = New System.Drawing.Size(79, 22)
        Me.RB_DEPO_BUSCAR_CODIGO.TabIndex = 1
        Me.RB_DEPO_BUSCAR_CODIGO.TabStop = True
        Me.RB_DEPO_BUSCAR_CODIGO.Text = "CODIGO"
        Me.RB_DEPO_BUSCAR_CODIGO.UseVisualStyleBackColor = True
        '
        'RB_DEPO_BUSCAR_NOMBRE
        '
        Me.RB_DEPO_BUSCAR_NOMBRE.AutoSize = True
        Me.RB_DEPO_BUSCAR_NOMBRE.Location = New System.Drawing.Point(11, 26)
        Me.RB_DEPO_BUSCAR_NOMBRE.Name = "RB_DEPO_BUSCAR_NOMBRE"
        Me.RB_DEPO_BUSCAR_NOMBRE.Size = New System.Drawing.Size(81, 22)
        Me.RB_DEPO_BUSCAR_NOMBRE.TabIndex = 0
        Me.RB_DEPO_BUSCAR_NOMBRE.TabStop = True
        Me.RB_DEPO_BUSCAR_NOMBRE.Text = "NOMBRE"
        Me.RB_DEPO_BUSCAR_NOMBRE.UseVisualStyleBackColor = True
        '
        'BTN_DEPO_BUS_SALIR
        '
        Me.BTN_DEPO_BUS_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DEPO_BUS_SALIR.Location = New System.Drawing.Point(680, 356)
        Me.BTN_DEPO_BUS_SALIR.Name = "BTN_DEPO_BUS_SALIR"
        Me.BTN_DEPO_BUS_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_DEPO_BUS_SALIR.TabIndex = 15
        Me.BTN_DEPO_BUS_SALIR.Text = "Salir"
        Me.BTN_DEPO_BUS_SALIR.UseVisualStyleBackColor = True
        '
        'FRM_DEPOSITOS_BUSCAR_B_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 404)
        Me.Controls.Add(Me.BTN_DEPO_BUS_ELIMINAR)
        Me.Controls.Add(Me.BTN_DEPO_BUS_EDITAR)
        Me.Controls.Add(Me.DGV_DEPO_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_DEPO_BUS_SALIR)
        Me.Name = "FRM_DEPOSITOS_BUSCAR_B_M"
        Me.Text = "MODIFICAR Y ELIMINAR DEPOSITOS"
        CType(Me.DGV_DEPO_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_DEPO_BUS_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_DEPO_BUS_EDITAR As System.Windows.Forms.Button
    Friend WithEvents DGV_DEPO_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_DEPO_BUSCAR_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_DEPO_BUSCAR_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents RB_DEPO_BUSCAR_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents RB_DEPO_BUSCAR_NOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_DEPO_BUS_SALIR As System.Windows.Forms.Button
End Class
