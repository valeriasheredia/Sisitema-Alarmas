Public Class FRM_REPORTE_VENTA
    Public id_venta As Integer

    Private Sub FRM_REPORTE_VENTA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ReporteVenta As New Reporte_Venta
        ReporteVenta.SetParameterValue("@id_venta", id_venta)
        CrystalReportViewer1.ReportSource = ReporteVenta
    End Sub
End Class