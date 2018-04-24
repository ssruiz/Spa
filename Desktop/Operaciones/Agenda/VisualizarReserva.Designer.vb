<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarReserva
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.FechaCompra = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPaquete = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvServicios = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.lblCancelarReserva = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPagar = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.rdEfectivo = New System.Windows.Forms.RadioButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.754772!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.24522!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1362, 750)
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
        Me.Panel1.Size = New System.Drawing.Size(1362, 46)
        Me.Panel1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(362, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(226, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "RESERVA REALIZADA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 643)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.36765!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.63235!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel8, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1362, 643)
        Me.TableLayoutPanel4.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel7.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(2, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(411, 639)
        Me.Panel7.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(15, 14)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46512!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53488!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(350, 447)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 46)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "DATOS RESERVA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtClienteNombre)
        Me.FlowLayoutPanel1.Controls.Add(Me.FechaCompra)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtFecha)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSub)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtTotal)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDescuento)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSaldo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtHoraInicio)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 48)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(348, 398)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cliente"
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
        Me.FechaCompra.Size = New System.Drawing.Size(117, 21)
        Me.FechaCompra.TabIndex = 0
        Me.FechaCompra.Text = "Fecha Reserva"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(3, 78)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(333, 27)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sub-Total"
        '
        'txtSub
        '
        Me.txtSub.Enabled = False
        Me.txtSub.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.Location = New System.Drawing.Point(3, 132)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.ReadOnly = True
        Me.txtSub.Size = New System.Drawing.Size(333, 27)
        Me.txtSub.TabIndex = 4
        Me.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(3, 186)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(333, 27)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descuento"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(3, 240)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(333, 27)
        Me.txtDescuento.TabIndex = 2
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Saldo a pagar"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(3, 294)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(333, 27)
        Me.txtSaldo.TabIndex = 4
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hora Inicio"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Enabled = False
        Me.txtHoraInicio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.Location = New System.Drawing.Point(3, 348)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.ReadOnly = True
        Me.txtHoraInicio.Size = New System.Drawing.Size(333, 27)
        Me.txtHoraInicio.TabIndex = 2
        Me.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(415, 2)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(945, 639)
        Me.Panel8.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblPaquete, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(43, 14)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.154507!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.01287!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.72727!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(844, 435)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblPaquete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPaquete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaquete.Location = New System.Drawing.Point(2, 2)
        Me.lblPaquete.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(840, 34)
        Me.lblPaquete.TabIndex = 0
        Me.lblPaquete.Text = "SERVICIOS SOLICITADOS"
        Me.lblPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(5, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(834, 246)
        Me.Panel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.39618!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(834, 246)
        Me.TableLayoutPanel6.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvServicios)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(828, 240)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServicios.ColumnHeadersHeight = 31
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServicios.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvServicios.EnableHeadersVisualStyles = False
        Me.dgvServicios.Location = New System.Drawing.Point(0, 0)
        Me.dgvServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvServicios.RowHeadersVisible = False
        Me.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServicios.Size = New System.Drawing.Size(828, 240)
        Me.dgvServicios.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.txtComentario)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(5, 295)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(834, 135)
        Me.Panel6.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(117, 26)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(383, 105)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblSalir)
        Me.Panel3.Controls.Add(Me.lblCancelarReserva)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 689)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1362, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblSalir.Location = New System.Drawing.Point(1205, 11)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblSalir.Size = New System.Drawing.Size(131, 41)
        Me.lblSalir.TabIndex = 15
        Me.lblSalir.Text = "VOLVER"
        '
        'lblCancelarReserva
        '
        Me.lblCancelarReserva.AutoSize = True
        Me.lblCancelarReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelarReserva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelarReserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelarReserva.Location = New System.Drawing.Point(97, 11)
        Me.lblCancelarReserva.Name = "lblCancelarReserva"
        Me.lblCancelarReserva.Padding = New System.Windows.Forms.Padding(10)
        Me.lblCancelarReserva.Size = New System.Drawing.Size(185, 41)
        Me.lblCancelarReserva.TabIndex = 14
        Me.lblCancelarReserva.Text = "CANCELAR RESERVA"
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(67, 13)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(266, 27)
        Me.txtPago.TabIndex = 4
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monto"
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
        Me.Label3.Size = New System.Drawing.Size(347, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Realizar Pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPagar
        '
        Me.lblPagar.AutoSize = True
        Me.lblPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPagar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagar.Location = New System.Drawing.Point(1, 134)
        Me.lblPagar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPagar.Name = "lblPagar"
        Me.lblPagar.Size = New System.Drawing.Size(347, 34)
        Me.lblPagar.TabIndex = 3
        Me.lblPagar.Text = "PAGAR"
        Me.lblPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel10, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblPagar, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel9, 0, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(15, 467)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.33614!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.66386!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(349, 169)
        Me.TableLayoutPanel5.TabIndex = 18
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbTarjeta.Location = New System.Drawing.Point(143, 2)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(164, 25)
        Me.rbTarjeta.TabIndex = 0
        Me.rbTarjeta.TabStop = True
        Me.rbTarjeta.Text = "Tarjeta de Crédito"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'rdEfectivo
        '
        Me.rdEfectivo.AutoSize = True
        Me.rdEfectivo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdEfectivo.Location = New System.Drawing.Point(18, 3)
        Me.rdEfectivo.Name = "rdEfectivo"
        Me.rdEfectivo.Size = New System.Drawing.Size(90, 25)
        Me.rdEfectivo.TabIndex = 0
        Me.rdEfectivo.TabStop = True
        Me.rdEfectivo.Text = "Efectivo"
        Me.rdEfectivo.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.rbTarjeta)
        Me.Panel9.Controls.Add(Me.rdEfectivo)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(1, 92)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(347, 41)
        Me.Panel9.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.txtPago)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(1, 38)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(347, 53)
        Me.Panel10.TabIndex = 0
        '
        'VisualizarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 750)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VisualizarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualizarReserva"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtHoraInicio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSalir As Label
    Friend WithEvents lblCancelarReserva As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents FechaCompra As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblPaquete As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvServicios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblPagar As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents rdEfectivo As RadioButton
End Class
