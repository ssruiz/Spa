<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarTratamiento
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gbAntecedentesEnfer = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtPesoI = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtBI = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtPI = New System.Windows.Forms.TextBox()
        Me.txtImc = New System.Windows.Forms.TextBox()
        Me.txtBOMB = New System.Windows.Forms.TextBox()
        Me.txtCINT = New System.Windows.Forms.TextBox()
        Me.Label41t = New System.Windows.Forms.Label()
        Me.txtOMB = New System.Windows.Forms.TextBox()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.txtPD = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.lblAgregarHistorial = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbAntecedentesEnfer.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33501!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66499!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1020, 437)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Desktop.My.Resources.Resources.degradado2
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(407, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Tratamiento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 334)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.76228!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1020, 334)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gbAntecedentesEnfer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1020, 334)
        Me.Panel4.TabIndex = 16
        '
        'gbAntecedentesEnfer
        '
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label50)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label44)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label48)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtTratamiento)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label46)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtPeso)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label49)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtPesoI)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label47)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label43)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label45)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label51)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label41)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtAltura)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtBI)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label42)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtPI)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtImc)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtBOMB)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtCINT)
        Me.gbAntecedentesEnfer.Controls.Add(Me.Label41t)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtOMB)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtBD)
        Me.gbAntecedentesEnfer.Controls.Add(Me.txtPD)
        Me.gbAntecedentesEnfer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAntecedentesEnfer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.gbAntecedentesEnfer.Location = New System.Drawing.Point(26, 15)
        Me.gbAntecedentesEnfer.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.gbAntecedentesEnfer.Name = "gbAntecedentesEnfer"
        Me.gbAntecedentesEnfer.Size = New System.Drawing.Size(978, 285)
        Me.gbAntecedentesEnfer.TabIndex = 17
        Me.gbAntecedentesEnfer.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(838, 190)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(25, 21)
        Me.Label50.TabIndex = 26
        Me.Label50.Text = "BI"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(252, 38)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(108, 21)
        Me.Label44.TabIndex = 29
        Me.Label44.Text = "Tratamiento "
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(683, 190)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(25, 21)
        Me.Label48.TabIndex = 26
        Me.Label48.Text = "PI"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(386, 36)
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(317, 27)
        Me.txtTratamiento.TabIndex = 57
        Me.txtTratamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(478, 190)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(65, 21)
        Me.Label46.TabIndex = 26
        Me.Label46.Text = "B. OMB"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(141, 89)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 27)
        Me.txtPeso.TabIndex = 58
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(831, 127)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(32, 21)
        Me.Label49.TabIndex = 26
        Me.Label49.Text = "BD"
        '
        'txtPesoI
        '
        Me.txtPesoI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoI.Location = New System.Drawing.Point(141, 146)
        Me.txtPesoI.Name = "txtPesoI"
        Me.txtPesoI.Size = New System.Drawing.Size(100, 27)
        Me.txtPesoI.TabIndex = 59
        Me.txtPesoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(683, 127)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(32, 21)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "PD"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(40, 91)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 21)
        Me.Label43.TabIndex = 28
        Me.Label43.Text = "Peso"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(480, 123)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(47, 21)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "OMB"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(40, 152)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(88, 21)
        Me.Label51.TabIndex = 28
        Me.Label51.Text = "Peso Ideal"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(286, 190)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(47, 21)
        Me.Label41.TabIndex = 26
        Me.Label41.Text = "CINT"
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(141, 202)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 27)
        Me.txtAltura.TabIndex = 60
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBI
        '
        Me.txtBI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBI.Location = New System.Drawing.Point(869, 184)
        Me.txtBI.Name = "txtBI"
        Me.txtBI.Size = New System.Drawing.Size(98, 27)
        Me.txtBI.TabIndex = 68
        Me.txtBI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(40, 208)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(57, 21)
        Me.Label42.TabIndex = 27
        Me.Label42.Text = "Altura"
        '
        'txtPI
        '
        Me.txtPI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPI.Location = New System.Drawing.Point(714, 184)
        Me.txtPI.Name = "txtPI"
        Me.txtPI.Size = New System.Drawing.Size(98, 27)
        Me.txtPI.TabIndex = 66
        Me.txtPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImc
        '
        Me.txtImc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImc.Location = New System.Drawing.Point(350, 117)
        Me.txtImc.Name = "txtImc"
        Me.txtImc.Size = New System.Drawing.Size(100, 27)
        Me.txtImc.TabIndex = 61
        Me.txtImc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBOMB
        '
        Me.txtBOMB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBOMB.Location = New System.Drawing.Point(549, 184)
        Me.txtBOMB.Name = "txtBOMB"
        Me.txtBOMB.Size = New System.Drawing.Size(100, 27)
        Me.txtBOMB.TabIndex = 64
        Me.txtBOMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCINT
        '
        Me.txtCINT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCINT.Location = New System.Drawing.Point(350, 184)
        Me.txtCINT.Name = "txtCINT"
        Me.txtCINT.Size = New System.Drawing.Size(100, 27)
        Me.txtCINT.TabIndex = 62
        Me.txtCINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41t
        '
        Me.Label41t.AutoSize = True
        Me.Label41t.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41t.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label41t.Location = New System.Drawing.Point(286, 117)
        Me.Label41t.Name = "Label41t"
        Me.Label41t.Size = New System.Drawing.Size(40, 21)
        Me.Label41t.TabIndex = 26
        Me.Label41t.Text = "IMC"
        '
        'txtOMB
        '
        Me.txtOMB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOMB.Location = New System.Drawing.Point(549, 121)
        Me.txtOMB.Name = "txtOMB"
        Me.txtOMB.Size = New System.Drawing.Size(100, 27)
        Me.txtOMB.TabIndex = 63
        Me.txtOMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBD
        '
        Me.txtBD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBD.Location = New System.Drawing.Point(869, 121)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(98, 27)
        Me.txtBD.TabIndex = 67
        Me.txtBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPD
        '
        Me.txtPD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPD.Location = New System.Drawing.Point(714, 121)
        Me.txtPD.Name = "txtPD"
        Me.txtPD.Size = New System.Drawing.Size(98, 27)
        Me.txtPD.TabIndex = 65
        Me.txtPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCancelar)
        Me.Panel3.Controls.Add(Me.lblReset)
        Me.Panel3.Controls.Add(Me.lblAgregarHistorial)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 376)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1020, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblCancelar.Location = New System.Drawing.Point(658, 11)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblCancelar.Size = New System.Drawing.Size(131, 41)
        Me.lblCancelar.TabIndex = 5
        Me.lblCancelar.Text = "VOLVER"
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblReset.Location = New System.Drawing.Point(477, 11)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblReset.Size = New System.Drawing.Size(116, 41)
        Me.lblReset.TabIndex = 16
        Me.lblReset.Text = "RESET"
        '
        'lblAgregarHistorial
        '
        Me.lblAgregarHistorial.AutoSize = True
        Me.lblAgregarHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblAgregarHistorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblAgregarHistorial.Location = New System.Drawing.Point(278, 11)
        Me.lblAgregarHistorial.Name = "lblAgregarHistorial"
        Me.lblAgregarHistorial.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblAgregarHistorial.Size = New System.Drawing.Size(147, 41)
        Me.lblAgregarHistorial.TabIndex = 16
        Me.lblAgregarHistorial.Text = "GUARDAR"
        '
        'AgregarTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AgregarTratamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarTratamiento"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.gbAntecedentesEnfer.ResumeLayout(False)
        Me.gbAntecedentesEnfer.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAgregarHistorial As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCancelar As Label
    Friend WithEvents gbAntecedentesEnfer As GroupBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txtPesoI As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtBI As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtPI As TextBox
    Friend WithEvents txtImc As TextBox
    Friend WithEvents txtBOMB As TextBox
    Friend WithEvents txtCINT As TextBox
    Friend WithEvents Label41t As Label
    Friend WithEvents txtOMB As TextBox
    Friend WithEvents txtBD As TextBox
    Friend WithEvents txtPD As TextBox
    Friend WithEvents lblReset As Label
End Class
