using ContractApplikation.Src.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ContractApplikation.Src.Helper
{
    public class OleDbHelper : IOleDbHelper
    {
        OleDbConnection conn;

        public OleDbHelper()
        {
            conn = OledbConnect.conn;
        }

        public bool AddCustomerDetailToDatabase(Ansprechpartner kunden, OleDbConnection conn)
        {
            var _returnVal = false;
            var cmd = new OleDbCommand("INSERT INTO Ansprechpartner " +
                    "(Bezeichnung, Vorname, Nachname, Abteilung, Email, Telefon, Strasse, Ort, Firma, Abteilungszusatz, Geschäftsbereich) " +
                    "VALUES (@Bezeichnung, @Vorname, @Nachname, @Abteilung, @Email, @Telefon, @Strasse, @Ort, @Firma, @Abteilungszusatz, @Geschäftsbereich)");
            cmd.Connection = conn;

            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Parameters.Add("@Bezeichnung", OleDbType.VarChar).Value = kunden.Bezeichnung;
                cmd.Parameters.Add("@Vorname", OleDbType.VarChar).Value = kunden.Vorname;
                cmd.Parameters.Add("@Nachname", OleDbType.VarChar).Value = kunden.Nachname;
                cmd.Parameters.Add("@Abteilung", OleDbType.VarChar).Value = kunden.Abteilung;
                cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = kunden.Email;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar).Value = kunden.Telefon;
                cmd.Parameters.Add("@Strasse", OleDbType.VarChar).Value = kunden.Strasse;
                cmd.Parameters.Add("@Ort", OleDbType.VarChar).Value = kunden.Ort;
                cmd.Parameters.Add("@Firma", OleDbType.VarChar).Value = kunden.Firma;
                cmd.Parameters.Add("@Abteilungszusatz", OleDbType.VarChar).Value = kunden.Abteilungszusatz;
                cmd.Parameters.Add("@Geschäftsbereich", OleDbType.VarChar).Value = kunden.Geschäftsbereich;
                _returnVal = cmd.ExecuteNonQuery() > 0;

                if (_returnVal)
                    MessageBox.Show("Customer details of " + kunden.Vorname + " is successfully entered to the database.");
            }
            return _returnVal;
        }

        public bool AddProjectDetailToDatabase(Projekt project, OleDbConnection conn)
        {
            var _returnVal = false;
            var cmd = new OleDbCommand("INSERT INTO Projekt " +
                    "(Projektnummer, StartDatum, EndDatum, AnsprechpartnerID, AnzahlStunden, Verrechnungssatz, ProjektTitel, Gesprächsperson, Disponent, ProjektBeschreibung) " +
                    "VALUES (@Projektnummer, @StartDatum, @EndDatum, @AnsprechpartnerID, @AnzahlStunden, @Verrechnungssatz, @ProjektTitel, @Gesprächsperson, @Disponent, @ProjektBeschreibung)");
            cmd.Connection = conn;

            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.Parameters.Add("@Projektnummer", OleDbType.VarChar).Value = project.Projektnummer;
                cmd.Parameters.Add("@StartDatum", OleDbType.VarChar).Value = project.StartDatum;
                cmd.Parameters.Add("@EndDatum", OleDbType.VarChar).Value = project.EndDatum;
                cmd.Parameters.Add("@AnsprechpartnerID", OleDbType.VarChar).Value = project.AnsprechPartnerID;
                cmd.Parameters.Add("@AnzahlStunden", OleDbType.VarChar).Value = project.AnzahlStunden;
                cmd.Parameters.Add("@Verrechnungssatz", OleDbType.VarChar).Value = project.Verrechnungssatz;
                cmd.Parameters.Add("@ProjektTitel", OleDbType.VarChar).Value = project.ProjektTitel;
                cmd.Parameters.Add("@Gesprächsperson", OleDbType.VarChar).Value = project.Gesprächsperson;
                cmd.Parameters.Add("@Disponent", OleDbType.VarChar).Value = project.Disponent;
                cmd.Parameters.Add("@ProjektBeschreibung", OleDbType.VarChar).Value = project.ProjektBeschreibung;
                _returnVal = cmd.ExecuteNonQuery() > 0;

                if (_returnVal)
                    MessageBox.Show("Project details of " + project.ProjektTitel + " is successfully entered to the database.");
            }

            return _returnVal;
        }



        public bool InsertCustomerDetail(Ansprechpartner kunden)
        {
            using (var conn = this.conn)
                return AddCustomerDetailToDatabase(kunden, conn);


        }

        public bool InsertProjectDetail(Projekt projekt)
        {
            using (var conn = this.conn)
                return AddProjectDetailToDatabase(projekt, conn);

        }

        public IEnumerable<Ansprechpartner> FetchCustomerDetails()
        {
            OleDbDataReader dr = null;
            using (var conn = this.conn)
            {
                var cmd = new OleDbCommand("SELECT * FROM Ansprechpartner", conn);
                dr = cmd.ExecuteReader();
            }
            while (dr.Read())
            {
                yield return new Ansprechpartner(dr);
            }

        }

        public IEnumerable<Projekt> FetchProjectDetails()
        {

            OleDbDataReader dr = null;
            using (var conn = this.conn)
            {
                var cmd = new OleDbCommand("SELECT * FROM Projekt", conn);
                dr = cmd.ExecuteReader();
            }
            while (dr.Read())
            {
                yield return new Projekt(dr);
            }
        }

        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }

    }
}
