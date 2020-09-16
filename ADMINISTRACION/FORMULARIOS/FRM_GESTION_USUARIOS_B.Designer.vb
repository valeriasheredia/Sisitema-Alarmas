<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_GESTION_USUARIOS_B
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
        Me.BTN_USU_BAJA_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_USU_BAJA_CERRAR = New System.Windows.Forms.Button()
        Me.DGV_USU_ELIMINAR = New System.Windows.Forms.DataGridView()
        Me.BTN_USU_BAJA_CAMBIAR_PASS = New System.Windows.Forms.Button()
        CType(Me.DGV_USU_ELIMINAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_USU_BAJA_ELIMINAR
        '
        Me.BTN_USU_BAJA_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_BAJA_ELIMINAR.Location = New System.Drawing.Point(10, 177)
        Me.BTN_USU_BAJA_ELIMINAR.Name = "BTN_USU_BAJA_ELIMINAR"
        Me.BTN_USU_BAJA_ELIMINAR.Size = New System.Drawing.Size(77, 26)
        Me.BTN_USU_BAJA_ELIMINAR.TabIndex = 0
        Me.BTN_USU_BAJA_ELIMINAR.Text = "Eliminar"
        Me.BTN_USU_BAJA_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_USU_BAJA_CERRAR
        '
        Me.BTN_USU_BAJA_CERRAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_BAJA_CERRAR.Location = New System.Drawing.Point(266, 177)
        Me.BTN_USU_BAJA_CERRAR.Name = "BTN_USU_BAJA_CERRAR"
        Me.BTN_USU_BAJA_CERRAR.Size = New System.Drawing.Size(77, 26)
        Me.BTN_USU_BAJA_CERRAR.TabIndex = 1
        Me.BTN_USU_BAJA_CERRAR.Text = "Cerrar"
        Me.BTN_USU_BAJA_CERRAR.UseVisualStyleBackColor = True
        '
        'DGV_USU_ELIMINAR
        '
        Me.DGV_USU_ELIMINAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_USU_ELIMINAR.Location = New System.Drawing.Point(12, 12)
        Me.DGV_USU_ELIMINAR.Name = "DGV_USU_ELIMINAR"
        Me.DGV_USU_ELIMINAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_USU_ELIMINAR.Size = New System.Drawing.Size(331, 130)
        Me.DGV_USU_ELIMINAR.TabIndex = 2
        '
        'BTN_USU_BAJA_CAMBIAR_PASS
        '
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Location = New System.Drawing.Point(90, 155)
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Name = "BTN_USU_BAJA_CAMBIAR_PASS"
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Size = New System.Drawing.Size(93, 48)
        Me.BTN_USU_BAJA_CAMBIAR_PASS.TabIndex = 3
        Me.BTN_USU_BAJA_CAMBIAR_PASS.Text = "Cambiar Contraseña"
        Me.BTN_USU_BAJA_CAMBIAR_PASS.UseVisualStyleBackColor = True
        '
        'FRM_GESTION_USUARIOS_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 212)
        Me.Controls.Add(Me.BTN_USU_BAJA_CAMBIAR_PASS)
        Me.Controls.Add(Me.DGV_USU_ELIMINAR)
        Me.Controls.Add(Me.BTN_USU_BAJA_CERRAR)
        Me.Controls.Add(Me.BTN_USU_BAJA_ELIMINAR)
        Me.Name = "FRM_GESTION_USUARIOS_B"
        Me.Text = "Consulta de usuarios"
        CType(Me.DGV_USU_ELIMINAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_USU_BAJA_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_USU_BAJA_CERRAR As System.Windows.Forms.Button
    Friend WithEvents DGV_USU_ELIMINAR As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_USU_BAJA_CAMBIAR_PASS As System.Windows.Forms.Button
End Class
