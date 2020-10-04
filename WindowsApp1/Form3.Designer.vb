<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Entrée = New Guna.UI.WinForms.GunaCircleButton()
        Me.Sortie = New Guna.UI.WinForms.GunaCircleButton()
        Me.Transfert = New Guna.UI.WinForms.GunaCircleButton()
        Me.Livraison = New Guna.UI.WinForms.GunaCircleButton()
        Me.SuspendLayout()
        '
        'Entrée
        '
        Me.Entrée.AnimationHoverSpeed = 0.07!
        Me.Entrée.AnimationSpeed = 0.03!
        Me.Entrée.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Entrée.BorderColor = System.Drawing.Color.Black
        Me.Entrée.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Entrée.FocusedColor = System.Drawing.Color.Empty
        Me.Entrée.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Entrée.ForeColor = System.Drawing.Color.White
        Me.Entrée.Image = Nothing
        Me.Entrée.ImageSize = New System.Drawing.Size(52, 52)
        Me.Entrée.Location = New System.Drawing.Point(18, 34)
        Me.Entrée.Name = "Entrée"
        Me.Entrée.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Entrée.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Entrée.OnHoverForeColor = System.Drawing.Color.White
        Me.Entrée.OnHoverImage = Nothing
        Me.Entrée.OnPressedColor = System.Drawing.Color.Black
        Me.Entrée.Size = New System.Drawing.Size(75, 75)
        Me.Entrée.TabIndex = 0
        Me.Entrée.Text = "Entrée"
        '
        'Sortie
        '
        Me.Sortie.AnimationHoverSpeed = 0.07!
        Me.Sortie.AnimationSpeed = 0.03!
        Me.Sortie.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sortie.BorderColor = System.Drawing.Color.Black
        Me.Sortie.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Sortie.FocusedColor = System.Drawing.Color.Empty
        Me.Sortie.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Sortie.ForeColor = System.Drawing.Color.White
        Me.Sortie.Image = Nothing
        Me.Sortie.ImageSize = New System.Drawing.Size(52, 52)
        Me.Sortie.Location = New System.Drawing.Point(110, 34)
        Me.Sortie.Name = "Sortie"
        Me.Sortie.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sortie.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Sortie.OnHoverForeColor = System.Drawing.Color.White
        Me.Sortie.OnHoverImage = Nothing
        Me.Sortie.OnPressedColor = System.Drawing.Color.Black
        Me.Sortie.Size = New System.Drawing.Size(75, 75)
        Me.Sortie.TabIndex = 1
        Me.Sortie.Text = "Sortie"
        '
        'Transfert
        '
        Me.Transfert.AnimationHoverSpeed = 0.07!
        Me.Transfert.AnimationSpeed = 0.03!
        Me.Transfert.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Transfert.BorderColor = System.Drawing.Color.Black
        Me.Transfert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Transfert.FocusedColor = System.Drawing.Color.Empty
        Me.Transfert.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Transfert.ForeColor = System.Drawing.Color.White
        Me.Transfert.Image = Nothing
        Me.Transfert.ImageSize = New System.Drawing.Size(52, 52)
        Me.Transfert.Location = New System.Drawing.Point(207, 34)
        Me.Transfert.Name = "Transfert"
        Me.Transfert.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Transfert.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Transfert.OnHoverForeColor = System.Drawing.Color.White
        Me.Transfert.OnHoverImage = Nothing
        Me.Transfert.OnPressedColor = System.Drawing.Color.Black
        Me.Transfert.Size = New System.Drawing.Size(75, 75)
        Me.Transfert.TabIndex = 2
        Me.Transfert.Text = "Transfert"
        '
        'Livraison
        '
        Me.Livraison.AnimationHoverSpeed = 0.07!
        Me.Livraison.AnimationSpeed = 0.03!
        Me.Livraison.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Livraison.BorderColor = System.Drawing.Color.Black
        Me.Livraison.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Livraison.FocusedColor = System.Drawing.Color.Empty
        Me.Livraison.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Livraison.ForeColor = System.Drawing.Color.White
        Me.Livraison.Image = Nothing
        Me.Livraison.ImageSize = New System.Drawing.Size(52, 52)
        Me.Livraison.Location = New System.Drawing.Point(302, 34)
        Me.Livraison.Name = "Livraison"
        Me.Livraison.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Livraison.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Livraison.OnHoverForeColor = System.Drawing.Color.White
        Me.Livraison.OnHoverImage = Nothing
        Me.Livraison.OnPressedColor = System.Drawing.Color.Black
        Me.Livraison.Size = New System.Drawing.Size(75, 75)
        Me.Livraison.TabIndex = 3
        Me.Livraison.Text = "Livraison"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 143)
        Me.Controls.Add(Me.Livraison)
        Me.Controls.Add(Me.Transfert)
        Me.Controls.Add(Me.Sortie)
        Me.Controls.Add(Me.Entrée)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisir le type de mouvement à ajouter "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Entrée As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Sortie As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Transfert As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Livraison As Guna.UI.WinForms.GunaCircleButton
End Class
