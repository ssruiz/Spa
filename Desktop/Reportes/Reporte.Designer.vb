<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.crystalReportv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dpFechaEsp = New System.Windows.Forms.DateTimePicker()
        Me.lblHoy = New System.Windows.Forms.Label()
        Me.lblFechaEsp = New System.Windows.Forms.Label()
        Me.lblMensual = New System.Windows.Forms.Label()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'crystalReportv
        '
        Me.crystalReportv.ActiveViewIndex = -1
        Me.crystalReportv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crystalReportv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crystalReportv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crystalReportv.Location = New System.Drawing.Point(0, 122)
        Me.crystalReportv.Margin = New System.Windows.Forms.Padding(0)
        Me.crystalReportv.Name = "crystalReportv"
        Me.crystalReportv.ShowGroupTreeButton = False
        Me.crystalReportv.ShowLogo = False
        Me.crystalReportv.Size = New System.Drawing.Size(1343, 599)
        Me.crystalReportv.TabIndex = 0
        Me.crystalReportv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.crystalReportv, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.531013!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.46899!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1343, 721)
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
        Me.Panel1.Size = New System.Drawing.Size(1343, 60)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1281, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 34)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Salir")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(441, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "REPORTES DE CAJA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dpFechaEsp)
        Me.Panel2.Controls.Add(Me.lblHoy)
        Me.Panel2.Controls.Add(Me.lblFechaEsp)
        Me.Panel2.Controls.Add(Me.lblMensual)
        Me.Panel2.Controls.Add(Me.lblSemana)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1343, 62)
        Me.Panel2.TabIndex = 2
        '
        'dpFechaEsp
        '
        Me.dpFechaEsp.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaEsp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaEsp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaEsp.Location = New System.Drawing.Point(811, 16)
        Me.dpFechaEsp.Name = "dpFechaEsp"
        Me.dpFechaEsp.Size = New System.Drawing.Size(200, 29)
        Me.dpFechaEsp.TabIndex = 19
        '
        'lblHoy
        '
        Me.lblHoy.AutoSize = True
        Me.lblHoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblHoy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblHoy.Location = New System.Drawing.Point(31, 10)
        Me.lblHoy.Name = "lblHoy"
        Me.lblHoy.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblHoy.Size = New System.Drawing.Size(104, 41)
        Me.lblHoy.TabIndex = 16
        Me.lblHoy.Text = "HOY"
        Me.ToolTip1.SetToolTip(Me.lblHoy, "Cobros realizados el dia de hoy")
        '
        'lblFechaEsp
        '
        Me.lblFechaEsp.AutoSize = True
        Me.lblFechaEsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblFechaEsp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEsp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblFechaEsp.Location = New System.Drawing.Point(592, 10)
        Me.lblFechaEsp.Name = "lblFechaEsp"
        Me.lblFechaEsp.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblFechaEsp.Size = New System.Drawing.Size(210, 41)
        Me.lblFechaEsp.TabIndex = 18
        Me.lblFechaEsp.Text = "FECHA ESPECÍFICA"
        '
        'lblMensual
        '
        Me.lblMensual.AutoSize = True
        Me.lblMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblMensual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblMensual.Location = New System.Drawing.Point(363, 10)
        Me.lblMensual.Name = "lblMensual"
        Me.lblMensual.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblMensual.Size = New System.Drawing.Size(147, 41)
        Me.lblMensual.TabIndex = 18
        Me.lblMensual.Text = "MENSUAL"
        Me.ToolTip1.SetToolTip(Me.lblMensual, "Cobros del mes")
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblSemana.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblSemana.Location = New System.Drawing.Point(169, 10)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Padding = New System.Windows.Forms.Padding(40, 10, 40, 10)
        Me.lblSemana.Size = New System.Drawing.Size(166, 41)
        Me.lblSemana.TabIndex = 17
        Me.lblSemana.Text = "SEMANAL"
        Me.ToolTip1.SetToolTip(Me.lblSemana, "Cobros de la semana")
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 721)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crystalReportv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHoy As Label
    Friend WithEvents lblMensual As Label
    Friend WithEvents lblSemana As Label
    Friend WithEvents dpFechaEsp As DateTimePicker
    Friend WithEvents lblFechaEsp As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
