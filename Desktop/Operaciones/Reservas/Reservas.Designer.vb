<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpInicio = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabReservas = New System.Windows.Forms.TabControl()
        Me.tpReservasServicios = New System.Windows.Forms.TabPage()
        Me.dgvReservasServicios = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvReservaP = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNuevaReserva = New System.Windows.Forms.Label()
        Me.lblCancelarR = New System.Windows.Forms.Label()
        Me.lblVerR = New System.Windows.Forms.Label()
        Me.IDReservaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregaRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentarioRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoRp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDReserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicioR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentarioR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tabReservas.SuspendLayout()
        Me.tpReservasServicios.SuspendLayout()
        CType(Me.dgvReservasServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvReservaP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.195301!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.8047!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1362, 742)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1358, 52)
        Me.Panel1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(379, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(116, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "RESERVAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(2, 56)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1358, 684)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82278!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.17722!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1358, 684)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.88342!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.11658!))
        Me.TableLayoutPanel7.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1358, 108)
        Me.TableLayoutPanel7.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtBusqueda)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(363, 104)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BUSCAR CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(9, 52)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(334, 27)
        Me.txtBusqueda.TabIndex = 6
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblBuscar)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.dpfin)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.dpInicio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(367, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(989, 104)
        Me.Panel5.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(627, 49)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Padding = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.lblBuscar.Size = New System.Drawing.Size(108, 30)
        Me.lblBuscar.TabIndex = 8
        Me.lblBuscar.Text = "BUSCAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESDE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dpfin
        '
        Me.dpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpfin.Location = New System.Drawing.Point(388, 50)
        Me.dpfin.Name = "dpfin"
        Me.dpfin.Size = New System.Drawing.Size(218, 29)
        Me.dpfin.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(310, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "HASTA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dpInicio
        '
        Me.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpInicio.Location = New System.Drawing.Point(86, 50)
        Me.dpInicio.Name = "dpInicio"
        Me.dpInicio.Size = New System.Drawing.Size(218, 29)
        Me.dpInicio.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tabReservas, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 108)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1358, 576)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'tabReservas
        '
        Me.tabReservas.Controls.Add(Me.tpReservasServicios)
        Me.tabReservas.Controls.Add(Me.TabPage2)
        Me.tabReservas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabReservas.Location = New System.Drawing.Point(0, 0)
        Me.tabReservas.Margin = New System.Windows.Forms.Padding(0)
        Me.tabReservas.Name = "tabReservas"
        Me.tabReservas.Padding = New System.Drawing.Point(0, 0)
        Me.tabReservas.SelectedIndex = 0
        Me.tabReservas.Size = New System.Drawing.Size(1154, 576)
        Me.tabReservas.TabIndex = 18
        '
        'tpReservasServicios
        '
        Me.tpReservasServicios.Controls.Add(Me.dgvReservasServicios)
        Me.tpReservasServicios.Location = New System.Drawing.Point(4, 30)
        Me.tpReservasServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.tpReservasServicios.Name = "tpReservasServicios"
        Me.tpReservasServicios.Size = New System.Drawing.Size(1146, 542)
        Me.tpReservasServicios.TabIndex = 0
        Me.tpReservasServicios.Text = "Reservas Servicios"
        Me.tpReservasServicios.UseVisualStyleBackColor = True
        '
        'dgvReservasServicios
        '
        Me.dgvReservasServicios.AllowUserToAddRows = False
        Me.dgvReservasServicios.AllowUserToDeleteRows = False
        Me.dgvReservasServicios.AllowUserToOrderColumns = True
        Me.dgvReservasServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservasServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvReservasServicios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvReservasServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvReservasServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservasServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReservasServicios.ColumnHeadersHeight = 31
        Me.dgvReservasServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReservasServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReserva, Me.FechaR, Me.ClienteR, Me.HoraInicioR, Me.ComentarioR, Me.Estado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservasServicios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReservasServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReservasServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReservasServicios.EnableHeadersVisualStyles = False
        Me.dgvReservasServicios.Location = New System.Drawing.Point(0, 0)
        Me.dgvReservasServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvReservasServicios.Name = "dgvReservasServicios"
        Me.dgvReservasServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservasServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReservasServicios.RowHeadersVisible = False
        Me.dgvReservasServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasServicios.Size = New System.Drawing.Size(1146, 542)
        Me.dgvReservasServicios.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvReservaP)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1146, 542)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reserva de Paquetes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvReservaP
        '
        Me.dgvReservaP.AllowUserToAddRows = False
        Me.dgvReservaP.AllowUserToDeleteRows = False
        Me.dgvReservaP.AllowUserToOrderColumns = True
        Me.dgvReservaP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservaP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvReservaP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvReservaP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvReservaP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservaP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReservaP.ColumnHeadersHeight = 31
        Me.dgvReservaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReservaP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservaP, Me.ClienteRP, Me.FechaRp, Me.EntregaRp, Me.SaldoRp, Me.TotalRp, Me.ComentarioRp, Me.EstadoRp})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservaP.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReservaP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReservaP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReservaP.EnableHeadersVisualStyles = False
        Me.dgvReservaP.Location = New System.Drawing.Point(0, 0)
        Me.dgvReservaP.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvReservaP.Name = "dgvReservaP"
        Me.dgvReservaP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservaP.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReservaP.RowHeadersVisible = False
        Me.dgvReservaP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservaP.Size = New System.Drawing.Size(1146, 542)
        Me.dgvReservaP.TabIndex = 18
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1154, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.052265!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.94774!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(204, 576)
        Me.TableLayoutPanel4.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel4.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 29)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(204, 547)
        Me.Panel4.TabIndex = 21
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblSalir, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 490)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(204, 57)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'lblSalir
        '
        Me.lblSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSalir.AutoSize = True
        Me.lblSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblSalir.Location = New System.Drawing.Point(3, 3)
        Me.lblSalir.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(198, 51)
        Me.lblSalir.TabIndex = 16
        Me.lblSalir.Text = "SALIR"
        Me.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblNuevaReserva, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCancelarR, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblVerR, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(204, 176)
        Me.TableLayoutPanel5.TabIndex = 15
        '
        'lblNuevaReserva
        '
        Me.lblNuevaReserva.AutoSize = True
        Me.lblNuevaReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblNuevaReserva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNuevaReserva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaReserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblNuevaReserva.Location = New System.Drawing.Point(3, 0)
        Me.lblNuevaReserva.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblNuevaReserva.Name = "lblNuevaReserva"
        Me.lblNuevaReserva.Size = New System.Drawing.Size(198, 52)
        Me.lblNuevaReserva.TabIndex = 13
        Me.lblNuevaReserva.Text = "NUEVA RESERVA"
        Me.lblNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCancelarR
        '
        Me.lblCancelarR.AutoSize = True
        Me.lblCancelarR.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelarR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCancelarR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelarR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelarR.Location = New System.Drawing.Point(3, 119)
        Me.lblCancelarR.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCancelarR.Name = "lblCancelarR"
        Me.lblCancelarR.Size = New System.Drawing.Size(198, 54)
        Me.lblCancelarR.TabIndex = 14
        Me.lblCancelarR.Text = "CANCELAR RESERVA"
        Me.lblCancelarR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVerR
        '
        Me.lblVerR.AutoSize = True
        Me.lblVerR.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblVerR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVerR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblVerR.Location = New System.Drawing.Point(3, 61)
        Me.lblVerR.Margin = New System.Windows.Forms.Padding(3)
        Me.lblVerR.Name = "lblVerR"
        Me.lblVerR.Size = New System.Drawing.Size(198, 52)
        Me.lblVerR.TabIndex = 14
        Me.lblVerR.Text = "VER RESERVA"
        Me.lblVerR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDReservaP
        '
        Me.IDReservaP.DataPropertyName = "IDReservaP"
        Me.IDReservaP.HeaderText = "IDReserva"
        Me.IDReservaP.Name = "IDReservaP"
        Me.IDReservaP.Visible = False
        '
        'ClienteRP
        '
        Me.ClienteRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClienteRP.DataPropertyName = "Cliente"
        Me.ClienteRP.HeaderText = "Cliente"
        Me.ClienteRP.Name = "ClienteRP"
        Me.ClienteRP.Width = 81
        '
        'FechaRp
        '
        Me.FechaRp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FechaRp.DataPropertyName = "Fecha"
        Me.FechaRp.HeaderText = "Fecha"
        Me.FechaRp.Name = "FechaRp"
        Me.FechaRp.Width = 241
        '
        'EntregaRp
        '
        Me.EntregaRp.DataPropertyName = "Entrega"
        Me.EntregaRp.HeaderText = "Entrega"
        Me.EntregaRp.Name = "EntregaRp"
        '
        'SaldoRp
        '
        Me.SaldoRp.DataPropertyName = "Saldo"
        Me.SaldoRp.HeaderText = "Saldo"
        Me.SaldoRp.Name = "SaldoRp"
        '
        'TotalRp
        '
        Me.TotalRp.DataPropertyName = "Total"
        Me.TotalRp.HeaderText = "Total"
        Me.TotalRp.Name = "TotalRp"
        '
        'ComentarioRp
        '
        Me.ComentarioRp.DataPropertyName = "Comentario"
        Me.ComentarioRp.HeaderText = "Comentario"
        Me.ComentarioRp.Name = "ComentarioRp"
        Me.ComentarioRp.Visible = False
        '
        'EstadoRp
        '
        Me.EstadoRp.DataPropertyName = "Estado"
        Me.EstadoRp.HeaderText = "Estado"
        Me.EstadoRp.Name = "EstadoRp"
        Me.EstadoRp.Visible = False
        '
        'IDReserva
        '
        Me.IDReserva.DataPropertyName = "IDReserva"
        Me.IDReserva.HeaderText = "IDReserva"
        Me.IDReserva.Name = "IDReserva"
        Me.IDReserva.Visible = False
        '
        'FechaR
        '
        Me.FechaR.DataPropertyName = "Fecha"
        Me.FechaR.HeaderText = "Fecha"
        Me.FechaR.Name = "FechaR"
        '
        'ClienteR
        '
        Me.ClienteR.DataPropertyName = "Cliente"
        Me.ClienteR.HeaderText = "Cliente"
        Me.ClienteR.Name = "ClienteR"
        '
        'HoraInicioR
        '
        Me.HoraInicioR.DataPropertyName = "Hora Inicio"
        Me.HoraInicioR.HeaderText = "Hora Inicio"
        Me.HoraInicioR.Name = "HoraInicioR"
        '
        'ComentarioR
        '
        Me.ComentarioR.DataPropertyName = "Comentario"
        Me.ComentarioR.HeaderText = "Comentario"
        Me.ComentarioR.Name = "ComentarioR"
        Me.ComentarioR.Visible = False
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = False
        '
        'Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservas"
        Me.Text = "ReservasCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tabReservas.ResumeLayout(False)
        Me.tpReservasServicios.ResumeLayout(False)
        CType(Me.dgvReservasServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvReservaP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvReservasServicios As DataGridView
    Friend WithEvents tabReservas As TabControl
    Friend WithEvents tpReservasServicios As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvReservaP As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblNuevaReserva As Label
    Friend WithEvents lblVerR As Label
    Friend WithEvents lblCancelarR As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblSalir As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblBuscar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dpfin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dpInicio As DateTimePicker
    Friend WithEvents IDReservaP As DataGridViewTextBoxColumn
    Friend WithEvents ClienteRP As DataGridViewTextBoxColumn
    Friend WithEvents FechaRp As DataGridViewTextBoxColumn
    Friend WithEvents EntregaRp As DataGridViewTextBoxColumn
    Friend WithEvents SaldoRp As DataGridViewTextBoxColumn
    Friend WithEvents TotalRp As DataGridViewTextBoxColumn
    Friend WithEvents ComentarioRp As DataGridViewTextBoxColumn
    Friend WithEvents EstadoRp As DataGridViewTextBoxColumn
    Friend WithEvents IDReserva As DataGridViewTextBoxColumn
    Friend WithEvents FechaR As DataGridViewTextBoxColumn
    Friend WithEvents ClienteR As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicioR As DataGridViewTextBoxColumn
    Friend WithEvents ComentarioR As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
