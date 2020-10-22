Imports System.Data.SqlClient
Module Conexiones
    '-----------------------------Variables para la conexion con bases de Datos COTIZADOR-------------------------------------------
    Public conexionMetasCotizador As SqlConnection
    Public comandoMetasCotizador As SqlCommand
    Public lectorMetasCotizador As SqlDataReader
    Public adapterMetasCotizador As SqlDataAdapter
    Public datatableMetasCotizador As DataTable
    '--------------------------------------------------------------------------------------------------------------------------
    '-----------------------------Variables para la conexion con bases de Datos COTIZADOR-------------------------------------------
    Public conexionMetasInf As SqlConnection
    Public comandoMetasInf As SqlCommand
    Public lectorMetasInf As SqlDataReader

    Sub MetodoMetasCotizador()
        Try
            conexionMetasCotizador = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2020; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionMetasCotizador.Open()
        Catch ex As Exception
        End Try
    End Sub
    Sub MetodoMetasInf()
        Try
            conexionMetasInf = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=InformacionGeneral; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionMetasInf.Open()
        Catch ex As Exception
        End Try
    End Sub
End Module

