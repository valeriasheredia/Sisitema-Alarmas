<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMAS_DE_PAGO
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
        Me.TB_FDP_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_FDP_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.TB_FDP_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_FDP_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_FDP_SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Forma de pago*"
        '
        'TB_FDP_DESCRIPCION
        '
        Me.TB_FDP_DESCRIPCION.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FDP_DESCRIPCION.Location = New System.Drawing.Point(30, 51)
        Me.TB_FDP_DESCRIPCION.Name = "TB_FDP_DESCRIPCION"
        Me.TB_FDP_DESCRIPCION.Size = New System.Drawing.Size(276, 26)
        Me.TB_FDP_DESCRIPCION.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*Dato obligatorio"
        '
        'BTN_FDP_ACTUALIZAR
        '
        Me.BTN_FDP_ACTUALIZAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FDP_ACTUALIZAR.Location = New System.Drawing.Point(116, 125)
        Me.BTN_FDP_ACTUALIZAR.Name = "BTN_FDP_ACTUALIZAR"
        Me.BTN_FDP_ACTUALIZAR.Size = New System.Drawing.Size(100, 35)
        Me.BTN_FDP_ACTUALIZAR.TabIndex = 6
        Me.BTN_FDP_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_FDP_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'TB_FDP_ID
        '
        Me.TB_FDP_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FDP_ID.Location = New System.Drawing.Point(222, 10)
        Me.TB_FDP_ID.Name = "TB_FDP_ID"
        Me.TB_FDP_ID.Size = New System.Drawing.Size(57, 26)
        Me.TB_FDP_ID.TabIndex = 7
        Me.TB_FDP_ID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id"
        Me.Label2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_FDP_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 110)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BTN_FDP_GUARDAR
        '
        Me.BTN_FDP_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FDP_GUARDAR.Location = New System.Drawing.Point(110, 125)
        Me.BTN_FDP_GUARDAR.Name = "BTN_FDP_GUARDAR"
        Me.BTN_FDP_GUARDAR.Size = New System.Drawing.Size(100, 35)
        Me.BTN_FDP_GUARDAR.TabIndex = 10
        Me.BTN_FDP_GUARDAR.Text = "Guardar"
        Me.BTN_FDP_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_FDP_SALIR
        '
        Me.BTN_FDP_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FDP_SALIR.Location = New System.Drawing.Point(222, 125)
        Me.BTN_FDP_SALIR.Name = "BTN_FDP_SALIR"
        Me.BTN_FDP_SALIR.Size = New System.Drawing.Size(100, 35)
        Me.BTN_FDP_SALIR.TabIndex = 11
        Me.BTN_FDP_SALIR.Text = "Salir"
        Me.BTN_FDP_SALIR.UseVisualStyleBackColor = True
        '
        'FRM_FORMAS_DE_PAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 168)
        Me.Controls.Add(Me.BTN_FDP_SALIR)
        Me.Controls.Add(Me.BTN_FDP_GUARDAR)
        Me.Controls.Add(Me.BTN_FDP_ACTUALIZAR)
        Me.Controls.Add(Me.TB_FDP_DESCRIPCION)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_FORMAS_DE_PAGO"
        Me.Text = "CARGAR FORMA DE PAGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_FDP_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_FDP_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents TB_FDP_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_FDP_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_FDP_SALIR As System.Windows.Forms.Button
End Class
