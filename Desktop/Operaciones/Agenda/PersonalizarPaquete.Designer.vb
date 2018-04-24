<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonalizarPaquete
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nroSesion = New System.Windows.Forms.NumericUpDown()
        Me.listServicios = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.lblAgregar = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.nroSesion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91842!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.08159!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(561, 589)
        Me.TableLayoutPanel1.TabIndex = 3
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
        Me.Panel1.Size = New System.Drawing.Size(561, 78)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECCIONE SERVICIO PARA LA RESERVA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.nroSesion)
        Me.Panel2.Controls.Add(Me.listServicios)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 450)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero de Sesiones"
        '
        'nroSesion
        '
        Me.nroSesion.Location = New System.Drawing.Point(373, 408)
        Me.nroSesion.Name = "nroSesion"
        Me.nroSesion.Size = New System.Drawing.Size(120, 29)
        Me.nroSesion.TabIndex = 1
        '
        'listServicios
        '
        Me.listServicios.FormattingEnabled = True
        Me.listServicios.ItemHeight = 21
        Me.listServicios.Location = New System.Drawing.Point(46, 31)
        Me.listServicios.Name = "listServicios"
        Me.listServicios.Size = New System.Drawing.Size(447, 361)
        Me.listServicios.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblSalir)
        Me.Panel3.Controls.Add(Me.lblAgregar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 528)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 61)
        Me.Panel3.TabIndex = 2
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblSalir.Location = New System.Drawing.Point(334, 11)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblSalir.Size = New System.Drawing.Size(113, 41)
        Me.lblSalir.TabIndex = 13
        Me.lblSalir.Text = "SALIR"
        '
        'lblAgregar
        '
        Me.lblAgregar.AutoSize = True
        Me.lblAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lblAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lblAgregar.Location = New System.Drawing.Point(124, 11)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.lblAgregar.Size = New System.Drawing.Size(132, 41)
        Me.lblAgregar.TabIndex = 13
        Me.lblAgregar.Text = "AÑADIR"
        '
        'PersonalizarPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 589)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PersonalizarPaquete"
        Me.Text = "PersonalizarPaquete"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nroSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents nroSesion As NumericUpDown
    Friend WithEvents listServicios As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSalir As Label
    Friend WithEvents lblAgregar As Label
End Class
