<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservasDelDia
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCitasPaquetes = New System.Windows.Forms.TabControl()
        Me.tbpCitas = New System.Windows.Forms.TabPage()
        Me.pnlCitas = New System.Windows.Forms.Panel()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.tpPaquetes = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvCitasPaquete = New System.Windows.Forms.DataGridView()
        Me.IDSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagHoraSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlServicios = New System.Windows.Forms.Panel()
        Me.listS = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNuevaR = New System.Windows.Forms.Label()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.lblVolver = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rectNuevaR = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectCancelar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectModificar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectVolver = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tabCitasPaquetes.SuspendLayout()
        Me.tbpCitas.SuspendLayout()
        Me.pnlCitas.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPaquetes.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvCitasPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlServicios.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.5364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.4636!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1068, 533)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 49)
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
        Me.lblTitulo.Size = New System.Drawing.Size(159, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "RESERVAS DEL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 423)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1035, 389)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.tabCitasPaquetes, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60274!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.39726!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(517, 389)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel4.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(513, 45)
        Me.Panel4.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(125, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTES AGENDADOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCitasPaquetes
        '
        Me.tabCitasPaquetes.Controls.Add(Me.tbpCitas)
        Me.tabCitasPaquetes.Controls.Add(Me.tpPaquetes)
        Me.tabCitasPaquetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCitasPaquetes.Location = New System.Drawing.Point(0, 49)
        Me.tabCitasPaquetes.Margin = New System.Windows.Forms.Padding(0)
        Me.tabCitasPaquetes.Name = "tabCitasPaquetes"
        Me.tabCitasPaquetes.SelectedIndex = 0
        Me.tabCitasPaquetes.Size = New System.Drawing.Size(517, 340)
        Me.tabCitasPaquetes.TabIndex = 20
        '
        'tbpCitas
        '
        Me.tbpCitas.Controls.Add(Me.pnlCitas)
        Me.tbpCitas.Location = New System.Drawing.Point(4, 30)
        Me.tbpCitas.Name = "tbpCitas"
        Me.tbpCitas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCitas.Size = New System.Drawing.Size(509, 306)
        Me.tbpCitas.TabIndex = 0
        Me.tbpCitas.Text = "Citas "
        Me.tbpCitas.UseVisualStyleBackColor = True
        '
        'pnlCitas
        '
        Me.pnlCitas.Controls.Add(Me.dgvCitas)
        Me.pnlCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCitas.Location = New System.Drawing.Point(3, 3)
        Me.pnlCitas.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.pnlCitas.Name = "pnlCitas"
        Me.pnlCitas.Size = New System.Drawing.Size(503, 300)
        Me.pnlCitas.TabIndex = 7
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvCitas.BackgroundColor = System.Drawing.Color.White
        Me.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCitas.ColumnHeadersHeight = 31
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCitas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCitas.EnableHeadersVisualStyles = False
        Me.dgvCitas.Location = New System.Drawing.Point(0, 0)
        Me.dgvCitas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCitas.RowHeadersVisible = False
        Me.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitas.Size = New System.Drawing.Size(503, 300)
        Me.dgvCitas.TabIndex = 18
        '
        'tpPaquetes
        '
        Me.tpPaquetes.Controls.Add(Me.Panel6)
        Me.tpPaquetes.Location = New System.Drawing.Point(4, 30)
        Me.tpPaquetes.Name = "tpPaquetes"
        Me.tpPaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPaquetes.Size = New System.Drawing.Size(509, 306)
        Me.tpPaquetes.TabIndex = 1
        Me.tpPaquetes.Text = "Sesiones de Paquete"
        Me.tpPaquetes.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvCitasPaquete)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(503, 300)
        Me.Panel6.TabIndex = 7
        '
        'dgvCitasPaquete
        '
        Me.dgvCitasPaquete.AllowUserToAddRows = False
        Me.dgvCitasPaquete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitasPaquete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvCitasPaquete.BackgroundColor = System.Drawing.Color.White
        Me.dgvCitasPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCitasPaquete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitasPaquete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCitasPaquete.ColumnHeadersHeight = 31
        Me.dgvCitasPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCitasPaquete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSesion, Me.ClienteSesion, Me.FechaSesion, Me.HoraSesion, Me.TagHoraSesion, Me.EstadoSesion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCitasPaquete.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCitasPaquete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCitasPaquete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCitasPaquete.EnableHeadersVisualStyles = False
        Me.dgvCitasPaquete.Location = New System.Drawing.Point(0, 0)
        Me.dgvCitasPaquete.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCitasPaquete.Name = "dgvCitasPaquete"
        Me.dgvCitasPaquete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitasPaquete.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCitasPaquete.RowHeadersVisible = False
        Me.dgvCitasPaquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitasPaquete.Size = New System.Drawing.Size(503, 300)
        Me.dgvCitasPaquete.TabIndex = 18
        '
        'IDSesion
        '
        Me.IDSesion.DataPropertyName = "IDSesion"
        Me.IDSesion.HeaderText = "IDSesion"
        Me.IDSesion.Name = "IDSesion"
        Me.IDSesion.Visible = False
        '
        'ClienteSesion
        '
        Me.ClienteSesion.DataPropertyName = "Cliente"
        Me.ClienteSesion.HeaderText = "Cliente"
        Me.ClienteSesion.Name = "ClienteSesion"
        '
        'FechaSesion
        '
        Me.FechaSesion.DataPropertyName = "Fecha"
        Me.FechaSesion.HeaderText = "Fecha"
        Me.FechaSesion.Name = "FechaSesion"
        '
        'HoraSesion
        '
        Me.HoraSesion.DataPropertyName = "Hora"
        Me.HoraSesion.HeaderText = "Hora"
        Me.HoraSesion.Name = "HoraSesion"
        '
        'TagHoraSesion
        '
        Me.TagHoraSesion.DataPropertyName = "TagHora"
        Me.TagHoraSesion.HeaderText = "TagHora"
        Me.TagHoraSesion.Name = "TagHoraSesion"
        Me.TagHoraSesion.Visible = False
        '
        'EstadoSesion
        '
        Me.EstadoSesion.DataPropertyName = "EstadoSesion"
        Me.EstadoSesion.HeaderText = "Estado"
        Me.EstadoSesion.Name = "EstadoSesion"
        Me.EstadoSesion.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.pnlServicios, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(517, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60274!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.39726!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(518, 389)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel5.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(2, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(514, 45)
        Me.Panel5.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(118, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SERVICIOS SOLICITADOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlServicios
        '
        Me.pnlServicios.Controls.Add(Me.listS)
        Me.pnlServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServicios.Location = New System.Drawing.Point(2, 49)
        Me.pnlServicios.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.pnlServicios.Name = "pnlServicios"
        Me.pnlServicios.Size = New System.Drawing.Size(516, 340)
        Me.pnlServicios.TabIndex = 17
        '
        'listS
        '
        Me.listS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listS.FormattingEnabled = True
        Me.listS.ItemHeight = 21
        Me.listS.Location = New System.Drawing.Point(0, 0)
        Me.listS.Margin = New System.Windows.Forms.Padding(0)
        Me.listS.Name = "listS"
        Me.listS.Size = New System.Drawing.Size(516, 340)
        Me.listS.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblNuevaR)
        Me.Panel3.Controls.Add(Me.lblCancelar)
        Me.Panel3.Controls.Add(Me.lblMod)
        Me.Panel3.Controls.Add(Me.lblVolver)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 472)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1068, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblNuevaR
        '
        Me.lblNuevaR.AutoSize = True
        Me.lblNuevaR.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblNuevaR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblNuevaR.Location = New System.Drawing.Point(418, 15)
        Me.lblNuevaR.Name = "lblNuevaR"
        Me.lblNuevaR.Size = New System.Drawing.Size(123, 21)
        Me.lblNuevaR.TabIndex = 14
        Me.lblNuevaR.Text = "Nueva Reserva"
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelar.Location = New System.Drawing.Point(234, 15)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(139, 21)
        Me.lblCancelar.TabIndex = 13
        Me.lblCancelar.Text = "Cancelar Reserva"
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblMod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblMod.Location = New System.Drawing.Point(85, 15)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(84, 21)
        Me.lblMod.TabIndex = 13
        Me.lblMod.Text = "Modificar"
        '
        'lblVolver
        '
        Me.lblVolver.AutoSize = True
        Me.lblVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblVolver.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblVolver.Location = New System.Drawing.Point(931, 18)
        Me.lblVolver.Name = "lblVolver"
        Me.lblVolver.Size = New System.Drawing.Size(71, 21)
        Me.lblVolver.TabIndex = 15
        Me.lblVolver.Text = "VOLVER"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.rectNuevaR, Me.rectCancelar, Me.rectModificar, Me.rectVolver})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1068, 61)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 863
        Me.LineShape1.X2 = 864
        Me.LineShape1.Y1 = -4
        Me.LineShape1.Y2 = 62
        '
        'rectNuevaR
        '
        Me.rectNuevaR.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectNuevaR.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectNuevaR.BorderColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectNuevaR.Location = New System.Drawing.Point(402, 10)
        Me.rectNuevaR.Name = "rectNuevaR"
        Me.rectNuevaR.Size = New System.Drawing.Size(154, 34)
        '
        'rectCancelar
        '
        Me.rectCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectCancelar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectCancelar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectCancelar.Location = New System.Drawing.Point(223, 10)
        Me.rectCancelar.Name = "rectCancelar"
        Me.rectCancelar.Size = New System.Drawing.Size(160, 34)
        '
        'rectModificar
        '
        Me.rectModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectModificar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectModificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectModificar.Location = New System.Drawing.Point(56, 10)
        Me.rectModificar.Name = "rectModificar"
        Me.rectModificar.Size = New System.Drawing.Size(150, 33)
        '
        'rectVolver
        '
        Me.rectVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectVolver.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectVolver.BorderColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.rectVolver.Location = New System.Drawing.Point(892, 12)
        Me.rectVolver.Name = "rectVolver"
        Me.rectVolver.Size = New System.Drawing.Size(154, 34)
        '
        'ReservasDelDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 533)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReservasDelDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservasDelDia"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tabCitasPaquetes.ResumeLayout(False)
        Me.tbpCitas.ResumeLayout(False)
        Me.pnlCitas.ResumeLayout(False)
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPaquetes.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvCitasPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlServicios.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCancelar As Label
    Friend WithEvents lblMod As Label
    Friend WithEvents rectCancelar As PowerPacks.RectangleShape
    Friend WithEvents rectModificar As PowerPacks.RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblVolver As Label
    Friend WithEvents lblNuevaR As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents rectVolver As PowerPacks.RectangleShape
    Friend WithEvents rectNuevaR As PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlServicios As Panel
    Friend WithEvents listS As ListBox
    Friend WithEvents tabCitasPaquetes As TabControl
    Friend WithEvents tbpCitas As TabPage
    Friend WithEvents pnlCitas As Panel
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents tpPaquetes As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvCitasPaquete As DataGridView
    Friend WithEvents IDSesion As DataGridViewTextBoxColumn
    Friend WithEvents ClienteSesion As DataGridViewTextBoxColumn
    Friend WithEvents FechaSesion As DataGridViewTextBoxColumn
    Friend WithEvents HoraSesion As DataGridViewTextBoxColumn
    Friend WithEvents TagHoraSesion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoSesion As DataGridViewTextBoxColumn
End Class
