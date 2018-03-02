<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tblInicio = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.tblMenuCostado = New System.Windows.Forms.TableLayoutPanel()
        Me.lblServicios = New System.Windows.Forms.Label()
        Me.lblAgenda = New System.Windows.Forms.Label()
        Me.lblPersonal = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.tblBarraInicio = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBarra = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSistemaSpa = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip.SuspendLayout()
        Me.tblInicio.SuspendLayout()
        Me.tblPrincipal.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblMenuCostado.SuspendLayout()
        Me.tblBarraInicio.SuspendLayout()
        Me.tblBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(6, 10, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1339, 37)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ToolStripSeparator5})
        Me.FileMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(65, 24)
        Me.FileMenu.Text = "&Sesion"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(104, 6)
        '
        'tblInicio
        '
        Me.tblInicio.ColumnCount = 1
        Me.tblInicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblInicio.Controls.Add(Me.tblPrincipal, 0, 1)
        Me.tblInicio.Controls.Add(Me.tblBarraInicio, 0, 0)
        Me.tblInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInicio.Location = New System.Drawing.Point(0, 37)
        Me.tblInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.tblInicio.Name = "tblInicio"
        Me.tblInicio.RowCount = 2
        Me.tblInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.860262!))
        Me.tblInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.13974!))
        Me.tblInicio.Size = New System.Drawing.Size(1339, 627)
        Me.tblInicio.TabIndex = 20
        '
        'tblPrincipal
        '
        Me.tblPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.tblPrincipal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblPrincipal.ColumnCount = 2
        Me.tblPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.74074!))
        Me.tblPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.25926!))
        Me.tblPrincipal.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tblPrincipal.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPrincipal.ForeColor = System.Drawing.Color.Cornsilk
        Me.tblPrincipal.Location = New System.Drawing.Point(0, 49)
        Me.tblPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.tblPrincipal.Name = "tblPrincipal"
        Me.tblPrincipal.RowCount = 1
        Me.tblPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.75949!))
        Me.tblPrincipal.Size = New System.Drawing.Size(1339, 578)
        Me.tblPrincipal.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSalir, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblMenuCostado, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 576)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.BackColor = System.Drawing.Color.Transparent
        Me.lblSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.Location = New System.Drawing.Point(4, 531)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(162, 44)
        Me.lblSalir.TabIndex = 4
        Me.lblSalir.Text = "SALIR"
        Me.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblMenuCostado
        '
        Me.tblMenuCostado.BackColor = System.Drawing.Color.Transparent
        Me.tblMenuCostado.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblMenuCostado.ColumnCount = 1
        Me.tblMenuCostado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMenuCostado.Controls.Add(Me.lblServicios, 0, 3)
        Me.tblMenuCostado.Controls.Add(Me.lblAgenda, 0, 2)
        Me.tblMenuCostado.Controls.Add(Me.lblPersonal, 0, 1)
        Me.tblMenuCostado.Controls.Add(Me.lblClientes, 0, 0)
        Me.tblMenuCostado.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblMenuCostado.Location = New System.Drawing.Point(1, 1)
        Me.tblMenuCostado.Margin = New System.Windows.Forms.Padding(0)
        Me.tblMenuCostado.Name = "tblMenuCostado"
        Me.tblMenuCostado.RowCount = 4
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99875!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99875!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00125!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00125!))
        Me.tblMenuCostado.Size = New System.Drawing.Size(168, 275)
        Me.tblMenuCostado.TabIndex = 2
        '
        'lblServicios
        '
        Me.lblServicios.AutoSize = True
        Me.lblServicios.BackColor = System.Drawing.Color.Transparent
        Me.lblServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServicios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.Location = New System.Drawing.Point(4, 205)
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(160, 69)
        Me.lblServicios.TabIndex = 3
        Me.lblServicios.Text = "SERVICIOS"
        Me.lblServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgenda
        '
        Me.lblAgenda.AutoSize = True
        Me.lblAgenda.BackColor = System.Drawing.Color.Transparent
        Me.lblAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAgenda.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgenda.Location = New System.Drawing.Point(4, 137)
        Me.lblAgenda.Name = "lblAgenda"
        Me.lblAgenda.Size = New System.Drawing.Size(160, 67)
        Me.lblAgenda.TabIndex = 2
        Me.lblAgenda.Text = "AGENDA"
        Me.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPersonal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.Location = New System.Drawing.Point(4, 69)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(160, 67)
        Me.lblPersonal.TabIndex = 1
        Me.lblPersonal.Text = "PERSONAL"
        Me.lblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.BackColor = System.Drawing.Color.Transparent
        Me.lblClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(4, 1)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(160, 67)
        Me.lblClientes.TabIndex = 0
        Me.lblClientes.Text = "CLIENTES"
        Me.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblBarraInicio
        '
        Me.tblBarraInicio.BackColor = System.Drawing.Color.LavenderBlush
        Me.tblBarraInicio.ColumnCount = 1
        Me.tblBarraInicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBarraInicio.Controls.Add(Me.tblBarra, 0, 0)
        Me.tblBarraInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBarraInicio.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.tblBarraInicio.Location = New System.Drawing.Point(0, 0)
        Me.tblBarraInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.tblBarraInicio.Name = "tblBarraInicio"
        Me.tblBarraInicio.RowCount = 1
        Me.tblBarraInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBarraInicio.Size = New System.Drawing.Size(1339, 49)
        Me.tblBarraInicio.TabIndex = 1
        '
        'tblBarra
        '
        Me.tblBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.tblBarra.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblBarra.ColumnCount = 2
        Me.tblBarra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.60193!))
        Me.tblBarra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.39807!))
        Me.tblBarra.Controls.Add(Me.lblSistemaSpa, 0, 0)
        Me.tblBarra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBarra.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.tblBarra.Location = New System.Drawing.Point(0, 0)
        Me.tblBarra.Margin = New System.Windows.Forms.Padding(0)
        Me.tblBarra.Name = "tblBarra"
        Me.tblBarra.RowCount = 1
        Me.tblBarra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBarra.Size = New System.Drawing.Size(1339, 49)
        Me.tblBarra.TabIndex = 0
        '
        'lblSistemaSpa
        '
        Me.lblSistemaSpa.AutoSize = True
        Me.lblSistemaSpa.BackColor = System.Drawing.Color.Transparent
        Me.lblSistemaSpa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSistemaSpa.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistemaSpa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSistemaSpa.Location = New System.Drawing.Point(1, 1)
        Me.lblSistemaSpa.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSistemaSpa.Name = "lblSistemaSpa"
        Me.lblSistemaSpa.Size = New System.Drawing.Size(168, 47)
        Me.lblSistemaSpa.TabIndex = 1
        Me.lblSistemaSpa.Text = "SISTEMA SPA"
        Me.lblSistemaSpa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(172, 1)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.15278!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.84722!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1166, 576)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 664)
        Me.Controls.Add(Me.tblInicio)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.tblInicio.ResumeLayout(False)
        Me.tblPrincipal.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tblMenuCostado.ResumeLayout(False)
        Me.tblMenuCostado.PerformLayout()
        Me.tblBarraInicio.ResumeLayout(False)
        Me.tblBarra.ResumeLayout(False)
        Me.tblBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tblInicio As TableLayoutPanel
    Friend WithEvents tblPrincipal As TableLayoutPanel
    Friend WithEvents tblBarraInicio As TableLayoutPanel
    Friend WithEvents tblBarra As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblMenuCostado As TableLayoutPanel
    Friend WithEvents lblServicios As Label
    Friend WithEvents lblAgenda As Label
    Friend WithEvents lblPersonal As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents lblSistemaSpa As Label
    Friend WithEvents lblSalir As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
