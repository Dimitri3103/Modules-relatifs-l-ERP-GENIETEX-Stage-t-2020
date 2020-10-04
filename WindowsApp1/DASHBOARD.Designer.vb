<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DASHBOARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DASHBOARD))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnMessages = New System.Windows.Forms.Button()
        Me.btnForum = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(54, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 56)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(54, 437)
        Me.Panel1.TabIndex = 3
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.Button1)
        Me.pnlDashboard.Controls.Add(Me.btnCalendar)
        Me.pnlDashboard.Controls.Add(Me.btnCourses)
        Me.pnlDashboard.Controls.Add(Me.btnMessages)
        Me.pnlDashboard.Controls.Add(Me.btnForum)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(701, 437)
        Me.pnlDashboard.TabIndex = 5
        '
        'Button8
        '
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button8.Image = Global.WindowsApp1.My.Resources.Resources.Settings
        Me.Button8.Location = New System.Drawing.Point(545, 8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(31, 37)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(476, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button7.Image = Global.WindowsApp1.My.Resources.Resources.LogOut
        Me.Button7.Location = New System.Drawing.Point(582, 9)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(31, 37)
        Me.Button7.TabIndex = 12
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.Image = Global.WindowsApp1.My.Resources.Resources.Dashboard
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(6, 9)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(114, 40)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   Accueil"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(102, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 110)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "   Fournisseurs"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCalendar
        '
        Me.btnCalendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnCalendar.FlatAppearance.BorderSize = 0
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalendar.Image = CType(resources.GetObject("btnCalendar.Image"), System.Drawing.Image)
        Me.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalendar.Location = New System.Drawing.Point(104, 84)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(260, 110)
        Me.btnCalendar.TabIndex = 1
        Me.btnCalendar.Text = "    Magasins et Stocks "
        Me.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalendar.UseVisualStyleBackColor = False
        '
        'btnCourses
        '
        Me.btnCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnCourses.FlatAppearance.BorderSize = 0
        Me.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourses.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourses.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCourses.Image = CType(resources.GetObject("btnCourses.Image"), System.Drawing.Image)
        Me.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourses.Location = New System.Drawing.Point(370, 84)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(260, 110)
        Me.btnCourses.TabIndex = 3
        Me.btnCourses.Text = "   Inventaire"
        Me.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourses.UseVisualStyleBackColor = False
        '
        'btnMessages
        '
        Me.btnMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnMessages.FlatAppearance.BorderSize = 0
        Me.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessages.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessages.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMessages.Image = CType(resources.GetObject("btnMessages.Image"), System.Drawing.Image)
        Me.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMessages.Location = New System.Drawing.Point(370, 200)
        Me.btnMessages.Name = "btnMessages"
        Me.btnMessages.Size = New System.Drawing.Size(260, 110)
        Me.btnMessages.TabIndex = 4
        Me.btnMessages.Text = "   États et Impressions"
        Me.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMessages.UseVisualStyleBackColor = False
        '
        'btnForum
        '
        Me.btnForum.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnForum.FlatAppearance.BorderSize = 0
        Me.btnForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForum.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnForum.Image = CType(resources.GetObject("btnForum.Image"), System.Drawing.Image)
        Me.btnForum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnForum.Location = New System.Drawing.Point(235, 316)
        Me.btnForum.Name = "btnForum"
        Me.btnForum.Size = New System.Drawing.Size(260, 110)
        Me.btnForum.TabIndex = 5
        Me.btnForum.Text = "   Tableaux de bord"
        Me.btnForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnForum.UseVisualStyleBackColor = False
        '
        'DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 437)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DASHBOARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DASHBOARD"
        Me.Panel2.ResumeLayout(False)
        Me.pnlDashboard.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnForum As Button
    Friend WithEvents btnMessages As Button
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCourses As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Button1 As Button
End Class
