Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmHome
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(PanelSuperior, Color.Blue, 10, 10, Guna.UI.WinForms.VerHorAlign.HorizontalBottom)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim C As Integer
        C = Val(txtNumCot.Text)
        MsgBox(C)
        imprimircot(C)
    End Sub

    Sub imprimircot(ByVal COT As Integer)
        '=============================================== METODO PARA GENERAR EL PDF DE LA COTIZACION ===================================================
        'Try
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        FrmReporte.ReportViewer1.RefreshReport()
        FrmReporte.Show()

    End Sub
End Class
