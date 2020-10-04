<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MVTSORTIE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVTSORTIE))
        Me.DateMvt = New System.Windows.Forms.DateTimePicker()
        Me.RefMvt = New Guna.UI.WinForms.GunaTextBox()
        Me.PAMP = New Guna.UI.WinForms.GunaButton()
        Me.QteAprès = New Guna.UI.WinForms.GunaButton()
        Me.PHT = New Guna.UI.WinForms.GunaButton()
        Me.QteAvant = New Guna.UI.WinForms.GunaButton()
        Me.PMP = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.Magasin = New Guna.UI.WinForms.GunaComboBox()
        Me.TMagasinGMAOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyimportDataSet = New WindowsApp1.myimportDataSet()
        Me.MagasinDestination = New Guna.UI.WinForms.GunaButton()
        Me.LibelléMvt = New Guna.UI.WinForms.GunaTextBox()
        Me.Libellé = New Guna.UI.WinForms.GunaButton()
        Me.Quantité = New Guna.UI.WinForms.GunaTextBox()
        Me.QuantitéArticles = New Guna.UI.WinForms.GunaButton()
        Me.Pièce = New Guna.UI.WinForms.GunaComboBox()
        Me.PIECERECHANGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelPièce = New Guna.UI.WinForms.GunaButton()
        Me.RéférenceBon = New Guna.UI.WinForms.GunaButton()
        Me.DateSortie = New Guna.UI.WinForms.GunaButton()
        Me.Sauvegarder = New System.Windows.Forms.Button()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.PIECERECHANGETableAdapter = New WindowsApp1.myimportDataSetTableAdapters.PIECERECHANGETableAdapter()
        Me.TMagasinGMAOTableAdapter = New WindowsApp1.myimportDataSetTableAdapters.tMagasinGMAOTableAdapter()
        CType(Me.TMagasinGMAOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateMvt
        '
        Me.DateMvt.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.DateMvt.Location = New System.Drawing.Point(157, 11)
        Me.DateMvt.Name = "DateMvt"
        Me.DateMvt.Size = New System.Drawing.Size(250, 22)
        Me.DateMvt.TabIndex = 803
        '
        'RefMvt
        '
        Me.RefMvt.BaseColor = System.Drawing.Color.White
        Me.RefMvt.BorderColor = System.Drawing.Color.Silver
        Me.RefMvt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RefMvt.FocusedBaseColor = System.Drawing.Color.White
        Me.RefMvt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefMvt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.RefMvt.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.RefMvt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefMvt.Location = New System.Drawing.Point(250, 42)
        Me.RefMvt.Name = "RefMvt"
        Me.RefMvt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RefMvt.SelectedText = ""
        Me.RefMvt.Size = New System.Drawing.Size(157, 26)
        Me.RefMvt.TabIndex = 802
        '
        'PAMP
        '
        Me.PAMP.AnimationHoverSpeed = 0.07!
        Me.PAMP.AnimationSpeed = 0.03!
        Me.PAMP.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMP.BorderColor = System.Drawing.Color.Black
        Me.PAMP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PAMP.FocusedColor = System.Drawing.Color.Empty
        Me.PAMP.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PAMP.ForeColor = System.Drawing.Color.White
        Me.PAMP.Image = Nothing
        Me.PAMP.ImageSize = New System.Drawing.Size(20, 20)
        Me.PAMP.Location = New System.Drawing.Point(654, 184)
        Me.PAMP.Name = "PAMP"
        Me.PAMP.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PAMP.OnHoverForeColor = System.Drawing.Color.White
        Me.PAMP.OnHoverImage = Nothing
        Me.PAMP.OnPressedColor = System.Drawing.Color.Black
        Me.PAMP.Size = New System.Drawing.Size(162, 26)
        Me.PAMP.TabIndex = 801
        Me.PAMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QteAprès
        '
        Me.QteAprès.AnimationHoverSpeed = 0.07!
        Me.QteAprès.AnimationSpeed = 0.03!
        Me.QteAprès.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAprès.BorderColor = System.Drawing.Color.Black
        Me.QteAprès.DialogResult = System.Windows.Forms.DialogResult.None
        Me.QteAprès.FocusedColor = System.Drawing.Color.Empty
        Me.QteAprès.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.QteAprès.ForeColor = System.Drawing.Color.White
        Me.QteAprès.Image = Nothing
        Me.QteAprès.ImageSize = New System.Drawing.Size(20, 20)
        Me.QteAprès.Location = New System.Drawing.Point(654, 152)
        Me.QteAprès.Name = "QteAprès"
        Me.QteAprès.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAprès.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QteAprès.OnHoverForeColor = System.Drawing.Color.White
        Me.QteAprès.OnHoverImage = Nothing
        Me.QteAprès.OnPressedColor = System.Drawing.Color.Black
        Me.QteAprès.Size = New System.Drawing.Size(162, 26)
        Me.QteAprès.TabIndex = 800
        Me.QteAprès.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PHT
        '
        Me.PHT.AnimationHoverSpeed = 0.07!
        Me.PHT.AnimationSpeed = 0.03!
        Me.PHT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHT.BorderColor = System.Drawing.Color.Black
        Me.PHT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PHT.FocusedColor = System.Drawing.Color.Empty
        Me.PHT.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PHT.ForeColor = System.Drawing.Color.White
        Me.PHT.Image = Nothing
        Me.PHT.ImageSize = New System.Drawing.Size(20, 20)
        Me.PHT.Location = New System.Drawing.Point(245, 184)
        Me.PHT.Name = "PHT"
        Me.PHT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHT.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PHT.OnHoverForeColor = System.Drawing.Color.White
        Me.PHT.OnHoverImage = Nothing
        Me.PHT.OnPressedColor = System.Drawing.Color.Black
        Me.PHT.Size = New System.Drawing.Size(162, 26)
        Me.PHT.TabIndex = 799
        Me.PHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QteAvant
        '
        Me.QteAvant.AnimationHoverSpeed = 0.07!
        Me.QteAvant.AnimationSpeed = 0.03!
        Me.QteAvant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAvant.BorderColor = System.Drawing.Color.Black
        Me.QteAvant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.QteAvant.FocusedColor = System.Drawing.Color.Empty
        Me.QteAvant.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.QteAvant.ForeColor = System.Drawing.Color.White
        Me.QteAvant.Image = Nothing
        Me.QteAvant.ImageSize = New System.Drawing.Size(20, 20)
        Me.QteAvant.Location = New System.Drawing.Point(245, 152)
        Me.QteAvant.Name = "QteAvant"
        Me.QteAvant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAvant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QteAvant.OnHoverForeColor = System.Drawing.Color.White
        Me.QteAvant.OnHoverImage = Nothing
        Me.QteAvant.OnPressedColor = System.Drawing.Color.Black
        Me.QteAvant.Size = New System.Drawing.Size(162, 26)
        Me.QteAvant.TabIndex = 798
        Me.QteAvant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PMP
        '
        Me.PMP.AnimationHoverSpeed = 0.07!
        Me.PMP.AnimationSpeed = 0.03!
        Me.PMP.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMP.BorderColor = System.Drawing.Color.Black
        Me.PMP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMP.FocusedColor = System.Drawing.Color.Empty
        Me.PMP.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMP.ForeColor = System.Drawing.Color.White
        Me.PMP.Image = Nothing
        Me.PMP.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMP.Location = New System.Drawing.Point(16, 251)
        Me.PMP.Name = "PMP"
        Me.PMP.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMP.OnHoverForeColor = System.Drawing.Color.White
        Me.PMP.OnHoverImage = Nothing
        Me.PMP.OnPressedColor = System.Drawing.Color.Black
        Me.PMP.Size = New System.Drawing.Size(228, 26)
        Me.PMP.TabIndex = 797
        Me.PMP.Text = "PAMP : Prix d'Achat Moyen Pondéré"
        Me.PMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(59, 184)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton5.TabIndex = 796
        Me.GunaButton5.Text = "PHT"
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = Nothing
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(59, 152)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton6.TabIndex = 795
        Me.GunaButton6.Text = "Quantité avant Mvt"
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(466, 184)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton2.TabIndex = 794
        Me.GunaButton2.Text = "PAMP"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(466, 152)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton3.TabIndex = 793
        Me.GunaButton3.Text = "Quantité après Mvt"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Magasin
        '
        Me.Magasin.BackColor = System.Drawing.Color.Transparent
        Me.Magasin.BaseColor = System.Drawing.Color.White
        Me.Magasin.BorderColor = System.Drawing.Color.Silver
        Me.Magasin.DataSource = Me.TMagasinGMAOBindingSource
        Me.Magasin.DisplayMember = "Nom_Mag"
        Me.Magasin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Magasin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Magasin.FocusedColor = System.Drawing.Color.Empty
        Me.Magasin.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Magasin.ForeColor = System.Drawing.Color.Black
        Me.Magasin.FormattingEnabled = True
        Me.Magasin.Location = New System.Drawing.Point(594, 75)
        Me.Magasin.Name = "Magasin"
        Me.Magasin.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Magasin.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Magasin.Size = New System.Drawing.Size(222, 23)
        Me.Magasin.TabIndex = 792
        Me.Magasin.ValueMember = "Code_Mag"
        '
        'TMagasinGMAOBindingSource
        '
        Me.TMagasinGMAOBindingSource.DataMember = "tMagasinGMAO"
        Me.TMagasinGMAOBindingSource.DataSource = Me.MyimportDataSet
        '
        'MyimportDataSet
        '
        Me.MyimportDataSet.DataSetName = "myimportDataSet"
        Me.MyimportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MagasinDestination
        '
        Me.MagasinDestination.AnimationHoverSpeed = 0.07!
        Me.MagasinDestination.AnimationSpeed = 0.03!
        Me.MagasinDestination.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MagasinDestination.BorderColor = System.Drawing.Color.Black
        Me.MagasinDestination.DialogResult = System.Windows.Forms.DialogResult.None
        Me.MagasinDestination.FocusedColor = System.Drawing.Color.Empty
        Me.MagasinDestination.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MagasinDestination.ForeColor = System.Drawing.Color.White
        Me.MagasinDestination.Image = Nothing
        Me.MagasinDestination.ImageSize = New System.Drawing.Size(20, 20)
        Me.MagasinDestination.Location = New System.Drawing.Point(425, 76)
        Me.MagasinDestination.Name = "MagasinDestination"
        Me.MagasinDestination.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MagasinDestination.OnHoverBorderColor = System.Drawing.Color.Black
        Me.MagasinDestination.OnHoverForeColor = System.Drawing.Color.White
        Me.MagasinDestination.OnHoverImage = Nothing
        Me.MagasinDestination.OnPressedColor = System.Drawing.Color.Black
        Me.MagasinDestination.Size = New System.Drawing.Size(162, 26)
        Me.MagasinDestination.TabIndex = 791
        Me.MagasinDestination.Text = "Magasin :"
        Me.MagasinDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibelléMvt
        '
        Me.LibelléMvt.BaseColor = System.Drawing.Color.White
        Me.LibelléMvt.BorderColor = System.Drawing.Color.Silver
        Me.LibelléMvt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LibelléMvt.FocusedBaseColor = System.Drawing.Color.White
        Me.LibelléMvt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMvt.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.LibelléMvt.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléMvt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LibelléMvt.Location = New System.Drawing.Point(593, 43)
        Me.LibelléMvt.Name = "LibelléMvt"
        Me.LibelléMvt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LibelléMvt.SelectedText = ""
        Me.LibelléMvt.Size = New System.Drawing.Size(223, 26)
        Me.LibelléMvt.TabIndex = 790
        '
        'Libellé
        '
        Me.Libellé.AnimationHoverSpeed = 0.07!
        Me.Libellé.AnimationSpeed = 0.03!
        Me.Libellé.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Libellé.BorderColor = System.Drawing.Color.Black
        Me.Libellé.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Libellé.FocusedColor = System.Drawing.Color.Empty
        Me.Libellé.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Libellé.ForeColor = System.Drawing.Color.White
        Me.Libellé.Image = Nothing
        Me.Libellé.ImageSize = New System.Drawing.Size(20, 20)
        Me.Libellé.Location = New System.Drawing.Point(425, 43)
        Me.Libellé.Name = "Libellé"
        Me.Libellé.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Libellé.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Libellé.OnHoverForeColor = System.Drawing.Color.White
        Me.Libellé.OnHoverImage = Nothing
        Me.Libellé.OnPressedColor = System.Drawing.Color.Black
        Me.Libellé.Size = New System.Drawing.Size(162, 26)
        Me.Libellé.TabIndex = 789
        Me.Libellé.Text = "Libellé / Motif :"
        Me.Libellé.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quantité
        '
        Me.Quantité.BaseColor = System.Drawing.Color.White
        Me.Quantité.BorderColor = System.Drawing.Color.Silver
        Me.Quantité.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Quantité.FocusedBaseColor = System.Drawing.Color.White
        Me.Quantité.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Quantité.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Quantité.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Quantité.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Quantité.Location = New System.Drawing.Point(157, 106)
        Me.Quantité.Name = "Quantité"
        Me.Quantité.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Quantité.SelectedText = ""
        Me.Quantité.Size = New System.Drawing.Size(250, 26)
        Me.Quantité.TabIndex = 788
        '
        'QuantitéArticles
        '
        Me.QuantitéArticles.AnimationHoverSpeed = 0.07!
        Me.QuantitéArticles.AnimationSpeed = 0.03!
        Me.QuantitéArticles.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantitéArticles.BorderColor = System.Drawing.Color.Black
        Me.QuantitéArticles.DialogResult = System.Windows.Forms.DialogResult.None
        Me.QuantitéArticles.FocusedColor = System.Drawing.Color.Empty
        Me.QuantitéArticles.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.QuantitéArticles.ForeColor = System.Drawing.Color.White
        Me.QuantitéArticles.Image = Nothing
        Me.QuantitéArticles.ImageSize = New System.Drawing.Size(20, 20)
        Me.QuantitéArticles.Location = New System.Drawing.Point(16, 106)
        Me.QuantitéArticles.Name = "QuantitéArticles"
        Me.QuantitéArticles.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantitéArticles.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QuantitéArticles.OnHoverForeColor = System.Drawing.Color.White
        Me.QuantitéArticles.OnHoverImage = Nothing
        Me.QuantitéArticles.OnPressedColor = System.Drawing.Color.Black
        Me.QuantitéArticles.Size = New System.Drawing.Size(135, 26)
        Me.QuantitéArticles.TabIndex = 787
        Me.QuantitéArticles.Text = "Quantité :"
        Me.QuantitéArticles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pièce
        '
        Me.Pièce.BackColor = System.Drawing.Color.Transparent
        Me.Pièce.BaseColor = System.Drawing.Color.White
        Me.Pièce.BorderColor = System.Drawing.Color.Silver
        Me.Pièce.DataSource = Me.PIECERECHANGEBindingSource
        Me.Pièce.DisplayMember = "Designation"
        Me.Pièce.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Pièce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pièce.FocusedColor = System.Drawing.Color.Empty
        Me.Pièce.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Pièce.ForeColor = System.Drawing.Color.Black
        Me.Pièce.FormattingEnabled = True
        Me.Pièce.Location = New System.Drawing.Point(157, 74)
        Me.Pièce.Name = "Pièce"
        Me.Pièce.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pièce.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Pièce.Size = New System.Drawing.Size(250, 23)
        Me.Pièce.TabIndex = 786
        Me.Pièce.ValueMember = "CodePiece"
        '
        'PIECERECHANGEBindingSource
        '
        Me.PIECERECHANGEBindingSource.DataMember = "PIECERECHANGE"
        Me.PIECERECHANGEBindingSource.DataSource = Me.MyimportDataSet
        '
        'LabelPièce
        '
        Me.LabelPièce.AnimationHoverSpeed = 0.07!
        Me.LabelPièce.AnimationSpeed = 0.03!
        Me.LabelPièce.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelPièce.BorderColor = System.Drawing.Color.Black
        Me.LabelPièce.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LabelPièce.FocusedColor = System.Drawing.Color.Empty
        Me.LabelPièce.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LabelPièce.ForeColor = System.Drawing.Color.White
        Me.LabelPièce.Image = Nothing
        Me.LabelPièce.ImageSize = New System.Drawing.Size(20, 20)
        Me.LabelPièce.Location = New System.Drawing.Point(16, 74)
        Me.LabelPièce.Name = "LabelPièce"
        Me.LabelPièce.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelPièce.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LabelPièce.OnHoverForeColor = System.Drawing.Color.White
        Me.LabelPièce.OnHoverImage = Nothing
        Me.LabelPièce.OnPressedColor = System.Drawing.Color.Black
        Me.LabelPièce.Size = New System.Drawing.Size(135, 26)
        Me.LabelPièce.TabIndex = 785
        Me.LabelPièce.Text = "Pièce :"
        Me.LabelPièce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RéférenceBon
        '
        Me.RéférenceBon.AnimationHoverSpeed = 0.07!
        Me.RéférenceBon.AnimationSpeed = 0.03!
        Me.RéférenceBon.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RéférenceBon.BorderColor = System.Drawing.Color.Black
        Me.RéférenceBon.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RéférenceBon.FocusedColor = System.Drawing.Color.Empty
        Me.RéférenceBon.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.RéférenceBon.ForeColor = System.Drawing.Color.White
        Me.RéférenceBon.Image = Nothing
        Me.RéférenceBon.ImageSize = New System.Drawing.Size(20, 20)
        Me.RéférenceBon.Location = New System.Drawing.Point(16, 43)
        Me.RéférenceBon.Name = "RéférenceBon"
        Me.RéférenceBon.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RéférenceBon.OnHoverBorderColor = System.Drawing.Color.Black
        Me.RéférenceBon.OnHoverForeColor = System.Drawing.Color.White
        Me.RéférenceBon.OnHoverImage = Nothing
        Me.RéférenceBon.OnPressedColor = System.Drawing.Color.Black
        Me.RéférenceBon.Size = New System.Drawing.Size(228, 26)
        Me.RéférenceBon.TabIndex = 784
        Me.RéférenceBon.Text = "Bon Sortie Numéro :"
        Me.RéférenceBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateSortie
        '
        Me.DateSortie.AnimationHoverSpeed = 0.07!
        Me.DateSortie.AnimationSpeed = 0.03!
        Me.DateSortie.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateSortie.BorderColor = System.Drawing.Color.Black
        Me.DateSortie.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DateSortie.FocusedColor = System.Drawing.Color.Empty
        Me.DateSortie.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.DateSortie.ForeColor = System.Drawing.Color.White
        Me.DateSortie.Image = Nothing
        Me.DateSortie.ImageSize = New System.Drawing.Size(20, 20)
        Me.DateSortie.Location = New System.Drawing.Point(16, 11)
        Me.DateSortie.Name = "DateSortie"
        Me.DateSortie.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateSortie.OnHoverBorderColor = System.Drawing.Color.Black
        Me.DateSortie.OnHoverForeColor = System.Drawing.Color.White
        Me.DateSortie.OnHoverImage = Nothing
        Me.DateSortie.OnPressedColor = System.Drawing.Color.Black
        Me.DateSortie.Size = New System.Drawing.Size(135, 26)
        Me.DateSortie.TabIndex = 783
        Me.DateSortie.Text = "Date Sortie :"
        Me.DateSortie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sauvegarder
        '
        Me.Sauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sauvegarder.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sauvegarder.ForeColor = System.Drawing.Color.White
        Me.Sauvegarder.Image = CType(resources.GetObject("Sauvegarder.Image"), System.Drawing.Image)
        Me.Sauvegarder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sauvegarder.Location = New System.Drawing.Point(868, 85)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(91, 68)
        Me.Sauvegarder.TabIndex = 782
        Me.Sauvegarder.Text = "Sauvegarder"
        Me.Sauvegarder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Sauvegarder.UseVisualStyleBackColor = False
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimer.Location = New System.Drawing.Point(868, 159)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 781
        Me.Imprimer.Text = "Imprimer"
        Me.Imprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imprimer.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ajouter.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ajouter.ForeColor = System.Drawing.Color.White
        Me.Ajouter.Image = CType(resources.GetObject("Ajouter.Image"), System.Drawing.Image)
        Me.Ajouter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ajouter.Location = New System.Drawing.Point(868, 11)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(91, 68)
        Me.Ajouter.TabIndex = 780
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'PIECERECHANGETableAdapter
        '
        Me.PIECERECHANGETableAdapter.ClearBeforeFill = True
        '
        'TMagasinGMAOTableAdapter
        '
        Me.TMagasinGMAOTableAdapter.ClearBeforeFill = True
        '
        'MVTSORTIE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 289)
        Me.Controls.Add(Me.DateMvt)
        Me.Controls.Add(Me.RefMvt)
        Me.Controls.Add(Me.PAMP)
        Me.Controls.Add(Me.QteAprès)
        Me.Controls.Add(Me.PHT)
        Me.Controls.Add(Me.QteAvant)
        Me.Controls.Add(Me.PMP)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.GunaButton6)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.Magasin)
        Me.Controls.Add(Me.MagasinDestination)
        Me.Controls.Add(Me.LibelléMvt)
        Me.Controls.Add(Me.Libellé)
        Me.Controls.Add(Me.Quantité)
        Me.Controls.Add(Me.QuantitéArticles)
        Me.Controls.Add(Me.Pièce)
        Me.Controls.Add(Me.LabelPièce)
        Me.Controls.Add(Me.RéférenceBon)
        Me.Controls.Add(Me.DateSortie)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Ajouter)
        Me.Name = "MVTSORTIE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details Mouvement de Sortie :"
        CType(Me.TMagasinGMAOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateMvt As DateTimePicker
    Friend WithEvents RefMvt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PAMP As Guna.UI.WinForms.GunaButton
    Friend WithEvents QteAprès As Guna.UI.WinForms.GunaButton
    Friend WithEvents PHT As Guna.UI.WinForms.GunaButton
    Friend WithEvents QteAvant As Guna.UI.WinForms.GunaButton
    Friend WithEvents PMP As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Magasin As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents MagasinDestination As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléMvt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Libellé As Guna.UI.WinForms.GunaButton
    Friend WithEvents Quantité As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents QuantitéArticles As Guna.UI.WinForms.GunaButton
    Friend WithEvents Pièce As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LabelPièce As Guna.UI.WinForms.GunaButton
    Friend WithEvents RéférenceBon As Guna.UI.WinForms.GunaButton
    Friend WithEvents DateSortie As Guna.UI.WinForms.GunaButton
    Private WithEvents Sauvegarder As Button
    Private WithEvents Imprimer As Button
    Private WithEvents Ajouter As Button
    Friend WithEvents MyimportDataSet As myimportDataSet
    Friend WithEvents PIECERECHANGEBindingSource As BindingSource
    Friend WithEvents PIECERECHANGETableAdapter As myimportDataSetTableAdapters.PIECERECHANGETableAdapter
    Friend WithEvents TMagasinGMAOBindingSource As BindingSource
    Friend WithEvents TMagasinGMAOTableAdapter As myimportDataSetTableAdapters.tMagasinGMAOTableAdapter
End Class
