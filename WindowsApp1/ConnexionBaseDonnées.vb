Imports System.Data.OleDb
Public Class ConnexionBaseDonnées
    ReadOnly connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\NGOUTOUGA Dimitri\Documents\Projet Stage\WindowsApp1\WindowsApp1\myimport.accdb"
    Public con As New OleDbConnection(connString)
End Class
