Public Class FRM_HISTORIAL_VENTAS
    Public id_venta As Integer

    Private Sub FRM_HISTORIAL_VENTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Historial_Ventas As New Reporte_Historial_Ventas
        Historial_Ventas.SetParameterValue("@id_venta", id_venta)
        CrystalReportViewer1.ReportSource = Historial_Ventas
    End Sub
End Class