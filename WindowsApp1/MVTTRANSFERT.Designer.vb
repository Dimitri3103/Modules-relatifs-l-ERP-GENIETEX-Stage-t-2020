<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MVTTRANSFERT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVTTRANSFERT))
        Me.DateMvt = New System.Windows.Forms.DateTimePicker()
        Me.PAMPAprès = New Guna.UI.WinForms.GunaButton()
        Me.PHTAprès = New Guna.UI.WinForms.GunaButton()
        Me.QteAprès = New Guna.UI.WinForms.GunaButton()
        Me.PAMPAvant = New Guna.UI.WinForms.GunaButton()
        Me.PHTAvant = New Guna.UI.WinForms.GunaButton()
        Me.QteAvant = New Guna.UI.WinForms.GunaButton()
        Me.PAMP = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.PrixAchat = New Guna.UI.WinForms.GunaTextBox()
        Me.PA = New Guna.UI.WinForms.GunaButton()
        Me.Destination = New Guna.UI.WinForms.GunaComboBox()
        Me.TMagasinGMAOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyimportDataSet = New WindowsApp1.myimportDataSet()
        Me.MagasinDestination = New Guna.UI.WinForms.GunaButton()
        Me.Source = New Guna.UI.WinForms.GunaComboBox()
        Me.MagasinSource = New Guna.UI.WinForms.GunaButton()
        Me.LibelléMvt = New Guna.UI.WinForms.GunaTextBox()
        Me.Libellé = New Guna.UI.WinForms.GunaButton()
        Me.Quantité = New Guna.UI.WinForms.GunaTextBox()
        Me.QuantitéArticles = New Guna.UI.WinForms.GunaButton()
        Me.Pièce = New Guna.UI.WinForms.GunaComboBox()
        Me.PIECERECHANGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelPièce = New Guna.UI.WinForms.GunaButton()
        Me.RefMvt = New Guna.UI.WinForms.GunaTextBox()
        Me.RéférenceBon = New Guna.UI.WinForms.GunaButton()
        Me.DateTransfert = New Guna.UI.WinForms.GunaButton()
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
        Me.DateMvt.Location = New System.Drawing.Point(165, 9)
        Me.DateMvt.Name = "DateMvt"
        Me.DateMvt.Size = New System.Drawing.Size(250, 22)
        Me.DateMvt.TabIndex = 781
        '
        'PAMPAprès
        '
        Me.PAMPAprès.AnimationHoverSpeed = 0.07!
        Me.PAMPAprès.AnimationSpeed = 0.03!
        Me.PAMPAprès.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMPAprès.BorderColor = System.Drawing.Color.Black
        Me.PAMPAprès.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PAMPAprès.FocusedColor = System.Drawing.Color.Empty
        Me.PAMPAprès.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PAMPAprès.ForeColor = System.Drawing.Color.White
        Me.PAMPAprès.Image = Nothing
        Me.PAMPAprès.ImageSize = New System.Drawing.Size(20, 20)
        Me.PAMPAprès.Location = New System.Drawing.Point(662, 214)
        Me.PAMPAprès.Name = "PAMPAprès"
        Me.PAMPAprès.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMPAprès.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PAMPAprès.OnHoverForeColor = System.Drawing.Color.White
        Me.PAMPAprès.OnHoverImage = Nothing
        Me.PAMPAprès.OnPressedColor = System.Drawing.Color.Black
        Me.PAMPAprès.Size = New System.Drawing.Size(162, 26)
        Me.PAMPAprès.TabIndex = 780
        Me.PAMPAprès.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PHTAprès
        '
        Me.PHTAprès.AnimationHoverSpeed = 0.07!
        Me.PHTAprès.AnimationSpeed = 0.03!
        Me.PHTAprès.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHTAprès.BorderColor = System.Drawing.Color.Black
        Me.PHTAprès.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PHTAprès.FocusedColor = System.Drawing.Color.Empty
        Me.PHTAprès.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PHTAprès.ForeColor = System.Drawing.Color.White
        Me.PHTAprès.Image = Nothing
        Me.PHTAprès.ImageSize = New System.Drawing.Size(20, 20)
        Me.PHTAprès.Location = New System.Drawing.Point(662, 182)
        Me.PHTAprès.Name = "PHTAprès"
        Me.PHTAprès.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHTAprès.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PHTAprès.OnHoverForeColor = System.Drawing.Color.White
        Me.PHTAprès.OnHoverImage = Nothing
        Me.PHTAprès.OnPressedColor = System.Drawing.Color.Black
        Me.PHTAprès.Size = New System.Drawing.Size(162, 26)
        Me.PHTAprès.TabIndex = 779
        Me.PHTAprès.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.QteAprès.Location = New System.Drawing.Point(662, 150)
        Me.QteAprès.Name = "QteAprès"
        Me.QteAprès.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAprès.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QteAprès.OnHoverForeColor = System.Drawing.Color.White
        Me.QteAprès.OnHoverImage = Nothing
        Me.QteAprès.OnPressedColor = System.Drawing.Color.Black
        Me.QteAprès.Size = New System.Drawing.Size(162, 26)
        Me.QteAprès.TabIndex = 778
        Me.QteAprès.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PAMPAvant
        '
        Me.PAMPAvant.AnimationHoverSpeed = 0.07!
        Me.PAMPAvant.AnimationSpeed = 0.03!
        Me.PAMPAvant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMPAvant.BorderColor = System.Drawing.Color.Black
        Me.PAMPAvant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PAMPAvant.FocusedColor = System.Drawing.Color.Empty
        Me.PAMPAvant.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PAMPAvant.ForeColor = System.Drawing.Color.White
        Me.PAMPAvant.Image = Nothing
        Me.PAMPAvant.ImageSize = New System.Drawing.Size(20, 20)
        Me.PAMPAvant.Location = New System.Drawing.Point(253, 214)
        Me.PAMPAvant.Name = "PAMPAvant"
        Me.PAMPAvant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMPAvant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PAMPAvant.OnHoverForeColor = System.Drawing.Color.White
        Me.PAMPAvant.OnHoverImage = Nothing
        Me.PAMPAvant.OnPressedColor = System.Drawing.Color.Black
        Me.PAMPAvant.Size = New System.Drawing.Size(162, 26)
        Me.PAMPAvant.TabIndex = 777
        Me.PAMPAvant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PHTAvant
        '
        Me.PHTAvant.AnimationHoverSpeed = 0.07!
        Me.PHTAvant.AnimationSpeed = 0.03!
        Me.PHTAvant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHTAvant.BorderColor = System.Drawing.Color.Black
        Me.PHTAvant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PHTAvant.FocusedColor = System.Drawing.Color.Empty
        Me.PHTAvant.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PHTAvant.ForeColor = System.Drawing.Color.White
        Me.PHTAvant.Image = Nothing
        Me.PHTAvant.ImageSize = New System.Drawing.Size(20, 20)
        Me.PHTAvant.Location = New System.Drawing.Point(253, 182)
        Me.PHTAvant.Name = "PHTAvant"
        Me.PHTAvant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PHTAvant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PHTAvant.OnHoverForeColor = System.Drawing.Color.White
        Me.PHTAvant.OnHoverImage = Nothing
        Me.PHTAvant.OnPressedColor = System.Drawing.Color.Black
        Me.PHTAvant.Size = New System.Drawing.Size(162, 26)
        Me.PHTAvant.TabIndex = 776
        Me.PHTAvant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.QteAvant.Location = New System.Drawing.Point(253, 150)
        Me.QteAvant.Name = "QteAvant"
        Me.QteAvant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QteAvant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QteAvant.OnHoverForeColor = System.Drawing.Color.White
        Me.QteAvant.OnHoverImage = Nothing
        Me.QteAvant.OnPressedColor = System.Drawing.Color.Black
        Me.QteAvant.Size = New System.Drawing.Size(162, 26)
        Me.QteAvant.TabIndex = 775
        Me.QteAvant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PAMP
        '
        Me.PAMP.AnimationHoverSpeed = 0.07!
        Me.PAMP.AnimationSpeed = 0.03!
        Me.PAMP.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMP.BorderColor = System.Drawing.Color.Black
        Me.PAMP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PAMP.FocusedColor = System.Drawing.Color.Empty
        Me.PAMP.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PAMP.ForeColor = System.Drawing.Color.White
        Me.PAMP.Image = Nothing
        Me.PAMP.ImageSize = New System.Drawing.Size(20, 20)
        Me.PAMP.Location = New System.Drawing.Point(7, 254)
        Me.PAMP.Name = "PAMP"
        Me.PAMP.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PAMP.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PAMP.OnHoverForeColor = System.Drawing.Color.White
        Me.PAMP.OnHoverImage = Nothing
        Me.PAMP.OnPressedColor = System.Drawing.Color.Black
        Me.PAMP.Size = New System.Drawing.Size(228, 26)
        Me.PAMP.TabIndex = 774
        Me.PAMP.Text = "PAMP : Prix d'Achat Moyen Pondéré"
        Me.PAMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(67, 214)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton4.TabIndex = 773
        Me.GunaButton4.Text = "PAMP avant Mvt"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton5.Location = New System.Drawing.Point(67, 182)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton5.TabIndex = 772
        Me.GunaButton5.Text = "PHT avant Mvt"
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
        Me.GunaButton6.Location = New System.Drawing.Point(67, 150)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton6.TabIndex = 771
        Me.GunaButton6.Text = "Quantité avant Mvt"
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(474, 214)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton1.TabIndex = 770
        Me.GunaButton1.Text = "PAMP après Mvt"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton2.Location = New System.Drawing.Point(474, 182)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton2.TabIndex = 769
        Me.GunaButton2.Text = "PHT après Mvt"
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
        Me.GunaButton3.Location = New System.Drawing.Point(474, 150)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton3.TabIndex = 768
        Me.GunaButton3.Text = "Quantité après Mvt"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrixAchat
        '
        Me.PrixAchat.BaseColor = System.Drawing.Color.White
        Me.PrixAchat.BorderColor = System.Drawing.Color.Silver
        Me.PrixAchat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrixAchat.FocusedBaseColor = System.Drawing.Color.White
        Me.PrixAchat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrixAchat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.PrixAchat.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PrixAchat.Location = New System.Drawing.Point(601, 105)
        Me.PrixAchat.Name = "PrixAchat"
        Me.PrixAchat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrixAchat.SelectedText = ""
        Me.PrixAchat.Size = New System.Drawing.Size(223, 26)
        Me.PrixAchat.TabIndex = 767
        '
        'PA
        '
        Me.PA.AnimationHoverSpeed = 0.07!
        Me.PA.AnimationSpeed = 0.03!
        Me.PA.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PA.BorderColor = System.Drawing.Color.Black
        Me.PA.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PA.FocusedColor = System.Drawing.Color.Empty
        Me.PA.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PA.ForeColor = System.Drawing.Color.White
        Me.PA.Image = Nothing
        Me.PA.ImageSize = New System.Drawing.Size(20, 20)
        Me.PA.Location = New System.Drawing.Point(433, 105)
        Me.PA.Name = "PA"
        Me.PA.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PA.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PA.OnHoverForeColor = System.Drawing.Color.White
        Me.PA.OnHoverImage = Nothing
        Me.PA.OnPressedColor = System.Drawing.Color.Black
        Me.PA.Size = New System.Drawing.Size(162, 26)
        Me.PA.TabIndex = 766
        Me.PA.Text = "Prix Achat :"
        Me.PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Destination
        '
        Me.Destination.BackColor = System.Drawing.Color.Transparent
        Me.Destination.BaseColor = System.Drawing.Color.White
        Me.Destination.BorderColor = System.Drawing.Color.Silver
        Me.Destination.DataSource = Me.TMagasinGMAOBindingSource
        Me.Destination.DisplayMember = "Nom_Mag"
        Me.Destination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Destination.FocusedColor = System.Drawing.Color.Empty
        Me.Destination.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Destination.ForeColor = System.Drawing.Color.Black
        Me.Destination.FormattingEnabled = True
        Me.Destination.Location = New System.Drawing.Point(602, 72)
        Me.Destination.Name = "Destination"
        Me.Destination.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Destination.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Destination.Size = New System.Drawing.Size(222, 23)
        Me.Destination.TabIndex = 765
        Me.Destination.ValueMember = "Code_Mag"
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
        Me.MagasinDestination.Location = New System.Drawing.Point(433, 73)
        Me.MagasinDestination.Name = "MagasinDestination"
        Me.MagasinDestination.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MagasinDestination.OnHoverBorderColor = System.Drawing.Color.Black
        Me.MagasinDestination.OnHoverForeColor = System.Drawing.Color.White
        Me.MagasinDestination.OnHoverImage = Nothing
        Me.MagasinDestination.OnPressedColor = System.Drawing.Color.Black
        Me.MagasinDestination.Size = New System.Drawing.Size(162, 26)
        Me.MagasinDestination.TabIndex = 764
        Me.MagasinDestination.Text = "Magasin Destination :"
        Me.MagasinDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Source
        '
        Me.Source.BackColor = System.Drawing.Color.Transparent
        Me.Source.BaseColor = System.Drawing.Color.White
        Me.Source.BorderColor = System.Drawing.Color.Silver
        Me.Source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Source.FocusedColor = System.Drawing.Color.Empty
        Me.Source.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Source.ForeColor = System.Drawing.Color.Black
        Me.Source.FormattingEnabled = True
        Me.Source.Location = New System.Drawing.Point(602, 40)
        Me.Source.Name = "Source"
        Me.Source.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Source.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Source.Size = New System.Drawing.Size(222, 23)
        Me.Source.TabIndex = 763
        '
        'MagasinSource
        '
        Me.MagasinSource.AnimationHoverSpeed = 0.07!
        Me.MagasinSource.AnimationSpeed = 0.03!
        Me.MagasinSource.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MagasinSource.BorderColor = System.Drawing.Color.Black
        Me.MagasinSource.DialogResult = System.Windows.Forms.DialogResult.None
        Me.MagasinSource.FocusedColor = System.Drawing.Color.Empty
        Me.MagasinSource.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MagasinSource.ForeColor = System.Drawing.Color.White
        Me.MagasinSource.Image = Nothing
        Me.MagasinSource.ImageSize = New System.Drawing.Size(20, 20)
        Me.MagasinSource.Location = New System.Drawing.Point(433, 41)
        Me.MagasinSource.Name = "MagasinSource"
        Me.MagasinSource.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MagasinSource.OnHoverBorderColor = System.Drawing.Color.Black
        Me.MagasinSource.OnHoverForeColor = System.Drawing.Color.White
        Me.MagasinSource.OnHoverImage = Nothing
        Me.MagasinSource.OnPressedColor = System.Drawing.Color.Black
        Me.MagasinSource.Size = New System.Drawing.Size(162, 26)
        Me.MagasinSource.TabIndex = 762
        Me.MagasinSource.Text = "Magasin Source :"
        Me.MagasinSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LibelléMvt.Location = New System.Drawing.Point(601, 9)
        Me.LibelléMvt.Name = "LibelléMvt"
        Me.LibelléMvt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LibelléMvt.SelectedText = ""
        Me.LibelléMvt.Size = New System.Drawing.Size(223, 26)
        Me.LibelléMvt.TabIndex = 761
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
        Me.Libellé.Location = New System.Drawing.Point(433, 9)
        Me.Libellé.Name = "Libellé"
        Me.Libellé.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Libellé.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Libellé.OnHoverForeColor = System.Drawing.Color.White
        Me.Libellé.OnHoverImage = Nothing
        Me.Libellé.OnPressedColor = System.Drawing.Color.Black
        Me.Libellé.Size = New System.Drawing.Size(162, 26)
        Me.Libellé.TabIndex = 760
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
        Me.Quantité.Location = New System.Drawing.Point(165, 104)
        Me.Quantité.Name = "Quantité"
        Me.Quantité.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Quantité.SelectedText = ""
        Me.Quantité.Size = New System.Drawing.Size(250, 26)
        Me.Quantité.TabIndex = 759
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
        Me.QuantitéArticles.Location = New System.Drawing.Point(24, 104)
        Me.QuantitéArticles.Name = "QuantitéArticles"
        Me.QuantitéArticles.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantitéArticles.OnHoverBorderColor = System.Drawing.Color.Black
        Me.QuantitéArticles.OnHoverForeColor = System.Drawing.Color.White
        Me.QuantitéArticles.OnHoverImage = Nothing
        Me.QuantitéArticles.OnPressedColor = System.Drawing.Color.Black
        Me.QuantitéArticles.Size = New System.Drawing.Size(135, 26)
        Me.QuantitéArticles.TabIndex = 758
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
        Me.Pièce.Location = New System.Drawing.Point(165, 72)
        Me.Pièce.Name = "Pièce"
        Me.Pièce.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pièce.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Pièce.Size = New System.Drawing.Size(250, 23)
        Me.Pièce.TabIndex = 757
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
        Me.LabelPièce.Location = New System.Drawing.Point(24, 72)
        Me.LabelPièce.Name = "LabelPièce"
        Me.LabelPièce.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelPièce.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LabelPièce.OnHoverForeColor = System.Drawing.Color.White
        Me.LabelPièce.OnHoverImage = Nothing
        Me.LabelPièce.OnPressedColor = System.Drawing.Color.Black
        Me.LabelPièce.Size = New System.Drawing.Size(135, 26)
        Me.LabelPièce.TabIndex = 756
        Me.LabelPièce.Text = "Pièce :"
        Me.LabelPièce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.RefMvt.Location = New System.Drawing.Point(258, 40)
        Me.RefMvt.Name = "RefMvt"
        Me.RefMvt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RefMvt.SelectedText = ""
        Me.RefMvt.Size = New System.Drawing.Size(157, 26)
        Me.RefMvt.TabIndex = 755
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
        Me.RéférenceBon.Location = New System.Drawing.Point(24, 41)
        Me.RéférenceBon.Name = "RéférenceBon"
        Me.RéférenceBon.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RéférenceBon.OnHoverBorderColor = System.Drawing.Color.Black
        Me.RéférenceBon.OnHoverForeColor = System.Drawing.Color.White
        Me.RéférenceBon.OnHoverImage = Nothing
        Me.RéférenceBon.OnPressedColor = System.Drawing.Color.Black
        Me.RéférenceBon.Size = New System.Drawing.Size(228, 26)
        Me.RéférenceBon.TabIndex = 754
        Me.RéférenceBon.Text = "Bon Transfert Numéro :"
        Me.RéférenceBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTransfert
        '
        Me.DateTransfert.AnimationHoverSpeed = 0.07!
        Me.DateTransfert.AnimationSpeed = 0.03!
        Me.DateTransfert.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTransfert.BorderColor = System.Drawing.Color.Black
        Me.DateTransfert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DateTransfert.FocusedColor = System.Drawing.Color.Empty
        Me.DateTransfert.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.DateTransfert.ForeColor = System.Drawing.Color.White
        Me.DateTransfert.Image = Nothing
        Me.DateTransfert.ImageSize = New System.Drawing.Size(20, 20)
        Me.DateTransfert.Location = New System.Drawing.Point(24, 9)
        Me.DateTransfert.Name = "DateTransfert"
        Me.DateTransfert.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTransfert.OnHoverBorderColor = System.Drawing.Color.Black
        Me.DateTransfert.OnHoverForeColor = System.Drawing.Color.White
        Me.DateTransfert.OnHoverImage = Nothing
        Me.DateTransfert.OnPressedColor = System.Drawing.Color.Black
        Me.DateTransfert.Size = New System.Drawing.Size(135, 26)
        Me.DateTransfert.TabIndex = 753
        Me.DateTransfert.Text = "Date Transfert :"
        Me.DateTransfert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sauvegarder
        '
        Me.Sauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sauvegarder.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sauvegarder.ForeColor = System.Drawing.Color.White
        Me.Sauvegarder.Image = CType(resources.GetObject("Sauvegarder.Image"), System.Drawing.Image)
        Me.Sauvegarder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sauvegarder.Location = New System.Drawing.Point(876, 83)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(91, 68)
        Me.Sauvegarder.TabIndex = 752
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
        Me.Imprimer.Location = New System.Drawing.Point(876, 157)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 751
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
        Me.Ajouter.Location = New System.Drawing.Point(876, 9)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(91, 68)
        Me.Ajouter.TabIndex = 750
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
        'MVTTRANSFERT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 289)
        Me.Controls.Add(Me.DateMvt)
        Me.Controls.Add(Me.PAMPAprès)
        Me.Controls.Add(Me.PHTAprès)
        Me.Controls.Add(Me.QteAprès)
        Me.Controls.Add(Me.PAMPAvant)
        Me.Controls.Add(Me.PHTAvant)
        Me.Controls.Add(Me.QteAvant)
        Me.Controls.Add(Me.PAMP)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.GunaButton6)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.PrixAchat)
        Me.Controls.Add(Me.PA)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.MagasinDestination)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.MagasinSource)
        Me.Controls.Add(Me.LibelléMvt)
        Me.Controls.Add(Me.Libellé)
        Me.Controls.Add(Me.Quantité)
        Me.Controls.Add(Me.QuantitéArticles)
        Me.Controls.Add(Me.Pièce)
        Me.Controls.Add(Me.LabelPièce)
        Me.Controls.Add(Me.RefMvt)
        Me.Controls.Add(Me.RéférenceBon)
        Me.Controls.Add(Me.DateTransfert)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Ajouter)
        Me.Name = "MVTTRANSFERT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détails Mouvement de Transfert :"
        CType(Me.TMagasinGMAOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateMvt As DateTimePicker
    Friend WithEvents PAMPAprès As Guna.UI.WinForms.GunaButton
    Friend WithEvents PHTAprès As Guna.UI.WinForms.GunaButton
    Friend WithEvents QteAprès As Guna.UI.WinForms.GunaButton
    Friend WithEvents PAMPAvant As Guna.UI.WinForms.GunaButton
    Friend WithEvents PHTAvant As Guna.UI.WinForms.GunaButton
    Friend WithEvents QteAvant As Guna.UI.WinForms.GunaButton
    Friend WithEvents PAMP As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PrixAchat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PA As Guna.UI.WinForms.GunaButton
    Friend WithEvents Destination As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents MagasinDestination As Guna.UI.WinForms.GunaButton
    Friend WithEvents Source As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents MagasinSource As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléMvt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Libellé As Guna.UI.WinForms.GunaButton
    Friend WithEvents Quantité As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents QuantitéArticles As Guna.UI.WinForms.GunaButton
    Friend WithEvents Pièce As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LabelPièce As Guna.UI.WinForms.GunaButton
    Friend WithEvents RefMvt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents RéférenceBon As Guna.UI.WinForms.GunaButton
    Friend WithEvents DateTransfert As Guna.UI.WinForms.GunaButton
    Private WithEvents Sauvegarder As Button
    Private WithEvents Imprimer As Button
    Private WithEvents Ajouter As Button
    Friend WithEvents MyimportDataSet As myimportDataSet
    Friend WithEvents PIECERECHANGEBindingSource As BindingSource
    Friend WithEvents PIECERECHANGETableAdapter As myimportDataSetTableAdapters.PIECERECHANGETableAdapter
    Friend WithEvents TMagasinGMAOBindingSource As BindingSource
    Friend WithEvents TMagasinGMAOTableAdapter As myimportDataSetTableAdapters.tMagasinGMAOTableAdapter
End Class
