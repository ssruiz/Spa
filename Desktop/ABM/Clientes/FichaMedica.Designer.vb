<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichaMedica))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbHistorial = New System.Windows.Forms.GroupBox()
        Me.lblVerHistorial = New System.Windows.Forms.Label()
        Me.lblAgregarHistorial = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.gbEncargado = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblActEncargado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombreEncargado = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtApellidoEncargado = New System.Windows.Forms.TextBox()
        Me.txtEdadEncargado = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCiEncargado = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtOcupacionEncargado = New System.Windows.Forms.TextBox()
        Me.txtTelefonoEncargado = New System.Windows.Forms.TextBox()
        Me.gbFichaMed = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblActAnt = New System.Windows.Forms.Label()
        Me.gbAntecedentesP = New System.Windows.Forms.GroupBox()
        Me.txtOtrosAntecedentes = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.r1Cardio = New System.Windows.Forms.RadioButton()
        Me.r2Cardio = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel15 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.r1Psico = New System.Windows.Forms.RadioButton()
        Me.r2Psico = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.r1Neoplasicos = New System.Windows.Forms.RadioButton()
        Me.r2Neoplasicos = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.r1Alergicos = New System.Windows.Forms.RadioButton()
        Me.r2Alergicos = New System.Windows.Forms.RadioButton()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.r1Respiratorios = New System.Windows.Forms.RadioButton()
        Me.r2Respiratorio = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel14 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.r1Transfu = New System.Windows.Forms.RadioButton()
        Me.r2Transfu = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.r1Osteo = New System.Windows.Forms.RadioButton()
        Me.r2Osteo = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.r1Cirugias = New System.Windows.Forms.RadioButton()
        Me.r2Cirugias = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.r1Digestivos = New System.Windows.Forms.RadioButton()
        Me.r2Digestivos = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel13 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.r1AudioV = New System.Windows.Forms.RadioButton()
        Me.r2AudioV = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.r1Interna = New System.Windows.Forms.RadioButton()
        Me.r2Interna = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.r1Metabol = New System.Windows.Forms.RadioButton()
        Me.r2Metabol = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.r1Neuro = New System.Windows.Forms.RadioButton()
        Me.r2Neuro = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.r1Asma = New System.Windows.Forms.RadioButton()
        Me.r2Asma = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.r1Genito = New System.Windows.Forms.RadioButton()
        Me.r2Genito = New System.Windows.Forms.RadioButton()
        Me.gbAntecedentes = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAntHijos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAntHermanos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAntPadre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAntMadre = New System.Windows.Forms.TextBox()
        Me.gbDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblActCliente = New System.Windows.Forms.Label()
        Me.lnlNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEstadoC = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbHistorial.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEncargado.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbFichaMed.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbAntecedentesP.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel15.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel14.SuspendLayout()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel13.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.gbAntecedentes.SuspendLayout()
        Me.gbDatosPersonales.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.635829!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.36417!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1362, 591)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 45)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1258, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(371, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "FICHA DEL CLIENTE"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.gbHistorial)
        Me.Panel2.Controls.Add(Me.gbEncargado)
        Me.Panel2.Controls.Add(Me.gbFichaMed)
        Me.Panel2.Controls.Add(Me.gbDatosPersonales)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 546)
        Me.Panel2.TabIndex = 1
        '
        'gbHistorial
        '
        Me.gbHistorial.Controls.Add(Me.lblVerHistorial)
        Me.gbHistorial.Controls.Add(Me.lblAgregarHistorial)
        Me.gbHistorial.Controls.Add(Me.Panel5)
        Me.gbHistorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbHistorial.Location = New System.Drawing.Point(31, 1368)
        Me.gbHistorial.Name = "gbHistorial"
        Me.gbHistorial.Size = New System.Drawing.Size(1268, 368)
        Me.gbHistorial.TabIndex = 14
        Me.gbHistorial.TabStop = False
        Me.gbHistorial.Text = "Historial De Tratamientos"
        '
        'lblVerHistorial
        '
        Me.lblVerHistorial.AutoSize = True
        Me.lblVerHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblVerHistorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblVerHistorial.Location = New System.Drawing.Point(1081, 128)
        Me.lblVerHistorial.Name = "lblVerHistorial"
        Me.lblVerHistorial.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.lblVerHistorial.Size = New System.Drawing.Size(135, 41)
        Me.lblVerHistorial.TabIndex = 15
        Me.lblVerHistorial.Text = "Ver Detalle"
        '
        'lblAgregarHistorial
        '
        Me.lblAgregarHistorial.AutoSize = True
        Me.lblAgregarHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblAgregarHistorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblAgregarHistorial.Location = New System.Drawing.Point(1081, 50)
        Me.lblAgregarHistorial.Name = "lblAgregarHistorial"
        Me.lblAgregarHistorial.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblAgregarHistorial.Size = New System.Drawing.Size(135, 41)
        Me.lblAgregarHistorial.TabIndex = 14
        Me.lblAgregarHistorial.Text = "Agregar "
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvHistorial)
        Me.Panel5.Location = New System.Drawing.Point(26, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1027, 299)
        Me.Panel5.TabIndex = 0
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHistorial.ColumnHeadersHeight = 31
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.Location = New System.Drawing.Point(0, 0)
        Me.dgvHistorial.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvHistorial.MultiSelect = False
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(1027, 299)
        Me.dgvHistorial.TabIndex = 2
        '
        'gbEncargado
        '
        Me.gbEncargado.Controls.Add(Me.Panel3)
        Me.gbEncargado.Controls.Add(Me.Label13)
        Me.gbEncargado.Controls.Add(Me.Label17)
        Me.gbEncargado.Controls.Add(Me.txtNombreEncargado)
        Me.gbEncargado.Controls.Add(Me.Label19)
        Me.gbEncargado.Controls.Add(Me.txtApellidoEncargado)
        Me.gbEncargado.Controls.Add(Me.txtEdadEncargado)
        Me.gbEncargado.Controls.Add(Me.Label22)
        Me.gbEncargado.Controls.Add(Me.txtCiEncargado)
        Me.gbEncargado.Controls.Add(Me.Label23)
        Me.gbEncargado.Controls.Add(Me.Label24)
        Me.gbEncargado.Controls.Add(Me.txtOcupacionEncargado)
        Me.gbEncargado.Controls.Add(Me.txtTelefonoEncargado)
        Me.gbEncargado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEncargado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.gbEncargado.Location = New System.Drawing.Point(31, 365)
        Me.gbEncargado.Name = "gbEncargado"
        Me.gbEncargado.Size = New System.Drawing.Size(1268, 231)
        Me.gbEncargado.TabIndex = 13
        Me.gbEncargado.TabStop = False
        Me.gbEncargado.Text = "Datos Encargado"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblActEncargado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1262, 56)
        Me.Panel3.TabIndex = 22
        '
        'lblActEncargado
        '
        Me.lblActEncargado.AutoSize = True
        Me.lblActEncargado.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblActEncargado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActEncargado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblActEncargado.Location = New System.Drawing.Point(287, 9)
        Me.lblActEncargado.Name = "lblActEncargado"
        Me.lblActEncargado.Padding = New System.Windows.Forms.Padding(300, 9, 300, 9)
        Me.lblActEncargado.Size = New System.Drawing.Size(687, 39)
        Me.lblActEncargado.TabIndex = 13
        Me.lblActEncargado.Text = "Actualizar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(114, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(114, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 21)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Apellido"
        '
        'txtNombreEncargado
        '
        Me.txtNombreEncargado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEncargado.Location = New System.Drawing.Point(205, 37)
        Me.txtNombreEncargado.Name = "txtNombreEncargado"
        Me.txtNombreEncargado.Size = New System.Drawing.Size(317, 27)
        Me.txtNombreEncargado.TabIndex = 16
        Me.txtNombreEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(114, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 21)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "C.I"
        '
        'txtApellidoEncargado
        '
        Me.txtApellidoEncargado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoEncargado.Location = New System.Drawing.Point(205, 77)
        Me.txtApellidoEncargado.Name = "txtApellidoEncargado"
        Me.txtApellidoEncargado.Size = New System.Drawing.Size(317, 27)
        Me.txtApellidoEncargado.TabIndex = 17
        Me.txtApellidoEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEdadEncargado
        '
        Me.txtEdadEncargado.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEdadEncargado.Location = New System.Drawing.Point(700, 35)
        Me.txtEdadEncargado.MaxLength = 2
        Me.txtEdadEncargado.Name = "txtEdadEncargado"
        Me.txtEdadEncargado.Size = New System.Drawing.Size(317, 29)
        Me.txtEdadEncargado.TabIndex = 19
        Me.txtEdadEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(602, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 21)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Ocupación"
        '
        'txtCiEncargado
        '
        Me.txtCiEncargado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiEncargado.Location = New System.Drawing.Point(205, 113)
        Me.txtCiEncargado.Name = "txtCiEncargado"
        Me.txtCiEncargado.Size = New System.Drawing.Size(317, 27)
        Me.txtCiEncargado.TabIndex = 18
        Me.txtCiEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(602, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 21)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Teléfono"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(602, 39)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Edad"
        '
        'txtOcupacionEncargado
        '
        Me.txtOcupacionEncargado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacionEncargado.Location = New System.Drawing.Point(700, 75)
        Me.txtOcupacionEncargado.Name = "txtOcupacionEncargado"
        Me.txtOcupacionEncargado.Size = New System.Drawing.Size(317, 27)
        Me.txtOcupacionEncargado.TabIndex = 20
        Me.txtOcupacionEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefonoEncargado
        '
        Me.txtTelefonoEncargado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoEncargado.Location = New System.Drawing.Point(700, 117)
        Me.txtTelefonoEncargado.Name = "txtTelefonoEncargado"
        Me.txtTelefonoEncargado.Size = New System.Drawing.Size(317, 27)
        Me.txtTelefonoEncargado.TabIndex = 21
        Me.txtTelefonoEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbFichaMed
        '
        Me.gbFichaMed.Controls.Add(Me.Panel4)
        Me.gbFichaMed.Controls.Add(Me.gbAntecedentesP)
        Me.gbFichaMed.Controls.Add(Me.gbAntecedentes)
        Me.gbFichaMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFichaMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.gbFichaMed.Location = New System.Drawing.Point(31, 612)
        Me.gbFichaMed.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.gbFichaMed.Name = "gbFichaMed"
        Me.gbFichaMed.Size = New System.Drawing.Size(1268, 744)
        Me.gbFichaMed.TabIndex = 13
        Me.gbFichaMed.TabStop = False
        Me.gbFichaMed.Text = "Ficha Médica"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblActAnt)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 685)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1262, 56)
        Me.Panel4.TabIndex = 23
        '
        'lblActAnt
        '
        Me.lblActAnt.AutoSize = True
        Me.lblActAnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblActAnt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActAnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblActAnt.Location = New System.Drawing.Point(290, 9)
        Me.lblActAnt.Name = "lblActAnt"
        Me.lblActAnt.Padding = New System.Windows.Forms.Padding(300, 9, 300, 9)
        Me.lblActAnt.Size = New System.Drawing.Size(687, 39)
        Me.lblActAnt.TabIndex = 13
        Me.lblActAnt.Text = "Actualizar"
        '
        'gbAntecedentesP
        '
        Me.gbAntecedentesP.Controls.Add(Me.txtOtrosAntecedentes)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel1)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel15)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel6)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel5)
        Me.gbAntecedentesP.Controls.Add(Me.Label39)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel2)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel14)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel12)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel11)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel3)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel13)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel10)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel8)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel9)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel7)
        Me.gbAntecedentesP.Controls.Add(Me.FlowLayoutPanel4)
        Me.gbAntecedentesP.ForeColor = System.Drawing.Color.White
        Me.gbAntecedentesP.Location = New System.Drawing.Point(102, 224)
        Me.gbAntecedentesP.Name = "gbAntecedentesP"
        Me.gbAntecedentesP.Size = New System.Drawing.Size(1058, 448)
        Me.gbAntecedentesP.TabIndex = 0
        Me.gbAntecedentesP.TabStop = False
        Me.gbAntecedentesP.Text = "Antecedentes Patológicos Personales"
        '
        'txtOtrosAntecedentes
        '
        Me.txtOtrosAntecedentes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosAntecedentes.Location = New System.Drawing.Point(105, 324)
        Me.txtOtrosAntecedentes.Name = "txtOtrosAntecedentes"
        Me.txtOtrosAntecedentes.Size = New System.Drawing.Size(846, 105)
        Me.txtOtrosAntecedentes.TabIndex = 8
        Me.txtOtrosAntecedentes.Text = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label26)
        Me.FlowLayoutPanel1.Controls.Add(Me.r1Cardio)
        Me.FlowLayoutPanel1.Controls.Add(Me.r2Cardio)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(105, 39)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(3, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(139, 31)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Cardiovasculares"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Cardio
        '
        Me.r1Cardio.AutoSize = True
        Me.r1Cardio.Location = New System.Drawing.Point(148, 3)
        Me.r1Cardio.Name = "r1Cardio"
        Me.r1Cardio.Size = New System.Drawing.Size(42, 25)
        Me.r1Cardio.TabIndex = 5
        Me.r1Cardio.TabStop = True
        Me.r1Cardio.Text = "Si"
        Me.r1Cardio.UseVisualStyleBackColor = True
        '
        'r2Cardio
        '
        Me.r2Cardio.AutoSize = True
        Me.r2Cardio.Location = New System.Drawing.Point(196, 3)
        Me.r2Cardio.Name = "r2Cardio"
        Me.r2Cardio.Size = New System.Drawing.Size(51, 25)
        Me.r2Cardio.TabIndex = 5
        Me.r2Cardio.TabStop = True
        Me.r2Cardio.Text = "No"
        Me.r2Cardio.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel15
        '
        Me.FlowLayoutPanel15.Controls.Add(Me.Label38)
        Me.FlowLayoutPanel15.Controls.Add(Me.r1Psico)
        Me.FlowLayoutPanel15.Controls.Add(Me.r2Psico)
        Me.FlowLayoutPanel15.Location = New System.Drawing.Point(105, 270)
        Me.FlowLayoutPanel15.Name = "FlowLayoutPanel15"
        Me.FlowLayoutPanel15.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel15.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(3, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(105, 31)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Psicológicos"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Psico
        '
        Me.r1Psico.AutoSize = True
        Me.r1Psico.Location = New System.Drawing.Point(143, 3)
        Me.r1Psico.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.r1Psico.Name = "r1Psico"
        Me.r1Psico.Size = New System.Drawing.Size(42, 25)
        Me.r1Psico.TabIndex = 5
        Me.r1Psico.TabStop = True
        Me.r1Psico.Text = "Si"
        Me.r1Psico.UseVisualStyleBackColor = True
        '
        'r2Psico
        '
        Me.r2Psico.AutoSize = True
        Me.r2Psico.Location = New System.Drawing.Point(191, 3)
        Me.r2Psico.Name = "r2Psico"
        Me.r2Psico.Size = New System.Drawing.Size(51, 25)
        Me.r2Psico.TabIndex = 5
        Me.r2Psico.TabStop = True
        Me.r2Psico.Text = "No"
        Me.r2Psico.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Label29)
        Me.FlowLayoutPanel6.Controls.Add(Me.r1Neoplasicos)
        Me.FlowLayoutPanel6.Controls.Add(Me.r2Neoplasicos)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(105, 213)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel6.TabIndex = 7
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 31)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Neoplasicos"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Neoplasicos
        '
        Me.r1Neoplasicos.AutoSize = True
        Me.r1Neoplasicos.Location = New System.Drawing.Point(144, 3)
        Me.r1Neoplasicos.Margin = New System.Windows.Forms.Padding(35, 3, 3, 3)
        Me.r1Neoplasicos.Name = "r1Neoplasicos"
        Me.r1Neoplasicos.Size = New System.Drawing.Size(42, 25)
        Me.r1Neoplasicos.TabIndex = 5
        Me.r1Neoplasicos.TabStop = True
        Me.r1Neoplasicos.Text = "Si"
        Me.r1Neoplasicos.UseVisualStyleBackColor = True
        '
        'r2Neoplasicos
        '
        Me.r2Neoplasicos.AutoSize = True
        Me.r2Neoplasicos.Location = New System.Drawing.Point(192, 3)
        Me.r2Neoplasicos.Name = "r2Neoplasicos"
        Me.r2Neoplasicos.Size = New System.Drawing.Size(51, 25)
        Me.r2Neoplasicos.TabIndex = 5
        Me.r2Neoplasicos.TabStop = True
        Me.r2Neoplasicos.Text = "No"
        Me.r2Neoplasicos.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Label27)
        Me.FlowLayoutPanel5.Controls.Add(Me.r1Alergicos)
        Me.FlowLayoutPanel5.Controls.Add(Me.r2Alergicos)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(105, 157)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel5.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 31)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Alérgicos"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Alergicos
        '
        Me.r1Alergicos.AutoSize = True
        Me.r1Alergicos.Location = New System.Drawing.Point(147, 3)
        Me.r1Alergicos.Margin = New System.Windows.Forms.Padding(60, 3, 3, 3)
        Me.r1Alergicos.Name = "r1Alergicos"
        Me.r1Alergicos.Size = New System.Drawing.Size(42, 25)
        Me.r1Alergicos.TabIndex = 5
        Me.r1Alergicos.TabStop = True
        Me.r1Alergicos.Text = "Si"
        Me.r1Alergicos.UseVisualStyleBackColor = True
        '
        'r2Alergicos
        '
        Me.r2Alergicos.AutoSize = True
        Me.r2Alergicos.Location = New System.Drawing.Point(195, 3)
        Me.r2Alergicos.Name = "r2Alergicos"
        Me.r2Alergicos.Size = New System.Drawing.Size(51, 25)
        Me.r2Alergicos.TabIndex = 5
        Me.r2Alergicos.TabStop = True
        Me.r2Alergicos.Text = "No"
        Me.r2Alergicos.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(42, 324)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(51, 21)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Otros"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label25)
        Me.FlowLayoutPanel2.Controls.Add(Me.r1Respiratorios)
        Me.FlowLayoutPanel2.Controls.Add(Me.r2Respiratorio)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(105, 100)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 31)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Respiratorios"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Respiratorios
        '
        Me.r1Respiratorios.AutoSize = True
        Me.r1Respiratorios.Location = New System.Drawing.Point(146, 3)
        Me.r1Respiratorios.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.r1Respiratorios.Name = "r1Respiratorios"
        Me.r1Respiratorios.Size = New System.Drawing.Size(42, 25)
        Me.r1Respiratorios.TabIndex = 5
        Me.r1Respiratorios.TabStop = True
        Me.r1Respiratorios.Text = "Si"
        Me.r1Respiratorios.UseVisualStyleBackColor = True
        '
        'r2Respiratorio
        '
        Me.r2Respiratorio.AutoSize = True
        Me.r2Respiratorio.Location = New System.Drawing.Point(194, 3)
        Me.r2Respiratorio.Name = "r2Respiratorio"
        Me.r2Respiratorio.Size = New System.Drawing.Size(51, 25)
        Me.r2Respiratorio.TabIndex = 5
        Me.r2Respiratorio.TabStop = True
        Me.r2Respiratorio.Text = "No"
        Me.r2Respiratorio.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel14
        '
        Me.FlowLayoutPanel14.Controls.Add(Me.Label37)
        Me.FlowLayoutPanel14.Controls.Add(Me.r1Transfu)
        Me.FlowLayoutPanel14.Controls.Add(Me.r2Transfu)
        Me.FlowLayoutPanel14.Location = New System.Drawing.Point(671, 270)
        Me.FlowLayoutPanel14.Name = "FlowLayoutPanel14"
        Me.FlowLayoutPanel14.Size = New System.Drawing.Size(280, 38)
        Me.FlowLayoutPanel14.TabIndex = 7
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(3, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(115, 31)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Transfusiones"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Transfu
        '
        Me.r1Transfu.AutoSize = True
        Me.r1Transfu.Location = New System.Drawing.Point(158, 3)
        Me.r1Transfu.Margin = New System.Windows.Forms.Padding(37, 3, 3, 3)
        Me.r1Transfu.Name = "r1Transfu"
        Me.r1Transfu.Size = New System.Drawing.Size(42, 25)
        Me.r1Transfu.TabIndex = 5
        Me.r1Transfu.TabStop = True
        Me.r1Transfu.Text = "Si"
        Me.r1Transfu.UseVisualStyleBackColor = True
        '
        'r2Transfu
        '
        Me.r2Transfu.AutoSize = True
        Me.r2Transfu.Location = New System.Drawing.Point(206, 3)
        Me.r2Transfu.Name = "r2Transfu"
        Me.r2Transfu.Size = New System.Drawing.Size(51, 25)
        Me.r2Transfu.TabIndex = 5
        Me.r2Transfu.TabStop = True
        Me.r2Transfu.Text = "No"
        Me.r2Transfu.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.Controls.Add(Me.Label35)
        Me.FlowLayoutPanel12.Controls.Add(Me.r1Osteo)
        Me.FlowLayoutPanel12.Controls.Add(Me.r2Osteo)
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(671, 39)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(280, 38)
        Me.FlowLayoutPanel12.TabIndex = 7
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(3, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(134, 31)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Osteoarticulares"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Osteo
        '
        Me.r1Osteo.AutoSize = True
        Me.r1Osteo.Location = New System.Drawing.Point(155, 3)
        Me.r1Osteo.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.r1Osteo.Name = "r1Osteo"
        Me.r1Osteo.Size = New System.Drawing.Size(42, 25)
        Me.r1Osteo.TabIndex = 5
        Me.r1Osteo.TabStop = True
        Me.r1Osteo.Text = "Si"
        Me.r1Osteo.UseVisualStyleBackColor = True
        '
        'r2Osteo
        '
        Me.r2Osteo.AutoSize = True
        Me.r2Osteo.Location = New System.Drawing.Point(203, 3)
        Me.r2Osteo.Name = "r2Osteo"
        Me.r2Osteo.Size = New System.Drawing.Size(51, 25)
        Me.r2Osteo.TabIndex = 5
        Me.r2Osteo.TabStop = True
        Me.r2Osteo.Text = "No"
        Me.r2Osteo.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.Label34)
        Me.FlowLayoutPanel11.Controls.Add(Me.r1Cirugias)
        Me.FlowLayoutPanel11.Controls.Add(Me.r2Cirugias)
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(671, 213)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(280, 38)
        Me.FlowLayoutPanel11.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(3, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 31)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Cirugias"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Cirugias
        '
        Me.r1Cirugias.AutoSize = True
        Me.r1Cirugias.Location = New System.Drawing.Point(157, 3)
        Me.r1Cirugias.Margin = New System.Windows.Forms.Padding(79, 3, 3, 3)
        Me.r1Cirugias.Name = "r1Cirugias"
        Me.r1Cirugias.Size = New System.Drawing.Size(42, 25)
        Me.r1Cirugias.TabIndex = 5
        Me.r1Cirugias.TabStop = True
        Me.r1Cirugias.Text = "Si"
        Me.r1Cirugias.UseVisualStyleBackColor = True
        '
        'r2Cirugias
        '
        Me.r2Cirugias.AutoSize = True
        Me.r2Cirugias.Location = New System.Drawing.Point(205, 3)
        Me.r2Cirugias.Name = "r2Cirugias"
        Me.r2Cirugias.Size = New System.Drawing.Size(51, 25)
        Me.r2Cirugias.TabIndex = 5
        Me.r2Cirugias.TabStop = True
        Me.r2Cirugias.Text = "No"
        Me.r2Cirugias.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel3.Controls.Add(Me.r1Digestivos)
        Me.FlowLayoutPanel3.Controls.Add(Me.r2Digestivos)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(389, 39)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 31)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Digestivos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Digestivos
        '
        Me.r1Digestivos.AutoSize = True
        Me.r1Digestivos.Location = New System.Drawing.Point(136, 3)
        Me.r1Digestivos.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.r1Digestivos.Name = "r1Digestivos"
        Me.r1Digestivos.Size = New System.Drawing.Size(42, 25)
        Me.r1Digestivos.TabIndex = 5
        Me.r1Digestivos.TabStop = True
        Me.r1Digestivos.Text = "Si"
        Me.r1Digestivos.UseVisualStyleBackColor = True
        '
        'r2Digestivos
        '
        Me.r2Digestivos.AutoSize = True
        Me.r2Digestivos.Location = New System.Drawing.Point(184, 3)
        Me.r2Digestivos.Name = "r2Digestivos"
        Me.r2Digestivos.Size = New System.Drawing.Size(51, 25)
        Me.r2Digestivos.TabIndex = 5
        Me.r2Digestivos.TabStop = True
        Me.r2Digestivos.Text = "No"
        Me.r2Digestivos.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel13
        '
        Me.FlowLayoutPanel13.Controls.Add(Me.Label36)
        Me.FlowLayoutPanel13.Controls.Add(Me.r1AudioV)
        Me.FlowLayoutPanel13.Controls.Add(Me.r2AudioV)
        Me.FlowLayoutPanel13.Location = New System.Drawing.Point(389, 270)
        Me.FlowLayoutPanel13.Name = "FlowLayoutPanel13"
        Me.FlowLayoutPanel13.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel13.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(3, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(117, 31)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Audiovisuales"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1AudioV
        '
        Me.r1AudioV.AutoSize = True
        Me.r1AudioV.Location = New System.Drawing.Point(143, 3)
        Me.r1AudioV.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.r1AudioV.Name = "r1AudioV"
        Me.r1AudioV.Size = New System.Drawing.Size(42, 25)
        Me.r1AudioV.TabIndex = 5
        Me.r1AudioV.TabStop = True
        Me.r1AudioV.Text = "Si"
        Me.r1AudioV.UseVisualStyleBackColor = True
        '
        'r2AudioV
        '
        Me.r2AudioV.AutoSize = True
        Me.r2AudioV.Location = New System.Drawing.Point(191, 3)
        Me.r2AudioV.Name = "r2AudioV"
        Me.r2AudioV.Size = New System.Drawing.Size(51, 25)
        Me.r2AudioV.TabIndex = 5
        Me.r2AudioV.TabStop = True
        Me.r2AudioV.Text = "No"
        Me.r2AudioV.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.Label33)
        Me.FlowLayoutPanel10.Controls.Add(Me.r1Interna)
        Me.FlowLayoutPanel10.Controls.Add(Me.r2Interna)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(671, 157)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(280, 38)
        Me.FlowLayoutPanel10.TabIndex = 7
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(114, 31)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Internaciones"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Interna
        '
        Me.r1Interna.AutoSize = True
        Me.r1Interna.Location = New System.Drawing.Point(157, 3)
        Me.r1Interna.Margin = New System.Windows.Forms.Padding(37, 3, 3, 3)
        Me.r1Interna.Name = "r1Interna"
        Me.r1Interna.Size = New System.Drawing.Size(42, 25)
        Me.r1Interna.TabIndex = 5
        Me.r1Interna.TabStop = True
        Me.r1Interna.Text = "Si"
        Me.r1Interna.UseVisualStyleBackColor = True
        '
        'r2Interna
        '
        Me.r2Interna.AutoSize = True
        Me.r2Interna.Location = New System.Drawing.Point(205, 3)
        Me.r2Interna.Name = "r2Interna"
        Me.r2Interna.Size = New System.Drawing.Size(51, 25)
        Me.r2Interna.TabIndex = 5
        Me.r2Interna.TabStop = True
        Me.r2Interna.Text = "No"
        Me.r2Interna.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.Label31)
        Me.FlowLayoutPanel8.Controls.Add(Me.r1Metabol)
        Me.FlowLayoutPanel8.Controls.Add(Me.r2Metabol)
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(389, 213)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel8.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 31)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Metabólicos"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Metabol
        '
        Me.r1Metabol.AutoSize = True
        Me.r1Metabol.Location = New System.Drawing.Point(140, 3)
        Me.r1Metabol.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.r1Metabol.Name = "r1Metabol"
        Me.r1Metabol.Size = New System.Drawing.Size(42, 25)
        Me.r1Metabol.TabIndex = 5
        Me.r1Metabol.TabStop = True
        Me.r1Metabol.Text = "Si"
        Me.r1Metabol.UseVisualStyleBackColor = True
        '
        'r2Metabol
        '
        Me.r2Metabol.AutoSize = True
        Me.r2Metabol.Location = New System.Drawing.Point(188, 3)
        Me.r2Metabol.Name = "r2Metabol"
        Me.r2Metabol.Size = New System.Drawing.Size(51, 25)
        Me.r2Metabol.TabIndex = 5
        Me.r2Metabol.TabStop = True
        Me.r2Metabol.Text = "No"
        Me.r2Metabol.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel9.Controls.Add(Me.r1Neuro)
        Me.FlowLayoutPanel9.Controls.Add(Me.r2Neuro)
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(671, 100)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(280, 38)
        Me.FlowLayoutPanel9.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(147, 31)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Neuropsiquitricos"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Neuro
        '
        Me.r1Neuro.AutoSize = True
        Me.r1Neuro.Location = New System.Drawing.Point(156, 3)
        Me.r1Neuro.Name = "r1Neuro"
        Me.r1Neuro.Size = New System.Drawing.Size(42, 25)
        Me.r1Neuro.TabIndex = 5
        Me.r1Neuro.TabStop = True
        Me.r1Neuro.Text = "Si"
        Me.r1Neuro.UseVisualStyleBackColor = True
        '
        'r2Neuro
        '
        Me.r2Neuro.AutoSize = True
        Me.r2Neuro.Location = New System.Drawing.Point(204, 3)
        Me.r2Neuro.Name = "r2Neuro"
        Me.r2Neuro.Size = New System.Drawing.Size(51, 25)
        Me.r2Neuro.TabIndex = 5
        Me.r2Neuro.TabStop = True
        Me.r2Neuro.Text = "No"
        Me.r2Neuro.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.Label30)
        Me.FlowLayoutPanel7.Controls.Add(Me.r1Asma)
        Me.FlowLayoutPanel7.Controls.Add(Me.r2Asma)
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(389, 157)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel7.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 31)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Asmático"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Asma
        '
        Me.r1Asma.AutoSize = True
        Me.r1Asma.Location = New System.Drawing.Point(137, 3)
        Me.r1Asma.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.r1Asma.Name = "r1Asma"
        Me.r1Asma.Size = New System.Drawing.Size(42, 25)
        Me.r1Asma.TabIndex = 5
        Me.r1Asma.TabStop = True
        Me.r1Asma.Text = "Si"
        Me.r1Asma.UseVisualStyleBackColor = True
        '
        'r2Asma
        '
        Me.r2Asma.AutoSize = True
        Me.r2Asma.Location = New System.Drawing.Point(185, 3)
        Me.r2Asma.Name = "r2Asma"
        Me.r2Asma.Size = New System.Drawing.Size(51, 25)
        Me.r2Asma.TabIndex = 5
        Me.r2Asma.TabStop = True
        Me.r2Asma.Text = "No"
        Me.r2Asma.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel4.Controls.Add(Me.r1Genito)
        Me.FlowLayoutPanel4.Controls.Add(Me.r2Genito)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(389, 100)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel4.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 31)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Genitourinarios"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r1Genito
        '
        Me.r1Genito.AutoSize = True
        Me.r1Genito.Location = New System.Drawing.Point(138, 3)
        Me.r1Genito.Name = "r1Genito"
        Me.r1Genito.Size = New System.Drawing.Size(42, 25)
        Me.r1Genito.TabIndex = 5
        Me.r1Genito.TabStop = True
        Me.r1Genito.Text = "Si"
        Me.r1Genito.UseVisualStyleBackColor = True
        '
        'r2Genito
        '
        Me.r2Genito.AutoSize = True
        Me.r2Genito.Location = New System.Drawing.Point(186, 3)
        Me.r2Genito.Name = "r2Genito"
        Me.r2Genito.Size = New System.Drawing.Size(51, 25)
        Me.r2Genito.TabIndex = 5
        Me.r2Genito.TabStop = True
        Me.r2Genito.Text = "No"
        Me.r2Genito.UseVisualStyleBackColor = True
        '
        'gbAntecedentes
        '
        Me.gbAntecedentes.Controls.Add(Me.Label18)
        Me.gbAntecedentes.Controls.Add(Me.txtAntHijos)
        Me.gbAntecedentes.Controls.Add(Me.Label16)
        Me.gbAntecedentes.Controls.Add(Me.txtAntHermanos)
        Me.gbAntecedentes.Controls.Add(Me.Label10)
        Me.gbAntecedentes.Controls.Add(Me.txtAntPadre)
        Me.gbAntecedentes.Controls.Add(Me.Label1)
        Me.gbAntecedentes.Controls.Add(Me.txtAntMadre)
        Me.gbAntecedentes.ForeColor = System.Drawing.Color.White
        Me.gbAntecedentes.Location = New System.Drawing.Point(102, 37)
        Me.gbAntecedentes.Name = "gbAntecedentes"
        Me.gbAntecedentes.Size = New System.Drawing.Size(1058, 162)
        Me.gbAntecedentes.TabIndex = 0
        Me.gbAntecedentes.TabStop = False
        Me.gbAntecedentes.Text = "Antecedentes Familiares"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(528, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Hijos"
        '
        'txtAntHijos
        '
        Me.txtAntHijos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntHijos.Location = New System.Drawing.Point(636, 106)
        Me.txtAntHijos.Name = "txtAntHijos"
        Me.txtAntHijos.Size = New System.Drawing.Size(389, 27)
        Me.txtAntHijos.TabIndex = 25
        Me.txtAntHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(528, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Hermanos"
        '
        'txtAntHermanos
        '
        Me.txtAntHermanos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntHermanos.Location = New System.Drawing.Point(636, 52)
        Me.txtAntHermanos.Name = "txtAntHermanos"
        Me.txtAntHermanos.Size = New System.Drawing.Size(389, 27)
        Me.txtAntHermanos.TabIndex = 24
        Me.txtAntHermanos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(31, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Padre"
        '
        'txtAntPadre
        '
        Me.txtAntPadre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntPadre.Location = New System.Drawing.Point(124, 102)
        Me.txtAntPadre.Name = "txtAntPadre"
        Me.txtAntPadre.Size = New System.Drawing.Size(385, 27)
        Me.txtAntPadre.TabIndex = 23
        Me.txtAntPadre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Madre"
        '
        'txtAntMadre
        '
        Me.txtAntMadre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntMadre.Location = New System.Drawing.Point(124, 52)
        Me.txtAntMadre.Name = "txtAntMadre"
        Me.txtAntMadre.Size = New System.Drawing.Size(385, 27)
        Me.txtAntMadre.TabIndex = 22
        Me.txtAntMadre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbDatosPersonales
        '
        Me.gbDatosPersonales.Controls.Add(Me.Panel6)
        Me.gbDatosPersonales.Controls.Add(Me.lnlNombre)
        Me.gbDatosPersonales.Controls.Add(Me.Label2)
        Me.gbDatosPersonales.Controls.Add(Me.txtNombre)
        Me.gbDatosPersonales.Controls.Add(Me.Label3)
        Me.gbDatosPersonales.Controls.Add(Me.txtApellido)
        Me.gbDatosPersonales.Controls.Add(Me.txtEdad)
        Me.gbDatosPersonales.Controls.Add(Me.Label4)
        Me.gbDatosPersonales.Controls.Add(Me.cbEstadoC)
        Me.gbDatosPersonales.Controls.Add(Me.cbSexo)
        Me.gbDatosPersonales.Controls.Add(Me.txtCI)
        Me.gbDatosPersonales.Controls.Add(Me.Label8)
        Me.gbDatosPersonales.Controls.Add(Me.Label14)
        Me.gbDatosPersonales.Controls.Add(Me.Label5)
        Me.gbDatosPersonales.Controls.Add(Me.txtBarrio)
        Me.gbDatosPersonales.Controls.Add(Me.txtDepartamento)
        Me.gbDatosPersonales.Controls.Add(Me.txtCiudad)
        Me.gbDatosPersonales.Controls.Add(Me.txtDir)
        Me.gbDatosPersonales.Controls.Add(Me.txtEmail)
        Me.gbDatosPersonales.Controls.Add(Me.Label9)
        Me.gbDatosPersonales.Controls.Add(Me.txtCelular)
        Me.gbDatosPersonales.Controls.Add(Me.txtNacionalidad)
        Me.gbDatosPersonales.Controls.Add(Me.txtRUC)
        Me.gbDatosPersonales.Controls.Add(Me.Label40)
        Me.gbDatosPersonales.Controls.Add(Me.Label28)
        Me.gbDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.gbDatosPersonales.Controls.Add(Me.Label20)
        Me.gbDatosPersonales.Controls.Add(Me.Label6)
        Me.gbDatosPersonales.Controls.Add(Me.Label12)
        Me.gbDatosPersonales.Controls.Add(Me.Label15)
        Me.gbDatosPersonales.Controls.Add(Me.Label7)
        Me.gbDatosPersonales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosPersonales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.gbDatosPersonales.Location = New System.Drawing.Point(31, 7)
        Me.gbDatosPersonales.Name = "gbDatosPersonales"
        Me.gbDatosPersonales.Size = New System.Drawing.Size(1268, 343)
        Me.gbDatosPersonales.TabIndex = 12
        Me.gbDatosPersonales.TabStop = False
        Me.gbDatosPersonales.Text = "Datos Personales"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblActCliente)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 282)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1262, 58)
        Me.Panel6.TabIndex = 16
        '
        'lblActCliente
        '
        Me.lblActCliente.AutoSize = True
        Me.lblActCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblActCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblActCliente.Location = New System.Drawing.Point(287, 10)
        Me.lblActCliente.Name = "lblActCliente"
        Me.lblActCliente.Padding = New System.Windows.Forms.Padding(300, 9, 300, 9)
        Me.lblActCliente.Size = New System.Drawing.Size(687, 39)
        Me.lblActCliente.TabIndex = 13
        Me.lblActCliente.Text = "Actualizar"
        '
        'lnlNombre
        '
        Me.lnlNombre.AutoSize = True
        Me.lnlNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lnlNombre.Location = New System.Drawing.Point(20, 37)
        Me.lnlNombre.Name = "lnlNombre"
        Me.lnlNombre.Size = New System.Drawing.Size(84, 21)
        Me.lnlNombre.TabIndex = 0
        Me.lnlNombre.Text = "Nombre *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(492, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido *"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(150, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(317, 27)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(922, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "C.I *"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(592, 35)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(317, 27)
        Me.txtApellido.TabIndex = 2
        Me.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEdad.Location = New System.Drawing.Point(1027, 173)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(227, 29)
        Me.txtEdad.TabIndex = 12
        Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RUC"
        '
        'cbEstadoC
        '
        Me.cbEstadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoC.FormattingEnabled = True
        Me.cbEstadoC.Items.AddRange(New Object() {"-- Seleccione estado Civil --", "Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cbEstadoC.Location = New System.Drawing.Point(1027, 79)
        Me.cbEstadoC.Name = "cbEstadoC"
        Me.cbEstadoC.Size = New System.Drawing.Size(227, 29)
        Me.cbEstadoC.TabIndex = 9
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"-- Seleccione el Sexo --", "Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(1027, 125)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(227, 29)
        Me.cbSexo.TabIndex = 9
        '
        'txtCI
        '
        Me.txtCI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.Location = New System.Drawing.Point(1027, 33)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(227, 27)
        Me.txtCI.TabIndex = 3
        Me.txtCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(922, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sexo *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(20, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nacionalidad *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(492, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Teléfono *"
        '
        'txtBarrio
        '
        Me.txtBarrio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrio.Location = New System.Drawing.Point(1027, 224)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(227, 27)
        Me.txtBarrio.TabIndex = 15
        Me.txtBarrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Location = New System.Drawing.Point(150, 224)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(317, 27)
        Me.txtDepartamento.TabIndex = 13
        Me.txtDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(592, 224)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(317, 27)
        Me.txtCiudad.TabIndex = 14
        Me.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDir
        '
        Me.txtDir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(150, 170)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(317, 27)
        Me.txtDir.TabIndex = 10
        Me.txtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(592, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(317, 27)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(922, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Edad *"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(592, 170)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(317, 27)
        Me.txtCelular.TabIndex = 11
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(150, 123)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(317, 27)
        Me.txtNacionalidad.TabIndex = 7
        Me.txtNacionalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRUC
        '
        Me.txtRUC.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(150, 80)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(317, 27)
        Me.txtRUC.TabIndex = 4
        Me.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(927, 230)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 21)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Barrio *"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(494, 230)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 21)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Ciudad *"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(592, 125)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(317, 27)
        Me.txtTelefono.TabIndex = 8
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(22, 224)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(132, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Departamento *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(494, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Celular *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(22, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Dirección *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(922, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Estado Civil *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(492, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Email"
        '
        'FichaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 591)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FichaMedica"
        Me.Text = "FichaMedica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbHistorial.ResumeLayout(False)
        Me.gbHistorial.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEncargado.ResumeLayout(False)
        Me.gbEncargado.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbFichaMed.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gbAntecedentesP.ResumeLayout(False)
        Me.gbAntecedentesP.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel15.ResumeLayout(False)
        Me.FlowLayoutPanel15.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel14.ResumeLayout(False)
        Me.FlowLayoutPanel14.PerformLayout()
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.FlowLayoutPanel12.PerformLayout()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.FlowLayoutPanel11.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel13.ResumeLayout(False)
        Me.FlowLayoutPanel13.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel10.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.FlowLayoutPanel9.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.gbAntecedentes.ResumeLayout(False)
        Me.gbAntecedentes.PerformLayout()
        Me.gbDatosPersonales.ResumeLayout(False)
        Me.gbDatosPersonales.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gbFichaMed As GroupBox
    Friend WithEvents gbAntecedentesP As GroupBox
    Friend WithEvents txtOtrosAntecedentes As RichTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label26 As Label
    Friend WithEvents r1Cardio As RadioButton
    Friend WithEvents r2Cardio As RadioButton
    Friend WithEvents FlowLayoutPanel15 As FlowLayoutPanel
    Friend WithEvents Label38 As Label
    Friend WithEvents r1Psico As RadioButton
    Friend WithEvents r2Psico As RadioButton
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label29 As Label
    Friend WithEvents r1Neoplasicos As RadioButton
    Friend WithEvents r2Neoplasicos As RadioButton
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents r1Alergicos As RadioButton
    Friend WithEvents r2Alergicos As RadioButton
    Friend WithEvents Label39 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents r1Respiratorios As RadioButton
    Friend WithEvents r2Respiratorio As RadioButton
    Friend WithEvents FlowLayoutPanel14 As FlowLayoutPanel
    Friend WithEvents Label37 As Label
    Friend WithEvents r1Transfu As RadioButton
    Friend WithEvents r2Transfu As RadioButton
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents Label35 As Label
    Friend WithEvents r1Osteo As RadioButton
    Friend WithEvents r2Osteo As RadioButton
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents r1Cirugias As RadioButton
    Friend WithEvents r2Cirugias As RadioButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents r1Digestivos As RadioButton
    Friend WithEvents r2Digestivos As RadioButton
    Friend WithEvents FlowLayoutPanel13 As FlowLayoutPanel
    Friend WithEvents Label36 As Label
    Friend WithEvents r1AudioV As RadioButton
    Friend WithEvents r2AudioV As RadioButton
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents r1Interna As RadioButton
    Friend WithEvents r2Interna As RadioButton
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label31 As Label
    Friend WithEvents r1Metabol As RadioButton
    Friend WithEvents r2Metabol As RadioButton
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents Label32 As Label
    Friend WithEvents r1Neuro As RadioButton
    Friend WithEvents r2Neuro As RadioButton
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label30 As Label
    Friend WithEvents r1Asma As RadioButton
    Friend WithEvents r2Asma As RadioButton
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents r1Genito As RadioButton
    Friend WithEvents r2Genito As RadioButton
    Friend WithEvents gbAntecedentes As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtAntHijos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAntHermanos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAntPadre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAntMadre As TextBox
    Friend WithEvents gbDatosPersonales As GroupBox
    Friend WithEvents lnlNombre As Label
    Friend WithEvents gbEncargado As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombreEncargado As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtApellidoEncargado As TextBox
    Friend WithEvents txtEdadEncargado As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCiEncargado As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtOcupacionEncargado As TextBox
    Friend WithEvents txtTelefonoEncargado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gbHistorial As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblActEncargado As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblActCliente As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblActAnt As Label
    Friend WithEvents cbEstadoC As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents lblAgregarHistorial As Label
    Friend WithEvents lblVerHistorial As Label
End Class
