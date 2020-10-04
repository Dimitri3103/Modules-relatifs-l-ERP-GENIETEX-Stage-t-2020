Imports System.Data.OleDb
Public Class ETATSTOCKMAGASIN
    Private Sub ETATSTOCKMAGASIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'MyimportDataSet.tMagasinGMAO'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.TMagasinGMAOTableAdapter.Fill(Me.MyimportDataSet.tMagasinGMAO)

    End Sub

    Private Sub EtatStockMag_Click(sender As Object, e As EventArgs) Handles EtatStockMag.Click
        Dim BD As New ConnexionBaseDonnées
        Dim cmd As New OleDb.OleDbCommand
        Dim bind As New BindingSource
        cmd.CommandText = "SELECT PIECERECHANGE.Designation,tMagasinGMAO.Nom_Mag,tStock_Articles_MagasinGMAO.Libelle_Stock,tStock_Articles_MagasinGMAO.Quantité,tStock_Articles_MagasinGMAO.PAMP,tStock_Articles_MagasinGMAO.Dateheure,tStock_Articles_MagasinGMAO.PrixDernierMvt,tStock_Articles_MagasinGMAO.PAMPAvantDernierMvt 
                           FROM tStock_Articles_MagasinGMAO,PIECERECHANGE,tMagasinGMAO 
                           WHERE tStock_Articles_MagasinGMAO.Code_article=PIECERECHANGE.CodePiece AND tStock_Articles_MagasinGMAO.codemagasin=tMagasinGMAO.Code_Mag AND tStock_Articles_MagasinGMAO.codemagasin=@Code_Mag"
        cmd.Parameters.AddWithValue("@Code_Mag", Convert.ToInt32(Magasin.SelectedValue))
        cmd.Connection = BD.con
        BD.con.Open()
        bind.DataSource = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.DataSource = bind
    End Sub

    Private Sub Imprimer_Click(sender As Object, e As EventArgs) Handles Imprimer.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("Code_article")
            .Columns.Add("codemagasin")
            .Columns.Add("Libelle_Stock")
            .Columns.Add("Quantité")
            .Columns.Add("PAMP")
            .Columns.Add("Dateheure")
            .Columns.Add("PrixDernierMvt")
            .Columns.Add("PAMPAvantDernierMvt")
        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value, dgr.Cells(7).Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CrystalReport2
        reportDocument.SetDataSource(dt)
        IMPRESSIONETATSTOCK.CrystalReportViewer1.ReportSource = reportDocument
        IMPRESSIONETATSTOCK.ShowDialog()
    End Sub
End Class