<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PanelSuperior = New Guna.UI.WinForms.GunaPanel()
        Me.btnMinimizar = New Guna.UI.WinForms.GunaControlBox()
        Me.btnCerrar = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btnGenerar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtNumCot = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(418, 33)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.AnimationHoverSpeed = 0.07!
        Me.btnMinimizar.AnimationSpeed = 0.03!
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnMinimizar.IconSize = 15.0!
        Me.btnMinimizar.Location = New System.Drawing.Point(351, -1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnMinimizar.OnHoverIconColor = System.Drawing.Color.Black
        Me.btnMinimizar.OnPressedColor = System.Drawing.Color.Black
        Me.btnMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimizar.TabIndex = 6
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.AnimationHoverSpeed = 0.07!
        Me.btnCerrar.AnimationSpeed = 0.03!
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.IconColor = System.Drawing.Color.White
        Me.btnCerrar.IconSize = 15.0!
        Me.btnCerrar.Location = New System.Drawing.Point(385, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCerrar.OnHoverIconColor = System.Drawing.Color.White
        Me.btnCerrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.TabIndex = 5
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.PanelSuperior
        '
        'btnGenerar
        '
        Me.btnGenerar.AnimationHoverSpeed = 0.07!
        Me.btnGenerar.AnimationSpeed = 0.03!
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGenerar.BorderColor = System.Drawing.Color.Black
        Me.btnGenerar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnGenerar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnGenerar.CheckedForeColor = System.Drawing.Color.White
        Me.btnGenerar.CheckedImage = CType(resources.GetObject("btnGenerar.CheckedImage"), System.Drawing.Image)
        Me.btnGenerar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Image = Global.MiniSAM.My.Resources.Resources.expediente
        Me.btnGenerar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGenerar.Location = New System.Drawing.Point(287, 67)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGenerar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGenerar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerar.OnHoverImage = Nothing
        Me.btnGenerar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGenerar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerar.Radius = 6
        Me.btnGenerar.Size = New System.Drawing.Size(115, 42)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar PDF"
        '
        'txtNumCot
        '
        Me.txtNumCot.BackColor = System.Drawing.Color.Transparent
        Me.txtNumCot.BaseColor = System.Drawing.Color.White
        Me.txtNumCot.BorderColor = System.Drawing.Color.Silver
        Me.txtNumCot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumCot.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNumCot.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtNumCot.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumCot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNumCot.Location = New System.Drawing.Point(105, 74)
        Me.txtNumCot.Name = "txtNumCot"
        Me.txtNumCot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCot.Radius = 6
        Me.txtNumCot.Size = New System.Drawing.Size(160, 30)
        Me.txtNumCot.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Demi ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Generar PDF de las Cotizaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Núm. Cot:"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimateWindow1.Interval = 800
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 120)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumCot)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHome"
        Me.PanelSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PanelSuperior As Guna.UI.WinForms.GunaPanel
    Private WithEvents btnMinimizar As Guna.UI.WinForms.GunaControlBox
    Private WithEvents btnCerrar As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents txtNumCot As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnGenerar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
End Class
