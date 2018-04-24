<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgendarServiciosPaquete
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPagar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvSesionesAgend = New System.Windows.Forms.DataGridView()
        Me.IDCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDReserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.FechaCompra = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComent = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvPaquetes = New System.Windows.Forms.DataGridView()
        Me.IDR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesRest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPaquete = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.rdEfectivo = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvSesionesAgend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.048458!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.95154!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1362, 742)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 48)
        Me.Panel1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(466, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(187, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Agendar Sesiones"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 633)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblPagar, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel4, 0, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(27, 468)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16807!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.50336!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.84564!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.18792!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(336, 150)
        Me.TableLayoutPanel5.TabIndex = 17
        '
        'lblPagar
        '
        Me.lblPagar.AutoSize = True
        Me.lblPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPagar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagar.Location = New System.Drawing.Point(1, 107)
        Me.lblPagar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPagar.Name = "lblPagar"
        Me.lblPagar.Size = New System.Drawing.Size(334, 42)
        Me.lblPagar.TabIndex = 3
        Me.lblPagar.Text = "PAGAR"
        Me.lblPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 1)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(334, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Realizar Pago"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtPago)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(1, 31)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(334, 36)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Monto"
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(70, 3)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(254, 27)
        Me.txtPago.TabIndex = 4
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgvSesionesAgend, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(378, 313)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.3522!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.6478!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(960, 305)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'dgvSesionesAgend
        '
        Me.dgvSesionesAgend.AllowUserToAddRows = False
        Me.dgvSesionesAgend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSesionesAgend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvSesionesAgend.BackgroundColor = System.Drawing.Color.White
        Me.dgvSesionesAgend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSesionesAgend.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSesionesAgend.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvSesionesAgend.ColumnHeadersHeight = 50
        Me.dgvSesionesAgend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSesionesAgend.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCita, Me.IDReserva, Me.IDServ, Me.ServicioCita, Me.fechaCita, Me.Hora, Me.Estado})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSesionesAgend.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvSesionesAgend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSesionesAgend.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSesionesAgend.EnableHeadersVisualStyles = False
        Me.dgvSesionesAgend.Location = New System.Drawing.Point(0, 49)
        Me.dgvSesionesAgend.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvSesionesAgend.Name = "dgvSesionesAgend"
        Me.dgvSesionesAgend.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSesionesAgend.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvSesionesAgend.RowHeadersVisible = False
        Me.dgvSesionesAgend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSesionesAgend.Size = New System.Drawing.Size(960, 256)
        Me.dgvSesionesAgend.TabIndex = 21
        '
        'IDCita
        '
        Me.IDCita.DataPropertyName = "IDS"
        Me.IDCita.HeaderText = "IDS"
        Me.IDCita.Name = "IDCita"
        Me.IDCita.Visible = False
        '
        'IDReserva
        '
        Me.IDReserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IDReserva.DataPropertyName = "IDR"
        Me.IDReserva.FillWeight = 50.0!
        Me.IDReserva.HeaderText = "IDR"
        Me.IDReserva.Name = "IDReserva"
        Me.IDReserva.Visible = False
        Me.IDReserva.Width = 60
        '
        'IDServ
        '
        Me.IDServ.DataPropertyName = "IDServ"
        Me.IDServ.HeaderText = "IDServ"
        Me.IDServ.Name = "IDServ"
        Me.IDServ.Visible = False
        '
        'ServicioCita
        '
        Me.ServicioCita.DataPropertyName = "Servicio"
        Me.ServicioCita.HeaderText = "Servicio"
        Me.ServicioCita.Name = "ServicioCita"
        '
        'fechaCita
        '
        Me.fechaCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fechaCita.DataPropertyName = "Fecha"
        Me.fechaCita.FillWeight = 253.8071!
        Me.fechaCita.HeaderText = "Fecha"
        Me.fechaCita.Name = "fechaCita"
        Me.fechaCita.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fechaCita.Width = 54
        '
        'Hora
        '
        Me.Hora.DataPropertyName = "Hora"
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(960, 49)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CITAS AGENDADAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(26, 28)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46512!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53488!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(336, 426)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 44)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DATOS RESERVA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtClienteNombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.FechaCompra)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtFecha)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtTotal)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSaldo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtComent)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 46)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(334, 379)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cliente"
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Enabled = False
        Me.txtClienteNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteNombre.Location = New System.Drawing.Point(3, 24)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.ReadOnly = True
        Me.txtClienteNombre.Size = New System.Drawing.Size(333, 27)
        Me.txtClienteNombre.TabIndex = 1
        Me.txtClienteNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FechaCompra
        '
        Me.FechaCompra.AutoSize = True
        Me.FechaCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.FechaCompra.Location = New System.Drawing.Point(3, 54)
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.Size = New System.Drawing.Size(118, 21)
        Me.FechaCompra.TabIndex = 0
        Me.FechaCompra.Text = "Fecha Compra"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(3, 78)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(333, 27)
        Me.txtFecha.TabIndex = 4
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(3, 132)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(333, 27)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saldo a pagar"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(3, 186)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(333, 27)
        Me.txtSaldo.TabIndex = 4
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Comentario"
        '
        'txtComent
        '
        Me.txtComent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComent.Location = New System.Drawing.Point(3, 240)
        Me.txtComent.Name = "txtComent"
        Me.txtComent.Size = New System.Drawing.Size(333, 103)
        Me.txtComent.TabIndex = 5
        Me.txtComent.Text = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvPaquetes, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPaquete, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(378, 28)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.3522!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.6478!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(960, 275)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'dgvPaquetes
        '
        Me.dgvPaquetes.AllowUserToAddRows = False
        Me.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPaquetes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvPaquetes.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaquetes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvPaquetes.ColumnHeadersHeight = 50
        Me.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPaquetes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDR, Me.IDS, Me.Servicio, Me.SesionesR, Me.SesionesRest, Me.TotalS, Me.FechaS})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaquetes.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvPaquetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvPaquetes.EnableHeadersVisualStyles = False
        Me.dgvPaquetes.Location = New System.Drawing.Point(0, 44)
        Me.dgvPaquetes.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPaquetes.Name = "dgvPaquetes"
        Me.dgvPaquetes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaquetes.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvPaquetes.RowHeadersVisible = False
        Me.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaquetes.Size = New System.Drawing.Size(960, 231)
        Me.dgvPaquetes.TabIndex = 21
        '
        'IDR
        '
        Me.IDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IDR.DataPropertyName = "IDR"
        Me.IDR.FillWeight = 50.0!
        Me.IDR.HeaderText = "IDR"
        Me.IDR.Name = "IDR"
        Me.IDR.Visible = False
        Me.IDR.Width = 60
        '
        'IDS
        '
        Me.IDS.DataPropertyName = "IDS"
        Me.IDS.HeaderText = "IDS"
        Me.IDS.Name = "IDS"
        Me.IDS.Visible = False
        '
        'Servicio
        '
        Me.Servicio.DataPropertyName = "Servicio"
        Me.Servicio.FillWeight = 61.54822!
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        '
        'SesionesR
        '
        Me.SesionesR.DataPropertyName = "Sesiones Realizadas"
        Me.SesionesR.FillWeight = 61.54822!
        Me.SesionesR.HeaderText = "Sesiones Realizadas"
        Me.SesionesR.Name = "SesionesR"
        Me.SesionesR.ReadOnly = True
        '
        'SesionesRest
        '
        Me.SesionesRest.FillWeight = 61.54822!
        Me.SesionesRest.HeaderText = "Sesiones Restantes"
        Me.SesionesRest.Name = "SesionesRest"
        Me.SesionesRest.ReadOnly = True
        '
        'TotalS
        '
        Me.TotalS.DataPropertyName = "Total"
        Me.TotalS.FillWeight = 61.54822!
        Me.TotalS.HeaderText = "Total"
        Me.TotalS.Name = "TotalS"
        Me.TotalS.ReadOnly = True
        Me.TotalS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TotalS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FechaS
        '
        Me.FechaS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaS.FillWeight = 253.8071!
        Me.FechaS.HeaderText = "Fecha"
        Me.FechaS.MinimumWidth = 30
        Me.FechaS.Name = "FechaS"
        Me.FechaS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblPaquete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPaquete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaquete.Location = New System.Drawing.Point(0, 0)
        Me.lblPaquete.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(960, 44)
        Me.lblPaquete.TabIndex = 0
        Me.lblPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCancelar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 681)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1362, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelar.Location = New System.Drawing.Point(1225, 11)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblCancelar.Size = New System.Drawing.Size(113, 41)
        Me.lblCancelar.TabIndex = 15
        Me.lblCancelar.Text = "SALIR"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbTarjeta)
        Me.Panel4.Controls.Add(Me.rdEfectivo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(1, 68)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(334, 38)
        Me.Panel4.TabIndex = 4
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbTarjeta.Location = New System.Drawing.Point(147, 7)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(164, 25)
        Me.rbTarjeta.TabIndex = 1
        Me.rbTarjeta.TabStop = True
        Me.rbTarjeta.Text = "Tarjeta de Crédito"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'rdEfectivo
        '
        Me.rdEfectivo.AutoSize = True
        Me.rdEfectivo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdEfectivo.Location = New System.Drawing.Point(26, 6)
        Me.rdEfectivo.Name = "rdEfectivo"
        Me.rdEfectivo.Size = New System.Drawing.Size(90, 25)
        Me.rdEfectivo.TabIndex = 2
        Me.rdEfectivo.TabStop = True
        Me.rdEfectivo.Text = "Efectivo"
        Me.rdEfectivo.UseVisualStyleBackColor = True
        '
        'AgendarServiciosPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgendarServiciosPaquete"
        Me.Text = "AgendarServiciosPaquete"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dgvSesionesAgend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCancelar As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvPaquetes As DataGridView
    Friend WithEvents lblPaquete As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgvSesionesAgend As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents IDCita As DataGridViewTextBoxColumn
    Friend WithEvents IDReserva As DataGridViewTextBoxColumn
    Friend WithEvents IDServ As DataGridViewTextBoxColumn
    Friend WithEvents ServicioCita As DataGridViewTextBoxColumn
    Friend WithEvents fechaCita As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblPagar As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents FechaCompra As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtComent As RichTextBox
    Friend WithEvents IDR As DataGridViewTextBoxColumn
    Friend WithEvents IDS As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents SesionesR As DataGridViewTextBoxColumn
    Friend WithEvents SesionesRest As DataGridViewTextBoxColumn
    Friend WithEvents TotalS As DataGridViewTextBoxColumn
    Friend WithEvents FechaS As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents rdEfectivo As RadioButton
End Class
