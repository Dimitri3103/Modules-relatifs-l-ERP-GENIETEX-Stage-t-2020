<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMAORESPONSABLEMAINTENANCE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMAORESPONSABLEMAINTENANCE))
        Me.Machine = New Guna.UI.WinForms.GunaComboBox()
        Me.LibelléConducteur = New Guna.UI.WinForms.GunaButton()
        Me.Nom = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléDépartement = New Guna.UI.WinForms.GunaButton()
        Me.LibelléRéférence = New Guna.UI.WinForms.GunaButton()
        Me.LibelléMatricule = New Guna.UI.WinForms.GunaButton()
        Me.LiblNomResponsable = New Guna.UI.WinForms.GunaButton()
        Me.Département = New Guna.UI.WinForms.GunaComboBox()
        Me.Référence = New Guna.UI.WinForms.GunaTextBox()
        Me.Matricule = New Guna.UI.WinForms.GunaTextBox()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Sauvegarder = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Identification = New System.Windows.Forms.TabPage()
        Me.LieuNaissance = New Guna.UI.WinForms.GunaTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.IdResponsable = New Guna.UI.WinForms.GunaTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TelPerso = New Guna.UI.WinForms.GunaTextBox()
        Me.AdressePerso = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IdPoste = New Guna.UI.WinForms.GunaTextBox()
        Me.IdMachine = New Guna.UI.WinForms.GunaTextBox()
        Me.IdDépartement = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EtatCivil = New Guna.UI.WinForms.GunaComboBox()
        Me.Genre = New Guna.UI.WinForms.GunaComboBox()
        Me.Enfants = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CIN = New Guna.UI.WinForms.GunaTextBox()
        Me.Passeport = New Guna.UI.WinForms.GunaTextBox()
        Me.Nationalité = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TelPro = New Guna.UI.WinForms.GunaTextBox()
        Me.Mail = New Guna.UI.WinForms.GunaTextBox()
        Me.AdressePro = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.infos = New System.Windows.Forms.Label()
        Me.Naissance = New System.Windows.Forms.Label()
        Me.Etat = New System.Windows.Forms.Label()
        Me.Poste = New System.Windows.Forms.Label()
        Me.Contact = New System.Windows.Forms.Label()
        Me.DateValiditéPass = New System.Windows.Forms.DateTimePicker()
        Me.DateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.Identification.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Machine.Location = New System.Drawing.Point(7, 84)
        Me.Machine.Name = "Machine"
        Me.Machine.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Machine.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Machine.Size = New System.Drawing.Size(222, 23)
        Me.Machine.TabIndex = 785
        Me.Machine.ValueMember = "Code_Mag"
        '
        'LibelléConducteur
        '
        Me.LibelléConducteur.AnimationHoverSpeed = 0.07!
        Me.LibelléConducteur.AnimationSpeed = 0.03!
        Me.LibelléConducteur.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléConducteur.BorderColor = System.Drawing.Color.Black
        Me.LibelléConducteur.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléConducteur.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléConducteur.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléConducteur.ForeColor = System.Drawing.Color.White
        Me.LibelléConducteur.Image = Nothing
        Me.LibelléConducteur.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléConducteur.Location = New System.Drawing.Point(35, 52)
        Me.LibelléConducteur.Name = "LibelléConducteur"
        Me.LibelléConducteur.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléConducteur.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléConducteur.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléConducteur.OnHoverImage = Nothing
        Me.LibelléConducteur.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléConducteur.Size = New System.Drawing.Size(162, 26)
        Me.LibelléConducteur.TabIndex = 784
        Me.LibelléConducteur.Text = "Conducteur"
        Me.LibelléConducteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nom
        '
        Me.Nom.BaseColor = System.Drawing.Color.White
        Me.Nom.BorderColor = System.Drawing.Color.Silver
        Me.Nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nom.FocusedBaseColor = System.Drawing.Color.White
        Me.Nom.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nom.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Nom.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Nom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Nom.Location = New System.Drawing.Point(443, 12)
        Me.Nom.Name = "Nom"
        Me.Nom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nom.SelectedText = ""
        Me.Nom.Size = New System.Drawing.Size(222, 26)
        Me.Nom.TabIndex = 789
        '
        'LibelléDépartement
        '
        Me.LibelléDépartement.AnimationHoverSpeed = 0.07!
        Me.LibelléDépartement.AnimationSpeed = 0.03!
        Me.LibelléDépartement.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDépartement.BorderColor = System.Drawing.Color.Black
        Me.LibelléDépartement.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléDépartement.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléDépartement.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléDépartement.ForeColor = System.Drawing.Color.White
        Me.LibelléDépartement.Image = Nothing
        Me.LibelléDépartement.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléDépartement.Location = New System.Drawing.Point(275, 108)
        Me.LibelléDépartement.Name = "LibelléDépartement"
        Me.LibelléDépartement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDépartement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDépartement.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDépartement.OnHoverImage = Nothing
        Me.LibelléDépartement.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDépartement.Size = New System.Drawing.Size(162, 26)
        Me.LibelléDépartement.TabIndex = 791
        Me.LibelléDépartement.Text = "Département"
        Me.LibelléDépartement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LibelléRéférence.Location = New System.Drawing.Point(275, 76)
        Me.LibelléRéférence.Name = "LibelléRéférence"
        Me.LibelléRéférence.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRéférence.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléRéférence.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléRéférence.OnHoverImage = Nothing
        Me.LibelléRéférence.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléRéférence.Size = New System.Drawing.Size(162, 26)
        Me.LibelléRéférence.TabIndex = 792
        Me.LibelléRéférence.Text = "Référence"
        Me.LibelléRéférence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibelléMatricule
        '
        Me.LibelléMatricule.AnimationHoverSpeed = 0.07!
        Me.LibelléMatricule.AnimationSpeed = 0.03!
        Me.LibelléMatricule.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMatricule.BorderColor = System.Drawing.Color.Black
        Me.LibelléMatricule.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléMatricule.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléMatricule.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléMatricule.ForeColor = System.Drawing.Color.White
        Me.LibelléMatricule.Image = Nothing
        Me.LibelléMatricule.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléMatricule.Location = New System.Drawing.Point(275, 44)
        Me.LibelléMatricule.Name = "LibelléMatricule"
        Me.LibelléMatricule.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMatricule.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléMatricule.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléMatricule.OnHoverImage = Nothing
        Me.LibelléMatricule.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléMatricule.Size = New System.Drawing.Size(162, 26)
        Me.LibelléMatricule.TabIndex = 793
        Me.LibelléMatricule.Text = "Matricule"
        Me.LibelléMatricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LiblNomResponsable
        '
        Me.LiblNomResponsable.AnimationHoverSpeed = 0.07!
        Me.LiblNomResponsable.AnimationSpeed = 0.03!
        Me.LiblNomResponsable.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblNomResponsable.BorderColor = System.Drawing.Color.Black
        Me.LiblNomResponsable.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LiblNomResponsable.FocusedColor = System.Drawing.Color.Empty
        Me.LiblNomResponsable.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LiblNomResponsable.ForeColor = System.Drawing.Color.White
        Me.LiblNomResponsable.Image = Nothing
        Me.LiblNomResponsable.ImageSize = New System.Drawing.Size(20, 20)
        Me.LiblNomResponsable.Location = New System.Drawing.Point(275, 12)
        Me.LiblNomResponsable.Name = "LiblNomResponsable"
        Me.LiblNomResponsable.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LiblNomResponsable.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LiblNomResponsable.OnHoverForeColor = System.Drawing.Color.White
        Me.LiblNomResponsable.OnHoverImage = Nothing
        Me.LiblNomResponsable.OnPressedColor = System.Drawing.Color.Black
        Me.LiblNomResponsable.Size = New System.Drawing.Size(162, 26)
        Me.LiblNomResponsable.TabIndex = 794
        Me.LiblNomResponsable.Text = "Nom"
        Me.LiblNomResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Département.Location = New System.Drawing.Point(443, 108)
        Me.Département.Name = "Département"
        Me.Département.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Département.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Département.Size = New System.Drawing.Size(222, 23)
        Me.Département.TabIndex = 795
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
        Me.Référence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Référence.Location = New System.Drawing.Point(443, 76)
        Me.Référence.Name = "Référence"
        Me.Référence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Référence.SelectedText = ""
        Me.Référence.Size = New System.Drawing.Size(222, 26)
        Me.Référence.TabIndex = 796
        '
        'Matricule
        '
        Me.Matricule.BaseColor = System.Drawing.Color.White
        Me.Matricule.BorderColor = System.Drawing.Color.Silver
        Me.Matricule.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Matricule.FocusedBaseColor = System.Drawing.Color.White
        Me.Matricule.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Matricule.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Matricule.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Matricule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Matricule.Location = New System.Drawing.Point(443, 44)
        Me.Matricule.Name = "Matricule"
        Me.Matricule.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Matricule.SelectedText = ""
        Me.Matricule.Size = New System.Drawing.Size(222, 26)
        Me.Matricule.TabIndex = 797
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimer.Location = New System.Drawing.Point(924, 13)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 817
        Me.Imprimer.Text = "Imprimer"
        Me.Imprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imprimer.UseVisualStyleBackColor = False
        '
        'Sauvegarder
        '
        Me.Sauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sauvegarder.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Sauvegarder.ForeColor = System.Drawing.Color.White
        Me.Sauvegarder.Image = CType(resources.GetObject("Sauvegarder.Image"), System.Drawing.Image)
        Me.Sauvegarder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sauvegarder.Location = New System.Drawing.Point(814, 13)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(91, 68)
        Me.Sauvegarder.TabIndex = 816
        Me.Sauvegarder.Text = "Sauvegarder"
        Me.Sauvegarder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Sauvegarder.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ajouter.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Ajouter.ForeColor = System.Drawing.Color.White
        Me.Ajouter.Image = CType(resources.GetObject("Ajouter.Image"), System.Drawing.Image)
        Me.Ajouter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ajouter.Location = New System.Drawing.Point(704, 13)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(91, 68)
        Me.Ajouter.TabIndex = 815
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Identification)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(3, 151)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1025, 453)
        Me.TabControl1.TabIndex = 818
        '
        'Identification
        '
        Me.Identification.Controls.Add(Me.DateNaissance)
        Me.Identification.Controls.Add(Me.DateValiditéPass)
        Me.Identification.Controls.Add(Me.LieuNaissance)
        Me.Identification.Controls.Add(Me.Label17)
        Me.Identification.Controls.Add(Me.Label18)
        Me.Identification.Controls.Add(Me.CheckBox1)
        Me.Identification.Controls.Add(Me.IdResponsable)
        Me.Identification.Controls.Add(Me.Label16)
        Me.Identification.Controls.Add(Me.TelPerso)
        Me.Identification.Controls.Add(Me.AdressePerso)
        Me.Identification.Controls.Add(Me.Label13)
        Me.Identification.Controls.Add(Me.Label14)
        Me.Identification.Controls.Add(Me.Label15)
        Me.Identification.Controls.Add(Me.IdPoste)
        Me.Identification.Controls.Add(Me.IdMachine)
        Me.Identification.Controls.Add(Me.IdDépartement)
        Me.Identification.Controls.Add(Me.Label10)
        Me.Identification.Controls.Add(Me.Label11)
        Me.Identification.Controls.Add(Me.Label12)
        Me.Identification.Controls.Add(Me.EtatCivil)
        Me.Identification.Controls.Add(Me.Genre)
        Me.Identification.Controls.Add(Me.Enfants)
        Me.Identification.Controls.Add(Me.Label7)
        Me.Identification.Controls.Add(Me.Label8)
        Me.Identification.Controls.Add(Me.Label9)
        Me.Identification.Controls.Add(Me.CIN)
        Me.Identification.Controls.Add(Me.Passeport)
        Me.Identification.Controls.Add(Me.Nationalité)
        Me.Identification.Controls.Add(Me.Label4)
        Me.Identification.Controls.Add(Me.Label5)
        Me.Identification.Controls.Add(Me.Label6)
        Me.Identification.Controls.Add(Me.TelPro)
        Me.Identification.Controls.Add(Me.Mail)
        Me.Identification.Controls.Add(Me.AdressePro)
        Me.Identification.Controls.Add(Me.Label3)
        Me.Identification.Controls.Add(Me.Label2)
        Me.Identification.Controls.Add(Me.Label1)
        Me.Identification.Controls.Add(Me.infos)
        Me.Identification.Controls.Add(Me.Naissance)
        Me.Identification.Controls.Add(Me.Etat)
        Me.Identification.Controls.Add(Me.Poste)
        Me.Identification.Controls.Add(Me.Contact)
        Me.Identification.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Identification.Location = New System.Drawing.Point(4, 26)
        Me.Identification.Name = "Identification"
        Me.Identification.Padding = New System.Windows.Forms.Padding(3)
        Me.Identification.Size = New System.Drawing.Size(1017, 423)
        Me.Identification.TabIndex = 0
        Me.Identification.Text = "Identification"
        Me.Identification.UseVisualStyleBackColor = True
        '
        'LieuNaissance
        '
        Me.LieuNaissance.BaseColor = System.Drawing.Color.White
        Me.LieuNaissance.BorderColor = System.Drawing.Color.Silver
        Me.LieuNaissance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LieuNaissance.FocusedBaseColor = System.Drawing.Color.White
        Me.LieuNaissance.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LieuNaissance.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.LieuNaissance.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LieuNaissance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LieuNaissance.Location = New System.Drawing.Point(669, 354)
        Me.LieuNaissance.Name = "LieuNaissance"
        Me.LieuNaissance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LieuNaissance.SelectedText = ""
        Me.LieuNaissance.Size = New System.Drawing.Size(222, 26)
        Me.LieuNaissance.TabIndex = 824
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(506, 354)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 17)
        Me.Label17.TabIndex = 823
        Me.Label17.Text = "Lieu de Naissance"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(507, 322)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 17)
        Me.Label18.TabIndex = 822
        Me.Label18.Text = "Date de Naissance"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(511, 161)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 21)
        Me.CheckBox1.TabIndex = 820
        Me.CheckBox1.Text = "Est un responsable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'IdResponsable
        '
        Me.IdResponsable.BaseColor = System.Drawing.Color.White
        Me.IdResponsable.BorderColor = System.Drawing.Color.Silver
        Me.IdResponsable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdResponsable.FocusedBaseColor = System.Drawing.Color.White
        Me.IdResponsable.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdResponsable.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.IdResponsable.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.IdResponsable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IdResponsable.Location = New System.Drawing.Point(669, 133)
        Me.IdResponsable.Name = "IdResponsable"
        Me.IdResponsable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdResponsable.SelectedText = ""
        Me.IdResponsable.Size = New System.Drawing.Size(222, 26)
        Me.IdResponsable.TabIndex = 819
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(507, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 17)
        Me.Label16.TabIndex = 818
        Me.Label16.Text = "Responsable"
        '
        'TelPerso
        '
        Me.TelPerso.BaseColor = System.Drawing.Color.White
        Me.TelPerso.BorderColor = System.Drawing.Color.Silver
        Me.TelPerso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TelPerso.FocusedBaseColor = System.Drawing.Color.White
        Me.TelPerso.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TelPerso.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TelPerso.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TelPerso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TelPerso.Location = New System.Drawing.Point(669, 228)
        Me.TelPerso.Name = "TelPerso"
        Me.TelPerso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TelPerso.SelectedText = ""
        Me.TelPerso.Size = New System.Drawing.Size(222, 26)
        Me.TelPerso.TabIndex = 817
        '
        'AdressePerso
        '
        Me.AdressePerso.BaseColor = System.Drawing.Color.White
        Me.AdressePerso.BorderColor = System.Drawing.Color.Silver
        Me.AdressePerso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdressePerso.FocusedBaseColor = System.Drawing.Color.White
        Me.AdressePerso.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdressePerso.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.AdressePerso.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.AdressePerso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AdressePerso.Location = New System.Drawing.Point(669, 196)
        Me.AdressePerso.Name = "AdressePerso"
        Me.AdressePerso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdressePerso.SelectedText = ""
        Me.AdressePerso.Size = New System.Drawing.Size(222, 26)
        Me.AdressePerso.TabIndex = 815
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(506, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 17)
        Me.Label13.TabIndex = 814
        Me.Label13.Text = "Tél Portable Personnelle"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(507, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 17)
        Me.Label14.TabIndex = 813
        Me.Label14.Text = "Validité Passeport"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(506, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 17)
        Me.Label15.TabIndex = 812
        Me.Label15.Text = "Adresse Personnelle"
        '
        'IdPoste
        '
        Me.IdPoste.BaseColor = System.Drawing.Color.White
        Me.IdPoste.BorderColor = System.Drawing.Color.Silver
        Me.IdPoste.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdPoste.FocusedBaseColor = System.Drawing.Color.White
        Me.IdPoste.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdPoste.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.IdPoste.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.IdPoste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IdPoste.Location = New System.Drawing.Point(669, 69)
        Me.IdPoste.Name = "IdPoste"
        Me.IdPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdPoste.SelectedText = ""
        Me.IdPoste.Size = New System.Drawing.Size(222, 26)
        Me.IdPoste.TabIndex = 811
        '
        'IdMachine
        '
        Me.IdMachine.BaseColor = System.Drawing.Color.White
        Me.IdMachine.BorderColor = System.Drawing.Color.Silver
        Me.IdMachine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdMachine.FocusedBaseColor = System.Drawing.Color.White
        Me.IdMachine.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdMachine.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.IdMachine.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.IdMachine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IdMachine.Location = New System.Drawing.Point(669, 101)
        Me.IdMachine.Name = "IdMachine"
        Me.IdMachine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdMachine.SelectedText = ""
        Me.IdMachine.Size = New System.Drawing.Size(222, 26)
        Me.IdMachine.TabIndex = 810
        '
        'IdDépartement
        '
        Me.IdDépartement.BaseColor = System.Drawing.Color.White
        Me.IdDépartement.BorderColor = System.Drawing.Color.Silver
        Me.IdDépartement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdDépartement.FocusedBaseColor = System.Drawing.Color.White
        Me.IdDépartement.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdDépartement.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.IdDépartement.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.IdDépartement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IdDépartement.Location = New System.Drawing.Point(669, 37)
        Me.IdDépartement.Name = "IdDépartement"
        Me.IdDépartement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdDépartement.SelectedText = ""
        Me.IdDépartement.Size = New System.Drawing.Size(222, 26)
        Me.IdDépartement.TabIndex = 809
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(507, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 808
        Me.Label10.Text = "Poste"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(508, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 807
        Me.Label11.Text = "Machine"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(507, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 806
        Me.Label12.Text = "Département"
        '
        'EtatCivil
        '
        Me.EtatCivil.BackColor = System.Drawing.Color.Transparent
        Me.EtatCivil.BaseColor = System.Drawing.Color.White
        Me.EtatCivil.BorderColor = System.Drawing.Color.Silver
        Me.EtatCivil.DisplayMember = "Nom_Mag"
        Me.EtatCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EtatCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EtatCivil.FocusedColor = System.Drawing.Color.Empty
        Me.EtatCivil.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.EtatCivil.ForeColor = System.Drawing.Color.Black
        Me.EtatCivil.FormattingEnabled = True
        Me.EtatCivil.Location = New System.Drawing.Point(191, 351)
        Me.EtatCivil.Name = "EtatCivil"
        Me.EtatCivil.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EtatCivil.OnHoverItemForeColor = System.Drawing.Color.White
        Me.EtatCivil.Size = New System.Drawing.Size(222, 23)
        Me.EtatCivil.TabIndex = 805
        Me.EtatCivil.ValueMember = "Code_Mag"
        '
        'Genre
        '
        Me.Genre.BackColor = System.Drawing.Color.Transparent
        Me.Genre.BaseColor = System.Drawing.Color.White
        Me.Genre.BorderColor = System.Drawing.Color.Silver
        Me.Genre.DisplayMember = "Nom_Mag"
        Me.Genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Genre.FocusedColor = System.Drawing.Color.Empty
        Me.Genre.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Genre.ForeColor = System.Drawing.Color.Black
        Me.Genre.FormattingEnabled = True
        Me.Genre.Location = New System.Drawing.Point(191, 322)
        Me.Genre.Name = "Genre"
        Me.Genre.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Genre.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Genre.Size = New System.Drawing.Size(222, 23)
        Me.Genre.TabIndex = 804
        Me.Genre.ValueMember = "Code_Mag"
        '
        'Enfants
        '
        Me.Enfants.BaseColor = System.Drawing.Color.White
        Me.Enfants.BorderColor = System.Drawing.Color.Silver
        Me.Enfants.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Enfants.FocusedBaseColor = System.Drawing.Color.White
        Me.Enfants.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Enfants.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Enfants.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Enfants.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Enfants.Location = New System.Drawing.Point(191, 386)
        Me.Enfants.Name = "Enfants"
        Me.Enfants.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Enfants.SelectedText = ""
        Me.Enfants.Size = New System.Drawing.Size(222, 26)
        Me.Enfants.TabIndex = 803
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(28, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 801
        Me.Label7.Text = "Etat Civil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(29, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 800
        Me.Label8.Text = "Nombre d'enfants"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(28, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 799
        Me.Label9.Text = "Genre"
        '
        'CIN
        '
        Me.CIN.BaseColor = System.Drawing.Color.White
        Me.CIN.BorderColor = System.Drawing.Color.Silver
        Me.CIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CIN.FocusedBaseColor = System.Drawing.Color.White
        Me.CIN.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CIN.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.CIN.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CIN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CIN.Location = New System.Drawing.Point(191, 228)
        Me.CIN.Name = "CIN"
        Me.CIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CIN.SelectedText = ""
        Me.CIN.Size = New System.Drawing.Size(222, 26)
        Me.CIN.TabIndex = 798
        '
        'Passeport
        '
        Me.Passeport.BaseColor = System.Drawing.Color.White
        Me.Passeport.BorderColor = System.Drawing.Color.Silver
        Me.Passeport.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Passeport.FocusedBaseColor = System.Drawing.Color.White
        Me.Passeport.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passeport.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Passeport.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Passeport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Passeport.Location = New System.Drawing.Point(191, 260)
        Me.Passeport.Name = "Passeport"
        Me.Passeport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Passeport.SelectedText = ""
        Me.Passeport.Size = New System.Drawing.Size(222, 26)
        Me.Passeport.TabIndex = 797
        '
        'Nationalité
        '
        Me.Nationalité.BaseColor = System.Drawing.Color.White
        Me.Nationalité.BorderColor = System.Drawing.Color.Silver
        Me.Nationalité.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nationalité.FocusedBaseColor = System.Drawing.Color.White
        Me.Nationalité.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nationalité.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Nationalité.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Nationalité.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Nationalité.Location = New System.Drawing.Point(191, 196)
        Me.Nationalité.Name = "Nationalité"
        Me.Nationalité.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nationalité.SelectedText = ""
        Me.Nationalité.Size = New System.Drawing.Size(222, 26)
        Me.Nationalité.TabIndex = 796
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 795
        Me.Label4.Text = "N° CIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(29, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 794
        Me.Label5.Text = "N° de Passeport"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(28, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 793
        Me.Label6.Text = "Nationalité"
        '
        'TelPro
        '
        Me.TelPro.BaseColor = System.Drawing.Color.White
        Me.TelPro.BorderColor = System.Drawing.Color.Silver
        Me.TelPro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TelPro.FocusedBaseColor = System.Drawing.Color.White
        Me.TelPro.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TelPro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TelPro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TelPro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TelPro.Location = New System.Drawing.Point(191, 69)
        Me.TelPro.Name = "TelPro"
        Me.TelPro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TelPro.SelectedText = ""
        Me.TelPro.Size = New System.Drawing.Size(222, 26)
        Me.TelPro.TabIndex = 792
        '
        'Mail
        '
        Me.Mail.BaseColor = System.Drawing.Color.White
        Me.Mail.BorderColor = System.Drawing.Color.Silver
        Me.Mail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Mail.FocusedBaseColor = System.Drawing.Color.White
        Me.Mail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Mail.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Mail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mail.Location = New System.Drawing.Point(191, 101)
        Me.Mail.Name = "Mail"
        Me.Mail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Mail.SelectedText = ""
        Me.Mail.Size = New System.Drawing.Size(222, 26)
        Me.Mail.TabIndex = 791
        '
        'AdressePro
        '
        Me.AdressePro.BaseColor = System.Drawing.Color.White
        Me.AdressePro.BorderColor = System.Drawing.Color.Silver
        Me.AdressePro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdressePro.FocusedBaseColor = System.Drawing.Color.White
        Me.AdressePro.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdressePro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.AdressePro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.AdressePro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AdressePro.Location = New System.Drawing.Point(191, 37)
        Me.AdressePro.Name = "AdressePro"
        Me.AdressePro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdressePro.SelectedText = ""
        Me.AdressePro.Size = New System.Drawing.Size(222, 26)
        Me.AdressePro.TabIndex = 790
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(28, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tél Portable Professionnel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(29, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Adresse Professionnelle"
        '
        'infos
        '
        Me.infos.AutoSize = True
        Me.infos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.infos.Location = New System.Drawing.Point(18, 161)
        Me.infos.Name = "infos"
        Me.infos.Size = New System.Drawing.Size(156, 16)
        Me.infos.TabIndex = 4
        Me.infos.Text = "Informations personnelles"
        '
        'Naissance
        '
        Me.Naissance.AutoSize = True
        Me.Naissance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Naissance.Location = New System.Drawing.Point(496, 296)
        Me.Naissance.Name = "Naissance"
        Me.Naissance.Size = New System.Drawing.Size(69, 16)
        Me.Naissance.TabIndex = 3
        Me.Naissance.Text = "Naissance"
        '
        'Etat
        '
        Me.Etat.AutoSize = True
        Me.Etat.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Etat.Location = New System.Drawing.Point(18, 296)
        Me.Etat.Name = "Etat"
        Me.Etat.Size = New System.Drawing.Size(28, 16)
        Me.Etat.TabIndex = 2
        Me.Etat.Text = "Etat"
        '
        'Poste
        '
        Me.Poste.AutoSize = True
        Me.Poste.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Poste.Location = New System.Drawing.Point(496, 17)
        Me.Poste.Name = "Poste"
        Me.Poste.Size = New System.Drawing.Size(39, 16)
        Me.Poste.TabIndex = 1
        Me.Poste.Text = "Poste"
        '
        'Contact
        '
        Me.Contact.AutoSize = True
        Me.Contact.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Contact.Location = New System.Drawing.Point(18, 17)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(54, 16)
        Me.Contact.TabIndex = 0
        Me.Contact.Text = "Contact"
        '
        'DateValiditéPass
        '
        Me.DateValiditéPass.CalendarFont = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.DateValiditéPass.Location = New System.Drawing.Point(669, 260)
        Me.DateValiditéPass.Name = "DateValiditéPass"
        Me.DateValiditéPass.Size = New System.Drawing.Size(222, 22)
        Me.DateValiditéPass.TabIndex = 826
        '
        'DateNaissance
        '
        Me.DateNaissance.CalendarFont = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.DateNaissance.Location = New System.Drawing.Point(669, 323)
        Me.DateNaissance.Name = "DateNaissance"
        Me.DateNaissance.Size = New System.Drawing.Size(222, 22)
        Me.DateNaissance.TabIndex = 827
        '
        'GMAORESPONSABLEMAINTENANCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1032, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.Matricule)
        Me.Controls.Add(Me.Référence)
        Me.Controls.Add(Me.Département)
        Me.Controls.Add(Me.LiblNomResponsable)
        Me.Controls.Add(Me.LibelléMatricule)
        Me.Controls.Add(Me.LibelléRéférence)
        Me.Controls.Add(Me.LibelléDépartement)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Machine)
        Me.Controls.Add(Me.LibelléConducteur)
        Me.Name = "GMAORESPONSABLEMAINTENANCE"
        Me.Text = "Responsable maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.Identification.ResumeLayout(False)
        Me.Identification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Machine As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LibelléConducteur As Guna.UI.WinForms.GunaButton
    Friend WithEvents Nom As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléDépartement As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléRéférence As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléMatricule As Guna.UI.WinForms.GunaButton
    Friend WithEvents LiblNomResponsable As Guna.UI.WinForms.GunaButton
    Friend WithEvents Département As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Référence As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Matricule As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Imprimer As Button
    Friend WithEvents Sauvegarder As Button
    Friend WithEvents Ajouter As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Identification As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents IdResponsable As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TelPerso As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents AdressePerso As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents IdPoste As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents IdMachine As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents IdDépartement As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EtatCivil As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Genre As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Enfants As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CIN As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Passeport As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Nationalité As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TelPro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Mail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents AdressePro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents infos As Label
    Friend WithEvents Naissance As Label
    Friend WithEvents Etat As Label
    Friend WithEvents Poste As Label
    Friend WithEvents Contact As Label
    Friend WithEvents LieuNaissance As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DateNaissance As DateTimePicker
    Friend WithEvents DateValiditéPass As DateTimePicker
End Class
