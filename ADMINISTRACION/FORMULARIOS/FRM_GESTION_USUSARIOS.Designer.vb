<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_GESTION_USUARIOS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_USU_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_USU_CANCELAR = New System.Windows.Forms.Button()
        Me.TB_USU_USUARIO = New System.Windows.Forms.TextBox()
        Me.TB_USU_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.CB_USU_PERFIL = New System.Windows.Forms.ComboBox()
        Me.BTN_USU_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.TB_USU_REPETIR_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_USU_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña nueva*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Perfil*"
        '
        'BTN_USU_GUARDAR
        '
        Me.BTN_USU_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_GUARDAR.Location = New System.Drawing.Point(12, 215)
        Me.BTN_USU_GUARDAR.Name = "BTN_USU_GUARDAR"
        Me.BTN_USU_GUARDAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_GUARDAR.TabIndex = 5
        Me.BTN_USU_GUARDAR.Text = "Guardar"
        Me.BTN_USU_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_USU_CANCELAR
        '
        Me.BTN_USU_CANCELAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_CANCELAR.Location = New System.Drawing.Point(182, 216)
        Me.BTN_USU_CANCELAR.Name = "BTN_USU_CANCELAR"
        Me.BTN_USU_CANCELAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_CANCELAR.TabIndex = 7
        Me.BTN_USU_CANCELAR.Text = "Cancelar"
        Me.BTN_USU_CANCELAR.UseVisualStyleBackColor = True
        '
        'TB_USU_USUARIO
        '
        Me.TB_USU_USUARIO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_USUARIO.Location = New System.Drawing.Point(15, 35)
        Me.TB_USU_USUARIO.Name = "TB_USU_USUARIO"
        Me.TB_USU_USUARIO.Size = New System.Drawing.Size(137, 26)
        Me.TB_USU_USUARIO.TabIndex = 1
        '
        'TB_USU_CONTRASEÑA
        '
        Me.TB_USU_CONTRASEÑA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_CONTRASEÑA.Location = New System.Drawing.Point(15, 92)
        Me.TB_USU_CONTRASEÑA.Name = "TB_USU_CONTRASEÑA"
        Me.TB_USU_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_CONTRASEÑA.Size = New System.Drawing.Size(137, 26)
        Me.TB_USU_CONTRASEÑA.TabIndex = 2
        '
        'CB_USU_PERFIL
        '
        Me.CB_USU_PERFIL.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_USU_PERFIL.FormattingEnabled = True
        Me.CB_USU_PERFIL.Items.AddRange(New Object() {"ADMINISTRADOR", "LIMITADO", "CONSULTA"})
        Me.CB_USU_PERFIL.Location = New System.Drawing.Point(12, 146)
        Me.CB_USU_PERFIL.Name = "CB_USU_PERFIL"
        Me.CB_USU_PERFIL.Size = New System.Drawing.Size(140, 26)
        Me.CB_USU_PERFIL.TabIndex = 4
        '
        'BTN_USU_ACTUALIZAR
        '
        Me.BTN_USU_ACTUALIZAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_ACTUALIZAR.Location = New System.Drawing.Point(97, 215)
        Me.BTN_USU_ACTUALIZAR.Name = "BTN_USU_ACTUALIZAR"
        Me.BTN_USU_ACTUALIZAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_ACTUALIZAR.TabIndex = 6
        Me.BTN_USU_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_USU_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'TB_USU_REPETIR_CONTRASEÑA
        '
        Me.TB_USU_REPETIR_CONTRASEÑA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_REPETIR_CONTRASEÑA.Location = New System.Drawing.Point(161, 92)
        Me.TB_USU_REPETIR_CONTRASEÑA.Name = "TB_USU_REPETIR_CONTRASEÑA"
        Me.TB_USU_REPETIR_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_REPETIR_CONTRASEÑA.Size = New System.Drawing.Size(137, 26)
        Me.TB_USU_REPETIR_CONTRASEÑA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Repetir contraseña nueva*"
        '
        'TB_USU_ID
        '
        Me.TB_USU_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_ID.Location = New System.Drawing.Point(161, 35)
        Me.TB_USU_ID.Name = "TB_USU_ID"
        Me.TB_USU_ID.Size = New System.Drawing.Size(137, 26)
        Me.TB_USU_ID.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*Datos obligatorios"
        '
        'FRM_GESTION_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 257)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_USU_ID)
        Me.Controls.Add(Me.TB_USU_REPETIR_CONTRASEÑA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_USU_ACTUALIZAR)
        Me.Controls.Add(Me.CB_USU_PERFIL)
        Me.Controls.Add(Me.TB_USU_CONTRASEÑA)
        Me.Controls.Add(Me.TB_USU_USUARIO)
        Me.Controls.Add(Me.BTN_USU_CANCELAR)
        Me.Controls.Add(Me.BTN_USU_GUARDAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_GESTION_USUARIOS"
        Me.Text = "Gestión de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_USU_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_USU_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents TB_USU_USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TB_USU_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents CB_USU_PERFIL As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_USU_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents TB_USU_REPETIR_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
