<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMAOPIECEDERECHANGE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMAOPIECEDERECHANGE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Général = New System.Windows.Forms.TabPage()
        Me.AffecterApplication = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AjouterPièce = New System.Windows.Forms.Button()
        Me.AjouterFournisseur = New System.Windows.Forms.Button()
        Me.ImprimerFournisseur = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Application = New System.Windows.Forms.Label()
        Me.Fournisseur = New System.Windows.Forms.Label()
        Me.SauvegarderPièce = New System.Windows.Forms.Button()
        Me.ImprimerPièce = New System.Windows.Forms.Button()
        Me.PosteOpérateur = New Guna.UI.WinForms.GunaComboBox()
        Me.Conditionnement = New Guna.UI.WinForms.GunaComboBox()
        Me.LiblCond = New Guna.UI.WinForms.GunaButton()
        Me.LiblPoste = New Guna.UI.WinForms.GunaButton()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.LiblRefFab = New Guna.UI.WinForms.GunaButton()
        Me.Fabricant = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléFabricant = New Guna.UI.WinForms.GunaButton()
        Me.Désignation = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléDésignation = New Guna.UI.WinForms.GunaButton()
        Me.Département = New Guna.UI.WinForms.GunaComboBox()
        Me.Référence = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléRéférence = New Guna.UI.WinForms.GunaButton()
        Me.Machine = New Guna.UI.WinForms.GunaComboBox()
        Me.LibelléMachine = New Guna.UI.WinForms.GunaButton()
        Me.LibelléDepartement = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Documents = New System.Windows.Forms.TabPage()
        Me.Logistiques = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.Général.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Général)
        Me.TabControl1.Controls.Add(Me.Documents)
        Me.TabControl1.Controls.Add(Me.Logistiques)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1032, 555)
        Me.TabControl1.TabIndex = 0
        '
        'Général
        '
        Me.Général.Controls.Add(Me.AffecterApplication)
        Me.Général.Controls.Add(Me.Button3)
        Me.Général.Controls.Add(Me.DataGridView2)
        Me.Général.Controls.Add(Me.AjouterPièce)
        Me.Général.Controls.Add(Me.AjouterFournisseur)
        Me.Général.Controls.Add(Me.ImprimerFournisseur)
        Me.Général.Controls.Add(Me.DataGridView1)
        Me.Général.Controls.Add(Me.Application)
        Me.Général.Controls.Add(Me.Fournisseur)
        Me.Général.Controls.Add(Me.SauvegarderPièce)
        Me.Général.Controls.Add(Me.ImprimerPièce)
        Me.Général.Controls.Add(Me.PosteOpérateur)
        Me.Général.Controls.Add(Me.Conditionnement)
        Me.Général.Controls.Add(Me.LiblCond)
        Me.Général.Controls.Add(Me.LiblPoste)
        Me.Général.Controls.Add(Me.GunaTextBox2)
        Me.Général.Controls.Add(Me.LiblRefFab)
        Me.Général.Controls.Add(Me.Fabricant)
        Me.Général.Controls.Add(Me.LibelléFabricant)
        Me.Général.Controls.Add(Me.Désignation)
        Me.Général.Controls.Add(Me.LibelléDésignation)
        Me.Général.Controls.Add(Me.Département)
        Me.Général.Controls.Add(Me.Référence)
        Me.Général.Controls.Add(Me.LibelléRéférence)
        Me.Général.Controls.Add(Me.Machine)
        Me.Général.Controls.Add(Me.LibelléMachine)
        Me.Général.Controls.Add(Me.LibelléDepartement)
        Me.Général.Controls.Add(Me.Label1)
        Me.Général.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Général.Location = New System.Drawing.Point(4, 25)
        Me.Général.Name = "Général"
        Me.Général.Padding = New System.Windows.Forms.Padding(3)
        Me.Général.Size = New System.Drawing.Size(1024, 526)
        Me.Général.TabIndex = 0
        Me.Général.Text = "Général"
        Me.Général.UseVisualStyleBackColor = True
        '
        'AffecterApplication
        '
        Me.AffecterApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AffecterApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AffecterApplication.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AffecterApplication.ForeColor = System.Drawing.Color.White
        Me.AffecterApplication.Image = CType(resources.GetObject("AffecterApplication.Image"), System.Drawing.Image)
        Me.AffecterApplication.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AffecterApplication.Location = New System.Drawing.Point(892, 387)
        Me.AffecterApplication.Name = "AffecterApplication"
        Me.AffecterApplication.Size = New System.Drawing.Size(91, 57)
        Me.AffecterApplication.TabIndex = 801
        Me.AffecterApplication.Text = "Affecter"
        Me.AffecterApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AffecterApplication.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(892, 454)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 57)
        Me.Button3.TabIndex = 799
        Me.Button3.Text = "Imprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 387)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(821, 121)
        Me.DataGridView2.TabIndex = 798
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Intitulé"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 69
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date début d'application"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 158
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date fin d'application"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 138
        '
        'AjouterPièce
        '
        Me.AjouterPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AjouterPièce.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjouterPièce.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterPièce.ForeColor = System.Drawing.Color.White
        Me.AjouterPièce.Image = CType(resources.GetObject("AjouterPièce.Image"), System.Drawing.Image)
        Me.AjouterPièce.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AjouterPièce.Location = New System.Drawing.Point(892, 6)
        Me.AjouterPièce.Name = "AjouterPièce"
        Me.AjouterPièce.Size = New System.Drawing.Size(91, 57)
        Me.AjouterPièce.TabIndex = 797
        Me.AjouterPièce.Text = "Ajouter"
        Me.AjouterPièce.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AjouterPièce.UseVisualStyleBackColor = False
        '
        'AjouterFournisseur
        '
        Me.AjouterFournisseur.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AjouterFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjouterFournisseur.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterFournisseur.ForeColor = System.Drawing.Color.White
        Me.AjouterFournisseur.Image = CType(resources.GetObject("AjouterFournisseur.Image"), System.Drawing.Image)
        Me.AjouterFournisseur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AjouterFournisseur.Location = New System.Drawing.Point(892, 224)
        Me.AjouterFournisseur.Name = "AjouterFournisseur"
        Me.AjouterFournisseur.Size = New System.Drawing.Size(91, 57)
        Me.AjouterFournisseur.TabIndex = 796
        Me.AjouterFournisseur.Text = "Ajouter"
        Me.AjouterFournisseur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AjouterFournisseur.UseVisualStyleBackColor = False
        '
        'ImprimerFournisseur
        '
        Me.ImprimerFournisseur.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImprimerFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ImprimerFournisseur.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimerFournisseur.ForeColor = System.Drawing.Color.White
        Me.ImprimerFournisseur.Image = CType(resources.GetObject("ImprimerFournisseur.Image"), System.Drawing.Image)
        Me.ImprimerFournisseur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImprimerFournisseur.Location = New System.Drawing.Point(892, 289)
        Me.ImprimerFournisseur.Name = "ImprimerFournisseur"
        Me.ImprimerFournisseur.Size = New System.Drawing.Size(91, 57)
        Me.ImprimerFournisseur.TabIndex = 795
        Me.ImprimerFournisseur.Text = "Imprimer"
        Me.ImprimerFournisseur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImprimerFournisseur.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(821, 121)
        Me.DataGridView1.TabIndex = 794
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Fournisseur"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 89
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Référence Fournisseur"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 134
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Prix d'Achat"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 89
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Unité Achat"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 89
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Remise"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Conversion"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 94
        '
        'Application
        '
        Me.Application.AutoSize = True
        Me.Application.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Application.Location = New System.Drawing.Point(9, 368)
        Me.Application.Name = "Application"
        Me.Application.Size = New System.Drawing.Size(76, 16)
        Me.Application.TabIndex = 793
        Me.Application.Text = "Application"
        '
        'Fournisseur
        '
        Me.Fournisseur.AutoSize = True
        Me.Fournisseur.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Fournisseur.Location = New System.Drawing.Point(8, 205)
        Me.Fournisseur.Name = "Fournisseur"
        Me.Fournisseur.Size = New System.Drawing.Size(72, 16)
        Me.Fournisseur.TabIndex = 792
        Me.Fournisseur.Text = "Fournisseur"
        '
        'SauvegarderPièce
        '
        Me.SauvegarderPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SauvegarderPièce.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SauvegarderPièce.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SauvegarderPièce.ForeColor = System.Drawing.Color.White
        Me.SauvegarderPièce.Image = CType(resources.GetObject("SauvegarderPièce.Image"), System.Drawing.Image)
        Me.SauvegarderPièce.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SauvegarderPièce.Location = New System.Drawing.Point(892, 68)
        Me.SauvegarderPièce.Name = "SauvegarderPièce"
        Me.SauvegarderPièce.Size = New System.Drawing.Size(91, 57)
        Me.SauvegarderPièce.TabIndex = 791
        Me.SauvegarderPièce.Text = "Sauvegarder"
        Me.SauvegarderPièce.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SauvegarderPièce.UseVisualStyleBackColor = False
        '
        'ImprimerPièce
        '
        Me.ImprimerPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImprimerPièce.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ImprimerPièce.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimerPièce.ForeColor = System.Drawing.Color.White
        Me.ImprimerPièce.Image = CType(resources.GetObject("ImprimerPièce.Image"), System.Drawing.Image)
        Me.ImprimerPièce.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImprimerPièce.Location = New System.Drawing.Point(892, 131)
        Me.ImprimerPièce.Name = "ImprimerPièce"
        Me.ImprimerPièce.Size = New System.Drawing.Size(91, 57)
        Me.ImprimerPièce.TabIndex = 790
        Me.ImprimerPièce.Text = "Imprimer"
        Me.ImprimerPièce.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ImprimerPièce.UseVisualStyleBackColor = False
        '
        'PosteOpérateur
        '
        Me.PosteOpérateur.BackColor = System.Drawing.Color.Transparent
        Me.PosteOpérateur.BaseColor = System.Drawing.Color.White
        Me.PosteOpérateur.BorderColor = System.Drawing.Color.Silver
        Me.PosteOpérateur.DisplayMember = "Nom_Mag"
        Me.PosteOpérateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PosteOpérateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PosteOpérateur.FocusedColor = System.Drawing.Color.Empty
        Me.PosteOpérateur.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PosteOpérateur.ForeColor = System.Drawing.Color.Black
        Me.PosteOpérateur.FormattingEnabled = True
        Me.PosteOpérateur.Location = New System.Drawing.Point(611, 102)
        Me.PosteOpérateur.Name = "PosteOpérateur"
        Me.PosteOpérateur.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PosteOpérateur.OnHoverItemForeColor = System.Drawing.Color.White
        Me.PosteOpérateur.Size = New System.Drawing.Size(222, 23)
        Me.PosteOpérateur.TabIndex = 789
        Me.PosteOpérateur.ValueMember = "Code_Mag"
        '
        'Conditionnement
        '
        Me.Conditionnement.BackColor = System.Drawing.Color.Transparent
        Me.Conditionnement.BaseColor = System.Drawing.Color.White
        Me.Conditionnement.BorderColor = System.Drawing.Color.Silver
        Me.Conditionnement.DisplayMember = "Nom_Mag"
        Me.Conditionnement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Conditionnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Conditionnement.FocusedColor = System.Drawing.Color.Empty
        Me.Conditionnement.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Conditionnement.ForeColor = System.Drawing.Color.Black
        Me.Conditionnement.FormattingEnabled = True
        Me.Conditionnement.Location = New System.Drawing.Point(611, 135)
        Me.Conditionnement.Name = "Conditionnement"
        Me.Conditionnement.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Conditionnement.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Conditionnement.Size = New System.Drawing.Size(222, 23)
        Me.Conditionnement.TabIndex = 788
        Me.Conditionnement.ValueMember = "Code_Mag"
        '
        'LiblCond
        '
        Me.LiblCond.AnimationHoverSpeed = 0.07!
        Me.LiblCond.AnimationSpeed = 0.03!
        Me.LiblCond.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblCond.BorderColor = System.Drawing.Color.Black
        Me.LiblCond.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LiblCond.FocusedColor = System.Drawing.Color.Empty
        Me.LiblCond.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LiblCond.ForeColor = System.Drawing.Color.White
        Me.LiblCond.Image = Nothing
        Me.LiblCond.ImageSize = New System.Drawing.Size(20, 20)
        Me.LiblCond.Location = New System.Drawing.Point(442, 135)
        Me.LiblCond.Name = "LiblCond"
        Me.LiblCond.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblCond.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LiblCond.OnHoverForeColor = System.Drawing.Color.White
        Me.LiblCond.OnHoverImage = Nothing
        Me.LiblCond.OnPressedColor = System.Drawing.Color.Black
        Me.LiblCond.Size = New System.Drawing.Size(162, 26)
        Me.LiblCond.TabIndex = 787
        Me.LiblCond.Text = "Conditionnement"
        Me.LiblCond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LiblPoste
        '
        Me.LiblPoste.AnimationHoverSpeed = 0.07!
        Me.LiblPoste.AnimationSpeed = 0.03!
        Me.LiblPoste.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblPoste.BorderColor = System.Drawing.Color.Black
        Me.LiblPoste.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LiblPoste.FocusedColor = System.Drawing.Color.Empty
        Me.LiblPoste.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LiblPoste.ForeColor = System.Drawing.Color.White
        Me.LiblPoste.Image = Nothing
        Me.LiblPoste.ImageSize = New System.Drawing.Size(20, 20)
        Me.LiblPoste.Location = New System.Drawing.Point(442, 102)
        Me.LiblPoste.Name = "LiblPoste"
        Me.LiblPoste.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblPoste.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LiblPoste.OnHoverForeColor = System.Drawing.Color.White
        Me.LiblPoste.OnHoverImage = Nothing
        Me.LiblPoste.OnPressedColor = System.Drawing.Color.Black
        Me.LiblPoste.Size = New System.Drawing.Size(162, 26)
        Me.LiblPoste.TabIndex = 786
        Me.LiblPoste.Text = "Poste Opérateur"
        Me.LiblPoste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaTextBox2.Location = New System.Drawing.Point(180, 133)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(223, 26)
        Me.GunaTextBox2.TabIndex = 785
        '
        'LiblRefFab
        '
        Me.LiblRefFab.AnimationHoverSpeed = 0.07!
        Me.LiblRefFab.AnimationSpeed = 0.03!
        Me.LiblRefFab.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblRefFab.BorderColor = System.Drawing.Color.Black
        Me.LiblRefFab.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LiblRefFab.FocusedColor = System.Drawing.Color.Empty
        Me.LiblRefFab.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LiblRefFab.ForeColor = System.Drawing.Color.White
        Me.LiblRefFab.Image = Nothing
        Me.LiblRefFab.ImageSize = New System.Drawing.Size(20, 20)
        Me.LiblRefFab.Location = New System.Drawing.Point(12, 133)
        Me.LiblRefFab.Name = "LiblRefFab"
        Me.LiblRefFab.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblRefFab.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LiblRefFab.OnHoverForeColor = System.Drawing.Color.White
        Me.LiblRefFab.OnHoverImage = Nothing
        Me.LiblRefFab.OnPressedColor = System.Drawing.Color.Black
        Me.LiblRefFab.Size = New System.Drawing.Size(162, 26)
        Me.LiblRefFab.TabIndex = 784
        Me.LiblRefFab.Text = "Référence Fabricant"
        Me.LiblRefFab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fabricant
        '
        Me.Fabricant.BaseColor = System.Drawing.Color.White
        Me.Fabricant.BorderColor = System.Drawing.Color.Silver
        Me.Fabricant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fabricant.FocusedBaseColor = System.Drawing.Color.White
        Me.Fabricant.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Fabricant.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Fabricant.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Fabricant.Location = New System.Drawing.Point(179, 101)
        Me.Fabricant.Name = "Fabricant"
        Me.Fabricant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Fabricant.SelectedText = ""
        Me.Fabricant.Size = New System.Drawing.Size(223, 26)
        Me.Fabricant.TabIndex = 783
        '
        'LibelléFabricant
        '
        Me.LibelléFabricant.AnimationHoverSpeed = 0.07!
        Me.LibelléFabricant.AnimationSpeed = 0.03!
        Me.LibelléFabricant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléFabricant.BorderColor = System.Drawing.Color.Black
        Me.LibelléFabricant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléFabricant.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléFabricant.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléFabricant.ForeColor = System.Drawing.Color.White
        Me.LibelléFabricant.Image = Nothing
        Me.LibelléFabricant.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléFabricant.Location = New System.Drawing.Point(11, 101)
        Me.LibelléFabricant.Name = "LibelléFabricant"
        Me.LibelléFabricant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléFabricant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléFabricant.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléFabricant.OnHoverImage = Nothing
        Me.LibelléFabricant.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléFabricant.Size = New System.Drawing.Size(162, 26)
        Me.LibelléFabricant.TabIndex = 782
        Me.LibelléFabricant.Text = "Fabricant"
        Me.LibelléFabricant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Désignation
        '
        Me.Désignation.BaseColor = System.Drawing.Color.White
        Me.Désignation.BorderColor = System.Drawing.Color.Silver
        Me.Désignation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Désignation.FocusedBaseColor = System.Drawing.Color.White
        Me.Désignation.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Désignation.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Désignation.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Désignation.Location = New System.Drawing.Point(180, 69)
        Me.Désignation.Name = "Désignation"
        Me.Désignation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Désignation.SelectedText = ""
        Me.Désignation.Size = New System.Drawing.Size(223, 26)
        Me.Désignation.TabIndex = 781
        '
        'LibelléDésignation
        '
        Me.LibelléDésignation.AnimationHoverSpeed = 0.07!
        Me.LibelléDésignation.AnimationSpeed = 0.03!
        Me.LibelléDésignation.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDésignation.BorderColor = System.Drawing.Color.Black
        Me.LibelléDésignation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléDésignation.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléDésignation.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléDésignation.ForeColor = System.Drawing.Color.White
        Me.LibelléDésignation.Image = Nothing
        Me.LibelléDésignation.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléDésignation.Location = New System.Drawing.Point(12, 69)
        Me.LibelléDésignation.Name = "LibelléDésignation"
        Me.LibelléDésignation.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDésignation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDésignation.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDésignation.OnHoverImage = Nothing
        Me.LibelléDésignation.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDésignation.Size = New System.Drawing.Size(162, 26)
        Me.LibelléDésignation.TabIndex = 780
        Me.LibelléDésignation.Text = "Désignation"
        Me.LibelléDésignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Département.Location = New System.Drawing.Point(611, 37)
        Me.Département.Name = "Département"
        Me.Département.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Département.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Département.Size = New System.Drawing.Size(222, 23)
        Me.Département.TabIndex = 779
        Me.Département.ValueMember = "Code_Mag"
        '
        'Référence
        '
        Me.Référence.BaseColor = System.Drawing.Color.White
        Me.Référence.BorderColor = System.Drawing.Color.Silver
        Me.Référence.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Référence.FocusedBaseColor = System.Drawing.Color.White
        Me.Référence.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Référence.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Référence.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Référence.Location = New System.Drawing.Point(179, 37)
        Me.Référence.Name = "Référence"
        Me.Référence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Référence.SelectedText = ""
        Me.Référence.Size = New System.Drawing.Size(223, 26)
        Me.Référence.TabIndex = 778
        '
        'LibelléRéférence
        '
        Me.LibelléRéférence.AnimationHoverSpeed = 0.07!
        Me.LibelléRéférence.AnimationSpeed = 0.03!
        Me.LibelléRéférence.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRéférence.BorderColor = System.Drawing.Color.Black
        Me.LibelléRéférence.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléRéférence.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléRéférence.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléRéférence.ForeColor = System.Drawing.Color.White
        Me.LibelléRéférence.Image = Nothing
        Me.LibelléRéférence.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléRéférence.Location = New System.Drawing.Point(11, 37)
        Me.LibelléRéférence.Name = "LibelléRéférence"
        Me.LibelléRéférence.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRéférence.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléRéférence.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléRéférence.OnHoverImage = Nothing
        Me.LibelléRéférence.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléRéférence.Size = New System.Drawing.Size(162, 26)
        Me.LibelléRéférence.TabIndex = 777
        Me.LibelléRéférence.Text = "Référence"
        Me.LibelléRéférence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Machine
        '
        Me.Machine.BackColor = System.Drawing.Color.Transparent
        Me.Machine.BaseColor = System.Drawing.Color.White
        Me.Machine.BorderColor = System.Drawing.Color.Silver
        Me.Machine.DisplayMember = "Nom_Mag"
        Me.Machine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Machine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Machine.FocusedColor = System.Drawing.Color.Empty
        Me.Machine.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Machine.ForeColor = System.Drawing.Color.Black
        Me.Machine.FormattingEnabled = True
        Me.Machine.Location = New System.Drawing.Point(611, 70)
        Me.Machine.Name = "Machine"
        Me.Machine.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Machine.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Machine.Size = New System.Drawing.Size(222, 23)
        Me.Machine.TabIndex = 776
        Me.Machine.ValueMember = "Code_Mag"
        '
        'LibelléMachine
        '
        Me.LibelléMachine.AnimationHoverSpeed = 0.07!
        Me.LibelléMachine.AnimationSpeed = 0.03!
        Me.LibelléMachine.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMachine.BorderColor = System.Drawing.Color.Black
        Me.LibelléMachine.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléMachine.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléMachine.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléMachine.ForeColor = System.Drawing.Color.White
        Me.LibelléMachine.Image = Nothing
        Me.LibelléMachine.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléMachine.Location = New System.Drawing.Point(442, 70)
        Me.LibelléMachine.Name = "LibelléMachine"
        Me.LibelléMachine.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMachine.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléMachine.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléMachine.OnHoverImage = Nothing
        Me.LibelléMachine.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléMachine.Size = New System.Drawing.Size(162, 26)
        Me.LibelléMachine.TabIndex = 775
        Me.LibelléMachine.Text = "Machine"
        Me.LibelléMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LibelléDepartement.Location = New System.Drawing.Point(442, 37)
        Me.LibelléDepartement.Name = "LibelléDepartement"
        Me.LibelléDepartement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDepartement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDepartement.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDepartement.OnHoverImage = Nothing
        Me.LibelléDepartement.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDepartement.Size = New System.Drawing.Size(162, 26)
        Me.LibelléDepartement.TabIndex = 774
        Me.LibelléDepartement.Text = "Département"
        Me.LibelléDepartement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identification"
        '
        'Documents
        '
        Me.Documents.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Documents.Location = New System.Drawing.Point(4, 22)
        Me.Documents.Name = "Documents"
        Me.Documents.Padding = New System.Windows.Forms.Padding(3)
        Me.Documents.Size = New System.Drawing.Size(1024, 529)
        Me.Documents.TabIndex = 1
        Me.Documents.Text = "Documents Attachés"
        Me.Documents.UseVisualStyleBackColor = True
        '
        'Logistiques
        '
        Me.Logistiques.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logistiques.Location = New System.Drawing.Point(4, 22)
        Me.Logistiques.Name = "Logistiques"
        Me.Logistiques.Size = New System.Drawing.Size(1024, 529)
        Me.Logistiques.TabIndex = 2
        Me.Logistiques.Text = "Logistiques"
        Me.Logistiques.UseVisualStyleBackColor = True
        '
        'GMAOPIECEDERECHANGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 558)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "GMAOPIECEDERECHANGE"
        Me.Text = "Pièce de rechange"
        Me.TabControl1.ResumeLayout(False)
        Me.Général.ResumeLayout(False)
        Me.Général.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Général As TabPage
    Friend WithEvents Documents As TabPage
    Friend WithEvents Logistiques As TabPage
    Friend WithEvents PosteOpérateur As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Conditionnement As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LiblCond As Guna.UI.WinForms.GunaButton
    Friend WithEvents LiblPoste As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LiblRefFab As Guna.UI.WinForms.GunaButton
    Friend WithEvents Fabricant As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléFabricant As Guna.UI.WinForms.GunaButton
    Friend WithEvents Désignation As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléDésignation As Guna.UI.WinForms.GunaButton
    Friend WithEvents Département As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Référence As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléRéférence As Guna.UI.WinForms.GunaButton
    Friend WithEvents Machine As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LibelléMachine As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléDepartement As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Application As Label
    Friend WithEvents Fournisseur As Label
    Private WithEvents SauvegarderPièce As Button
    Private WithEvents ImprimerPièce As Button
    Private WithEvents AjouterFournisseur As Button
    Private WithEvents ImprimerFournisseur As Button
    Private WithEvents AjouterPièce As Button
    Private WithEvents AffecterApplication As Button
    Private WithEvents Button3 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
