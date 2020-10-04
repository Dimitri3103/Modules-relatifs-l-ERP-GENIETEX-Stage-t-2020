Imports System.Data.OleDb
Public Class MVTTRANSFERT
    Private Sub MVTTRANSFERT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.tMagasinGMAO'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.TMagasinGMAOTableAdapter.Fill(Me.MyimportDataSet.tMagasinGMAO)
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.PIECERECHANGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PIECERECHANGETableAdapter.Fill(Me.MyimportDataSet.PIECERECHANGE)


        Source.DataSource = MyimportDataSet.tMagasinGMAO
        Source.DisplayMember = "Nom_Mag"
        Source.ValueMember = "Code_Mag"
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim BD As New ConnexionBaseDonnées
        Dim cmd, cmd2, cmd3 As New OleDb.OleDbCommand
        Dim rowsAffected As Integer
        Try
            BD.con.Open()
            cmd.Connection = BD.con
            cmd2.Connection = BD.con
            cmd3.Connection = BD.con
            'Insertion du mouvement de transfert d'un magasin à un autre avec ses infos
            cmd.CommandText = "INSERT INTO tMouvementTransfert_Stock (Libellé_Mvt,RefMvt,CodeMagasin,Date_Mvt,QuantitéMvt,PHT,codearticle,heure_Mvt) 
                               VALUES (@Libellé_Mvt,@RefMvt,@CodeMagasin,@Date_Mvt,@QuantitéMvt,@PHT,@codearticle,@heure_Mvt)"
            Dim libl As String
            libl = LibelléMvt.Text + "(" + Source.Text + ")"
            cmd.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(libl))
            cmd.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Destination.SelectedValue))
            cmd.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd.Parameters.AddWithValue("@PHT", Convert.ToDecimal(PrixAchat.Text))
            cmd.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))
            cmd.Parameters.AddWithValue("@heure_Mvt", DBNull.Value)
            'Mise à jour du Stock d'articles du Magasin Source (On retranche de la quantité d'articles du mouvement de transfert)
            cmd2.CommandText = "UPDATE tStock_Articles_MagasinGMAO 
                                SET Quantité=Quantité-@QuantitéMvt,Dateheure=@Date_Mvt
                                WHERE Code_article = (SELECT codearticle FROM tMouvementTransfert_Stock WHERE CodeMagasin=@Destination AND QuantitéMvt=@QuantitéMvt AND Libellé_Mvt=@Libellé_Mvt AND RefMvt=@RefMvt AND Date_Mvt=@Date_Mvt ) 
                                AND codemagasin = @Source"
            cmd2.Parameters.AddWithValue("@Source", Convert.ToInt32(Source.SelectedValue))
            cmd2.Parameters.AddWithValue("@Destination", Convert.ToInt32(Destination.SelectedValue))
            cmd2.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd2.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(libl))
            cmd2.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd2.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd2.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))
            'Mise à jour du Stock d'articles du Magasin de destination (Calcul du nouveau PAMP et ajout de la quantité d'articles du mouvement de transfert) 
            cmd3.CommandText = "UPDATE tStock_Articles_MagasinGMAO 
                                SET Quantité=Quantité+@QuantitéMvt , PAMP=(Quantité*PAMP+@PHT)/(Quantité+@QuantitéMvt),Dateheure=@Date_Mvt,PrixDernierMvt=PAMP*Quantité,PAMPAvantDernierMvt=PAMP
                                WHERE Code_article = (SELECT codearticle FROM tMouvementTransfert_Stock WHERE CodeMagasin=@CodeMagasin AND QuantitéMvt=@QuantitéMvt AND PHT=@PHT AND Libellé_Mvt=@Libellé_Mvt AND RefMvt=@RefMvt AND Date_Mvt=@Date_Mvt ) 
                                AND codemagasin = (SELECT CodeMagasin FROM tMouvementTransfert_Stock WHERE codearticle=@codearticle AND QuantitéMvt=@QuantitéMvt AND PHT=@PHT AND Libellé_Mvt=@Libellé_Mvt AND RefMvt=@RefMvt AND Date_Mvt=@Date_Mvt )"
            cmd3.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Destination.SelectedValue))
            cmd3.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd3.Parameters.AddWithValue("@PHT", Convert.ToDecimal(PrixAchat.Text))
            cmd3.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(libl))
            cmd3.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd3.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd3.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))

            cmd.ExecuteNonQuery()
            rowsAffected = cmd2.ExecuteNonQuery()
            rowsAffected = cmd3.ExecuteNonQuery()
            BD.con.Close()
            MessageBox.Show("Mouvement Ajouté")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Form2.load_data()
        Close()
    End Sub

    Private Sub Sauvegarder_Click(sender As Object, e As EventArgs) Handles Sauvegarder.Click
        Dim BD As New ConnexionBaseDonnées
        Dim cmd As New OleDb.OleDbCommand
        Try
            BD.con.Open()
            cmd.Connection = BD.con
            'Sauvegarde des modifications des infos du mouvement de transfert
            cmd.CommandText = "UPDATE tMouvementTransfert_Stock SET Libellé_Mvt=@Libellé_Mvt,RefMvt=@RefMvt,CodeMagasin=@CodeMagasin,Date_Mvt=@Date_Mvt,QuantitéMvt=@QuantitéMvt,PHT=@PHT,codearticle=@codearticle,heure_Mvt=@heure_Mvt WHERE RefMvt=@RefMvt"
            cmd.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(LibelléMvt.Text))
            cmd.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Destination.SelectedValue))
            cmd.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd.Parameters.AddWithValue("@PHT", Convert.ToDecimal(PrixAchat.Text))
            cmd.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))
            cmd.Parameters.AddWithValue("@heure_Mvt", DBNull.Value)

            cmd.ExecuteNonQuery()
            BD.con.Close()
            MessageBox.Show("Modification Réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Form2.load_data()
        Close()
    End Sub

    Private Sub Imprimer_Click(sender As Object, e As EventArgs) Handles Imprimer.Click
        Dim imp As New CrystalReport1
        imp.SetParameterValue("Réf", RefMvt.Text)
        imp.SetParameterValue("Libellé", LibelléMvt.Text)
        imp.SetParameterValue("Qté", Quantité.Text)
        imp.SetParameterValue("Date", DateMvt.Value)
        imp.SetParameterValue("Pièce", Pièce.Text)
        imp.SetParameterValue("Magasin", Destination.Text)
        IMPRESSIONBONMVT.CrystalReportViewer1.ReportSource = imp
        IMPRESSIONBONMVT.ShowDialog()
        Close()
    End Sub
End Class