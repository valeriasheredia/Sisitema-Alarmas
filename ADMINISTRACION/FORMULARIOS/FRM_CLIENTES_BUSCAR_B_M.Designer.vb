<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CLIENTES_BUSCAR_B_M
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_CLIE_BUSCAR_APE = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_BUSCAR_DNI = New System.Windows.Forms.TextBox()
        Me.RB_CLIE_BUSCAR_APE = New System.Windows.Forms.RadioButton()
        Me.RB_CLIE_BUSCAR_DNI = New System.Windows.Forms.RadioButton()
        Me.BTN_CLIE_BUS_SALIR = New System.Windows.Forms.Button()
        Me.DGV_CLIE_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.BTN_CLIE_BUS_EDITAR = New System.Windows.Forms.Button()
        Me.BTN_CLIE_BUS_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_CLIE_BUS_IMPRIMIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_CLIE_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_CLIE_BUSCAR_APE)
        Me.GroupBox1.Controls.Add(Me.TB_CLIE_BUSCAR_DNI)
        Me.GroupBox1.Controls.Add(Me.RB_CLIE_BUSCAR_APE)
        Me.GroupBox1.Controls.Add(Me.RB_CLIE_BUSCAR_DNI)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'TB_CLIE_BUSCAR_APE
        '
        Me.TB_CLIE_BUSCAR_APE.Location = New System.Drawing.Point(85, 46)
        Me.TB_CLIE_BUSCAR_APE.Name = "TB_CLIE_BUSCAR_APE"
        Me.TB_CLIE_BUSCAR_APE.Size = New System.Drawing.Size(129, 26)
        Me.TB_CLIE_BUSCAR_APE.TabIndex = 3
        '
        'TB_CLIE_BUSCAR_DNI
        '
        Me.TB_CLIE_BUSCAR_DNI.Location = New System.Drawing.Point(85, 22)
        Me.TB_CLIE_BUSCAR_DNI.Name = "TB_CLIE_BUSCAR_DNI"
        Me.TB_CLIE_BUSCAR_DNI.Size = New System.Drawing.Size(129, 26)
        Me.TB_CLIE_BUSCAR_DNI.TabIndex = 2
        '
        'RB_CLIE_BUSCAR_APE
        '
        Me.RB_CLIE_BUSCAR_APE.AutoSize = True
        Me.RB_CLIE_BUSCAR_APE.Location = New System.Drawing.Point(11, 49)
        Me.RB_CLIE_BUSCAR_APE.Name = "RB_CLIE_BUSCAR_APE"
        Me.RB_CLIE_BUSCAR_APE.Size = New System.Drawing.Size(76, 22)
        Me.RB_CLIE_BUSCAR_APE.TabIndex = 1
        Me.RB_CLIE_BUSCAR_APE.TabStop = True
        Me.RB_CLIE_BUSCAR_APE.Text = "Apellido"
        Me.RB_CLIE_BUSCAR_APE.UseVisualStyleBackColor = True
        '
        'RB_CLIE_BUSCAR_DNI
        '
        Me.RB_CLIE_BUSCAR_DNI.AutoSize = True
        Me.RB_CLIE_BUSCAR_DNI.Location = New System.Drawing.Point(11, 26)
        Me.RB_CLIE_BUSCAR_DNI.Name = "RB_CLIE_BUSCAR_DNI"
        Me.RB_CLIE_BUSCAR_DNI.Size = New System.Drawing.Size(52, 22)
        Me.RB_CLIE_BUSCAR_DNI.TabIndex = 0
        Me.RB_CLIE_BUSCAR_DNI.TabStop = True
        Me.RB_CLIE_BUSCAR_DNI.Text = "DNI"
        Me.RB_CLIE_BUSCAR_DNI.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_BUS_SALIR
        '
        Me.BTN_CLIE_BUS_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLIE_BUS_SALIR.Location = New System.Drawing.Point(673, 357)
        Me.BTN_CLIE_BUS_SALIR.Name = "BTN_CLIE_BUS_SALIR"
        Me.BTN_CLIE_BUS_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_CLIE_BUS_SALIR.TabIndex = 1
        Me.BTN_CLIE_BUS_SALIR.Text = "Salir"
        Me.BTN_CLIE_BUS_SALIR.UseVisualStyleBackColor = True
        '
        'DGV_CLIE_BUSCAR
        '
        Me.DGV_CLIE_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CLIE_BUSCAR.Location = New System.Drawing.Point(19, 95)
        Me.DGV_CLIE_BUSCAR.MultiSelect = False
        Me.DGV_CLIE_BUSCAR.Name = "DGV_CLIE_BUSCAR"
        Me.DGV_CLIE_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_CLIE_BUSCAR.Size = New System.Drawing.Size(739, 252)
        Me.DGV_CLIE_BUSCAR.TabIndex = 1
        '
        'BTN_CLIE_BUS_EDITAR
        '
        Me.BTN_CLIE_BUS_EDITAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLIE_BUS_EDITAR.Location = New System.Drawing.Point(19, 357)
        Me.BTN_CLIE_BUS_EDITAR.Name = "BTN_CLIE_BUS_EDITAR"
        Me.BTN_CLIE_BUS_EDITAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_CLIE_BUS_EDITAR.TabIndex = 2
        Me.BTN_CLIE_BUS_EDITAR.Text = "Modificar"
        Me.BTN_CLIE_BUS_EDITAR.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_BUS_ELIMINAR
        '
        Me.BTN_CLIE_BUS_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLIE_BUS_ELIMINAR.Location = New System.Drawing.Point(65, 357)
        Me.BTN_CLIE_BUS_ELIMINAR.Name = "BTN_CLIE_BUS_ELIMINAR"
        Me.BTN_CLIE_BUS_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_CLIE_BUS_ELIMINAR.TabIndex = 3
        Me.BTN_CLIE_BUS_ELIMINAR.Text = "Eliminar"
        Me.BTN_CLIE_BUS_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_BUS_IMPRIMIR
        '
        Me.BTN_CLIE_BUS_IMPRIMIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLIE_BUS_IMPRIMIR.Location = New System.Drawing.Point(582, 357)
        Me.BTN_CLIE_BUS_IMPRIMIR.Name = "BTN_CLIE_BUS_IMPRIMIR"
        Me.BTN_CLIE_BUS_IMPRIMIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_CLIE_BUS_IMPRIMIR.TabIndex = 4
        Me.BTN_CLIE_BUS_IMPRIMIR.Text = "Imprimir"
        Me.BTN_CLIE_BUS_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'FRM_CLIENTES_BUSCAR_B_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 396)
        Me.Controls.Add(Me.BTN_CLIE_BUS_IMPRIMIR)
        Me.Controls.Add(Me.BTN_CLIE_BUS_ELIMINAR)
        Me.Controls.Add(Me.BTN_CLIE_BUS_EDITAR)
        Me.Controls.Add(Me.DGV_CLIE_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_CLIE_BUS_SALIR)
        Me.Name = "FRM_CLIENTES_BUSCAR_B_M"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICAR Y ELIMINAR CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_CLIE_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_CLIE_BUSCAR_APE As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_BUSCAR_DNI As System.Windows.Forms.TextBox
    Friend WithEvents BTN_CLIE_BUS_SALIR As System.Windows.Forms.Button
    Friend WithEvents RB_CLIE_BUSCAR_APE As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CLIE_BUSCAR_DNI As System.Windows.Forms.RadioButton
    Friend WithEvents DGV_CLIE_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_CLIE_BUS_EDITAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CLIE_BUS_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CLIE_BUS_IMPRIMIR As System.Windows.Forms.Button
End Class
