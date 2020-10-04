Imports System.Data.OleDb
Public Class Form2
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Form3.ShowDialog()
    End Sub

    Private Sub ÉtatDeStockDesMagasinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉtatDeStockDesMagasinsToolStripMenuItem.Click
        ETATSTOCKMAGASIN.ShowDialog()
    End Sub

    Private Sub ÉtatDeStockDesPiècesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉtatDeStockDesArticlesToolStripMenuItem.Click
        ETATSTOCKPIECE.ShowDialog()
    End Sub

    Private Sub ListeDesMouvementsDesPiècesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesMouvementsDesArticlesToolStripMenuItem.Click
        LISTEMVTSPIECES.ShowDialog()
    End Sub

    Private Sub MvtsEntrée_CheckedChanged(sender As Object, e As EventArgs) Handles MvtsEntrée.CheckedChanged
        If MvtsEntrée.Checked = True Then
            MvtsSortie.Checked = False
            MvtsTransfert.Checked = False
            Livraisons.Checked = False
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementEntree_Stock.RefMvt,tMouvementEntree_Stock.Libellé_Mvt,tMouvementEntree_Stock.QuantitéMvt,tMouvementEntree_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementEntree_Stock.PHT,
			                   tStock_Articles_MagasinGMAO.Quantité-tMouvementEntree_Stock.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,(tStock_Articles_MagasinGMAO.Quantité-tMouvementEntree_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.Quantité*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementEntree_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementEntree_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementEntree_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub MvtsSortie_CheckedChanged(sender As Object, e As EventArgs) Handles MvtsSortie.CheckedChanged
        If MvtsSortie.Checked = True Then
            MvtsEntrée.Checked = False
            MvtsTransfert.Checked = False
            Livraisons.Checked = False
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementSortie_Stock.RefMvt,tMouvementSortie_Stock.Libellé_Mvt,tMouvementSortie_Stock.QuantitéMvt,tMouvementSortie_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementSortie_Stock.PHT,
			                   tStock_Articles_MagasinGMAO.Quantité+tMouvementSortie_Stock.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,tStock_Articles_MagasinGMAO.PrixDernierMvt,(tStock_Articles_MagasinGMAO.Quantité+tMouvementSortie_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementSortie_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementSortie_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementSortie_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub MvtsTransfert_CheckedChanged(sender As Object, e As EventArgs) Handles MvtsTransfert.CheckedChanged
        If MvtsTransfert.Checked = True Then
            MvtsEntrée.Checked = False
            MvtsSortie.Checked = False
            Livraisons.Checked = False
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementTransfert_Stock.RefMvt,tMouvementTransfert_Stock.Libellé_Mvt,tMouvementTransfert_Stock.QuantitéMvt,tMouvementTransfert_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementTransfert_Stock.PHT,
			                    tStock_Articles_MagasinGMAO.Quantité-tMouvementTransfert_Stock.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,(tStock_Articles_MagasinGMAO.Quantité-tMouvementTransfert_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.Quantité*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementTransfert_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementTransfert_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementTransfert_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub Livraisons_CheckedChanged(sender As Object, e As EventArgs) Handles Livraisons.CheckedChanged
        If Livraisons.Checked = True Then
            MvtsEntrée.Checked = False
            MvtsSortie.Checked = False
            MvtsTransfert.Checked = False
        End If
    End Sub

    Public Sub load_data()
        If MvtsEntrée.Checked = True Then
            MvtsSortie.Checked = False
            MvtsTransfert.Checked = False
            Livraisons.Checked = False
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementEntree_Stock.RefMvt,tMouvementEntree_Stock.Libellé_Mvt,tMouvementEntree_Stock.QuantitéMvt,tMouvementEntree_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementEntree_Stock.PHT,
			                   tStock_Articles_MagasinGMAO.Quantité-tMouvementEntree_Stock.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,(tStock_Articles_MagasinGMAO.Quantité-tMouvementEntree_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.Quantité*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementEntree_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementEntree_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementEntree_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        ElseIf MvtsSortie.Checked = True Then
            MvtsEntrée.Checked = False
            MvtsTransfert.Checked = False
            Livraisons.Checked = False
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementSortie_Stock.RefMvt,tMouvementSortie_Stock.Libellé_Mvt,tMouvementSortie_Stock.QuantitéMvt,tMouvementSortie_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementSortie_Stock.PHT,
			                   tStock_Articles_MagasinGMAO.Quantité+tStock_Articles_MagasinGMAO.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,tStock_Articles_MagasinGMAO.PrixDernierMvt,(tStock_Articles_MagasinGMAO.Quantité+tMouvementSortie_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementSortie_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementSortie_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementSortie_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        ElseIf MvtsTransfert.Checked = True Then
            Dim BD As New ConnexionBaseDonnées
            Dim dt As New DataTable
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand
            With dt
                .Columns.Add("RefMvt")
                .Columns.Add("Libellé_Mvt")
                .Columns.Add("QuantitéMvt")
                .Columns.Add("Date_Mvt")
                .Columns.Add("Designation")
                .Columns.Add("Nom_Mag")
                .Columns.Add("PHT")
                .Columns.Add("QteAvant")
                .Columns.Add("QteAprès")
                .Columns.Add("PHTAvant")
                .Columns.Add("PHTAprès")
                .Columns.Add("PAMPAvant")
                .Columns.Add("PAMPAprès")
            End With
            cmd.CommandText = "SELECT tMouvementTransfert_Stock.RefMvt,tMouvementTransfert_Stock.Libellé_Mvt,tMouvementTransfert_Stock.QuantitéMvt,tMouvementTransfert_Stock.Date_Mvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementTransfert_Stock.PHT,
			                    tStock_Articles_MagasinGMAO.Quantité-tMouvementTransfert_Stock.QuantitéMvt,tStock_Articles_MagasinGMAO.Quantité,(tStock_Articles_MagasinGMAO.Quantité-tMouvementTransfert_Stock.QuantitéMvt)*tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.Quantité*tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt,tStock_Articles_MagasinGMAO.PAMP
                               FROM tMouvementTransfert_Stock,PIECERECHANGE,tMagasinGMAO,tStock_Articles_MagasinGMAO 
                               WHERE tMouvementTransfert_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementTransfert_Stock.codearticle=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag"
            cmd.Connection = BD.con
            BD.con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                dt.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
            End While
            dr.Close()
            BD.con.Close()
            DataGridView1.DataSource = dt
        ElseIf Livraisons.Checked = True Then
            MvtsEntrée.Checked = False
            MvtsSortie.Checked = False
            MvtsTransfert.Checked = False
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        row = DataGridView1.CurrentRow
        'Bouton Modifier du DatagridView
        If row.Cells("Modifier").Selected Then
            If MvtsEntrée.Checked = True Then
                Dim F1 As New MVTENTREE
                F1.RefMvt.Text = row.Cells("RefMvt").Value
                F1.LibelléMvt.Text = row.Cells("LibelléMvt").Value
                F1.Quantité.Text = row.Cells("QteMvt").Value
                F1.DateMvt.Value = row.Cells("DateMvt").Value
                F1.Pièce.Text = row.Cells("Pièce").Value
                F1.Magasin.Text = row.Cells("Magasin").Value
                F1.PrixAchat.Text = row.Cells("PA").Value
                F1.QteAvant.Text = row.Cells("QteAvant").Value
                F1.QteAprès.Text = row.Cells("QteAprès").Value
                F1.PHTAvant.Text = row.Cells("PHTAvant").Value
                F1.PHTAprès.Text = row.Cells("PHTAprès").Value
                F1.PAMPAvant.Text = row.Cells("PAMPAvant").Value
                F1.PAMPAprès.Text = row.Cells("PAMPAprès").Value
                F1.ShowDialog()
            ElseIf MvtsSortie.Checked = True Then
                Dim F2 As New MVTSORTIE
                F2.RefMvt.Text = row.Cells("RefMvt").Value
                F2.LibelléMvt.Text = row.Cells("LibelléMvt").Value
                F2.Quantité.Text = row.Cells("QteMvt").Value
                F2.DateMvt.Value = row.Cells("DateMvt").Value
                F2.Pièce.Text = row.Cells("Pièce").Value
                F2.Magasin.Text = row.Cells("Magasin").Value
                F2.QteAvant.Text = row.Cells("QteAvant").Value
                F2.QteAprès.Text = row.Cells("QteAprès").Value
                F2.PHT.Text = row.Cells("PHTAprès").Value
                F2.PAMP.Text = row.Cells("PAMPAprès").Value
                F2.ShowDialog()
            ElseIf MvtsTransfert.Checked = True Then
                Dim F3 As New MVTTRANSFERT
                F3.RefMvt.Text = row.Cells("RefMvt").Value
                F3.LibelléMvt.Text = row.Cells("LibelléMvt").Value
                F3.Quantité.Text = row.Cells("QteMvt").Value
                F3.DateMvt.Value = row.Cells("DateMvt").Value
                F3.Pièce.Text = row.Cells("Pièce").Value
                F3.Destination.Text = row.Cells("Magasin").Value
                F3.PrixAchat.Text = row.Cells("PA").Value
                F3.QteAvant.Text = row.Cells("QteAvant").Value
                F3.QteAprès.Text = row.Cells("QteAprès").Value
                F3.PHTAvant.Text = row.Cells("PHTAvant").Value
                F3.PHTAprès.Text = row.Cells("PHTAprès").Value
                F3.PAMPAvant.Text = row.Cells("PAMPAvant").Value
                F3.PAMPAprès.Text = row.Cells("PAMPAprès").Value
                F3.ShowDialog()
            End If
        End If
        'Bouton Supprimer du DatagridView
        If row.Cells("Supprimer").Selected Then
            If MessageBox.Show("Etes vous sûr de vouloir supprimer cette ligne ?", "Message", MessageBoxButtons.YesNo).Equals(DialogResult.Yes) Then
                Dim BD As New ConnexionBaseDonnées
                Dim cmd, cmd2, cmd3 As New OleDb.OleDbCommand
                Dim rowsAffected As Integer
                If MvtsEntrée.Checked = True Then
                    Try
                        BD.con.Open()
                        cmd.Connection = BD.con
                        cmd2.Connection = BD.con
                        'Régularisation du stock dans le magasin où on veut supprimer le mouvement d'entrée d'articles (on diminue la quantité d'articles entrée en stock)
                        cmd.CommandText = "UPDATE tStock_Articles_MagasinGMAO
                                           SET Quantité=Quantité-@QuantitéMvt
                                           WHERE Code_article = (SELECT codearticle FROM tMouvementEntree_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT)
                                           AND codemagasin = (SELECT CodeMagasin FROM tMouvementEntree_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT) "
                        cmd.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        cmd.Parameters.AddWithValue("@PHT", row.Cells("PA").Value)
                        'Suppression du mouvement d'entrée d'articles
                        cmd2.CommandText = "DELETE FROM tMouvementEntree_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT"
                        cmd2.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd2.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd2.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd2.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        cmd2.Parameters.AddWithValue("@PHT", row.Cells("PA").Value)

                        rowsAffected = cmd.ExecuteNonQuery
                        cmd2.ExecuteNonQuery()
                        BD.con.Close()
                        DataGridView1.Rows.Remove(row)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                ElseIf MvtsSortie.Checked = True Then
                    Try
                        BD.con.Open()
                        cmd.Connection = BD.con
                        cmd2.Connection = BD.con
                        'Régularisation du stock dans le magasin où on veut supprimer le mouvement de sortie d'articles (on augmente la quantité d'articles sortie du stock)
                        cmd.CommandText = "UPDATE tStock_Articles_MagasinGMAO
                                           SET Quantité=Quantité+@QuantitéMvt
                                           WHERE Code_article = (SELECT codearticle FROM tMouvementSortie_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt )
                                           AND codemagasin = (SELECT CodeMagasin FROM tMouvementSortie_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt ) "
                        cmd.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        'Suppression du mouvement de sortie d'articles
                        cmd2.CommandText = "DELETE FROM tMouvementSortie_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt"
                        cmd2.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd2.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd2.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd2.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)

                        rowsAffected = cmd.ExecuteNonQuery
                        cmd2.ExecuteNonQuery()
                        BD.con.Close()
                        DataGridView1.Rows.Remove(row)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf MvtsTransfert.Checked = True Then
                    Try
                        BD.con.Open()
                        cmd.Connection = BD.con
                        'cmd2.Connection = BD.con
                        cmd3.Connection = BD.con
                        'Régularisation du stock dans le magasin Destination (on diminue la quantité d'articles entrée en stock)
                        cmd.CommandText = "UPDATE tStock_Articles_MagasinGMAO
                                           SET Quantité=Quantité-@QuantitéMvt
                                           WHERE Code_article = (SELECT codearticle FROM tMouvementTransfert_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT)
                                           AND codemagasin = (SELECT CodeMagasin FROM tMouvementTransfert_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT) "
                        cmd.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        cmd.Parameters.AddWithValue("@PHT", row.Cells("PA").Value)
                        'Régularisation du stock dans le magasin source (on augmente la quantité d'articles sortie du stock)
                        cmd2.CommandText = "UPDATE tStock_Articles_MagasinGMAO
                                            SET Quantité=Quantité+@QuantitéMvt
                                            WHERE Code_article = (SELECT codearticle FROM tMouvementTransfert_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT )
                                            AND codemagasin = (SELECT Code_Mag FROM tMagasin WHERE Nom_Mag=@Source)"
                        Dim libl As String
                        Dim p1, p2 As Integer
                        libl = row.Cells("LibelléMvt").Value
                        p1 = libl.IndexOf("(")
                        p2 = libl.IndexOf(")")
                        cmd2.Parameters.AddWithValue("@Source", libl.Substring(p1 + 1, p2))
                        cmd2.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd2.Parameters.AddWithValue("@Libellé_Mvt", libl)
                        cmd2.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd2.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        cmd2.Parameters.AddWithValue("@PHT", row.Cells("PA").Value)
                        'Suppression du mouvement de transfert d'articles
                        cmd3.CommandText = "DELETE FROM tMouvementTransfert_Stock WHERE RefMvt=@RefMvt AND Libellé_Mvt=@Libellé_Mvt AND QuantitéMvt=@QuantitéMvt AND Date_Mvt=@Date_Mvt AND PHT=@PHT"
                        cmd3.Parameters.AddWithValue("@RefMvt", row.Cells("RefMvt").Value)
                        cmd3.Parameters.AddWithValue("@Libellé_Mvt", row.Cells("LibelléMvt").Value)
                        cmd3.Parameters.AddWithValue("@QuantitéMvt", row.Cells("QteMvt").Value)
                        cmd3.Parameters.AddWithValue("@Date_Mvt", row.Cells("DateMvt").Value)
                        cmd3.Parameters.AddWithValue("@PHT", row.Cells("PA").Value)

                        rowsAffected = cmd.ExecuteNonQuery
                        rowsAffected = cmd2.ExecuteNonQuery
                        cmd3.ExecuteNonQuery()
                        BD.con.Close()
                        DataGridView1.Rows.Remove(row)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class