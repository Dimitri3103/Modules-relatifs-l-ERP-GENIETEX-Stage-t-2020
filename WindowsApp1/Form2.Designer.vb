<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Livraisons = New System.Windows.Forms.CheckBox()
        Me.MvtsTransfert = New System.Windows.Forms.CheckBox()
        Me.MvtsSortie = New System.Windows.Forms.CheckBox()
        Me.MvtsEntrée = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RefMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelléMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMvt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pièce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Magasin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteAvant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteAprès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHTAvant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHTAprès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAMPAvant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAMPAprès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modifier = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Supprimer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÉtatDeStockDesMagasinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉtatDeStockDesArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesMouvementsDesArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Livraisons
        '
        Me.Livraisons.AutoSize = True
        Me.Livraisons.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Livraisons.Location = New System.Drawing.Point(668, 42)
        Me.Livraisons.Name = "Livraisons"
        Me.Livraisons.Size = New System.Drawing.Size(164, 21)
        Me.Livraisons.TabIndex = 648
        Me.Livraisons.Text = "Livraisons Fournisseurs"
        Me.Livraisons.UseVisualStyleBackColor = True
        '
        'MvtsTransfert
        '
        Me.MvtsTransfert.AutoSize = True
        Me.MvtsTransfert.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MvtsTransfert.Location = New System.Drawing.Point(559, 42)
        Me.MvtsTransfert.Name = "MvtsTransfert"
        Me.MvtsTransfert.Size = New System.Drawing.Size(84, 21)
        Me.MvtsTransfert.TabIndex = 647
        Me.MvtsTransfert.Text = "Transferts"
        Me.MvtsTransfert.UseVisualStyleBackColor = True
        '
        'MvtsSortie
        '
        Me.MvtsSortie.AutoSize = True
        Me.MvtsSortie.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MvtsSortie.Location = New System.Drawing.Point(457, 42)
        Me.MvtsSortie.Name = "MvtsSortie"
        Me.MvtsSortie.Size = New System.Drawing.Size(67, 21)
        Me.MvtsSortie.TabIndex = 646
        Me.MvtsSortie.Text = "Sorties"
        Me.MvtsSortie.UseVisualStyleBackColor = True
        '
        'MvtsEntrée
        '
        Me.MvtsEntrée.AutoSize = True
        Me.MvtsEntrée.Checked = True
        Me.MvtsEntrée.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MvtsEntrée.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MvtsEntrée.Location = New System.Drawing.Point(348, 42)
        Me.MvtsEntrée.Name = "MvtsEntrée"
        Me.MvtsEntrée.Size = New System.Drawing.Size(72, 21)
        Me.MvtsEntrée.TabIndex = 645
        Me.MvtsEntrée.Text = "Entrées"
        Me.MvtsEntrée.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefMvt, Me.LibelléMvt, Me.QteMvt, Me.DateMvt, Me.Pièce, Me.Magasin, Me.PA, Me.QteAvant, Me.QteAprès, Me.PHTAvant, Me.PHTAprès, Me.PAMPAvant, Me.PAMPAprès, Me.Modifier, Me.Supprimer})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1365, 394)
        Me.DataGridView1.TabIndex = 638
        '
        'RefMvt
        '
        Me.RefMvt.DataPropertyName = "RefMvt"
        Me.RefMvt.HeaderText = "Référence Mouvement"
        Me.RefMvt.Name = "RefMvt"
        Me.RefMvt.ReadOnly = True
        '
        'LibelléMvt
        '
        Me.LibelléMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LibelléMvt.DataPropertyName = "Libellé_Mvt"
        Me.LibelléMvt.HeaderText = "Libellé Mouvement"
        Me.LibelléMvt.Name = "LibelléMvt"
        Me.LibelléMvt.ReadOnly = True
        Me.LibelléMvt.Width = 141
        '
        'QteMvt
        '
        Me.QteMvt.DataPropertyName = "QuantitéMvt"
        Me.QteMvt.HeaderText = "Quantité Mouvement"
        Me.QteMvt.Name = "QteMvt"
        Me.QteMvt.ReadOnly = True
        '
        'DateMvt
        '
        Me.DateMvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateMvt.DataPropertyName = "Date_Mvt"
        Me.DateMvt.HeaderText = "Date Mouvement"
        Me.DateMvt.Name = "DateMvt"
        Me.DateMvt.ReadOnly = True
        Me.DateMvt.Width = 134
        '
        'Pièce
        '
        Me.Pièce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Pièce.DataPropertyName = "Designation"
        Me.Pièce.HeaderText = "Pièce"
        Me.Pièce.Name = "Pièce"
        Me.Pièce.ReadOnly = True
        Me.Pièce.Width = 68
        '
        'Magasin
        '
        Me.Magasin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Magasin.DataPropertyName = "Nom_Mag"
        Me.Magasin.HeaderText = "Magasin"
        Me.Magasin.Name = "Magasin"
        Me.Magasin.Width = 87
        '
        'PA
        '
        Me.PA.DataPropertyName = "PHT"
        Me.PA.HeaderText = "Prix Achat"
        Me.PA.Name = "PA"
        Me.PA.ReadOnly = True
        '
        'QteAvant
        '
        Me.QteAvant.DataPropertyName = "QteAvant"
        Me.QteAvant.HeaderText = "QteAvant"
        Me.QteAvant.Name = "QteAvant"
        Me.QteAvant.Visible = False
        '
        'QteAprès
        '
        Me.QteAprès.DataPropertyName = "QteAprès"
        Me.QteAprès.HeaderText = "QteAprès"
        Me.QteAprès.Name = "QteAprès"
        Me.QteAprès.Visible = False
        '
        'PHTAvant
        '
        Me.PHTAvant.DataPropertyName = "PHTAvant"
        Me.PHTAvant.HeaderText = "PHTAvant"
        Me.PHTAvant.Name = "PHTAvant"
        Me.PHTAvant.Visible = False
        '
        'PHTAprès
        '
        Me.PHTAprès.DataPropertyName = "PHTAprès"
        Me.PHTAprès.HeaderText = "PHTAprès"
        Me.PHTAprès.Name = "PHTAprès"
        Me.PHTAprès.Visible = False
        '
        'PAMPAvant
        '
        Me.PAMPAvant.DataPropertyName = "PAMPAvant"
        Me.PAMPAvant.HeaderText = "PAMPAvant"
        Me.PAMPAvant.Name = "PAMPAvant"
        Me.PAMPAvant.Visible = False
        '
        'PAMPAprès
        '
        Me.PAMPAprès.DataPropertyName = "PAMPAprès"
        Me.PAMPAprès.HeaderText = "PAMPAprès"
        Me.PAMPAprès.Name = "PAMPAprès"
        Me.PAMPAprès.Visible = False
        '
        'Modifier
        '
        Me.Modifier.HeaderText = "Modifier"
        Me.Modifier.Name = "Modifier"
        '
        'Supprimer
        '
        Me.Supprimer.HeaderText = "Supprimer"
        Me.Supprimer.Name = "Supprimer"
        '
        'Button50
        '
        Me.Button50.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button50.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button50.ForeColor = System.Drawing.Color.White
        Me.Button50.Location = New System.Drawing.Point(12, 33)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(169, 26)
        Me.Button50.TabIndex = 643
        Me.Button50.Text = "Ajouter un Mouvement"
        Me.Button50.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÉtatDeStockDesMagasinsToolStripMenuItem, Me.ÉtatDeStockDesArticlesToolStripMenuItem, Me.ListeDesMouvementsDesArticlesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.MenuStrip1.TabIndex = 649
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ÉtatDeStockDesMagasinsToolStripMenuItem
        '
        Me.ÉtatDeStockDesMagasinsToolStripMenuItem.Name = "ÉtatDeStockDesMagasinsToolStripMenuItem"
        Me.ÉtatDeStockDesMagasinsToolStripMenuItem.Size = New System.Drawing.Size(195, 21)
        Me.ÉtatDeStockDesMagasinsToolStripMenuItem.Text = "État de Stock des Magasins"
        '
        'ÉtatDeStockDesArticlesToolStripMenuItem
        '
        Me.ÉtatDeStockDesArticlesToolStripMenuItem.Name = "ÉtatDeStockDesArticlesToolStripMenuItem"
        Me.ÉtatDeStockDesArticlesToolStripMenuItem.Size = New System.Drawing.Size(176, 21)
        Me.ÉtatDeStockDesArticlesToolStripMenuItem.Text = "État de Stock des Pièces"
        '
        'ListeDesMouvementsDesArticlesToolStripMenuItem
        '
        Me.ListeDesMouvementsDesArticlesToolStripMenuItem.Name = "ListeDesMouvementsDesArticlesToolStripMenuItem"
        Me.ListeDesMouvementsDesArticlesToolStripMenuItem.Size = New System.Drawing.Size(230, 21)
        Me.ListeDesMouvementsDesArticlesToolStripMenuItem.Text = "Liste des Mouvements des Pièces"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 450)
        Me.Controls.Add(Me.Livraisons)
        Me.Controls.Add(Me.MvtsTransfert)
        Me.Controls.Add(Me.MvtsSortie)
        Me.Controls.Add(Me.MvtsEntrée)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste Des Mouvements"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Livraisons As CheckBox
    Friend WithEvents MvtsTransfert As CheckBox
    Friend WithEvents MvtsSortie As CheckBox
    Friend WithEvents MvtsEntrée As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents Button50 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ÉtatDeStockDesMagasinsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉtatDeStockDesArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesMouvementsDesArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefMvt As DataGridViewTextBoxColumn
    Friend WithEvents LibelléMvt As DataGridViewTextBoxColumn
    Friend WithEvents QteMvt As DataGridViewTextBoxColumn
    Friend WithEvents DateMvt As DataGridViewTextBoxColumn
    Friend WithEvents Pièce As DataGridViewTextBoxColumn
    Friend WithEvents Magasin As DataGridViewTextBoxColumn
    Friend WithEvents PA As DataGridViewTextBoxColumn
    Friend WithEvents QteAvant As DataGridViewTextBoxColumn
    Friend WithEvents QteAprès As DataGridViewTextBoxColumn
    Friend WithEvents PHTAvant As DataGridViewTextBoxColumn
    Friend WithEvents PHTAprès As DataGridViewTextBoxColumn
    Friend WithEvents PAMPAvant As DataGridViewTextBoxColumn
    Friend WithEvents PAMPAprès As DataGridViewTextBoxColumn
    Friend WithEvents Modifier As DataGridViewButtonColumn
    Friend WithEvents Supprimer As DataGridViewButtonColumn
End Class
