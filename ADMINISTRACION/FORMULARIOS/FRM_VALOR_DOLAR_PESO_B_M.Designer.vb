<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_VALOR_DOLAR_PESO_B_M
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
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.TB_PESOS = New System.Windows.Forms.TextBox()
        Me.TB_DOLARES = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_VALOR_ACTUAL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_ACTUALIZAR_VALOR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_LIMPIAR)
        Me.GroupBox1.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox1.Controls.Add(Me.BTN_CALCULAR)
        Me.GroupBox1.Controls.Add(Me.TB_PESOS)
        Me.GroupBox1.Controls.Add(Me.TB_DOLARES)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversor"
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(109, 133)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(86, 31)
        Me.BTN_LIMPIAR.TabIndex = 12
        Me.BTN_LIMPIAR.Text = "Limpiar"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SALIR.Location = New System.Drawing.Point(201, 133)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(86, 31)
        Me.BTN_SALIR.TabIndex = 11
        Me.BTN_SALIR.Text = "Salir"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(17, 133)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(86, 31)
        Me.BTN_CALCULAR.TabIndex = 10
        Me.BTN_CALCULAR.Text = "Calcular"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = True
        '
        'TB_PESOS
        '
        Me.TB_PESOS.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PESOS.Location = New System.Drawing.Point(172, 81)
        Me.TB_PESOS.Name = "TB_PESOS"
        Me.TB_PESOS.Size = New System.Drawing.Size(100, 26)
        Me.TB_PESOS.TabIndex = 9
        Me.TB_PESOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_DOLARES
        '
        Me.TB_DOLARES.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DOLARES.Location = New System.Drawing.Point(172, 38)
        Me.TB_DOLARES.Name = "TB_DOLARES"
        Me.TB_DOLARES.Size = New System.Drawing.Size(100, 26)
        Me.TB_DOLARES.TabIndex = 8
        Me.TB_DOLARES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad en Dólares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Equivalencia en Pesos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1 Dólar:"
        '
        'TB_VALOR_ACTUAL
        '
        Me.TB_VALOR_ACTUAL.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VALOR_ACTUAL.Location = New System.Drawing.Point(104, 34)
        Me.TB_VALOR_ACTUAL.Name = "TB_VALOR_ACTUAL"
        Me.TB_VALOR_ACTUAL.Size = New System.Drawing.Size(102, 26)
        Me.TB_VALOR_ACTUAL.TabIndex = 2
        Me.TB_VALOR_ACTUAL.Text = "20,17"
        Me.TB_VALOR_ACTUAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Pesos Argentinos)"
        '
        'BTN_ACTUALIZAR_VALOR
        '
        Me.BTN_ACTUALIZAR_VALOR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTUALIZAR_VALOR.Location = New System.Drawing.Point(223, 31)
        Me.BTN_ACTUALIZAR_VALOR.Name = "BTN_ACTUALIZAR_VALOR"
        Me.BTN_ACTUALIZAR_VALOR.Size = New System.Drawing.Size(86, 31)
        Me.BTN_ACTUALIZAR_VALOR.TabIndex = 4
        Me.BTN_ACTUALIZAR_VALOR.Text = "Actualizar"
        Me.BTN_ACTUALIZAR_VALOR.UseVisualStyleBackColor = True
        '
        'FRM_VALOR_DOLAR_PESO_B_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 315)
        Me.Controls.Add(Me.BTN_ACTUALIZAR_VALOR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_VALOR_ACTUAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_VALOR_DOLAR_PESO_B_M"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " EQUIVALENCIA DOLAR A PESO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_DOLARES As System.Windows.Forms.TextBox
    Friend WithEvents BTN_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_CALCULAR As System.Windows.Forms.Button
    Friend WithEvents TB_PESOS As System.Windows.Forms.TextBox
    Friend WithEvents TB_VALOR_ACTUAL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_ACTUALIZAR_VALOR As System.Windows.Forms.Button
End Class
