<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMAOATELIER
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMAOATELIER))
        Me.MatriculeResponsable = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléMatRespo = New Guna.UI.WinForms.GunaButton()
        Me.Responsable = New Guna.UI.WinForms.GunaComboBox()
        Me.LibelléResponsable = New Guna.UI.WinForms.GunaButton()
        Me.LibelléDepartement = New Guna.UI.WinForms.GunaButton()
        Me.Département = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléSecteur = New Guna.UI.WinForms.GunaButton()
        Me.Destination = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléDestination = New Guna.UI.WinForms.GunaButton()
        Me.MotsClés = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléMotsClés = New Guna.UI.WinForms.GunaButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Listepièces = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documents = New System.Windows.Forms.TabPage()
        Me.Sauvegarder = New System.Windows.Forms.Button()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Listepièces.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculeResponsable
        '
        Me.MatriculeResponsable.BaseColor = System.Drawing.Color.White
        Me.MatriculeResponsable.BorderColor = System.Drawing.Color.Silver
        Me.MatriculeResponsable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MatriculeResponsable.FocusedBaseColor = System.Drawing.Color.White
        Me.MatriculeResponsable.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MatriculeResponsable.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.MatriculeResponsable.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MatriculeResponsable.Location = New System.Drawing.Point(482, 77)
        Me.MatriculeResponsable.Name = "MatriculeResponsable"
        Me.MatriculeResponsable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MatriculeResponsable.SelectedText = ""
        Me.MatriculeResponsable.Size = New System.Drawing.Size(223, 26)
        Me.MatriculeResponsable.TabIndex = 770
        '
        'LibelléMatRespo
        '
        Me.LibelléMatRespo.AnimationHoverSpeed = 0.07!
        Me.LibelléMatRespo.AnimationSpeed = 0.03!
        Me.LibelléMatRespo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMatRespo.BorderColor = System.Drawing.Color.Black
        Me.LibelléMatRespo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléMatRespo.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléMatRespo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléMatRespo.ForeColor = System.Drawing.Color.White
        Me.LibelléMatRespo.Image = Nothing
        Me.LibelléMatRespo.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléMatRespo.Location = New System.Drawing.Point(314, 77)
        Me.LibelléMatRespo.Name = "LibelléMatRespo"
        Me.LibelléMatRespo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMatRespo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléMatRespo.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléMatRespo.OnHoverImage = Nothing
        Me.LibelléMatRespo.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléMatRespo.Size = New System.Drawing.Size(162, 26)
        Me.LibelléMatRespo.TabIndex = 769
        Me.LibelléMatRespo.Text = "Matricule Responsable"
        Me.LibelléMatRespo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Responsable
        '
        Me.Responsable.BackColor = System.Drawing.Color.Transparent
        Me.Responsable.BaseColor = System.Drawing.Color.White
        Me.Responsable.BorderColor = System.Drawing.Color.Silver
        Me.Responsable.DisplayMember = "Nom_Mag"
        Me.Responsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Responsable.FocusedColor = System.Drawing.Color.Empty
        Me.Responsable.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Responsable.ForeColor = System.Drawing.Color.Black
        Me.Responsable.FormattingEnabled = True
        Me.Responsable.Location = New System.Drawing.Point(483, 45)
        Me.Responsable.Name = "Responsable"
        Me.Responsable.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Responsable.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Responsable.Size = New System.Drawing.Size(222, 23)
        Me.Responsable.TabIndex = 768
        Me.Responsable.ValueMember = "Code_Mag"
        '
        'LibelléResponsable
        '
        Me.LibelléResponsable.AnimationHoverSpeed = 0.07!
        Me.LibelléResponsable.AnimationSpeed = 0.03!
        Me.LibelléResponsable.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléResponsable.BorderColor = System.Drawing.Color.Black
        Me.LibelléResponsable.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléResponsable.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléResponsable.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléResponsable.ForeColor = System.Drawing.Color.White
        Me.LibelléResponsable.Image = Nothing
        Me.LibelléResponsable.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléResponsable.Location = New System.Drawing.Point(314, 45)
        Me.LibelléResponsable.Name = "LibelléResponsable"
        Me.LibelléResponsable.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléResponsable.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléResponsable.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléResponsable.OnHoverImage = Nothing
        Me.LibelléResponsable.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléResponsable.Size = New System.Drawing.Size(162, 26)
        Me.LibelléResponsable.TabIndex = 767
        Me.LibelléResponsable.Text = "Responsable"
        Me.LibelléResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibelléDepartement
        '
        Me.LibelléDepartement.AnimationHoverSpeed = 0.07!
        Me.LibelléDepartement.AnimationSpeed = 0.03!
        Me.LibelléDepartement.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDepartement.BorderColor = System.Drawing.Color.Black
        Me.LibelléDepartement.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléDepartement.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléDepartement.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléDepartement.ForeColor = System.Drawing.Color.White
        Me.LibelléDepartement.Image = Nothing
        Me.LibelléDepartement.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléDepartement.Location = New System.Drawing.Point(314, 12)
        Me.LibelléDepartement.Name = "LibelléDepartement"
        Me.LibelléDepartement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDepartement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDepartement.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDepartement.OnHoverImage = Nothing
        Me.LibelléDepartement.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDepartement.Size = New System.Drawing.Size(162, 26)
        Me.LibelléDepartement.TabIndex = 765
        Me.LibelléDepartement.Text = "Département"
        Me.LibelléDepartement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Département
        '
        Me.Département.BackColor = System.Drawing.Color.Transparent
        Me.Département.BaseColor = System.Drawing.Color.White
        Me.Département.BorderColor = System.Drawing.Color.Silver
        Me.Département.DisplayMember = "Nom_Mag"
        Me.Département.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Département.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Département.FocusedColor = System.Drawing.Color.Empty
        Me.Département.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Département.ForeColor = System.Drawing.Color.Black
        Me.Département.FormattingEnabled = True
        Me.Département.Location = New System.Drawing.Point(483, 12)
        Me.Département.Name = "Département"
        Me.Département.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Département.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Département.Size = New System.Drawing.Size(222, 23)
        Me.Département.TabIndex = 771
        Me.Département.ValueMember = "Code_Mag"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(483, 109)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(223, 26)
        Me.GunaTextBox1.TabIndex = 773
        '
        'LibelléSecteur
        '
        Me.LibelléSecteur.AnimationHoverSpeed = 0.07!
        Me.LibelléSecteur.AnimationSpeed = 0.03!
        Me.LibelléSecteur.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléSecteur.BorderColor = System.Drawing.Color.Black
        Me.LibelléSecteur.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléSecteur.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléSecteur.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléSecteur.ForeColor = System.Drawing.Color.White
        Me.LibelléSecteur.Image = Nothing
        Me.LibelléSecteur.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléSecteur.Location = New System.Drawing.Point(315, 109)
        Me.LibelléSecteur.Name = "LibelléSecteur"
        Me.LibelléSecteur.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléSecteur.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléSecteur.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléSecteur.OnHoverImage = Nothing
        Me.LibelléSecteur.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléSecteur.Size = New System.Drawing.Size(162, 26)
        Me.LibelléSecteur.TabIndex = 772
        Me.LibelléSecteur.Text = "Secteur Activité"
        Me.LibelléSecteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Destination
        '
        Me.Destination.BaseColor = System.Drawing.Color.White
        Me.Destination.BorderColor = System.Drawing.Color.Silver
        Me.Destination.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Destination.FocusedBaseColor = System.Drawing.Color.White
        Me.Destination.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Destination.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Destination.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Destination.Location = New System.Drawing.Point(33, 77)
        Me.Destination.Name = "Destination"
        Me.Destination.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Destination.SelectedText = ""
        Me.Destination.Size = New System.Drawing.Size(223, 26)
        Me.Destination.TabIndex = 775
        '
        'LibelléDestination
        '
        Me.LibelléDestination.AnimationHoverSpeed = 0.07!
        Me.LibelléDestination.AnimationSpeed = 0.03!
        Me.LibelléDestination.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDestination.BorderColor = System.Drawing.Color.Black
        Me.LibelléDestination.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléDestination.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléDestination.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléDestination.ForeColor = System.Drawing.Color.White
        Me.LibelléDestination.Image = Nothing
        Me.LibelléDestination.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléDestination.Location = New System.Drawing.Point(33, 45)
        Me.LibelléDestination.Name = "LibelléDestination"
        Me.LibelléDestination.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDestination.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDestination.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDestination.OnHoverImage = Nothing
        Me.LibelléDestination.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDestination.Size = New System.Drawing.Size(223, 26)
        Me.LibelléDestination.TabIndex = 774
        Me.LibelléDestination.Text = "Destination"
        Me.LibelléDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MotsClés
        '
        Me.MotsClés.BaseColor = System.Drawing.Color.White
        Me.MotsClés.BorderColor = System.Drawing.Color.Silver
        Me.MotsClés.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MotsClés.FocusedBaseColor = System.Drawing.Color.White
        Me.MotsClés.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MotsClés.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.MotsClés.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MotsClés.Location = New System.Drawing.Point(192, 141)
        Me.MotsClés.Name = "MotsClés"
        Me.MotsClés.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MotsClés.SelectedText = ""
        Me.MotsClés.Size = New System.Drawing.Size(726, 26)
        Me.MotsClés.TabIndex = 777
        '
        'LibelléMotsClés
        '
        Me.LibelléMotsClés.AnimationHoverSpeed = 0.07!
        Me.LibelléMotsClés.AnimationSpeed = 0.03!
        Me.LibelléMotsClés.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMotsClés.BorderColor = System.Drawing.Color.Black
        Me.LibelléMotsClés.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléMotsClés.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléMotsClés.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléMotsClés.ForeColor = System.Drawing.Color.White
        Me.LibelléMotsClés.Image = Nothing
        Me.LibelléMotsClés.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléMotsClés.Location = New System.Drawing.Point(12, 141)
        Me.LibelléMotsClés.Name = "LibelléMotsClés"
        Me.LibelléMotsClés.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMotsClés.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléMotsClés.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléMotsClés.OnHoverImage = Nothing
        Me.LibelléMotsClés.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléMotsClés.Size = New System.Drawing.Size(162, 26)
        Me.LibelléMotsClés.TabIndex = 776
        Me.LibelléMotsClés.Text = "Mots Clés"
        Me.LibelléMotsClés.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Listepièces)
        Me.TabControl1.Controls.Add(Me.Documents)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 187)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 335)
        Me.TabControl1.TabIndex = 778
        '
        'Listepièces
        '
        Me.Listepièces.Controls.Add(Me.DataGridView1)
        Me.Listepièces.Location = New System.Drawing.Point(4, 25)
        Me.Listepièces.Name = "Listepièces"
        Me.Listepièces.Padding = New System.Windows.Forms.Padding(3)
        Me.Listepièces.Size = New System.Drawing.Size(898, 306)
        Me.Listepièces.TabIndex = 0
        Me.Listepièces.Text = "Liste des pièces de Rechanges"
        Me.Listepièces.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(825, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Désignation"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 96
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Référence"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 88
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Atelier"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 65
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Fabricant"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Référence Fabricant"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 131
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Poste Opérateur"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 112
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Conditionnement"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 128
        '
        'Documents
        '
        Me.Documents.Location = New System.Drawing.Point(4, 25)
        Me.Documents.Name = "Documents"
        Me.Documents.Padding = New System.Windows.Forms.Padding(3)
        Me.Documents.Size = New System.Drawing.Size(954, 306)
        Me.Documents.TabIndex = 1
        Me.Documents.Text = "Documents attachés"
        Me.Documents.UseVisualStyleBackColor = True
        '
        'Sauvegarder
        '
        Me.Sauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sauvegarder.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Sauvegarder.ForeColor = System.Drawing.Color.White
        Me.Sauvegarder.Image = CType(resources.GetObject("Sauvegarder.Image"), System.Drawing.Image)
        Me.Sauvegarder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sauvegarder.Location = New System.Drawing.Point(730, 12)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(91, 68)
        Me.Sauvegarder.TabIndex = 779
        Me.Sauvegarder.Text = "Sauvegarder"
        Me.Sauvegarder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Sauvegarder.UseVisualStyleBackColor = False
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimer.Location = New System.Drawing.Point(827, 12)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 780
        Me.Imprimer.Text = "Imprimer"
        Me.Imprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imprimer.UseVisualStyleBackColor = False
        '
        'GMAOATELIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 530)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.MotsClés)
        Me.Controls.Add(Me.LibelléMotsClés)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.LibelléDestination)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.LibelléSecteur)
        Me.Controls.Add(Me.Département)
        Me.Controls.Add(Me.MatriculeResponsable)
        Me.Controls.Add(Me.LibelléMatRespo)
        Me.Controls.Add(Me.Responsable)
        Me.Controls.Add(Me.LibelléResponsable)
        Me.Controls.Add(Me.LibelléDepartement)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "GMAOATELIER"
        Me.Text = "Gestion des ateliers"
        Me.TabControl1.ResumeLayout(False)
        Me.Listepièces.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MatriculeResponsable As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléMatRespo As Guna.UI.WinForms.GunaButton
    Friend WithEvents Responsable As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LibelléResponsable As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléDepartement As Guna.UI.WinForms.GunaButton
    Friend WithEvents Département As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléSecteur As Guna.UI.WinForms.GunaButton
    Friend WithEvents Destination As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléDestination As Guna.UI.WinForms.GunaButton
    Friend WithEvents MotsClés As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléMotsClés As Guna.UI.WinForms.GunaButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Listepièces As TabPage
    Friend WithEvents Documents As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Sauvegarder As Button
    Friend WithEvents Imprimer As Button
End Class
