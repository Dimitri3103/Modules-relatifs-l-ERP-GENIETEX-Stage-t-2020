<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GMAOPLANMAINTENANCE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMAOPLANMAINTENANCE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Datefin = New System.Windows.Forms.DateTimePicker()
        Me.Datedébut = New System.Windows.Forms.DateTimePicker()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Charger = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.Editer = New Guna.UI.WinForms.GunaButton()
        Me.début = New Guna.UI.WinForms.GunaButton()
        Me.fin = New Guna.UI.WinForms.GunaButton()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LibelléFréquence = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.LibelléDescription = New Guna.UI.WinForms.GunaButton()
        Me.Répétition = New Guna.UI.WinForms.GunaComboBox()
        Me.LibelléRépétition = New Guna.UI.WinForms.GunaButton()
        Me.Type = New Guna.UI.WinForms.GunaComboBox()
        Me.LibelléType = New Guna.UI.WinForms.GunaButton()
        Me.Machine = New Guna.UI.WinForms.GunaComboBox()
        Me.Référence = New Guna.UI.WinForms.GunaTextBox()
        Me.LibelléRéférence = New Guna.UI.WinForms.GunaButton()
        Me.LibelléMachine = New Guna.UI.WinForms.GunaButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datefin
        '
        Me.Datefin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Datefin.Location = New System.Drawing.Point(183, 326)
        Me.Datefin.Name = "Datefin"
        Me.Datefin.Size = New System.Drawing.Size(228, 23)
        Me.Datefin.TabIndex = 854
        '
        'Datedébut
        '
        Me.Datedébut.CalendarTrailingForeColor = System.Drawing.Color.Silver
        Me.Datedébut.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Datedébut.Location = New System.Drawing.Point(183, 294)
        Me.Datedébut.Name = "Datedébut"
        Me.Datedébut.Size = New System.Drawing.Size(228, 23)
        Me.Datedébut.TabIndex = 853
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimer.Location = New System.Drawing.Point(867, 12)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(91, 68)
        Me.Imprimer.TabIndex = 852
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
        Me.Supprimer.Location = New System.Drawing.Point(757, 12)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(91, 68)
        Me.Supprimer.TabIndex = 851
        Me.Supprimer.Text = "Supprimer"
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
        Me.Charger.Location = New System.Drawing.Point(647, 12)
        Me.Charger.Name = "Charger"
        Me.Charger.Size = New System.Drawing.Size(91, 68)
        Me.Charger.TabIndex = 850
        Me.Charger.Text = "Charger"
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
        Me.Modifier.Location = New System.Drawing.Point(537, 12)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(91, 68)
        Me.Modifier.TabIndex = 849
        Me.Modifier.Text = "Modifier"
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
        Me.Ajouter.Location = New System.Drawing.Point(427, 12)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(91, 68)
        Me.Ajouter.TabIndex = 848
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ajouter.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column1, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(12, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 245)
        Me.DataGridView1.TabIndex = 847
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 59
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Répétition"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 88
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Fréquence"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 91
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Jours de répétition"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Equipement"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 99
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 92
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date Début"
        Me.Column1.Name = "Column1"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Date Fin"
        Me.Column8.Name = "Column8"
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
        Me.GunaButton1.Location = New System.Drawing.Point(644, 370)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(150, 26)
        Me.GunaButton1.TabIndex = 846
        Me.GunaButton1.Text = "Filtre par Machine :"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.DisplayMember = "Nom_Mag"
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Location = New System.Drawing.Point(800, 370)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(222, 23)
        Me.GunaComboBox1.TabIndex = 845
        Me.GunaComboBox1.ValueMember = "Code_Mag"
        '
        'Editer
        '
        Me.Editer.AnimationHoverSpeed = 0.07!
        Me.Editer.AnimationSpeed = 0.03!
        Me.Editer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Editer.BorderColor = System.Drawing.Color.Black
        Me.Editer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Editer.FocusedColor = System.Drawing.Color.Empty
        Me.Editer.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Editer.ForeColor = System.Drawing.Color.White
        Me.Editer.Image = Nothing
        Me.Editer.ImageSize = New System.Drawing.Size(20, 20)
        Me.Editer.Location = New System.Drawing.Point(12, 370)
        Me.Editer.Name = "Editer"
        Me.Editer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Editer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Editer.OnHoverForeColor = System.Drawing.Color.White
        Me.Editer.OnHoverImage = Nothing
        Me.Editer.OnPressedColor = System.Drawing.Color.Black
        Me.Editer.Size = New System.Drawing.Size(81, 26)
        Me.Editer.TabIndex = 844
        Me.Editer.Text = "Editer"
        Me.Editer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'début
        '
        Me.début.AnimationHoverSpeed = 0.07!
        Me.début.AnimationSpeed = 0.03!
        Me.début.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.début.BorderColor = System.Drawing.Color.Black
        Me.début.DialogResult = System.Windows.Forms.DialogResult.None
        Me.début.FocusedColor = System.Drawing.Color.Empty
        Me.début.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.début.ForeColor = System.Drawing.Color.White
        Me.début.Image = Nothing
        Me.début.ImageSize = New System.Drawing.Size(20, 20)
        Me.début.Location = New System.Drawing.Point(12, 294)
        Me.début.Name = "début"
        Me.début.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.début.OnHoverBorderColor = System.Drawing.Color.Black
        Me.début.OnHoverForeColor = System.Drawing.Color.White
        Me.début.OnHoverImage = Nothing
        Me.début.OnPressedColor = System.Drawing.Color.Black
        Me.début.Size = New System.Drawing.Size(162, 26)
        Me.début.TabIndex = 843
        Me.début.Text = "Date début"
        Me.début.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fin
        '
        Me.fin.AnimationHoverSpeed = 0.07!
        Me.fin.AnimationSpeed = 0.03!
        Me.fin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fin.BorderColor = System.Drawing.Color.Black
        Me.fin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.fin.FocusedColor = System.Drawing.Color.Empty
        Me.fin.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.fin.ForeColor = System.Drawing.Color.White
        Me.fin.Image = Nothing
        Me.fin.ImageSize = New System.Drawing.Size(20, 20)
        Me.fin.Location = New System.Drawing.Point(12, 326)
        Me.fin.Name = "fin"
        Me.fin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.fin.OnHoverForeColor = System.Drawing.Color.White
        Me.fin.OnHoverImage = Nothing
        Me.fin.OnPressedColor = System.Drawing.Color.Black
        Me.fin.Size = New System.Drawing.Size(162, 26)
        Me.fin.TabIndex = 842
        Me.fin.Text = "Date fin"
        Me.fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaTextBox2.Location = New System.Drawing.Point(183, 204)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(839, 78)
        Me.GunaTextBox2.TabIndex = 841
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox8.Location = New System.Drawing.Point(744, 180)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(107, 21)
        Me.CheckBox8.TabIndex = 840
        Me.CheckBox8.Text = "Tous les jours"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox7.Location = New System.Drawing.Point(644, 180)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(94, 21)
        Me.CheckBox7.TabIndex = 839
        Me.CheckBox7.Text = "Dimanche"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox6.Location = New System.Drawing.Point(563, 180)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox6.TabIndex = 838
        Me.CheckBox6.Text = "Samedi"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox5.Location = New System.Drawing.Point(472, 180)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(85, 21)
        Me.CheckBox5.TabIndex = 837
        Me.CheckBox5.Text = "Vendredi"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox4.Location = New System.Drawing.Point(405, 180)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(61, 21)
        Me.CheckBox4.TabIndex = 836
        Me.CheckBox4.Text = "Jeudi"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox3.Location = New System.Drawing.Point(317, 180)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(82, 21)
        Me.CheckBox3.TabIndex = 835
        Me.CheckBox3.Text = "Mercredi"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox2.Location = New System.Drawing.Point(248, 180)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(63, 21)
        Me.CheckBox2.TabIndex = 834
        Me.CheckBox2.Text = "Mardi"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox1.Location = New System.Drawing.Point(181, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 21)
        Me.CheckBox1.TabIndex = 833
        Me.CheckBox1.Text = "Lundi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(487, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 832
        Me.Label2.Text = "semaines"
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
        Me.GunaTextBox1.Location = New System.Drawing.Point(417, 147)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(64, 26)
        Me.GunaTextBox1.TabIndex = 831
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(180, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 17)
        Me.Label1.TabIndex = 830
        Me.Label1.Text = "La maintenance se répète chaque"
        '
        'LibelléFréquence
        '
        Me.LibelléFréquence.AnimationHoverSpeed = 0.07!
        Me.LibelléFréquence.AnimationSpeed = 0.03!
        Me.LibelléFréquence.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléFréquence.BorderColor = System.Drawing.Color.Black
        Me.LibelléFréquence.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléFréquence.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléFréquence.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléFréquence.ForeColor = System.Drawing.Color.White
        Me.LibelléFréquence.Image = Nothing
        Me.LibelléFréquence.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléFréquence.Location = New System.Drawing.Point(12, 140)
        Me.LibelléFréquence.Name = "LibelléFréquence"
        Me.LibelléFréquence.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléFréquence.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléFréquence.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléFréquence.OnHoverImage = Nothing
        Me.LibelléFréquence.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléFréquence.Size = New System.Drawing.Size(162, 26)
        Me.LibelléFréquence.TabIndex = 829
        Me.LibelléFréquence.Text = "Fréquence"
        Me.LibelléFréquence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaButton3.Location = New System.Drawing.Point(12, 172)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(162, 26)
        Me.GunaButton3.TabIndex = 828
        Me.GunaButton3.Text = "Répéter le :"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibelléDescription
        '
        Me.LibelléDescription.AnimationHoverSpeed = 0.07!
        Me.LibelléDescription.AnimationSpeed = 0.03!
        Me.LibelléDescription.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDescription.BorderColor = System.Drawing.Color.Black
        Me.LibelléDescription.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléDescription.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléDescription.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléDescription.ForeColor = System.Drawing.Color.White
        Me.LibelléDescription.Image = Nothing
        Me.LibelléDescription.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléDescription.Location = New System.Drawing.Point(12, 204)
        Me.LibelléDescription.Name = "LibelléDescription"
        Me.LibelléDescription.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléDescription.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléDescription.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléDescription.OnHoverImage = Nothing
        Me.LibelléDescription.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléDescription.Size = New System.Drawing.Size(162, 26)
        Me.LibelléDescription.TabIndex = 827
        Me.LibelléDescription.Text = "Description"
        Me.LibelléDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Répétition
        '
        Me.Répétition.BackColor = System.Drawing.Color.Transparent
        Me.Répétition.BaseColor = System.Drawing.Color.White
        Me.Répétition.BorderColor = System.Drawing.Color.Silver
        Me.Répétition.DisplayMember = "Nom_Mag"
        Me.Répétition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Répétition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Répétition.FocusedColor = System.Drawing.Color.Empty
        Me.Répétition.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Répétition.ForeColor = System.Drawing.Color.Black
        Me.Répétition.FormattingEnabled = True
        Me.Répétition.Location = New System.Drawing.Point(181, 108)
        Me.Répétition.Name = "Répétition"
        Me.Répétition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Répétition.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Répétition.Size = New System.Drawing.Size(222, 23)
        Me.Répétition.TabIndex = 826
        Me.Répétition.ValueMember = "Code_Mag"
        '
        'LibelléRépétition
        '
        Me.LibelléRépétition.AnimationHoverSpeed = 0.07!
        Me.LibelléRépétition.AnimationSpeed = 0.03!
        Me.LibelléRépétition.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRépétition.BorderColor = System.Drawing.Color.Black
        Me.LibelléRépétition.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléRépétition.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléRépétition.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléRépétition.ForeColor = System.Drawing.Color.White
        Me.LibelléRépétition.Image = Nothing
        Me.LibelléRépétition.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléRépétition.Location = New System.Drawing.Point(12, 108)
        Me.LibelléRépétition.Name = "LibelléRépétition"
        Me.LibelléRépétition.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRépétition.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléRépétition.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléRépétition.OnHoverImage = Nothing
        Me.LibelléRépétition.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléRépétition.Size = New System.Drawing.Size(162, 26)
        Me.LibelléRépétition.TabIndex = 825
        Me.LibelléRépétition.Text = "Répétition"
        Me.LibelléRépétition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Type
        '
        Me.Type.BackColor = System.Drawing.Color.Transparent
        Me.Type.BaseColor = System.Drawing.Color.White
        Me.Type.BorderColor = System.Drawing.Color.Silver
        Me.Type.DisplayMember = "Nom_Mag"
        Me.Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.FocusedColor = System.Drawing.Color.Empty
        Me.Type.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Type.ForeColor = System.Drawing.Color.Black
        Me.Type.FormattingEnabled = True
        Me.Type.Location = New System.Drawing.Point(181, 76)
        Me.Type.Name = "Type"
        Me.Type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Type.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Type.Size = New System.Drawing.Size(222, 23)
        Me.Type.TabIndex = 824
        Me.Type.ValueMember = "Code_Mag"
        '
        'LibelléType
        '
        Me.LibelléType.AnimationHoverSpeed = 0.07!
        Me.LibelléType.AnimationSpeed = 0.03!
        Me.LibelléType.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléType.BorderColor = System.Drawing.Color.Black
        Me.LibelléType.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LibelléType.FocusedColor = System.Drawing.Color.Empty
        Me.LibelléType.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LibelléType.ForeColor = System.Drawing.Color.White
        Me.LibelléType.Image = Nothing
        Me.LibelléType.ImageSize = New System.Drawing.Size(20, 20)
        Me.LibelléType.Location = New System.Drawing.Point(12, 76)
        Me.LibelléType.Name = "LibelléType"
        Me.LibelléType.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléType.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléType.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléType.OnHoverImage = Nothing
        Me.LibelléType.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléType.Size = New System.Drawing.Size(162, 26)
        Me.LibelléType.TabIndex = 823
        Me.LibelléType.Text = "Type"
        Me.LibelléType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Machine.Location = New System.Drawing.Point(180, 44)
        Me.Machine.Name = "Machine"
        Me.Machine.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Machine.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Machine.Size = New System.Drawing.Size(222, 23)
        Me.Machine.TabIndex = 822
        Me.Machine.ValueMember = "Code_Mag"
        '
        'Référence
        '
        Me.Référence.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Référence.BorderColor = System.Drawing.Color.Silver
        Me.Référence.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Référence.FocusedBaseColor = System.Drawing.Color.White
        Me.Référence.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Référence.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Référence.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Référence.Location = New System.Drawing.Point(180, 12)
        Me.Référence.Name = "Référence"
        Me.Référence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Référence.SelectedText = ""
        Me.Référence.Size = New System.Drawing.Size(223, 26)
        Me.Référence.TabIndex = 821
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
        Me.LibelléRéférence.Location = New System.Drawing.Point(12, 12)
        Me.LibelléRéférence.Name = "LibelléRéférence"
        Me.LibelléRéférence.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléRéférence.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléRéférence.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléRéférence.OnHoverImage = Nothing
        Me.LibelléRéférence.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléRéférence.Size = New System.Drawing.Size(162, 26)
        Me.LibelléRéférence.TabIndex = 820
        Me.LibelléRéférence.Text = "Référence"
        Me.LibelléRéférence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LibelléMachine.Location = New System.Drawing.Point(12, 44)
        Me.LibelléMachine.Name = "LibelléMachine"
        Me.LibelléMachine.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LibelléMachine.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LibelléMachine.OnHoverForeColor = System.Drawing.Color.White
        Me.LibelléMachine.OnHoverImage = Nothing
        Me.LibelléMachine.OnPressedColor = System.Drawing.Color.Black
        Me.LibelléMachine.Size = New System.Drawing.Size(162, 26)
        Me.LibelléMachine.TabIndex = 819
        Me.LibelléMachine.Text = "Machine"
        Me.LibelléMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GMAOPLANMAINTENANCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.Datefin)
        Me.Controls.Add(Me.Datedébut)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Charger)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaComboBox1)
        Me.Controls.Add(Me.Editer)
        Me.Controls.Add(Me.début)
        Me.Controls.Add(Me.fin)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibelléFréquence)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.LibelléDescription)
        Me.Controls.Add(Me.Répétition)
        Me.Controls.Add(Me.LibelléRépétition)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.LibelléType)
        Me.Controls.Add(Me.Machine)
        Me.Controls.Add(Me.Référence)
        Me.Controls.Add(Me.LibelléRéférence)
        Me.Controls.Add(Me.LibelléMachine)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GMAOPLANMAINTENANCE"
        Me.Text = "Plan de maintenance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datefin As DateTimePicker
    Friend WithEvents Datedébut As DateTimePicker
    Friend WithEvents Imprimer As Button
    Friend WithEvents Supprimer As Button
    Friend WithEvents Charger As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents Ajouter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Editer As Guna.UI.WinForms.GunaButton
    Friend WithEvents début As Guna.UI.WinForms.GunaButton
    Friend WithEvents fin As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LibelléFréquence As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléDescription As Guna.UI.WinForms.GunaButton
    Friend WithEvents Répétition As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LibelléRépétition As Guna.UI.WinForms.GunaButton
    Friend WithEvents Type As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LibelléType As Guna.UI.WinForms.GunaButton
    Friend WithEvents Machine As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Référence As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LibelléRéférence As Guna.UI.WinForms.GunaButton
    Friend WithEvents LibelléMachine As Guna.UI.WinForms.GunaButton
End Class
