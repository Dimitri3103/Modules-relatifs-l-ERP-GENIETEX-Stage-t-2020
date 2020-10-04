Imports System.Data.OleDb
Public Class LISTEMVTSPIECES
    Private Sub LISTEMVTSPIECES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.PIECERECHANGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PIECERECHANGETableAdapter.Fill(Me.MyimportDataSet.PIECERECHANGE)

    End Sub

    Private Sub ListeMouvements_Click(sender As Object, e As EventArgs) Handles ListeMouvements.Click
        Dim BD As New ConnexionBaseDonnées
        Dim cmd As New OleDbCommand
        Dim bind As New BindingSource
        cmd.CommandText = "SELECT tMouvementEntree_Stock.RefMvt,tMouvementEntree_Stock.Libellé_Mvt,tMouvementEntree_Stock.QuantitéMvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementEntree_Stock.Date_Mvt,tMouvementEntree_Stock.PHT FROM tMouvementEntree_Stock,PIECERECHANGE,tMagasinGMAO WHERE tMouvementEntree_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementEntree_Stock.codearticle=PIECERECHANGE.CodePiece AND PIECERECHANGE.CodePiece = @codeArticle
                            UNION
                            SELECT tMouvementSortie_Stock.RefMvt,tMouvementSortie_Stock.Libellé_Mvt,tMouvementSortie_Stock.QuantitéMvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementSortie_Stock.Date_Mvt,tMouvementSortie_Stock.PHT FROM tMouvementSortie_Stock,PIECERECHANGE,tMagasinGMAO WHERE tMouvementSortie_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementSortie_Stock.codearticle=PIECERECHANGE.CodePiece AND PIECERECHANGE.CodePiece = @codeArticle
                            UNION
                            SELECT tMouvementTransfert_Stock.RefMvt,tMouvementTransfert_Stock.Libellé_Mvt,tMouvementTransfert_Stock.QuantitéMvt,PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tMouvementTransfert_Stock.Date_Mvt,tMouvementTransfert_Stock.PHT FROM tMouvementTransfert_Stock,PIECERECHANGE,tMagasinGMAO WHERE tMouvementTransfert_Stock.CodeMagasin=tMagasinGMAO.Code_Mag AND tMouvementTransfert_Stock.codearticle=PIECERECHANGE.CodePiece
                            AND PIECERECHANGE.CodePiece = @codeArticle"
        cmd.Parameters.AddWithValue("@codeArticle", Convert.ToString(Pièce.SelectedValue))
        cmd.Connection = BD.con
        BD.con.Open()
        bind.DataSource = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub Imprimer_Click(sender As Object, e As EventArgs) Handles Imprimer.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("RefMvt")
            .Columns.Add("Libellé_Mvt")
            .Columns.Add("QuantitéMvt")
            .Columns.Add("Date_Mvt")
            .Columns.Add("codearticle")
            .Columns.Add("CodeMagasin")
            .Columns.Add("PHT")
        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CrystalReport3
        reportDocument.SetDataSource(dt)
        IMPRESSIONLISTEMVTPIECES.CrystalReportViewer1.ReportSource = reportDocument
        IMPRESSIONLISTEMVTPIECES.ShowDialog()
    End Sub
End Class