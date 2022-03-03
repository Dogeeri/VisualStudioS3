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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LST_LISTA = New System.Windows.Forms.ListBox()
        Me.CALC_VEND = New System.Windows.Forms.Button()
        Me.CMB_VEND = New System.Windows.Forms.ComboBox()
        Me.CMB_CLI = New System.Windows.Forms.ComboBox()
        Me.TXT_FIND_VEND = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_FIND_CLI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CALC_CLI = New System.Windows.Forms.Button()
        Me.LST_BUSCAR = New System.Windows.Forms.ListBox()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.TXT_FAKECLI = New System.Windows.Forms.TextBox()
        Me.TXT_FAKEVEND = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_LISTA
        '
        Me.LST_LISTA.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_LISTA.FormattingEnabled = True
        Me.LST_LISTA.Location = New System.Drawing.Point(12, 28)
        Me.LST_LISTA.Name = "LST_LISTA"
        Me.LST_LISTA.Size = New System.Drawing.Size(874, 277)
        Me.LST_LISTA.TabIndex = 0
        '
        'CALC_VEND
        '
        Me.CALC_VEND.Location = New System.Drawing.Point(112, 394)
        Me.CALC_VEND.Name = "CALC_VEND"
        Me.CALC_VEND.Size = New System.Drawing.Size(169, 21)
        Me.CALC_VEND.TabIndex = 1
        Me.CALC_VEND.Text = "Calcular"
        Me.CALC_VEND.UseVisualStyleBackColor = True
        '
        'CMB_VEND
        '
        Me.CMB_VEND.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_VEND.FormattingEnabled = True
        Me.CMB_VEND.Location = New System.Drawing.Point(112, 367)
        Me.CMB_VEND.Name = "CMB_VEND"
        Me.CMB_VEND.Size = New System.Drawing.Size(169, 21)
        Me.CMB_VEND.TabIndex = 2
        Me.CMB_VEND.Text = "TODOS"
        '
        'CMB_CLI
        '
        Me.CMB_CLI.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_CLI.FormattingEnabled = True
        Me.CMB_CLI.Location = New System.Drawing.Point(290, 367)
        Me.CMB_CLI.Name = "CMB_CLI"
        Me.CMB_CLI.Size = New System.Drawing.Size(169, 21)
        Me.CMB_CLI.TabIndex = 3
        Me.CMB_CLI.Text = "TODOS"
        '
        'TXT_FIND_VEND
        '
        Me.TXT_FIND_VEND.Location = New System.Drawing.Point(112, 324)
        Me.TXT_FIND_VEND.Name = "TXT_FIND_VEND"
        Me.TXT_FIND_VEND.Size = New System.Drawing.Size(169, 20)
        Me.TXT_FIND_VEND.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(745, 311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aqua
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Aqua
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "VENDEDOR"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Aqua
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Aqua
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ITEM"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Aqua
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(657, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ITEM"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Aqua
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(794, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Aqua
        Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(830, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "STOCK"
        '
        'TXT_FIND_CLI
        '
        Me.TXT_FIND_CLI.Location = New System.Drawing.Point(290, 324)
        Me.TXT_FIND_CLI.Name = "TXT_FIND_CLI"
        Me.TXT_FIND_CLI.Size = New System.Drawing.Size(169, 20)
        Me.TXT_FIND_CLI.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Aqua
        Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "BUSQUEDA INCREMENTAL VENDEDOR"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Aqua
        Me.Label10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "BUSQUEDA CONTENIDO CLIENTE"
        '
        'CALC_CLI
        '
        Me.CALC_CLI.Location = New System.Drawing.Point(290, 394)
        Me.CALC_CLI.Name = "CALC_CLI"
        Me.CALC_CLI.Size = New System.Drawing.Size(169, 21)
        Me.CALC_CLI.TabIndex = 17
        Me.CALC_CLI.Text = "Calcular"
        Me.CALC_CLI.UseVisualStyleBackColor = True
        '
        'LST_BUSCAR
        '
        Me.LST_BUSCAR.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_BUSCAR.FormattingEnabled = True
        Me.LST_BUSCAR.Location = New System.Drawing.Point(933, 112)
        Me.LST_BUSCAR.Name = "LST_BUSCAR"
        Me.LST_BUSCAR.Size = New System.Drawing.Size(475, 108)
        Me.LST_BUSCAR.TabIndex = 18
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(112, 421)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(169, 20)
        Me.TXT_TOTAL.TabIndex = 19
        '
        'TXT_FAKECLI
        '
        Me.TXT_FAKECLI.Location = New System.Drawing.Point(933, 60)
        Me.TXT_FAKECLI.Name = "TXT_FAKECLI"
        Me.TXT_FAKECLI.Size = New System.Drawing.Size(169, 20)
        Me.TXT_FAKECLI.TabIndex = 20
        '
        'TXT_FAKEVEND
        '
        Me.TXT_FAKEVEND.Location = New System.Drawing.Point(933, 86)
        Me.TXT_FAKEVEND.Name = "TXT_FAKEVEND"
        Me.TXT_FAKEVEND.Size = New System.Drawing.Size(169, 20)
        Me.TXT_FAKEVEND.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 48)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(896, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_FAKEVEND)
        Me.Controls.Add(Me.TXT_FAKECLI)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.LST_BUSCAR)
        Me.Controls.Add(Me.CALC_CLI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_FIND_CLI)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXT_FIND_VEND)
        Me.Controls.Add(Me.CMB_CLI)
        Me.Controls.Add(Me.CMB_VEND)
        Me.Controls.Add(Me.CALC_VEND)
        Me.Controls.Add(Me.LST_LISTA)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LST_LISTA As ListBox
    Friend WithEvents CALC_VEND As Button
    Friend WithEvents CMB_VEND As ComboBox
    Friend WithEvents CMB_CLI As ComboBox
    Friend WithEvents TXT_FIND_VEND As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_FIND_CLI As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CALC_CLI As Button
    Friend WithEvents LST_BUSCAR As ListBox
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents TXT_FAKECLI As TextBox
    Friend WithEvents TXT_FAKEVEND As TextBox
    Friend WithEvents Button1 As Button
End Class
