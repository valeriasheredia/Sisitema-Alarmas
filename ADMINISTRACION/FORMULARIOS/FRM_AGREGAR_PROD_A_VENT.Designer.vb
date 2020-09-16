<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AGREGAR_PROD_A_VENT
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
        Me.BTN_AGREGAR_PROD_LIMPIAR = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTN_AGREGAR_PROD_BUSCAR = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BTN_AGREGAR_PROD_CARGAR = New System.Windows.Forms.Button()
        Me.BTN_AGREGAR_PROD_SALIR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_AGREGAR_PROD_LIMPIAR)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.BTN_AGREGAR_PROD_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'BTN_AGREGAR_PROD_LIMPIAR
        '
        Me.BTN_AGREGAR_PROD_LIMPIAR.Location = New System.Drawing.Point(243, 45)
        Me.BTN_AGREGAR_PROD_LIMPIAR.Name = "BTN_AGREGAR_PROD_LIMPIAR"
        Me.BTN_AGREGAR_PROD_LIMPIAR.Size = New System.Drawing.Size(100, 22)
        Me.BTN_AGREGAR_PROD_LIMPIAR.TabIndex = 4
        Me.BTN_AGREGAR_PROD_LIMPIAR.Text = "Limpiar"
        Me.BTN_AGREGAR_PROD_LIMPIAR.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 20)
        Me.TextBox1.TabIndex = 3
        '
        'BTN_AGREGAR_PROD_BUSCAR
        '
        Me.BTN_AGREGAR_PROD_BUSCAR.Location = New System.Drawing.Point(137, 45)
        Me.BTN_AGREGAR_PROD_BUSCAR.Name = "BTN_AGREGAR_PROD_BUSCAR"
        Me.BTN_AGREGAR_PROD_BUSCAR.Size = New System.Drawing.Size(100, 22)
        Me.BTN_AGREGAR_PROD_BUSCAR.TabIndex = 2
        Me.BTN_AGREGAR_PROD_BUSCAR.Text = "Buscar"
        Me.BTN_AGREGAR_PROD_BUSCAR.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(42, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Código"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(43, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descripción"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BTN_AGREGAR_PROD_CARGAR
        '
        Me.BTN_AGREGAR_PROD_CARGAR.Location = New System.Drawing.Point(26, 292)
        Me.BTN_AGREGAR_PROD_CARGAR.Name = "BTN_AGREGAR_PROD_CARGAR"
        Me.BTN_AGREGAR_PROD_CARGAR.Size = New System.Drawing.Size(100, 22)
        Me.BTN_AGREGAR_PROD_CARGAR.TabIndex = 4
        Me.BTN_AGREGAR_PROD_CARGAR.Text = "Cargar"
        Me.BTN_AGREGAR_PROD_CARGAR.UseVisualStyleBackColor = True
        '
        'BTN_AGREGAR_PROD_SALIR
        '
        Me.BTN_AGREGAR_PROD_SALIR.Location = New System.Drawing.Point(152, 292)
        Me.BTN_AGREGAR_PROD_SALIR.Name = "BTN_AGREGAR_PROD_SALIR"
        Me.BTN_AGREGAR_PROD_SALIR.Size = New System.Drawing.Size(100, 22)
        Me.BTN_AGREGAR_PROD_SALIR.TabIndex = 5
        Me.BTN_AGREGAR_PROD_SALIR.Text = "Salir"
        Me.BTN_AGREGAR_PROD_SALIR.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 202)
        Me.DataGridView1.TabIndex = 6
        '
        'FRM_AGREGAR_PROD_A_VENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 354)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_AGREGAR_PROD_SALIR)
        Me.Controls.Add(Me.BTN_AGREGAR_PROD_CARGAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_AGREGAR_PROD_A_VENT"
        Me.Text = "AGREGAR PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_AGREGAR_PROD_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_AGREGAR_PROD_CARGAR As System.Windows.Forms.Button
    Friend WithEvents BTN_AGREGAR_PROD_SALIR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_AGREGAR_PROD_LIMPIAR As System.Windows.Forms.Button
End Class
