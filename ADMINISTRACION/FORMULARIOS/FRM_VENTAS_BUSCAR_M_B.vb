Imports System.Data.SqlClient

Public Class FRM_VENTAS_BUSCAR_M_B

    Dim datacontext As New DC_AdminDataContext
    Dim datareporte As New DC_Administracion_Reportes

    Private Maestro As SqlDataAdapter
    Private Detalle As SqlDataAdapter
    Private ConjuntoDeDatos As DataSet

    Private Sub BTN_PROD_TIPO_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ArmarGrillaMaestro()
        DGV_VENTA_BUSCAR.Enabled = True
        DGV_VENTA_BUSCAR.AutoGenerateColumns = False
        DGV_VENTA_BUSCAR.Columns.Clear()

        DGV_VENTA_BUSCAR.Columns.Add("ID_CLIENTE", "ID_CLIENTE")
        DGV_VENTA_BUSCAR.Columns.Add("CLI_NOMBRES", "NOMBRES")
        DGV_VENTA_BUSCAR.Columns.Add("CLI_APELLIDO", "APELLIDO")
        DGV_VENTA_BUSCAR.Columns.Add("CLI_DNI", "DNI")
        DGV_VENTA_BUSCAR.Columns.Add("ID_VENTA", "ID_VENTA")
        DGV_VENTA_BUSCAR.Columns.Add("VENT_FECHA", "FECHA")
        DGV_VENTA_BUSCAR.Columns.Add("VENT_TOTAL", "TOTAL")
        DGV_VENTA_BUSCAR.Columns.Add("ID_VENTA", "ID_VENTA")

        DGV_VENTA_BUSCAR.Columns(0).DataPropertyName = "ID_CLIENTE"
        DGV_VENTA_BUSCAR.Columns(0).Visible = False
        DGV_VENTA_BUSCAR.Columns(1).DataPropertyName = "CLI_NOMBRES"
        DGV_VENTA_BUSCAR.Columns(2).DataPropertyName = "CLI_APELLIDO"
        DGV_VENTA_BUSCAR.Columns(3).DataPropertyName = "CLI_DNI"
        DGV_VENTA_BUSCAR.Columns(4).DataPropertyName = "ID_VENTA"
        DGV_VENTA_BUSCAR.Columns(4).Visible = False
        DGV_VENTA_BUSCAR.Columns(5).DataPropertyName = "VENT_FECHA"
        DGV_VENTA_BUSCAR.Columns(6).DataPropertyName = "VENT_TOTAL"
        DGV_VENTA_BUSCAR.Columns(7).DataPropertyName = "ID_VENTA"

        DGV_VENTA_BUSCAR.ClearSelection()
    End Sub

    Private Sub ArmarGrillaDetalle()
        DGV_VENTA_DETALLE.Enabled = True
        DGV_VENTA_DETALLE.AutoGenerateColumns = False
        DGV_VENTA_DETALLE.Columns.Clear()

        DGV_VENTA_DETALLE.Columns.Add("ID_PROD_X_VTA", "ID_PROD_X_VTA")
        DGV_VENTA_DETALLE.Columns.Add("PXV_CANTIDAD", "CANTIDAD")
        DGV_VENTA_DETALLE.Columns.Add("ID_VENTA", "ID_VENTA")
        DGV_VENTA_DETALLE.Columns.Add("PROD_DESCRIPCION", "DESCRIPCION")
        DGV_VENTA_DETALLE.Columns.Add("PROD_PRECIO_VTA", "PRECIO VENTA")
        DGV_VENTA_DETALLE.Columns.Add("ID_CLIENTE", "ID_CLIENTE")

        DGV_VENTA_DETALLE.Columns(0).DataPropertyName = "ID_PROD_X_VTA"
        DGV_VENTA_DETALLE.Columns(0).Visible = False
        DGV_VENTA_DETALLE.Columns(1).DataPropertyName = "PXV_CANTIDAD"
        DGV_VENTA_DETALLE.Columns(2).DataPropertyName = "ID_VENTA"
        DGV_VENTA_DETALLE.Columns(2).Visible = False
        DGV_VENTA_DETALLE.Columns(3).DataPropertyName = "PROD_DESCRIPCION"
        DGV_VENTA_DETALLE.Columns(3).Width = 200
        DGV_VENTA_DETALLE.Columns(4).DataPropertyName = "PROD_PRECIO_VTA"
        DGV_VENTA_DETALLE.Columns(5).DataPropertyName = "ID_CLIENTE"
        DGV_VENTA_DETALLE.Columns(5).Visible = False
        DGV_VENTA_DETALLE.ClearSelection()
    End Sub

    Private Sub BTN_PROD_TIPO_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.VENTAS Where C.ID_VENTA = CInt(DGV_VENTA_BUSCAR.Item("ID_VENTA", DGV_VENTA_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará la venta seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Venta")
            Case MsgBoxResult.Yes
                datacontext.VENTAS.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("La venta ha sido eliminada satisfactoriamente")
                Me.CargarGrillaMaestro()
        End Select
    End Sub

    Private Sub TB_VENTA_BUSCAR_DNI_CLI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_VENTA_BUSCAR_DNI_CLI.TextChanged
        Dim buscar As String
        If RB_CLI_DNI_BUSCAR.Checked = True Then
            ArmarGrillaMaestro()
            buscar = Me.TB_VENTA_BUSCAR_DNI_CLI.Text & "*"
            Dim ConsultaDniCliente = From U In datacontext.CLIENTES
                            Join V In datacontext.VENTAS On U.ID_CLIENTE Equals V.ID_CLIENTE
                            Select U.ID_CLIENTE, U.CLI_APELLIDO, U.CLI_NOMBRES, U.CLI_DNI, V.ID_VENTA, V.VENT_FECHA Where CLI_DNI Like buscar.ToString
            DGV_VENTA_BUSCAR.DataSource = ConsultaDniCliente
        End If
    End Sub

    'CONTROLAR 
    Private Sub DTP_FECHA_VENTA_BUSCAR_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTP_FECHA_VENTA_BUSCAR.ValueChanged
        Dim buscar As String
        If RB_VENT_FECHA_BUSCAR.Checked = True Then
            ArmarGrillaMaestro()
            buscar = Me.DTP_FECHA_VENTA_BUSCAR.Value & "*"
            Dim ConsultaFechaVenta = From U In datacontext.CLIENTES
                            Join V In datacontext.VENTAS On U.ID_CLIENTE Equals V.ID_CLIENTE
                            Select U.ID_CLIENTE, U.CLI_APELLIDO, U.CLI_NOMBRES, U.CLI_DNI, V.ID_VENTA, V.VENT_FECHA Where VENT_FECHA Like buscar.ToString
            DGV_VENTA_BUSCAR.DataSource = ConsultaFechaVenta
        End If
    End Sub

    Private Sub RB_CLI_DNI_BUSCAR_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RB_CLI_DNI_BUSCAR.CheckedChanged
        DTP_FECHA_VENTA_BUSCAR.Enabled = False
        TB_VENTA_BUSCAR_DNI_CLI.Enabled = True
        TB_VENTA_BUSCAR_DNI_CLI.Focus()
    End Sub

    Private Sub RB_VENT_FECHA_BUSCAR_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RB_VENT_FECHA_BUSCAR.CheckedChanged
        DTP_FECHA_VENTA_BUSCAR.Enabled = True
        TB_VENTA_BUSCAR_DNI_CLI.Enabled = False
    End Sub

    Public Sub CargarGrillaMaestro() 'MAESTRO
        Dim CargarGrillaMaestro = From U In datacontext.CLIENTES
                            Join V In datacontext.VENTAS On U.ID_CLIENTE Equals V.ID_CLIENTE
                            Select U.ID_CLIENTE, U.CLI_APELLIDO, U.CLI_NOMBRES, U.CLI_DNI, V.ID_VENTA, V.VENT_FECHA
        DGV_VENTA_BUSCAR.DataSource = CargarGrillaMaestro
    End Sub

    Public Sub CargarGrillaDetalle() 'DETALLE
        Dim ConsultaGrillaDetalle = From U In datacontext.PRODUCTOS
                            Join V In datacontext.PROD_X_VTA On V.ID_PRODUCTO Equals U.ID_PRODUCTO
                            Join D In datacontext.VENTAS On V.ID_VENTA Equals D.ID_VENTA
                            Select V.ID_VENTA, D.ID_CLIENTE, V.PXV_CANTIDAD, U.PROD_DESCRIPCION, U.PROD_PRECIO_VTA
        DGV_VENTA_DETALLE.DataSource = ConsultaGrillaDetalle
    End Sub

    Private Sub FRM_VENTAS_BUSCAR_M_B_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
        Dim miConexion As New SqlConnection("Data Source=VALE\VALEVALERIA;Initial Catalog=Administracion;Integrated Security=True")

        CargarGrillaMaestro()
        ArmarGrillaMaestro()

        CargarGrillaDetalle()
        ArmarGrillaDetalle()

        Maestro = New SqlDataAdapter("SELECT dbo.CLIENTES.ID_CLIENTE, dbo.CLIENTES.CLI_NOMBRES, dbo.CLIENTES.CLI_APELLIDO,dbo.CLIENTES.CLI_DNI, dbo.VENTAS.ID_VENTA, dbo.VENTAS.VENT_FECHA, dbo.VENTAS.VENT_TOTAL FROM dbo.CLIENTES INNER JOIN dbo.VENTAS ON dbo.CLIENTES.ID_CLIENTE = dbo.VENTAS.ID_CLIENTE WHERE VENTAS.ID_CLIENTE <> 0 order by ID_VENTA desc", miConexion)
        Dim MaestroCmdBuilder As New SqlCommandBuilder(Maestro)

        Detalle = New SqlDataAdapter("SELECT dbo.PROD_X_VTA.ID_PROD_X_VTA, dbo.PROD_X_VTA.PXV_CANTIDAD,dbo.PROD_X_VTA.ID_VENTA, dbo.PRODUCTOS.PROD_DESCRIPCION, dbo.PRODUCTOS.PROD_PRECIO_VTA, dbo.VENTAS.ID_CLIENTE FROM dbo.PROD_X_VTA INNER JOIN dbo.PRODUCTOS ON dbo.PROD_X_VTA.ID_PRODUCTO = dbo.PRODUCTOS.ID_PRODUCTO INNER JOIN dbo.VENTAS ON dbo.PROD_X_VTA.ID_VENTA = dbo.VENTAS.ID_VENTA WHERE VENTAS.ID_CLIENTE<>0 order by ID_VENTA desc", miConexion)
        Dim DetalleCmdBuilder As New SqlCommandBuilder(Detalle)

        ConjuntoDeDatos = New DataSet
        Maestro.Fill(ConjuntoDeDatos, "VENTAS")
        Me.DGV_VENTA_BUSCAR.DataSource = ConjuntoDeDatos
        Me.DGV_VENTA_BUSCAR.DataMember = "VENTAS"

        Detalle.Fill(ConjuntoDeDatos, "PROD_X_VTA")

        Me.DGV_VENTA_DETALLE.DataSource = ConjuntoDeDatos

        ConjuntoDeDatos.Relations.Add("VENTA_PROD_X_VTA", ConjuntoDeDatos.Tables("VENTAS").Columns("ID_VENTA"),
                                                  ConjuntoDeDatos.Tables("PROD_X_VTA").Columns("ID_VENTA"))
        Me.DGV_VENTA_DETALLE.DataMember = "VENTAS.VENTA_PROD_X_VTA"
    End Sub

    Private Sub BTN_VENTA_BUS_IMPRIMIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_IMPRIMIR.Click
        Dim objForm As New Reporte_Historial_Ventas
        Dim id_ven As Integer = DGV_VENTA_BUSCAR.CurrentRow.Cells("ID_VENTA").Value
        FRM_HISTORIAL_VENTAS.id_venta = id_ven
        FRM_HISTORIAL_VENTAS.Show()
    End Sub
End Class
