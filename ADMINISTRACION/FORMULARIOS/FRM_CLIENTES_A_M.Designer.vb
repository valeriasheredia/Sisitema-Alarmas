<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CLIENTES_A_M
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
        Me.TB_CLIE_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_NOMBRES = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_DIRECCION = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_TEL_1 = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_TEL_2 = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_MAIL = New System.Windows.Forms.TextBox()
        Me.TB_CLIE_DNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_CLIE_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_CLIE_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_CLIE_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_CLIE_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.TB_CLIE_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_CLIE_CONTRATO = New System.Windows.Forms.TextBox()
        Me.GB_CLIE_ABONADO = New System.Windows.Forms.GroupBox()
        Me.DTP_CLIE_FECHA_ALTA = New System.Windows.Forms.DateTimePicker()
        Me.CB_CLIE_TIPO = New System.Windows.Forms.ComboBox()
        Me.TIPO = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CHB_CLIE_ABONADO = New System.Windows.Forms.CheckBox()
        Me.GB_CLIE_ABONADO.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_CLIE_APELLIDO
        '
        Me.TB_CLIE_APELLIDO.Location = New System.Drawing.Point(340, 110)
        Me.TB_CLIE_APELLIDO.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_APELLIDO.Name = "TB_CLIE_APELLIDO"
        Me.TB_CLIE_APELLIDO.Size = New System.Drawing.Size(310, 26)
        Me.TB_CLIE_APELLIDO.TabIndex = 3
        '
        'TB_CLIE_NOMBRES
        '
        Me.TB_CLIE_NOMBRES.Location = New System.Drawing.Point(16, 110)
        Me.TB_CLIE_NOMBRES.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_NOMBRES.Name = "TB_CLIE_NOMBRES"
        Me.TB_CLIE_NOMBRES.Size = New System.Drawing.Size(310, 26)
        Me.TB_CLIE_NOMBRES.TabIndex = 2
        '
        'TB_CLIE_DIRECCION
        '
        Me.TB_CLIE_DIRECCION.Location = New System.Drawing.Point(16, 164)
        Me.TB_CLIE_DIRECCION.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_DIRECCION.Name = "TB_CLIE_DIRECCION"
        Me.TB_CLIE_DIRECCION.Size = New System.Drawing.Size(306, 26)
        Me.TB_CLIE_DIRECCION.TabIndex = 4
        '
        'TB_CLIE_LOCALIDAD
        '
        Me.TB_CLIE_LOCALIDAD.Location = New System.Drawing.Point(344, 164)
        Me.TB_CLIE_LOCALIDAD.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_LOCALIDAD.Name = "TB_CLIE_LOCALIDAD"
        Me.TB_CLIE_LOCALIDAD.Size = New System.Drawing.Size(306, 26)
        Me.TB_CLIE_LOCALIDAD.TabIndex = 5
        '
        'TB_CLIE_TEL_1
        '
        Me.TB_CLIE_TEL_1.Location = New System.Drawing.Point(16, 235)
        Me.TB_CLIE_TEL_1.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_TEL_1.Name = "TB_CLIE_TEL_1"
        Me.TB_CLIE_TEL_1.Size = New System.Drawing.Size(190, 26)
        Me.TB_CLIE_TEL_1.TabIndex = 6
        '
        'TB_CLIE_TEL_2
        '
        Me.TB_CLIE_TEL_2.Location = New System.Drawing.Point(226, 235)
        Me.TB_CLIE_TEL_2.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_TEL_2.Name = "TB_CLIE_TEL_2"
        Me.TB_CLIE_TEL_2.Size = New System.Drawing.Size(186, 26)
        Me.TB_CLIE_TEL_2.TabIndex = 7
        '
        'TB_CLIE_MAIL
        '
        Me.TB_CLIE_MAIL.Location = New System.Drawing.Point(20, 289)
        Me.TB_CLIE_MAIL.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_MAIL.Name = "TB_CLIE_MAIL"
        Me.TB_CLIE_MAIL.Size = New System.Drawing.Size(392, 26)
        Me.TB_CLIE_MAIL.TabIndex = 8
        '
        'TB_CLIE_DNI
        '
        Me.TB_CLIE_DNI.Location = New System.Drawing.Point(16, 49)
        Me.TB_CLIE_DNI.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_DNI.MaxLength = 8
        Me.TB_CLIE_DNI.Name = "TB_CLIE_DNI"
        Me.TB_CLIE_DNI.Size = New System.Drawing.Size(138, 26)
        Me.TB_CLIE_DNI.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DNI*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dirección*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Localidad*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 213)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Teléfono 1*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 213)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Teléfono 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 267)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'BTN_CLIE_GUARDAR
        '
        Me.BTN_CLIE_GUARDAR.Location = New System.Drawing.Point(20, 353)
        Me.BTN_CLIE_GUARDAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_CLIE_GUARDAR.Name = "BTN_CLIE_GUARDAR"
        Me.BTN_CLIE_GUARDAR.Size = New System.Drawing.Size(116, 40)
        Me.BTN_CLIE_GUARDAR.TabIndex = 16
        Me.BTN_CLIE_GUARDAR.Text = "Guardar"
        Me.BTN_CLIE_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_CANCELAR
        '
        Me.BTN_CLIE_CANCELAR.Location = New System.Drawing.Point(541, 353)
        Me.BTN_CLIE_CANCELAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_CLIE_CANCELAR.Name = "BTN_CLIE_CANCELAR"
        Me.BTN_CLIE_CANCELAR.Size = New System.Drawing.Size(116, 40)
        Me.BTN_CLIE_CANCELAR.TabIndex = 18
        Me.BTN_CLIE_CANCELAR.Text = "Cancelar"
        Me.BTN_CLIE_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_LIMPIAR
        '
        Me.BTN_CLIE_LIMPIAR.Location = New System.Drawing.Point(417, 353)
        Me.BTN_CLIE_LIMPIAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_CLIE_LIMPIAR.Name = "BTN_CLIE_LIMPIAR"
        Me.BTN_CLIE_LIMPIAR.Size = New System.Drawing.Size(116, 40)
        Me.BTN_CLIE_LIMPIAR.TabIndex = 19
        Me.BTN_CLIE_LIMPIAR.Text = "Limpiar"
        Me.BTN_CLIE_LIMPIAR.UseVisualStyleBackColor = True
        '
        'BTN_CLIE_ACTUALIZAR
        '
        Me.BTN_CLIE_ACTUALIZAR.Location = New System.Drawing.Point(65, 353)
        Me.BTN_CLIE_ACTUALIZAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_CLIE_ACTUALIZAR.Name = "BTN_CLIE_ACTUALIZAR"
        Me.BTN_CLIE_ACTUALIZAR.Size = New System.Drawing.Size(116, 40)
        Me.BTN_CLIE_ACTUALIZAR.TabIndex = 20
        Me.BTN_CLIE_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_CLIE_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'TB_CLIE_ID
        '
        Me.TB_CLIE_ID.Location = New System.Drawing.Point(417, 49)
        Me.TB_CLIE_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_ID.Name = "TB_CLIE_ID"
        Me.TB_CLIE_ID.Size = New System.Drawing.Size(138, 26)
        Me.TB_CLIE_ID.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(418, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "* Datos obligatorios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombres*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 17)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Nº Contrato*"
        '
        'TB_CLIE_CONTRATO
        '
        Me.TB_CLIE_CONTRATO.Location = New System.Drawing.Point(14, 39)
        Me.TB_CLIE_CONTRATO.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_CLIE_CONTRATO.Name = "TB_CLIE_CONTRATO"
        Me.TB_CLIE_CONTRATO.Size = New System.Drawing.Size(138, 26)
        Me.TB_CLIE_CONTRATO.TabIndex = 25
        '
        'GB_CLIE_ABONADO
        '
        Me.GB_CLIE_ABONADO.Controls.Add(Me.DTP_CLIE_FECHA_ALTA)
        Me.GB_CLIE_ABONADO.Controls.Add(Me.CB_CLIE_TIPO)
        Me.GB_CLIE_ABONADO.Controls.Add(Me.TIPO)
        Me.GB_CLIE_ABONADO.Controls.Add(Me.Label12)
        Me.GB_CLIE_ABONADO.Controls.Add(Me.Label11)
        Me.GB_CLIE_ABONADO.Controls.Add(Me.TB_CLIE_CONTRATO)
        Me.GB_CLIE_ABONADO.Location = New System.Drawing.Point(423, 218)
        Me.GB_CLIE_ABONADO.Name = "GB_CLIE_ABONADO"
        Me.GB_CLIE_ABONADO.Size = New System.Drawing.Size(226, 130)
        Me.GB_CLIE_ABONADO.TabIndex = 27
        Me.GB_CLIE_ABONADO.TabStop = False
        '
        'DTP_CLIE_FECHA_ALTA
        '
        Me.DTP_CLIE_FECHA_ALTA.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_CLIE_FECHA_ALTA.Location = New System.Drawing.Point(14, 90)
        Me.DTP_CLIE_FECHA_ALTA.Name = "DTP_CLIE_FECHA_ALTA"
        Me.DTP_CLIE_FECHA_ALTA.Size = New System.Drawing.Size(202, 24)
        Me.DTP_CLIE_FECHA_ALTA.TabIndex = 29
        '
        'CB_CLIE_TIPO
        '
        Me.CB_CLIE_TIPO.FormattingEnabled = True
        Me.CB_CLIE_TIPO.Items.AddRange(New Object() {"1", "2"})
        Me.CB_CLIE_TIPO.Location = New System.Drawing.Point(162, 39)
        Me.CB_CLIE_TIPO.Name = "CB_CLIE_TIPO"
        Me.CB_CLIE_TIPO.Size = New System.Drawing.Size(54, 26)
        Me.CB_CLIE_TIPO.TabIndex = 31
        '
        'TIPO
        '
        Me.TIPO.AutoSize = True
        Me.TIPO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPO.Location = New System.Drawing.Point(163, 17)
        Me.TIPO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Size = New System.Drawing.Size(42, 18)
        Me.TIPO.TabIndex = 30
        Me.TIPO.Text = "Tipo*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 69)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Alta*"
        '
        'CHB_CLIE_ABONADO
        '
        Me.CHB_CLIE_ABONADO.AutoSize = True
        Me.CHB_CLIE_ABONADO.Location = New System.Drawing.Point(425, 208)
        Me.CHB_CLIE_ABONADO.Name = "CHB_CLIE_ABONADO"
        Me.CHB_CLIE_ABONADO.Size = New System.Drawing.Size(80, 22)
        Me.CHB_CLIE_ABONADO.TabIndex = 28
        Me.CHB_CLIE_ABONADO.Text = "Abonado"
        Me.CHB_CLIE_ABONADO.UseVisualStyleBackColor = True
        '
        'FRM_CLIENTES_A_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 401)
        Me.Controls.Add(Me.CHB_CLIE_ABONADO)
        Me.Controls.Add(Me.GB_CLIE_ABONADO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TB_CLIE_ID)
        Me.Controls.Add(Me.BTN_CLIE_ACTUALIZAR)
        Me.Controls.Add(Me.BTN_CLIE_LIMPIAR)
        Me.Controls.Add(Me.BTN_CLIE_CANCELAR)
        Me.Controls.Add(Me.BTN_CLIE_GUARDAR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_CLIE_DNI)
        Me.Controls.Add(Me.TB_CLIE_MAIL)
        Me.Controls.Add(Me.TB_CLIE_TEL_2)
        Me.Controls.Add(Me.TB_CLIE_TEL_1)
        Me.Controls.Add(Me.TB_CLIE_LOCALIDAD)
        Me.Controls.Add(Me.TB_CLIE_DIRECCION)
        Me.Controls.Add(Me.TB_CLIE_NOMBRES)
        Me.Controls.Add(Me.TB_CLIE_APELLIDO)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_CLIENTES_A_M"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGAR CLIENTES"
        Me.GB_CLIE_ABONADO.ResumeLayout(False)
        Me.GB_CLIE_ABONADO.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_CLIE_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_NOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_LOCALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_TEL_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_TEL_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_MAIL As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIE_DNI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTN_CLIE_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CLIE_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CLIE_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CLIE_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents TB_CLIE_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIE_CONTRATO As System.Windows.Forms.TextBox
    Friend WithEvents GB_CLIE_ABONADO As System.Windows.Forms.GroupBox
    Friend WithEvents CB_CLIE_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents TIPO As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CHB_CLIE_ABONADO As System.Windows.Forms.CheckBox
    Friend WithEvents DTP_CLIE_FECHA_ALTA As System.Windows.Forms.DateTimePicker

End Class
