<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INGRESO
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
        Me.BTN_INGR_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_INGR_CANCELAR = New System.Windows.Forms.Button()
        Me.TB_USU_USUARIO = New System.Windows.Forms.TextBox()
        Me.TB_USU_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.BTN_ING_CAMBIO_PASS = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña*"
        '
        'BTN_INGR_ACEPTAR
        '
        Me.BTN_INGR_ACEPTAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INGR_ACEPTAR.Location = New System.Drawing.Point(13, 148)
        Me.BTN_INGR_ACEPTAR.Name = "BTN_INGR_ACEPTAR"
        Me.BTN_INGR_ACEPTAR.Size = New System.Drawing.Size(87, 32)
        Me.BTN_INGR_ACEPTAR.TabIndex = 3
        Me.BTN_INGR_ACEPTAR.Text = "Ingresar"
        Me.BTN_INGR_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_INGR_CANCELAR
        '
        Me.BTN_INGR_CANCELAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INGR_CANCELAR.Location = New System.Drawing.Point(106, 148)
        Me.BTN_INGR_CANCELAR.Name = "BTN_INGR_CANCELAR"
        Me.BTN_INGR_CANCELAR.Size = New System.Drawing.Size(87, 32)
        Me.BTN_INGR_CANCELAR.TabIndex = 4
        Me.BTN_INGR_CANCELAR.Text = "Salir"
        Me.BTN_INGR_CANCELAR.UseVisualStyleBackColor = True
        '
        'TB_USU_USUARIO
        '
        Me.TB_USU_USUARIO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_USUARIO.Location = New System.Drawing.Point(17, 35)
        Me.TB_USU_USUARIO.Name = "TB_USU_USUARIO"
        Me.TB_USU_USUARIO.Size = New System.Drawing.Size(155, 26)
        Me.TB_USU_USUARIO.TabIndex = 1
        '
        'TB_USU_CONTRASEÑA
        '
        Me.TB_USU_CONTRASEÑA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_CONTRASEÑA.Location = New System.Drawing.Point(17, 91)
        Me.TB_USU_CONTRASEÑA.Name = "TB_USU_CONTRASEÑA"
        Me.TB_USU_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_CONTRASEÑA.Size = New System.Drawing.Size(155, 26)
        Me.TB_USU_CONTRASEÑA.TabIndex = 2
        '
        'BTN_ING_CAMBIO_PASS
        '
        Me.BTN_ING_CAMBIO_PASS.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ING_CAMBIO_PASS.Location = New System.Drawing.Point(199, 148)
        Me.BTN_ING_CAMBIO_PASS.Name = "BTN_ING_CAMBIO_PASS"
        Me.BTN_ING_CAMBIO_PASS.Size = New System.Drawing.Size(120, 32)
        Me.BTN_ING_CAMBIO_PASS.TabIndex = 5
        Me.BTN_ING_CAMBIO_PASS.Text = "Cambiar contraseña"
        Me.BTN_ING_CAMBIO_PASS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Datos obligatorios*"
        '
        'FRM_INGRESO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 192)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_ING_CAMBIO_PASS)
        Me.Controls.Add(Me.TB_USU_CONTRASEÑA)
        Me.Controls.Add(Me.TB_USU_USUARIO)
        Me.Controls.Add(Me.BTN_INGR_CANCELAR)
        Me.Controls.Add(Me.BTN_INGR_ACEPTAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_INGRESO"
        Me.Text = "INGRESO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_INGR_ACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTN_INGR_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents TB_USU_USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TB_USU_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents BTN_ING_CAMBIO_PASS As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
