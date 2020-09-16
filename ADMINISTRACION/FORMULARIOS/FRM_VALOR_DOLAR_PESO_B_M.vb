Public Class FRM_VALOR_DOLAR_PESO_B_M

    Private Sub FRM_VALOR_DOLAR_PESO_B_M_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TB_VALOR_ACTUAL.Focus()
        TB_VALOR_ACTUAL.Enabled = False
        TB_PESOS.Enabled = False
    End Sub

    Private Sub BTN_LIMPIAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_LIMPIAR.Click
        TB_DOLARES.Clear()
        TB_PESOS.Clear()
    End Sub

    Private Sub BTN_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BTN_CALCULAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CALCULAR.Click
        If TB_VALOR_ACTUAL.Text = "" Then
            MsgBox("Debe ingresar el valor actual del Dólar")
            TB_VALOR_ACTUAL.Focus()
            TB_DOLARES.Clear()

        ElseIf TB_DOLARES.Text = "" Then
            MsgBox("Debe ingresar la cantidad de Dólares")
            TB_DOLARES.Focus()
        Else
            Dim PESOS, DOLARES As Double
            DOLARES = Val(TB_DOLARES.Text)
            PESOS = Val(TB_DOLARES.Text * TB_VALOR_ACTUAL.Text)
            TB_PESOS.Text = PESOS
        End If
    End Sub

    'VALIDA EL INGRESO DE SOLO NUMEROS Y LA COMA (PARA PRECIO_COMPRA Y PRECIO_VENTA)
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not CajaTexto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TB_VALOR_ACTUAL_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TB_VALOR_ACTUAL.KeyPress
        NumerosyDecimal(TB_VALOR_ACTUAL, e)
    End Sub

    Private Sub TB_DOLARES_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TB_DOLARES.KeyPress
        NumerosyDecimal(TB_DOLARES, e)
    End Sub

    Private Sub BTN_ACTUALIZAR_VALOR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_ACTUALIZAR_VALOR.Click
        TB_VALOR_ACTUAL.Enabled = True
        TB_VALOR_ACTUAL.Clear()
        TB_VALOR_ACTUAL.Focus()
    End Sub

End Class