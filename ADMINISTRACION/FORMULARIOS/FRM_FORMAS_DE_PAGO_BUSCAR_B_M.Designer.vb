<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMAS_DE_PAGO_BUSCAR_B_M
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
        Me.BTN_FORMA_PAGO_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_FORMA_PAGO_EDITAR = New System.Windows.Forms.Button()
        Me.DGV_FORMA_DE_PAGO_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_FORMA_PAGO_BUSCAR_DESC = New System.Windows.Forms.TextBox()
        Me.BTN_FORMA_PAGO_SALIR = New System.Windows.Forms.Button()
        CType(Me.DGV_FORMA_DE_PAGO_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_FORMA_PAGO_ELIMINAR
        '
        Me.BTN_FORMA_PAGO_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FORMA_PAGO_ELIMINAR.Location = New System.Drawing.Point(124, 301)
        Me.BTN_FORMA_PAGO_ELIMINAR.Name = "BTN_FORMA_PAGO_ELIMINAR"
        Me.BTN_FORMA_PAGO_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_FORMA_PAGO_ELIMINAR.TabIndex = 8
        Me.BTN_FORMA_PAGO_ELIMINAR.Text = "Eliminar"
        Me.BTN_FORMA_PAGO_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_FORMA_PAGO_EDITAR
        '
        Me.BTN_FORMA_PAGO_EDITAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FORMA_PAGO_EDITAR.Location = New System.Drawing.Point(33, 301)
        Me.BTN_FORMA_PAGO_EDITAR.Name = "BTN_FORMA_PAGO_EDITAR"
        Me.BTN_FORMA_PAGO_EDITAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_FORMA_PAGO_EDITAR.TabIndex = 7
        Me.BTN_FORMA_PAGO_EDITAR.Text = "Modificar"
        Me.BTN_FORMA_PAGO_EDITAR.UseVisualStyleBackColor = True
        '
        'DGV_FORMA_DE_PAGO_BUSCAR
        '
        Me.DGV_FORMA_DE_PAGO_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FORMA_DE_PAGO_BUSCAR.Location = New System.Drawing.Point(26, 94)
        Me.DGV_FORMA_DE_PAGO_BUSCAR.Name = "DGV_FORMA_DE_PAGO_BUSCAR"
        Me.DGV_FORMA_DE_PAGO_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_FORMA_DE_PAGO_BUSCAR.Size = New System.Drawing.Size(275, 191)
        Me.DGV_FORMA_DE_PAGO_BUSCAR.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_FORMA_PAGO_BUSCAR_DESC)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 64)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Forma de Pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción"
        '
        'TB_FORMA_PAGO_BUSCAR_DESC
        '
        Me.TB_FORMA_PAGO_BUSCAR_DESC.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FORMA_PAGO_BUSCAR_DESC.Location = New System.Drawing.Point(91, 25)
        Me.TB_FORMA_PAGO_BUSCAR_DESC.Name = "TB_FORMA_PAGO_BUSCAR_DESC"
        Me.TB_FORMA_PAGO_BUSCAR_DESC.Size = New System.Drawing.Size(174, 26)
        Me.TB_FORMA_PAGO_BUSCAR_DESC.TabIndex = 2
        '
        'BTN_FORMA_PAGO_SALIR
        '
        Me.BTN_FORMA_PAGO_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FORMA_PAGO_SALIR.Location = New System.Drawing.Point(216, 301)
        Me.BTN_FORMA_PAGO_SALIR.Name = "BTN_FORMA_PAGO_SALIR"
        Me.BTN_FORMA_PAGO_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_FORMA_PAGO_SALIR.TabIndex = 5
        Me.BTN_FORMA_PAGO_SALIR.Text = "Salir"
        Me.BTN_FORMA_PAGO_SALIR.UseVisualStyleBackColor = True
        '
        'FRM_FORMAS_DE_PAGO_BUSCAR_B_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 352)
        Me.Controls.Add(Me.BTN_FORMA_PAGO_ELIMINAR)
        Me.Controls.Add(Me.BTN_FORMA_PAGO_EDITAR)
        Me.Controls.Add(Me.DGV_FORMA_DE_PAGO_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_FORMA_PAGO_SALIR)
        Me.Name = "FRM_FORMAS_DE_PAGO_BUSCAR_B_M"
        Me.Text = "MODIFICAR Y ELIMINAR FORMAS DE PAGO"
        CType(Me.DGV_FORMA_DE_PAGO_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_FORMA_PAGO_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_FORMA_PAGO_EDITAR As System.Windows.Forms.Button
    Friend WithEvents DGV_FORMA_DE_PAGO_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_FORMA_PAGO_BUSCAR_DESC As System.Windows.Forms.TextBox
    Friend WithEvents BTN_FORMA_PAGO_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
