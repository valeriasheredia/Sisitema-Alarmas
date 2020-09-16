
Imports System.Data.SqlClient

Public Class Form1

    Private Maestro As SqlDataAdapter
    Private Detalle As SqlDataAdapter
    Private ConjuntoDeDatos As DataSet

    Private Sub Form1_Load() Handles MyBase.Load

        Dim miConexion As New SqlConnection("Data Source=VALE\VALEVALERIA;Initial Catalog=Administracion;Integrated Security=True")

        Maestro = New SqlDataAdapter("SELECT * FROM VENTAS", miConexion)
        Dim MaestroCmdBuilder As New SqlCommandBuilder(Maestro)

        Detalle = New SqlDataAdapter("SELECT * FROM PROD_X_VTA", miConexion)
        Dim DetalleCmdBuilder As New SqlCommandBuilder(Detalle)

        ConjuntoDeDatos = New DataSet
        Maestro.Fill(ConjuntoDeDatos, "VENTAS")
        Me.DataGridView1.DataSource = ConjuntoDeDatos
        Me.DataGridView1.DataMember = "VENTAS"

        Detalle.Fill(ConjuntoDeDatos, "PROD_X_VTA")
        Me.DataGridView2.DataSource = ConjuntoDeDatos

        ConjuntoDeDatos.Relations.Add("VENTA_PROD_X_VTA", ConjuntoDeDatos.Tables("VENTAS").Columns("ID_VENTA"),
                                                  ConjuntoDeDatos.Tables("PROD_X_VTA").Columns("ID_VENTA"))

        Me.DataGridView2.DataMember = "VENTAS.VENTA_PROD_X_VTA"
    End Sub
End Class


