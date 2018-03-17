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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblInicio = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.tblMenuCostado = New System.Windows.Forms.TableLayoutPanel()
        Me.lblServicios = New System.Windows.Forms.Label()
        Me.lblAgenda = New System.Windows.Forms.Label()
        Me.lblPersonal = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.tblContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvInicio = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblBarraInicio = New System.Windows.Forms.TableLayoutPanel()
        Me.ptLogo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBanner = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTarget = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ptboxBuscar = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rectBuscar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblReservas = New System.Windows.Forms.Label()
        Me.lblActualizar = New System.Windows.Forms.Label()
        Me.lblModificar = New System.Windows.Forms.Label()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectActualizar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectModificar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectAgregar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tblInicio.SuspendLayout()
        Me.tblPrincipal.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tblMenuCostado.SuspendLayout()
        Me.tblContenido.SuspendLayout()
        CType(Me.dgvInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tblBarraInicio.SuspendLayout()
        CType(Me.ptLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tblBanner.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ptboxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblInicio
        '
        Me.tblInicio.ColumnCount = 1
        Me.tblInicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblInicio.Controls.Add(Me.tblPrincipal, 0, 1)
        Me.tblInicio.Controls.Add(Me.tblBarraInicio, 0, 0)
        Me.tblInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInicio.Location = New System.Drawing.Point(0, 0)
        Me.tblInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.tblInicio.Name = "tblInicio"
        Me.tblInicio.RowCount = 2
        Me.tblInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.87601!))
        Me.tblInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.12399!))
        Me.tblInicio.Size = New System.Drawing.Size(1362, 742)
        Me.tblInicio.TabIndex = 20
        '
        'tblPrincipal
        '
        Me.tblPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.tblPrincipal.ColumnCount = 2
        Me.tblPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.15272!))
        Me.tblPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.84728!))
        Me.tblPrincipal.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tblPrincipal.Controls.Add(Me.tblContenido, 1, 0)
        Me.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPrincipal.ForeColor = System.Drawing.Color.Cornsilk
        Me.tblPrincipal.Location = New System.Drawing.Point(0, 192)
        Me.tblPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.tblPrincipal.Name = "tblPrincipal"
        Me.tblPrincipal.RowCount = 1
        Me.tblPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPrincipal.Size = New System.Drawing.Size(1362, 550)
        Me.tblPrincipal.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblMenuCostado, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(220, 550)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblSalir, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 506)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99875!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(218, 43)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.BackColor = System.Drawing.Color.Transparent
        Me.lblSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.Location = New System.Drawing.Point(0, 0)
        Me.lblSalir.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(218, 43)
        Me.lblSalir.TabIndex = 0
        Me.lblSalir.Text = "SALIR"
        Me.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblMenuCostado
        '
        Me.tblMenuCostado.BackColor = System.Drawing.Color.Transparent
        Me.tblMenuCostado.ColumnCount = 1
        Me.tblMenuCostado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMenuCostado.Controls.Add(Me.lblServicios, 0, 3)
        Me.tblMenuCostado.Controls.Add(Me.lblAgenda, 0, 2)
        Me.tblMenuCostado.Controls.Add(Me.lblPersonal, 0, 1)
        Me.tblMenuCostado.Controls.Add(Me.lblClientes, 0, 0)
        Me.tblMenuCostado.Controls.Add(Me.lblVentas, 0, 4)
        Me.tblMenuCostado.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblMenuCostado.Location = New System.Drawing.Point(1, 1)
        Me.tblMenuCostado.Margin = New System.Windows.Forms.Padding(0)
        Me.tblMenuCostado.Name = "tblMenuCostado"
        Me.tblMenuCostado.RowCount = 5
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99915!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99915!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00115!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00027!))
        Me.tblMenuCostado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00027!))
        Me.tblMenuCostado.Size = New System.Drawing.Size(218, 293)
        Me.tblMenuCostado.TabIndex = 2
        '
        'lblServicios
        '
        Me.lblServicios.AutoSize = True
        Me.lblServicios.BackColor = System.Drawing.Color.Transparent
        Me.lblServicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServicios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.Location = New System.Drawing.Point(0, 174)
        Me.lblServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(218, 58)
        Me.lblServicios.TabIndex = 3
        Me.lblServicios.Text = "SERVICIOS"
        Me.lblServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgenda
        '
        Me.lblAgenda.AutoSize = True
        Me.lblAgenda.BackColor = System.Drawing.Color.Transparent
        Me.lblAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAgenda.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgenda.Location = New System.Drawing.Point(0, 116)
        Me.lblAgenda.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAgenda.Name = "lblAgenda"
        Me.lblAgenda.Size = New System.Drawing.Size(218, 58)
        Me.lblAgenda.TabIndex = 2
        Me.lblAgenda.Text = "AGENDA"
        Me.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPersonal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.Location = New System.Drawing.Point(0, 58)
        Me.lblPersonal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(218, 58)
        Me.lblPersonal.TabIndex = 1
        Me.lblPersonal.Text = "PERSONAL"
        Me.lblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.BackColor = System.Drawing.Color.Transparent
        Me.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(0, 0)
        Me.lblClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(218, 58)
        Me.lblClientes.TabIndex = 0
        Me.lblClientes.Text = "CLIENTES"
        Me.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblVentas.Location = New System.Drawing.Point(0, 232)
        Me.lblVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(218, 61)
        Me.lblVentas.TabIndex = 4
        Me.lblVentas.Text = "VENTAS"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblContenido
        '
        Me.tblContenido.ColumnCount = 1
        Me.tblContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblContenido.Controls.Add(Me.dgvInicio, 0, 0)
        Me.tblContenido.Controls.Add(Me.Panel1, 0, 1)
        Me.tblContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblContenido.ForeColor = System.Drawing.Color.Black
        Me.tblContenido.Location = New System.Drawing.Point(220, 0)
        Me.tblContenido.Margin = New System.Windows.Forms.Padding(0)
        Me.tblContenido.Name = "tblContenido"
        Me.tblContenido.RowCount = 2
        Me.tblContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.22807!))
        Me.tblContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tblContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblContenido.Size = New System.Drawing.Size(1142, 550)
        Me.tblContenido.TabIndex = 1
        '
        'dgvInicio
        '
        Me.dgvInicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvInicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvInicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvInicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInicio.ColumnHeadersHeight = 31
        Me.dgvInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInicio.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInicio.EnableHeadersVisualStyles = False
        Me.dgvInicio.Location = New System.Drawing.Point(0, 0)
        Me.dgvInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvInicio.Name = "dgvInicio"
        Me.dgvInicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInicio.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInicio.RowHeadersVisible = False
        Me.dgvInicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInicio.Size = New System.Drawing.Size(1142, 506)
        Me.dgvInicio.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 506)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(995, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ASCS ® - 2018"
        '
        'tblBarraInicio
        '
        Me.tblBarraInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.tblBarraInicio.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.tblBarraInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblBarraInicio.ColumnCount = 2
        Me.tblBarraInicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.02941!))
        Me.tblBarraInicio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.97059!))
        Me.tblBarraInicio.Controls.Add(Me.ptLogo, 0, 0)
        Me.tblBarraInicio.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.tblBarraInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblBarraInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBarraInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tblBarraInicio.Location = New System.Drawing.Point(1, 1)
        Me.tblBarraInicio.Margin = New System.Windows.Forms.Padding(1)
        Me.tblBarraInicio.Name = "tblBarraInicio"
        Me.tblBarraInicio.RowCount = 1
        Me.tblBarraInicio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBarraInicio.Size = New System.Drawing.Size(1360, 190)
        Me.tblBarraInicio.TabIndex = 1
        '
        'ptLogo
        '
        Me.ptLogo.BackColor = System.Drawing.Color.Transparent
        Me.ptLogo.BackgroundImage = Global.Desktop.My.Resources.Resources.logoSpa
        Me.ptLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptLogo.Image = Global.Desktop.My.Resources.Resources.logoSpa
        Me.ptLogo.Location = New System.Drawing.Point(10, 10)
        Me.ptLogo.Margin = New System.Windows.Forms.Padding(10)
        Me.ptLogo.Name = "ptLogo"
        Me.ptLogo.Size = New System.Drawing.Size(197, 170)
        Me.ptLogo.TabIndex = 0
        Me.ptLogo.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tblBanner, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(217, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.47368!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.52632!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1143, 190)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'tblBanner
        '
        Me.tblBanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tblBanner.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.tblBanner.ColumnCount = 1
        Me.tblBanner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.6148!))
        Me.tblBanner.Controls.Add(Me.txtTarget, 0, 0)
        Me.tblBanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBanner.Location = New System.Drawing.Point(0, 0)
        Me.tblBanner.Margin = New System.Windows.Forms.Padding(0)
        Me.tblBanner.Name = "tblBanner"
        Me.tblBanner.RowCount = 1
        Me.tblBanner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBanner.Size = New System.Drawing.Size(1143, 112)
        Me.tblBanner.TabIndex = 1
        '
        'txtTarget
        '
        Me.txtTarget.AutoSize = True
        Me.txtTarget.BackColor = System.Drawing.Color.Transparent
        Me.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTarget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTarget.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarget.ForeColor = System.Drawing.Color.Cornsilk
        Me.txtTarget.Location = New System.Drawing.Point(0, 0)
        Me.txtTarget.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(1143, 112)
        Me.txtTarget.TabIndex = 1
        Me.txtTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 112)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1143, 78)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92126!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.07874!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1143, 78)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.ptboxBuscar)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 78)
        Me.Panel2.TabIndex = 0
        '
        'ptboxBuscar
        '
        Me.ptboxBuscar.BackColor = System.Drawing.Color.White
        Me.ptboxBuscar.BackgroundImage = Global.Desktop.My.Resources.Resources.search
        Me.ptboxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptboxBuscar.Location = New System.Drawing.Point(283, 24)
        Me.ptboxBuscar.Name = "ptboxBuscar"
        Me.ptboxBuscar.Size = New System.Drawing.Size(33, 28)
        Me.ptboxBuscar.TabIndex = 2
        Me.ptboxBuscar.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBuscar.Location = New System.Drawing.Point(54, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(218, 22)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.TabStop = False
        Me.txtBuscar.Text = "BUSCAR"
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.rectBuscar})
        Me.ShapeContainer2.Size = New System.Drawing.Size(342, 78)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 341
        Me.LineShape1.X2 = 341
        Me.LineShape1.Y1 = -10
        Me.LineShape1.Y2 = 111
        '
        'rectBuscar
        '
        Me.rectBuscar.BackColor = System.Drawing.Color.White
        Me.rectBuscar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectBuscar.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.rectBuscar.Location = New System.Drawing.Point(22, 20)
        Me.rectBuscar.Name = "rectBuscar"
        Me.rectBuscar.Size = New System.Drawing.Size(301, 36)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblReservas)
        Me.Panel3.Controls.Add(Me.lblActualizar)
        Me.Panel3.Controls.Add(Me.lblModificar)
        Me.Panel3.Controls.Add(Me.lblNuevo)
        Me.Panel3.Controls.Add(Me.ShapeContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(342, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 78)
        Me.Panel3.TabIndex = 5
        '
        'lblReservas
        '
        Me.lblReservas.AutoSize = True
        Me.lblReservas.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblReservas.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblReservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblReservas.Location = New System.Drawing.Point(602, 24)
        Me.lblReservas.Name = "lblReservas"
        Me.lblReservas.Size = New System.Drawing.Size(133, 28)
        Me.lblReservas.TabIndex = 22
        Me.lblReservas.Text = "Ver Reservas"
        Me.lblReservas.Visible = False
        '
        'lblActualizar
        '
        Me.lblActualizar.AutoSize = True
        Me.lblActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblActualizar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblActualizar.Location = New System.Drawing.Point(423, 24)
        Me.lblActualizar.Name = "lblActualizar"
        Me.lblActualizar.Size = New System.Drawing.Size(108, 28)
        Me.lblActualizar.TabIndex = 1
        Me.lblActualizar.Text = "Actualizar"
        '
        'lblModificar
        '
        Me.lblModificar.AutoSize = True
        Me.lblModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblModificar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblModificar.Location = New System.Drawing.Point(240, 24)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(104, 28)
        Me.lblModificar.TabIndex = 1
        Me.lblModificar.Text = "Modificar"
        '
        'lblNuevo
        '
        Me.lblNuevo.AutoSize = True
        Me.lblNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblNuevo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblNuevo.Location = New System.Drawing.Point(61, 24)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(88, 28)
        Me.lblNuevo.TabIndex = 1
        Me.lblNuevo.Text = "Agregar"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.rectActualizar, Me.rectModificar, Me.rectAgregar})
        Me.ShapeContainer1.Size = New System.Drawing.Size(801, 78)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.Location = New System.Drawing.Point(588, 20)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(162, 39)
        Me.RectangleShape1.Visible = False
        '
        'rectActualizar
        '
        Me.rectActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rectActualizar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectActualizar.BorderColor = System.Drawing.Color.DimGray
        Me.rectActualizar.Location = New System.Drawing.Point(394, 19)
        Me.rectActualizar.Name = "rectActualizar"
        Me.rectActualizar.Size = New System.Drawing.Size(162, 39)
        '
        'rectModificar
        '
        Me.rectModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rectModificar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectModificar.BorderColor = System.Drawing.Color.DimGray
        Me.rectModificar.Location = New System.Drawing.Point(209, 19)
        Me.rectModificar.Name = "rectModificar"
        Me.rectModificar.Size = New System.Drawing.Size(162, 39)
        '
        'rectAgregar
        '
        Me.rectAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rectAgregar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectAgregar.BorderColor = System.Drawing.Color.DimGray
        Me.rectAgregar.Location = New System.Drawing.Point(21, 19)
        Me.rectAgregar.Name = "rectAgregar"
        Me.rectAgregar.Size = New System.Drawing.Size(162, 39)
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.tblInicio)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tblInicio.ResumeLayout(False)
        Me.tblPrincipal.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tblMenuCostado.ResumeLayout(False)
        Me.tblMenuCostado.PerformLayout()
        Me.tblContenido.ResumeLayout(False)
        CType(Me.dgvInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblBarraInicio.ResumeLayout(False)
        CType(Me.ptLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tblBanner.ResumeLayout(False)
        Me.tblBanner.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ptboxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblInicio As TableLayoutPanel
    Friend WithEvents tblBarraInicio As TableLayoutPanel
    Friend WithEvents ptLogo As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tblBanner As TableLayoutPanel
    Friend WithEvents txtTarget As Label
    Friend WithEvents tblPrincipal As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblSalir As Label
    Friend WithEvents tblMenuCostado As TableLayoutPanel
    Friend WithEvents lblServicios As Label
    Friend WithEvents lblAgenda As Label
    Friend WithEvents lblPersonal As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ptboxBuscar As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents rectBuscar As PowerPacks.RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblModificar As Label
    Friend WithEvents lblNuevo As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents rectModificar As PowerPacks.RectangleShape
    Friend WithEvents rectAgregar As PowerPacks.RectangleShape
    Friend WithEvents tblContenido As TableLayoutPanel
    Friend WithEvents dgvInicio As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblActualizar As Label
    Friend WithEvents rectActualizar As PowerPacks.RectangleShape
    Friend WithEvents lblVentas As Label
    Friend WithEvents lblReservas As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
