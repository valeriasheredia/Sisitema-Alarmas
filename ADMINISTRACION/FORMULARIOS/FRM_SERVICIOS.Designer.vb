<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SERVICIOS
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
        Me.BTN_SERV_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_SERV_SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_SERV_DIRECCION = New System.Windows.Forms.TextBox()
        Me.TB_SERV_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.TB_SERV_TEL_1 = New System.Windows.Forms.TextBox()
        Me.TB_SERV_TEL_2 = New System.Windows.Forms.TextBox()
        Me.TB_SERV_TEL_3 = New System.Windows.Forms.TextBox()
        Me.TB_SERV_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.CB_SERV_DNI_CLIENTE = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_SERV_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_SERV_GUARDAR
        '
        Me.BTN_SERV_GUARDAR.Location = New System.Drawing.Point(32, 485)
        Me.BTN_SERV_GUARDAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_SERV_GUARDAR.Name = "BTN_SERV_GUARDAR"
        Me.BTN_SERV_GUARDAR.Size = New System.Drawing.Size(91, 35)
        Me.BTN_SERV_GUARDAR.TabIndex = 0
        Me.BTN_SERV_GUARDAR.Text = "Guardar"
        Me.BTN_SERV_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_SERV_SALIR
        '
        Me.BTN_SERV_SALIR.Location = New System.Drawing.Point(195, 485)
        Me.BTN_SERV_SALIR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_SERV_SALIR.Name = "BTN_SERV_SALIR"
        Me.BTN_SERV_SALIR.Size = New System.Drawing.Size(91, 35)
        Me.BTN_SERV_SALIR.TabIndex = 1
        Me.BTN_SERV_SALIR.Text = "Salir"
        Me.BTN_SERV_SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dirección del servicio*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Localidad del servicio*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono 1*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Teléfono 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Teléfono 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Descripción del servicio*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 159)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cliente*"
        '
        'TB_SERV_DIRECCION
        '
        Me.TB_SERV_DIRECCION.Location = New System.Drawing.Point(32, 46)
        Me.TB_SERV_DIRECCION.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_DIRECCION.Name = "TB_SERV_DIRECCION"
        Me.TB_SERV_DIRECCION.Size = New System.Drawing.Size(185, 26)
        Me.TB_SERV_DIRECCION.TabIndex = 9
        '
        'TB_SERV_LOCALIDAD
        '
        Me.TB_SERV_LOCALIDAD.Location = New System.Drawing.Point(247, 46)
        Me.TB_SERV_LOCALIDAD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_LOCALIDAD.Name = "TB_SERV_LOCALIDAD"
        Me.TB_SERV_LOCALIDAD.Size = New System.Drawing.Size(168, 26)
        Me.TB_SERV_LOCALIDAD.TabIndex = 10
        '
        'TB_SERV_TEL_1
        '
        Me.TB_SERV_TEL_1.Location = New System.Drawing.Point(32, 110)
        Me.TB_SERV_TEL_1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_TEL_1.Name = "TB_SERV_TEL_1"
        Me.TB_SERV_TEL_1.Size = New System.Drawing.Size(159, 26)
        Me.TB_SERV_TEL_1.TabIndex = 11
        '
        'TB_SERV_TEL_2
        '
        Me.TB_SERV_TEL_2.Location = New System.Drawing.Point(247, 110)
        Me.TB_SERV_TEL_2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_TEL_2.Name = "TB_SERV_TEL_2"
        Me.TB_SERV_TEL_2.Size = New System.Drawing.Size(168, 26)
        Me.TB_SERV_TEL_2.TabIndex = 12
        '
        'TB_SERV_TEL_3
        '
        Me.TB_SERV_TEL_3.Location = New System.Drawing.Point(32, 181)
        Me.TB_SERV_TEL_3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_TEL_3.Name = "TB_SERV_TEL_3"
        Me.TB_SERV_TEL_3.Size = New System.Drawing.Size(159, 26)
        Me.TB_SERV_TEL_3.TabIndex = 13
        '
        'TB_SERV_DESCRIPCION
        '
        Me.TB_SERV_DESCRIPCION.Location = New System.Drawing.Point(32, 247)
        Me.TB_SERV_DESCRIPCION.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_SERV_DESCRIPCION.Multiline = True
        Me.TB_SERV_DESCRIPCION.Name = "TB_SERV_DESCRIPCION"
        Me.TB_SERV_DESCRIPCION.Size = New System.Drawing.Size(383, 199)
        Me.TB_SERV_DESCRIPCION.TabIndex = 14
        '
        'CB_SERV_DNI_CLIENTE
        '
        Me.CB_SERV_DNI_CLIENTE.FormattingEnabled = True
        Me.CB_SERV_DNI_CLIENTE.Location = New System.Drawing.Point(247, 181)
        Me.CB_SERV_DNI_CLIENTE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_SERV_DNI_CLIENTE.Name = "CB_SERV_DNI_CLIENTE"
        Me.CB_SERV_DNI_CLIENTE.Size = New System.Drawing.Size(168, 26)
        Me.CB_SERV_DNI_CLIENTE.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 466)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "*Datos obligatorios"
        '
        'BTN_SERV_ACTUALIZAR
        '
        Me.BTN_SERV_ACTUALIZAR.Location = New System.Drawing.Point(84, 485)
        Me.BTN_SERV_ACTUALIZAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_SERV_ACTUALIZAR.Name = "BTN_SERV_ACTUALIZAR"
        Me.BTN_SERV_ACTUALIZAR.Size = New System.Drawing.Size(91, 35)
        Me.BTN_SERV_ACTUALIZAR.TabIndex = 23
        Me.BTN_SERV_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_SERV_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'FRM_SERVICIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 541)
        Me.Controls.Add(Me.BTN_SERV_ACTUALIZAR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CB_SERV_DNI_CLIENTE)
        Me.Controls.Add(Me.TB_SERV_DESCRIPCION)
        Me.Controls.Add(Me.TB_SERV_TEL_3)
        Me.Controls.Add(Me.TB_SERV_TEL_2)
        Me.Controls.Add(Me.TB_SERV_TEL_1)
        Me.Controls.Add(Me.TB_SERV_LOCALIDAD)
        Me.Controls.Add(Me.TB_SERV_DIRECCION)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_SERV_SALIR)
        Me.Controls.Add(Me.BTN_SERV_GUARDAR)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FRM_SERVICIOS"
        Me.Text = "SERVICIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_SERV_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SERV_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_SERV_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_SERV_LOCALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TB_SERV_TEL_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_SERV_TEL_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_SERV_TEL_3 As System.Windows.Forms.TextBox
    Friend WithEvents TB_SERV_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents CB_SERV_DNI_CLIENTE As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BTN_SERV_ACTUALIZAR As System.Windows.Forms.Button
End Class
