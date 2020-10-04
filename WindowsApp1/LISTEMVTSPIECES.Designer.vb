<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTEMVTSPIECES
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListeMouvements = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RefMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libellé_Mvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitéMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Mvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pièces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Mag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Pièce = New System.Windows.Forms.ComboBox()
        Me.PIECERECHANGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyimportDataSet = New WindowsApp1.myimportDataSet()
        Me.LabelPièce = New System.Windows.Forms.Button()
        Me.PIECERECHANGETableAdapter = New WindowsApp1.myimportDataSetTableAdapters.PIECERECHANGETableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeMouvements
        '
        Me.ListeMouvements.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListeMouvements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListeMouvements.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeMouvements.ForeColor = System.Drawing.Color.White
        Me.ListeMouvements.Location = New System.Drawing.Point(418, 12)
        Me.ListeMouvements.Name = "ListeMouvements"
        Me.ListeMouvements.Size = New System.Drawing.Size(179, 26)
        Me.ListeMouvements.TabIndex = 681
        Me.ListeMouvements.Text = "Afficher Mouvements"
        Me.ListeMouvements.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefMvt, Me.Libellé_Mvt, Me.QuantitéMvt, Me.Date_Mvt, Me.Pièces, Me.Nom_Mag, Me.PHT})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1278, 394)
        Me.DataGridView1.TabIndex = 680
        '
        'RefMvt
        '
        Me.RefMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RefMvt.DataPropertyName = "RefMvt"
        Me.RefMvt.HeaderText = "Référence Mouvement"
        Me.RefMvt.Name = "RefMvt"
        Me.RefMvt.ReadOnly = True
        Me.RefMvt.Width = 163
        '
        'Libellé_Mvt
        '
        Me.Libellé_Mvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Libellé_Mvt.DataPropertyName = "Libellé_Mvt"
        Me.Libellé_Mvt.HeaderText = "Libellé Mouvement"
        Me.Libellé_Mvt.Name = "Libellé_Mvt"
        Me.Libellé_Mvt.ReadOnly = True
        Me.Libellé_Mvt.Width = 141
        '
        'QuantitéMvt
        '
        Me.QuantitéMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuantitéMvt.DataPropertyName = "QuantitéMvt"
        Me.QuantitéMvt.HeaderText = "Quantité Mouvement"
        Me.QuantitéMvt.Name = "QuantitéMvt"
        Me.QuantitéMvt.ReadOnly = True
        Me.QuantitéMvt.Width = 157
        '
        'Date_Mvt
        '
        Me.Date_Mvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Date_Mvt.DataPropertyName = "Date_Mvt"
        Me.Date_Mvt.HeaderText = "Date Mouvement"
        Me.Date_Mvt.Name = "Date_Mvt"
        Me.Date_Mvt.ReadOnly = True
        Me.Date_Mvt.Width = 134
        '
        'Pièces
        '
        Me.Pièces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Pièces.DataPropertyName = "Designation"
        Me.Pièces.HeaderText = "Pièce"
        Me.Pièces.Name = "Pièces"
        Me.Pièces.ReadOnly = True
        Me.Pièces.Width = 68
        '
        'Nom_Mag
        '
        Me.Nom_Mag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nom_Mag.DataPropertyName = "Nom_Mag"
        Me.Nom_Mag.HeaderText = "Magasin"
        Me.Nom_Mag.Name = "Nom_Mag"
        Me.Nom_Mag.Width = 87
        '
        'PHT
        '
        Me.PHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PHT.DataPropertyName = "PHT"
        Me.PHT.HeaderText = "Prix Achat"
        Me.PHT.Name = "PHT"
        Me.PHT.ReadOnly = True
        Me.PHT.Width = 89
        '
        'Imprimer
        '
        Me.Imprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Imprimer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimer.ForeColor = System.Drawing.Color.White
        Me.Imprimer.Location = New System.Drawing.Point(620, 12)
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(100, 26)
        Me.Imprimer.TabIndex = 679
        Me.Imprimer.Text = "Imprimer"
        Me.Imprimer.UseVisualStyleBackColor = False
        '
        'Pièce
        '
        Me.Pièce.DataSource = Me.PIECERECHANGEBindingSource
        Me.Pièce.DisplayMember = "Designation"
        Me.Pièce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pièce.FormattingEnabled = True
        Me.Pièce.Location = New System.Drawing.Point(124, 17)
        Me.Pièce.Name = "Pièce"
        Me.Pièce.Size = New System.Drawing.Size(259, 21)
        Me.Pièce.TabIndex = 678
        Me.Pièce.ValueMember = "CodePiece"
        '
        'PIECERECHANGEBindingSource
        '
        Me.PIECERECHANGEBindingSource.DataMember = "PIECERECHANGE"
        Me.PIECERECHANGEBindingSource.DataSource = Me.MyimportDataSet
        '
        'MyimportDataSet
        '
        Me.MyimportDataSet.DataSetName = "myimportDataSet"
        Me.MyimportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelPièce
        '
        Me.LabelPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LabelPièce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPièce.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPièce.ForeColor = System.Drawing.Color.White
        Me.LabelPièce.Location = New System.Drawing.Point(13, 12)
        Me.LabelPièce.Name = "LabelPièce"
        Me.LabelPièce.Size = New System.Drawing.Size(100, 26)
        Me.LabelPièce.TabIndex = 677
        Me.LabelPièce.Text = "Pièce :"
        Me.LabelPièce.UseVisualStyleBackColor = False
        '
        'PIECERECHANGETableAdapter
        '
        Me.PIECERECHANGETableAdapter.ClearBeforeFill = True
        '
        'LISTEMVTSPIECES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 450)
        Me.Controls.Add(Me.ListeMouvements)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Imprimer)
        Me.Controls.Add(Me.Pièce)
        Me.Controls.Add(Me.LabelPièce)
        Me.Name = "LISTEMVTSPIECES"
        Me.Text = "Liste des Mouvements de pièces sélectionnées dans un ou plusieurs magasins"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ListeMouvements As Button
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents Imprimer As Button
    Friend WithEvents Pièce As ComboBox
    Private WithEvents LabelPièce As Button
    Friend WithEvents RefMvt As DataGridViewTextBoxColumn
    Friend WithEvents Libellé_Mvt As DataGridViewTextBoxColumn
    Friend WithEvents QuantitéMvt As DataGridViewTextBoxColumn
    Friend WithEvents Date_Mvt As DataGridViewTextBoxColumn
    Friend WithEvents Pièces As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Mag As DataGridViewTextBoxColumn
    Friend WithEvents PHT As DataGridViewTextBoxColumn
    Friend WithEvents MyimportDataSet As myimportDataSet
    Friend WithEvents PIECERECHANGEBindingSource As BindingSource
    Friend WithEvents PIECERECHANGETableAdapter As myimportDataSetTableAdapters.PIECERECHANGETableAdapter
End Class
