<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RealizarReserva
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lnlFecha = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.NumericUpDown()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tabServiciosPaquetes = New System.Windows.Forms.TabControl()
        Me.tbServicios = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvServicios = New System.Windows.Forms.DataGridView()
        Me.tbPaquetes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvPaquetes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSesiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPaquete = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblMenos = New System.Windows.Forms.Label()
        Me.lblMas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtClienteRUC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClienteApe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClienteCI = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.lblGUARDAR = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabServiciosPaquetes.SuspendLayout()
        Me.tbServicios.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPaquetes.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.843137!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.15686!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1144, 673)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.Panel1.Size = New System.Drawing.Size(1144, 48)
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
        Me.lblTitulo.Size = New System.Drawing.Size(210, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "REALIZAR RESERVA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1144, 564)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtComentario)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lnlFecha)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtFecha)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtHoraFin)
        Me.GroupBox3.Controls.Add(Me.txtDuracion)
        Me.GroupBox3.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox3.Controls.Add(Me.lblDuracion)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 260)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(116, 170)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(251, 69)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Comentario"
        '
        'lnlFecha
        '
        Me.lnlFecha.AutoSize = True
        Me.lnlFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lnlFecha.Location = New System.Drawing.Point(10, 30)
        Me.lnlFecha.Name = "lnlFecha"
        Me.lnlFecha.Size = New System.Drawing.Size(54, 21)
        Me.lnlFecha.TabIndex = 0
        Me.lnlFecha.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(202, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Hora Fin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hora Inicio"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(116, 28)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(250, 27)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(255, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "minutos"
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Enabled = False
        Me.txtHoraFin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFin.Location = New System.Drawing.Point(287, 73)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.ReadOnly = True
        Me.txtHoraFin.Size = New System.Drawing.Size(80, 27)
        Me.txtHoraFin.TabIndex = 2
        Me.txtHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Enabled = False
        Me.txtDuracion.Location = New System.Drawing.Point(116, 121)
        Me.txtDuracion.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(120, 29)
        Me.txtDuracion.TabIndex = 15
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDuracion.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Enabled = False
        Me.txtHoraInicio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.Location = New System.Drawing.Point(116, 73)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.ReadOnly = True
        Me.txtHoraInicio.Size = New System.Drawing.Size(80, 27)
        Me.txtHoraInicio.TabIndex = 2
        Me.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblDuracion.Location = New System.Drawing.Point(10, 121)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(80, 21)
        Me.lblDuracion.TabIndex = 0
        Me.lblDuracion.Text = "Duración"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tabServiciosPaquetes)
        Me.GroupBox2.Controls.Add(Me.txtEntrega)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.lblMenos)
        Me.GroupBox2.Controls.Add(Me.lblMas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 487)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'tabServiciosPaquetes
        '
        Me.tabServiciosPaquetes.Controls.Add(Me.tbServicios)
        Me.tabServiciosPaquetes.Controls.Add(Me.tbPaquetes)
        Me.tabServiciosPaquetes.Location = New System.Drawing.Point(129, 42)
        Me.tabServiciosPaquetes.Name = "tabServiciosPaquetes"
        Me.tabServiciosPaquetes.SelectedIndex = 0
        Me.tabServiciosPaquetes.Size = New System.Drawing.Size(565, 358)
        Me.tabServiciosPaquetes.TabIndex = 14
        '
        'tbServicios
        '
        Me.tbServicios.Controls.Add(Me.Panel4)
        Me.tbServicios.Location = New System.Drawing.Point(4, 30)
        Me.tbServicios.Name = "tbServicios"
        Me.tbServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tbServicios.Size = New System.Drawing.Size(557, 324)
        Me.tbServicios.TabIndex = 0
        Me.tbServicios.Text = "Servicios"
        Me.tbServicios.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvServicios)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(551, 318)
        Me.Panel4.TabIndex = 6
        '
        'dgvServicios
        '
        Me.dgvServicios.AllowUserToAddRows = False
        Me.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvServicios.BackgroundColor = System.Drawing.Color.White
        Me.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServicios.ColumnHeadersHeight = 31
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServicios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvServicios.EnableHeadersVisualStyles = False
        Me.dgvServicios.Location = New System.Drawing.Point(0, 0)
        Me.dgvServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServicios.RowHeadersVisible = False
        Me.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServicios.Size = New System.Drawing.Size(551, 318)
        Me.dgvServicios.TabIndex = 19
        '
        'tbPaquetes
        '
        Me.tbPaquetes.Controls.Add(Me.TableLayoutPanel2)
        Me.tbPaquetes.Location = New System.Drawing.Point(4, 30)
        Me.tbPaquetes.Margin = New System.Windows.Forms.Padding(0)
        Me.tbPaquetes.Name = "tbPaquetes"
        Me.tbPaquetes.Size = New System.Drawing.Size(557, 324)
        Me.tbPaquetes.TabIndex = 1
        Me.tbPaquetes.Text = "Paquetes"
        Me.tbPaquetes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvPaquetes, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPaquete, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.3522!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.6478!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(557, 324)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'dgvPaquetes
        '
        Me.dgvPaquetes.AllowUserToAddRows = False
        Me.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPaquetes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvPaquetes.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaquetes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPaquetes.ColumnHeadersHeight = 31
        Me.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPaquetes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Servicio, Me.CantSesiones})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaquetes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPaquetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPaquetes.EnableHeadersVisualStyles = False
        Me.dgvPaquetes.Location = New System.Drawing.Point(0, 52)
        Me.dgvPaquetes.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPaquetes.Name = "dgvPaquetes"
        Me.dgvPaquetes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaquetes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPaquetes.RowHeadersVisible = False
        Me.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaquetes.Size = New System.Drawing.Size(557, 272)
        Me.dgvPaquetes.TabIndex = 21
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Servicio
        '
        Me.Servicio.DataPropertyName = "Servicio"
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        '
        'CantSesiones
        '
        Me.CantSesiones.DataPropertyName = "Cantidad"
        Me.CantSesiones.HeaderText = "C.Sesiones"
        Me.CantSesiones.Name = "CantSesiones"
        Me.CantSesiones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CantSesiones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblPaquete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPaquete.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaquete.Location = New System.Drawing.Point(0, 0)
        Me.lblPaquete.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(557, 52)
        Me.lblPaquete.TabIndex = 0
        Me.lblPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEntrega
        '
        Me.txtEntrega.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrega.Location = New System.Drawing.Point(468, 439)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(198, 27)
        Me.txtEntrega.TabIndex = 1
        Me.txtEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(384, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Entrega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(384, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(468, 406)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(198, 27)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMenos
        '
        Me.lblMenos.AutoSize = True
        Me.lblMenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblMenos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblMenos.Location = New System.Drawing.Point(26, 130)
        Me.lblMenos.Name = "lblMenos"
        Me.lblMenos.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblMenos.Size = New System.Drawing.Size(94, 31)
        Me.lblMenos.TabIndex = 13
        Me.lblMenos.Text = "Eliminar"
        '
        'lblMas
        '
        Me.lblMas.AutoSize = True
        Me.lblMas.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblMas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblMas.Location = New System.Drawing.Point(26, 75)
        Me.lblMas.Name = "lblMas"
        Me.lblMas.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblMas.Size = New System.Drawing.Size(91, 31)
        Me.lblMas.TabIndex = 13
        Me.lblMas.Text = "Agregar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(257, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SERVICIOS SOLICITADOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtClienteRUC)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtClienteApe)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtClienteCI)
        Me.GroupBox1.Controls.Add(Me.txtClienteNombre)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 221)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(196, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "RUC"
        '
        'txtClienteRUC
        '
        Me.txtClienteRUC.Enabled = False
        Me.txtClienteRUC.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteRUC.Location = New System.Drawing.Point(200, 178)
        Me.txtClienteRUC.Name = "txtClienteRUC"
        Me.txtClienteRUC.ReadOnly = True
        Me.txtClienteRUC.Size = New System.Drawing.Size(170, 27)
        Me.txtClienteRUC.TabIndex = 4
        Me.txtClienteRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Apellido"
        '
        'txtClienteApe
        '
        Me.txtClienteApe.Enabled = False
        Me.txtClienteApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteApe.Location = New System.Drawing.Point(11, 176)
        Me.txtClienteApe.Name = "txtClienteApe"
        Me.txtClienteApe.ReadOnly = True
        Me.txtClienteApe.Size = New System.Drawing.Size(163, 27)
        Me.txtClienteApe.TabIndex = 4
        Me.txtClienteApe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(152, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CLIENTE"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(21, 39)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(244, 27)
        Me.txtBusqueda.TabIndex = 4
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(281, 39)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblBuscar.Size = New System.Drawing.Size(88, 30)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "BUSCAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(196, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre"
        '
        'txtClienteCI
        '
        Me.txtClienteCI.Enabled = False
        Me.txtClienteCI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCI.Location = New System.Drawing.Point(200, 124)
        Me.txtClienteCI.Name = "txtClienteCI"
        Me.txtClienteCI.ReadOnly = True
        Me.txtClienteCI.Size = New System.Drawing.Size(170, 27)
        Me.txtClienteCI.TabIndex = 4
        Me.txtClienteCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Enabled = False
        Me.txtClienteNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteNombre.Location = New System.Drawing.Point(11, 123)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.ReadOnly = True
        Me.txtClienteNombre.Size = New System.Drawing.Size(163, 27)
        Me.txtClienteNombre.TabIndex = 4
        Me.txtClienteNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 25)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(381, 193)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -4
        Me.LineShape1.X2 = 395
        Me.LineShape1.Y1 = 58
        Me.LineShape1.Y2 = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCancelar)
        Me.Panel3.Controls.Add(Me.lblReset)
        Me.Panel3.Controls.Add(Me.lblGUARDAR)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 612)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1144, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelar.Location = New System.Drawing.Point(745, 11)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblCancelar.Size = New System.Drawing.Size(152, 41)
        Me.lblCancelar.TabIndex = 15
        Me.lblCancelar.Text = "CANCELAR"
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblReset.Location = New System.Drawing.Point(467, 11)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Padding = New System.Windows.Forms.Padding(40, 10, 40, 10)
        Me.lblReset.Size = New System.Drawing.Size(136, 41)
        Me.lblReset.TabIndex = 14
        Me.lblReset.Text = "RESET"
        '
        'lblGUARDAR
        '
        Me.lblGUARDAR.AutoSize = True
        Me.lblGUARDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblGUARDAR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblGUARDAR.Location = New System.Drawing.Point(216, 11)
        Me.lblGUARDAR.Name = "lblGUARDAR"
        Me.lblGUARDAR.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblGUARDAR.Size = New System.Drawing.Size(147, 41)
        Me.lblGUARDAR.TabIndex = 13
        Me.lblGUARDAR.Text = "GUARDAR"
        '
        'RealizarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 673)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "RealizarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarReserva"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabServiciosPaquetes.ResumeLayout(False)
        Me.tbServicios.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPaquetes.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoraInicio As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lnlFecha As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCancelar As Label
    Friend WithEvents lblReset As Label
    Friend WithEvents lblGUARDAR As Label
    Friend WithEvents lblMenos As Label
    Friend WithEvents lblMas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuracion As NumericUpDown
    Friend WithEvents lblDuracion As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtClienteCI As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtClienteRUC As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtClienteApe As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHoraFin As TextBox
    Friend WithEvents txtEntrega As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvServicios As DataGridView
    Friend WithEvents tabServiciosPaquetes As TabControl
    Friend WithEvents tbServicios As TabPage
    Friend WithEvents tbPaquetes As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvPaquetes As DataGridView
    Friend WithEvents lblPaquete As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents CantSesiones As DataGridViewTextBoxColumn
End Class
