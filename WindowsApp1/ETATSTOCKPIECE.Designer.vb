<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ETATSTOCKPIECE
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
        Me.EtatStockPièce = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Mag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dateheure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDernierMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAMPAvantDernierMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImprimerEtatStockPièce = New System.Windows.Forms.Button()
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
        'EtatStockPièce
        '
        Me.EtatStockPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EtatStockPièce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EtatStockPièce.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatStockPièce.ForeColor = System.Drawing.Color.White
        Me.EtatStockPièce.Location = New System.Drawing.Point(438, 12)
        Me.EtatStockPièce.Name = "EtatStockPièce"
        Me.EtatStockPièce.Size = New System.Drawing.Size(100, 26)
        Me.EtatStockPièce.TabIndex = 680
        Me.EtatStockPièce.Text = "Afficher Etat"
        Me.EtatStockPièce.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Designation, Me.Nom_Mag, Me.Libelle_Stock, Me.Quantité, Me.PAMP, Me.Dateheure, Me.PrixDernierMvt, Me.PAMPAvantDernierMvt})
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
        Me.DataGridView1.Size = New System.Drawing.Size(1070, 394)
        Me.DataGridView1.TabIndex = 679
        '
        'Designation
        '
        Me.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Designation.DataPropertyName = "Designation"
        Me.Designation.HeaderText = "Pièce"
        Me.Designation.Name = "Designation"
        Me.Designation.ReadOnly = True
        Me.Designation.Width = 68
        '
        'Nom_Mag
        '
        Me.Nom_Mag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nom_Mag.DataPropertyName = "Nom_Mag"
        Me.Nom_Mag.HeaderText = "Magasin"
        Me.Nom_Mag.Name = "Nom_Mag"
        Me.Nom_Mag.ReadOnly = True
        Me.Nom_Mag.Width = 87
        '
        'Libelle_Stock
        '
        Me.Libelle_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Libelle_Stock.DataPropertyName = "Libelle_Stock"
        Me.Libelle_Stock.HeaderText = "Libellé Stock"
        Me.Libelle_Stock.Name = "Libelle_Stock"
        Me.Libelle_Stock.ReadOnly = True
        Me.Libelle_Stock.Width = 103
        '
        'Quantité
        '
        Me.Quantité.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantité.DataPropertyName = "Quantité"
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        Me.Quantité.ReadOnly = True
        Me.Quantité.Width = 90
        '
        'PAMP
        '
        Me.PAMP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PAMP.DataPropertyName = "PAMP"
        Me.PAMP.HeaderText = "PAMP"
        Me.PAMP.Name = "PAMP"
        Me.PAMP.ReadOnly = True
        Me.PAMP.Width = 69
        '
        'Dateheure
        '
        Me.Dateheure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Dateheure.DataPropertyName = "Dateheure"
        Me.Dateheure.HeaderText = "Date "
        Me.Dateheure.Name = "Dateheure"
        Me.Dateheure.Width = 69
        '
        'PrixDernierMvt
        '
        Me.PrixDernierMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrixDernierMvt.DataPropertyName = "PrixDernierMvt"
        Me.PrixDernierMvt.HeaderText = "Prix Dernier Mouvement"
        Me.PrixDernierMvt.Name = "PrixDernierMvt"
        Me.PrixDernierMvt.ReadOnly = True
        Me.PrixDernierMvt.Width = 168
        '
        'PAMPAvantDernierMvt
        '
        Me.PAMPAvantDernierMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PAMPAvantDernierMvt.DataPropertyName = "PAMPAvantDernierMvt"
        Me.PAMPAvantDernierMvt.HeaderText = "PAMP Avant Dernier Mouvement"
        Me.PAMPAvantDernierMvt.Name = "PAMPAvantDernierMvt"
        Me.PAMPAvantDernierMvt.Width = 221
        '
        'ImprimerEtatStockPièce
        '
        Me.ImprimerEtatStockPièce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImprimerEtatStockPièce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImprimerEtatStockPièce.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimerEtatStockPièce.ForeColor = System.Drawing.Color.White
        Me.ImprimerEtatStockPièce.Location = New System.Drawing.Point(578, 12)
        Me.ImprimerEtatStockPièce.Name = "ImprimerEtatStockPièce"
        Me.ImprimerEtatStockPièce.Size = New System.Drawing.Size(100, 26)
        Me.ImprimerEtatStockPièce.TabIndex = 678
        Me.ImprimerEtatStockPièce.Text = "Imprimer"
        Me.ImprimerEtatStockPièce.UseVisualStyleBackColor = False
        '
        'Pièce
        '
        Me.Pièce.DataSource = Me.PIECERECHANGEBindingSource
        Me.Pièce.DisplayMember = "Designation"
        Me.Pièce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Pièce.FormattingEnabled = True
        Me.Pièce.Location = New System.Drawing.Point(130, 16)
        Me.Pièce.Name = "Pièce"
        Me.Pièce.Size = New System.Drawing.Size(259, 21)
        Me.Pièce.TabIndex = 677
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
        Me.LabelPièce.TabIndex = 676
        Me.LabelPièce.Text = "Pièce :"
        Me.LabelPièce.UseVisualStyleBackColor = False
        '
        'PIECERECHANGETableAdapter
        '
        Me.PIECERECHANGETableAdapter.ClearBeforeFill = True
        '
        'ETATSTOCKPIECE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 450)
        Me.Controls.Add(Me.EtatStockPièce)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ImprimerEtatStockPièce)
        Me.Controls.Add(Me.Pièce)
        Me.Controls.Add(Me.LabelPièce)
        Me.Name = "ETATSTOCKPIECE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "État de stock dans tous les magasins pour une pièce sélectionnée"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIECERECHANGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyimportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents EtatStockPièce As Button
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents ImprimerEtatStockPièce As Button
    Friend WithEvents Pièce As ComboBox
    Private WithEvents LabelPièce As Button
    Friend WithEvents Designation As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Mag As DataGridViewTextBoxColumn
    Friend WithEvents Libelle_Stock As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents PAMP As DataGridViewTextBoxColumn
    Friend WithEvents Dateheure As DataGridViewTextBoxColumn
    Friend WithEvents PrixDernierMvt As DataGridViewTextBoxColumn
    Friend WithEvents PAMPAvantDernierMvt As DataGridViewTextBoxColumn
    Friend WithEvents MyimportDataSet As myimportDataSet
    Friend WithEvents PIECERECHANGEBindingSource As BindingSource
    Friend WithEvents PIECERECHANGETableAdapter As myimportDataSetTableAdapters.PIECERECHANGETableAdapter
End Class
