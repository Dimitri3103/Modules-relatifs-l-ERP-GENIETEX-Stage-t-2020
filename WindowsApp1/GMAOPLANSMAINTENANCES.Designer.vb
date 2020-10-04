<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GMAOPLANSMAINTENANCES
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMAOPLANSMAINTENANCES))
        Me.PMCuratif = New Guna.UI.WinForms.GunaButton()
        Me.PMElectronique = New Guna.UI.WinForms.GunaButton()
        Me.PMMécanique = New Guna.UI.WinForms.GunaButton()
        Me.PMPréventif = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PMHydrolique = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Charger = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PMCuratif
        '
        Me.PMCuratif.AnimationHoverSpeed = 0.07!
        Me.PMCuratif.AnimationSpeed = 0.03!
        Me.PMCuratif.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMCuratif.BorderColor = System.Drawing.Color.Black
        Me.PMCuratif.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMCuratif.FocusedColor = System.Drawing.Color.Empty
        Me.PMCuratif.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMCuratif.ForeColor = System.Drawing.Color.White
        Me.PMCuratif.Image = Nothing
        Me.PMCuratif.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMCuratif.Location = New System.Drawing.Point(12, 12)
        Me.PMCuratif.Name = "PMCuratif"
        Me.PMCuratif.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMCuratif.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMCuratif.OnHoverForeColor = System.Drawing.Color.White
        Me.PMCuratif.OnHoverImage = Nothing
        Me.PMCuratif.OnPressedColor = System.Drawing.Color.Black
        Me.PMCuratif.Size = New System.Drawing.Size(32, 26)
        Me.PMCuratif.TabIndex = 778
        Me.PMCuratif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PMElectronique
        '
        Me.PMElectronique.AnimationHoverSpeed = 0.07!
        Me.PMElectronique.AnimationSpeed = 0.03!
        Me.PMElectronique.BaseColor = System.Drawing.Color.Silver
        Me.PMElectronique.BorderColor = System.Drawing.Color.Black
        Me.PMElectronique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMElectronique.FocusedColor = System.Drawing.Color.Empty
        Me.PMElectronique.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMElectronique.ForeColor = System.Drawing.Color.White
        Me.PMElectronique.Image = Nothing
        Me.PMElectronique.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMElectronique.Location = New System.Drawing.Point(169, 44)
        Me.PMElectronique.Name = "PMElectronique"
        Me.PMElectronique.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.PMElectronique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMElectronique.OnHoverForeColor = System.Drawing.Color.White
        Me.PMElectronique.OnHoverImage = Nothing
        Me.PMElectronique.OnPressedColor = System.Drawing.Color.Black
        Me.PMElectronique.Size = New System.Drawing.Size(32, 26)
        Me.PMElectronique.TabIndex = 779
        Me.PMElectronique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PMMécanique
        '
        Me.PMMécanique.AnimationHoverSpeed = 0.07!
        Me.PMMécanique.AnimationSpeed = 0.03!
        Me.PMMécanique.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMMécanique.BorderColor = System.Drawing.Color.Black
        Me.PMMécanique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMMécanique.FocusedColor = System.Drawing.Color.Empty
        Me.PMMécanique.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMMécanique.ForeColor = System.Drawing.Color.White
        Me.PMMécanique.Image = Nothing
        Me.PMMécanique.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMMécanique.Location = New System.Drawing.Point(169, 12)
        Me.PMMécanique.Name = "PMMécanique"
        Me.PMMécanique.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PMMécanique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMMécanique.OnHoverForeColor = System.Drawing.Color.White
        Me.PMMécanique.OnHoverImage = Nothing
        Me.PMMécanique.OnPressedColor = System.Drawing.Color.Black
        Me.PMMécanique.Size = New System.Drawing.Size(32, 26)
        Me.PMMécanique.TabIndex = 780
        Me.PMMécanique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PMPréventif
        '
        Me.PMPréventif.AnimationHoverSpeed = 0.07!
        Me.PMPréventif.AnimationSpeed = 0.03!
        Me.PMPréventif.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PMPréventif.BorderColor = System.Drawing.Color.Black
        Me.PMPréventif.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMPréventif.FocusedColor = System.Drawing.Color.Empty
        Me.PMPréventif.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMPréventif.ForeColor = System.Drawing.Color.White
        Me.PMPréventif.Image = Nothing
        Me.PMPréventif.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMPréventif.Location = New System.Drawing.Point(12, 44)
        Me.PMPréventif.Name = "PMPréventif"
        Me.PMPréventif.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PMPréventif.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMPréventif.OnHoverForeColor = System.Drawing.Color.White
        Me.PMPréventif.OnHoverImage = Nothing
        Me.PMPréventif.OnPressedColor = System.Drawing.Color.Black
        Me.PMPréventif.Size = New System.Drawing.Size(32, 26)
        Me.PMPréventif.TabIndex = 781
        Me.PMPréventif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 782
        Me.Label1.Text = "PM Curatif"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 783
        Me.Label2.Text = "PM Préventif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 784
        Me.Label3.Text = "PM Mécanique"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 785
        Me.Label4.Text = "PM Electronique"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 787
        Me.Label5.Text = "PM Hydrolique"
        '
        'PMHydrolique
        '
        Me.PMHydrolique.AnimationHoverSpeed = 0.07!
        Me.PMHydrolique.AnimationSpeed = 0.03!
        Me.PMHydrolique.BaseColor = System.Drawing.Color.OliveDrab
        Me.PMHydrolique.BorderColor = System.Drawing.Color.Black
        Me.PMHydrolique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PMHydrolique.FocusedColor = System.Drawing.Color.Empty
        Me.PMHydrolique.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.PMHydrolique.ForeColor = System.Drawing.Color.White
        Me.PMHydrolique.Image = Nothing
        Me.PMHydrolique.ImageSize = New System.Drawing.Size(20, 20)
        Me.PMHydrolique.Location = New System.Drawing.Point(328, 12)
        Me.PMHydrolique.Name = "PMHydrolique"
        Me.PMHydrolique.OnHoverBaseColor = System.Drawing.Color.OliveDrab
        Me.PMHydrolique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PMHydrolique.OnHoverForeColor = System.Drawing.Color.White
        Me.PMHydrolique.OnHoverImage = Nothing
        Me.PMHydrolique.OnPressedColor = System.Drawing.Color.Black
        Me.PMHydrolique.Size = New System.Drawing.Size(32, 26)
        Me.PMHydrolique.TabIndex = 786
        Me.PMHydrolique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton5.Location = New System.Drawing.Point(1038, 12)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(144, 26)
        Me.GunaButton5.TabIndex = 788
        Me.GunaButton5.Text = "Nombre de jours"
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.Items.Add("1")
        Me.DomainUpDown1.Items.Add("2")
        Me.DomainUpDown1.Items.Add("3")
        Me.DomainUpDown1.Items.Add("5")
        Me.DomainUpDown1.Items.Add("6")
        Me.DomainUpDown1.Items.Add("7")
        Me.DomainUpDown1.Items.Add("8")
        Me.DomainUpDown1.Items.Add("9")
        Me.DomainUpDown1.Items.Add("10")
        Me.DomainUpDown1.Items.Add("11")
        Me.DomainUpDown1.Items.Add("12")
        Me.DomainUpDown1.Items.Add("13")
        Me.DomainUpDown1.Items.Add("14")
        Me.DomainUpDown1.Items.Add("15")
        Me.DomainUpDown1.Items.Add("16")
        Me.DomainUpDown1.Items.Add("17")
        Me.DomainUpDown1.Items.Add("18")
        Me.DomainUpDown1.Items.Add("19")
        Me.DomainUpDown1.Items.Add("20")
        Me.DomainUpDown1.Items.Add("21")
        Me.DomainUpDown1.Items.Add("22")
        Me.DomainUpDown1.Items.Add("23")
        Me.DomainUpDown1.Items.Add("24")
        Me.DomainUpDown1.Items.Add("25")
        Me.DomainUpDown1.Items.Add("26")
        Me.DomainUpDown1.Items.Add("27")
        Me.DomainUpDown1.Items.Add("28")
        Me.DomainUpDown1.Items.Add("29")
        Me.DomainUpDown1.Items.Add("30")
        Me.DomainUpDown1.Items.Add("31")
        Me.DomainUpDown1.Location = New System.Drawing.Point(1093, 44)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(38, 22)
        Me.DomainUpDown1.TabIndex = 789
        Me.DomainUpDown1.Text = "0"
        Me.DomainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimer.Location = New System.Drawing.Point(916, 7)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 821
        Me.Imprimer.Text = "Imprimer"
        Me.Imprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imprimer.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Supprimer.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Supprimer.ForeColor = System.Drawing.Color.White
        Me.Supprimer.Image = CType(resources.GetObject("Supprimer.Image"), System.Drawing.Image)
        Me.Supprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Supprimer.Location = New System.Drawing.Point(806, 7)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(91, 68)
        Me.Supprimer.TabIndex = 820
        Me.Supprimer.Text = "Suivant"
        Me.Supprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Charger
        '
        Me.Charger.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Charger.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Charger.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Charger.ForeColor = System.Drawing.Color.White
        Me.Charger.Image = CType(resources.GetObject("Charger.Image"), System.Drawing.Image)
        Me.Charger.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Charger.Location = New System.Drawing.Point(696, 7)
        Me.Charger.Name = "Charger"
        Me.Charger.Size = New System.Drawing.Size(91, 68)
        Me.Charger.TabIndex = 819
        Me.Charger.Text = "Précédent"
        Me.Charger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Charger.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Modifier.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Modifier.ForeColor = System.Drawing.Color.White
        Me.Modifier.Image = CType(resources.GetObject("Modifier.Image"), System.Drawing.Image)
        Me.Modifier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Modifier.Location = New System.Drawing.Point(586, 7)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(91, 68)
        Me.Modifier.TabIndex = 818
        Me.Modifier.Text = "Actualiser"
        Me.Modifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ajouter.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Ajouter.ForeColor = System.Drawing.Color.White
        Me.Ajouter.Image = CType(resources.GetObject("Ajouter.Image"), System.Drawing.Image)
        Me.Ajouter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Ajouter.Location = New System.Drawing.Point(476, 7)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(91, 68)
        Me.Ajouter.TabIndex = 817
        Me.Ajouter.Text = "Créer un PM"
        Me.Ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1194, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 54)
        Me.Button1.TabIndex = 822
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GMAOPLANSMAINTENANCES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1283, 588)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Charger)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PMHydrolique)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PMPréventif)
        Me.Controls.Add(Me.PMMécanique)
        Me.Controls.Add(Me.PMElectronique)
        Me.Controls.Add(Me.PMCuratif)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GMAOPLANSMAINTENANCES"
        Me.Text = "Plans de maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PMCuratif As Guna.UI.WinForms.GunaButton
    Friend WithEvents PMElectronique As Guna.UI.WinForms.GunaButton
    Friend WithEvents PMMécanique As Guna.UI.WinForms.GunaButton
    Friend WithEvents PMPréventif As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PMHydrolique As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Imprimer As Button
    Friend WithEvents Supprimer As Button
    Friend WithEvents Charger As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents Ajouter As Button
    Friend WithEvents Button1 As Button
End Class
