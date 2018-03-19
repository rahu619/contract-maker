using ContractApplikation.Src.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ContractApplikation.src.helper
{
    public class OleDbHelper
    {
        public static OleDbHelper sharedInstance = new OleDbHelper();

        private const string CONNECTION_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\GRajan\source\repos\ContractApplikation\ContractApplikation\Vertrag-DB.accdb";

        private OleDbConnection openConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = CONNECTION_STRING;
            conn.Open();
            return conn;
        }

        private void closeConnection(OleDbConnection conn)
        {
            conn.Close();
        }

        private void AddCustomerDetailToDatabase(Ansprechpartner kunden, OleDbConnection conn)
        {
            var cmd = new OleDbCommand("INSERT INTO Ansprechpartner " +
                    "(Bezeichnung, Vorname, Nachname, Abteilung, Email, Telefon, Strasse, Ort, Firma, Abteilungszusatz, Geschäftsbereich) " +
                    "VALUES (@Bezeichnung, @Vorname, @Nachname, @Abteilung, @Email, @Telefon, @Strasse, @Ort, @Firma, @Abteilungszusatz, @Geschäftsbereich)");
            cmd.Connection = conn;

            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Parameters.Add("@Bezeichnung", OleDbType.VarChar).Value = kunden.bezeichnung;
                cmd.Parameters.Add("@Vorname", OleDbType.VarChar).Value = kunden.vorname;
                cmd.Parameters.Add("@Nachname", OleDbType.VarChar).Value = kunden.nachname;
                cmd.Parameters.Add("@Abteilung", OleDbType.VarChar).Value = kunden.abteilung;
                cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = kunden.email;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar).Value = kunden.telefon;
                cmd.Parameters.Add("@Strasse", OleDbType.VarChar).Value = kunden.strasse;
                cmd.Parameters.Add("@Ort", OleDbType.VarChar).Value = kunden.ort;
                cmd.Parameters.Add("@Firma", OleDbType.VarChar).Value = kunden.firma;
                cmd.Parameters.Add("@Abteilungszusatz", OleDbType.VarChar).Value = kunden.abteilungszusatz;
                cmd.Parameters.Add("@Geschäftsbereich", OleDbType.VarChar).Value = kunden.geschäftsbereich;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer details of " + kunden.vorname + " is successfully entered to the database.");
            }
        }

        private void AddProjectDetailToDatabase(Projekt project, OleDbConnection conn)
        {
            var cmd = new OleDbCommand("INSERT INTO Projekt " +
                    "(Projektnummer, StartDatum, EndDatum, AnsprechpartnerID, AnzahlStunden, Verrechnungssatz, ProjektTitel, Gesprächsperson, Disponent, ProjektBeschreibung) " +
                    "VALUES (@Projektnummer, @StartDatum, @EndDatum, @AnsprechpartnerID, @AnzahlStunden, @Verrechnungssatz, @ProjektTitel, @Gesprächsperson, @Disponent, @ProjektBeschreibung)");
            cmd.Connection = conn;

            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Parameters.Add("@Projektnummer", OleDbType.VarChar).Value       = project.projektNummer;
                cmd.Parameters.Add("@StartDatum", OleDbType.VarChar).Value          = project.startDatum;
                cmd.Parameters.Add("@EndDatum", OleDbType.VarChar).Value            = project.endDatum;
                cmd.Parameters.Add("@AnsprechpartnerID", OleDbType.VarChar).Value   = project.ansprechPartnerID;
                cmd.Parameters.Add("@AnzahlStunden", OleDbType.VarChar).Value       = project.anzahlStunden;
                cmd.Parameters.Add("@Verrechnungssatz", OleDbType.VarChar).Value    = project.verrechnungssatz;
                cmd.Parameters.Add("@ProjektTitel", OleDbType.VarChar).Value        = project.projektTitel;
                cmd.Parameters.Add("@Gesprächsperson", OleDbType.VarChar).Value     = project.gesprächsperson;
                cmd.Parameters.Add("@Disponent", OleDbType.VarChar).Value           = project.disponent;
                cmd.Parameters.Add("@ProjektBeschreibung", OleDbType.VarChar).Value = project.projektBeschreibung;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project details of " + project.projektTitel + " is successfully entered to the database.");
            }
        }

        public bool InsertCustomerDetail(Ansprechpartner kunden)
        {
            try
            {
                OleDbConnection conn = openConnection();
                AddCustomerDetailToDatabase(kunden, conn);
                closeConnection(conn);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }

            return true;
        }

        public bool InsertProjectDetail(Projekt projekt)
        {
            try
            {
                OleDbConnection conn = openConnection();
                AddProjectDetailToDatabase(projekt, conn);
                closeConnection(conn);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }

            return true;
        }

        public void FetchCustomerDetails()
        {
            try
            {
                List<Ansprechpartner> customerList = new List<Ansprechpartner>();
                OleDbDataReader dr = null;
                var cmd = new OleDbCommand("SELECT * FROM Ansprechpartner", openConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    customerList.Add(new Ansprechpartner(dr));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void FetchProjectDetails()
        {
            try
            {
                List<Projekt> projectList = new List<Projekt>();
                OleDbDataReader dr = null;
                var cmd = new OleDbCommand("SELECT * FROM Projekt", openConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    projectList.Add(new Projekt(dr));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
