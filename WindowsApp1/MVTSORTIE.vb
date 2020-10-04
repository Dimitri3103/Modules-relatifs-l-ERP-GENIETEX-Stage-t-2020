Imports System.Data.OleDb
Public Class MVTSORTIE
    Private Sub MVTSORTIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.tMagasinGMAO'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.TMagasinGMAOTableAdapter.Fill(Me.MyimportDataSet.tMagasinGMAO)
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.PIECERECHANGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PIECERECHANGETableAdapter.Fill(Me.MyimportDataSet.PIECERECHANGE)

    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim BD As New ConnexionBaseDonnées
        Dim cmd, cmd2 As New OleDb.OleDbCommand
        Dim rowsAffected As Integer
        Try
            BD.con.Open()
            cmd.Connection = BD.con
            cmd2.Connection = BD.con
            'Insertion du mouvement de sortie avec ses infos
            cmd.CommandText = "INSERT INTO tMouvementSortie_Stock (Libellé_Mvt,RefMvt,CodeMagasin,Date_Mvt,QuantitéMvt,PHT,codearticle,heure_Mvt) 
                               VALUES (@Libellé_Mvt,@RefMvt,@CodeMagasin,@Date_Mvt,@QuantitéMvt,@PHT,@codearticle,@heure_Mvt)"
            cmd.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(LibelléMvt.Text))
            cmd.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Magasin.SelectedValue))
            cmd.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd.Parameters.AddWithValue("@PHT", DBNull.Value)
            cmd.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))
            cmd.Parameters.AddWithValue("@heure_Mvt", DBNull.Value)
            'Mise à jour du Stock d'articles en Magasin (On retranche de la quantité d'articles du mouvement de sortie)
            cmd2.CommandText = "UPDATE tStock_Articles_MagasinGMAO 
                                SET Quantité=Quantité-@QuantitéMvt,Dateheure=@Date_Mvt,PAMPAvantDernierMvt=PAMP,PrixDernierMvt=PrixDernierMvt 
                                WHERE Code_article = (SELECT codearticle FROM tMouvementSortie_Stock WHERE CodeMagasin=@CodeMagasin AND QuantitéMvt=@QuantitéMvt AND Libellé_Mvt=@Libellé_Mvt AND RefMvt=@RefMvt AND Date_Mvt=@Date_Mvt ) 
                                AND codemagasin = (SELECT CodeMagasin FROM tMouvementSortie_Stock WHERE codearticle=@codearticle AND QuantitéMvt=@QuantitéMvt AND Libellé_Mvt=@Libellé_Mvt AND RefMvt=@RefMvt AND Date_Mvt=@Date_Mvt )"
            cmd2.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Magasin.SelectedValue))
            cmd2.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
            cmd2.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(LibelléMvt.Text))
            cmd2.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd2.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd2.Parameters.AddWithValue("@codearticle", Convert.ToString(Pièce.SelectedValue))

            cmd.ExecuteNonQuery()
            rowsAffected = cmd2.ExecuteNonQuery()
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
            'Sauvegarde des modifications des infos du mouvement de sortie
            cmd.CommandText = "UPDATE tMouvementSortie_Stock 
                               SET Libellé_Mvt=@Libellé_Mvt,RefMvt=@RefMvt,CodeMagasin=@CodeMagasin,Date_Mvt=@Date_Mvt,QuantitéMvt=@QuantitéMvt,codearticle=@codearticle,heure_Mvt=@heure_Mvt
                               WHERE RefMvt=@RefMvt"
            cmd.Parameters.AddWithValue("@Libellé_Mvt", Convert.ToString(LibelléMvt.Text))
            cmd.Parameters.AddWithValue("@RefMvt", Convert.ToString(RefMvt.Text))
            cmd.Parameters.AddWithValue("@CodeMagasin", Convert.ToInt32(Magasin.SelectedValue))
            cmd.Parameters.AddWithValue("@Date_Mvt", Convert.ToDateTime(DateMvt.Value))
            cmd.Parameters.AddWithValue("@QuantitéMvt", Convert.ToInt32(Quantité.Text))
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
        imp.SetParameterValue("Magasin", Magasin.Text)
        imp.SetParameterValue("PrixAchat", "")
        IMPRESSIONBONMVT.CrystalReportViewer1.ReportSource = imp
        IMPRESSIONBONMVT.ShowDialog()
        Close()
    End Sub
End Class