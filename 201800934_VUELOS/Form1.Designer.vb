<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_peten = New System.Windows.Forms.TextBox()
        Me.txt_izabal = New System.Windows.Forms.TextBox()
        Me.txt_costasur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_peten = New System.Windows.Forms.CheckBox()
        Me.cb_izabal = New System.Windows.Forms.CheckBox()
        Me.cb_costasur = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_helicoptero = New System.Windows.Forms.RadioButton()
        Me.rb_jet = New System.Windows.Forms.RadioButton()
        Me.rb_avioneta = New System.Windows.Forms.RadioButton()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(66, 29)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_VUELOS.My.Resources.Resources.images
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 402)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_peten)
        Me.GroupBox4.Controls.Add(Me.txt_izabal)
        Me.GroupBox4.Controls.Add(Me.txt_costasur)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 232)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cantidad de pasajeros:"
        '
        'txt_peten
        '
        Me.txt_peten.Location = New System.Drawing.Point(109, 164)
        Me.txt_peten.Name = "txt_peten"
        Me.txt_peten.Size = New System.Drawing.Size(100, 26)
        Me.txt_peten.TabIndex = 5
        Me.txt_peten.Text = "0"
        '
        'txt_izabal
        '
        Me.txt_izabal.Location = New System.Drawing.Point(109, 99)
        Me.txt_izabal.Name = "txt_izabal"
        Me.txt_izabal.Size = New System.Drawing.Size(100, 26)
        Me.txt_izabal.TabIndex = 4
        Me.txt_izabal.Text = "0"
        '
        'txt_costasur
        '
        Me.txt_costasur.Location = New System.Drawing.Point(109, 43)
        Me.txt_costasur.Name = "txt_costasur"
        Me.txt_costasur.Size = New System.Drawing.Size(100, 26)
        Me.txt_costasur.TabIndex = 3
        Me.txt_costasur.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peten:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Izabal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costa Sur:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_peten)
        Me.GroupBox3.Controls.Add(Me.cb_izabal)
        Me.GroupBox3.Controls.Add(Me.cb_costasur)
        Me.GroupBox3.Location = New System.Drawing.Point(574, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 232)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destino:"
        '
        'cb_peten
        '
        Me.cb_peten.AutoSize = True
        Me.cb_peten.Location = New System.Drawing.Point(29, 169)
        Me.cb_peten.Name = "cb_peten"
        Me.cb_peten.Size = New System.Drawing.Size(81, 24)
        Me.cb_peten.TabIndex = 2
        Me.cb_peten.Text = "Peten:"
        Me.cb_peten.UseVisualStyleBackColor = True
        '
        'cb_izabal
        '
        Me.cb_izabal.AutoSize = True
        Me.cb_izabal.Location = New System.Drawing.Point(29, 104)
        Me.cb_izabal.Name = "cb_izabal"
        Me.cb_izabal.Size = New System.Drawing.Size(82, 24)
        Me.cb_izabal.TabIndex = 1
        Me.cb_izabal.Text = "Izabal:"
        Me.cb_izabal.UseVisualStyleBackColor = True
        '
        'cb_costasur
        '
        Me.cb_costasur.AutoSize = True
        Me.cb_costasur.Location = New System.Drawing.Point(29, 41)
        Me.cb_costasur.Name = "cb_costasur"
        Me.cb_costasur.Size = New System.Drawing.Size(110, 24)
        Me.cb_costasur.TabIndex = 0
        Me.cb_costasur.Text = "Costa Sur:"
        Me.cb_costasur.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_helicoptero)
        Me.GroupBox2.Controls.Add(Me.rb_jet)
        Me.GroupBox2.Controls.Add(Me.rb_avioneta)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 232)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Aeronave:"
        '
        'rb_helicoptero
        '
        Me.rb_helicoptero.AutoSize = True
        Me.rb_helicoptero.Location = New System.Drawing.Point(34, 169)
        Me.rb_helicoptero.Name = "rb_helicoptero"
        Me.rb_helicoptero.Size = New System.Drawing.Size(119, 24)
        Me.rb_helicoptero.TabIndex = 2
        Me.rb_helicoptero.TabStop = True
        Me.rb_helicoptero.Text = "Helicoptero:"
        Me.rb_helicoptero.UseVisualStyleBackColor = True
        '
        'rb_jet
        '
        Me.rb_jet.AutoSize = True
        Me.rb_jet.Location = New System.Drawing.Point(34, 104)
        Me.rb_jet.Name = "rb_jet"
        Me.rb_jet.Size = New System.Drawing.Size(60, 24)
        Me.rb_jet.TabIndex = 1
        Me.rb_jet.TabStop = True
        Me.rb_jet.Text = "Jet:"
        Me.rb_jet.UseVisualStyleBackColor = True
        '
        'rb_avioneta
        '
        Me.rb_avioneta.AutoSize = True
        Me.rb_avioneta.Location = New System.Drawing.Point(34, 41)
        Me.rb_avioneta.Name = "rb_avioneta"
        Me.rb_avioneta.Size = New System.Drawing.Size(100, 24)
        Me.rb_avioneta.TabIndex = 0
        Me.rb_avioneta.TabStop = True
        Me.rb_avioneta.Text = "Avioneta:"
        Me.rb_avioneta.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(313, 333)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(163, 54)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "SISTEMA AGENCIA DE VIAJES:"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_peten As TextBox
    Friend WithEvents txt_izabal As TextBox
    Friend WithEvents txt_costasur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_peten As CheckBox
    Friend WithEvents cb_izabal As CheckBox
    Friend WithEvents cb_costasur As CheckBox
    Friend WithEvents rb_helicoptero As RadioButton
    Friend WithEvents rb_jet As RadioButton
    Friend WithEvents rb_avioneta As RadioButton
End Class
