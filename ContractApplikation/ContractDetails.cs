using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using ContractApplikation.src.helper;
using ContractApplikation.Src.Model;

namespace ContractApplikation
{

    public partial class ContractDetails : Form
    {

        public ContractDetails()
        {
            InitializeComponent();
        }


        private void createCustomer_Click(object sender, EventArgs e)
        {
            if (customerDetailIsValid())
            {
                var controlsForCustomerTabPage = this.Controls[0].Controls[0].Controls;
                Ansprechpartner kunden = generateCustomerWithControl(controlsForCustomerTabPage);
                addCustomDetailToDatabase(kunden);
            }
        }

        private Ansprechpartner generateCustomerWithControl(Control.ControlCollection controlsForCustomerTabPage)
        {
            IEnumerable<TextBox> textboxControls = controlsForCustomerTabPage.OfType<TextBox>();
            List<TextBox> listOfTextboxes = textboxControls.ToList();
            return new Ansprechpartner(listOfTextboxes, getHonorificsForCustomer());
        }

        private Honorifics getHonorificsForCustomer()
        {
            return (herrRadioBtn.Checked ? Honorifics.HERR : Honorifics.FRAU);
        }

        private void addCustomDetailToDatabase(Ansprechpartner kunden)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\GRajan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Vertrag-DB.accdb";
            conn.Open();
            var cmd = new OleDbCommand("INSERT INTO Ansprechpartner " +
                    "(Bezeichnung, Vorname, Nachname, Abteilung, Email, Telefon, Strasse, Ort, Firma, Abteilungszusatz, Geschäftsbereich) " +
                    "VALUES (@Bezeichnung, @Vorname, @Nachname, @Abteilung, @Email, @Telefon, @Strasse, @Ort, @Firma, @Abteilungszusatz, @Geschäftsbereich)");
            cmd.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Open)
            {
                cmd.Parameters.Add("@Bezeichnung", OleDbType.VarChar).Value      = kunden.bezeichnung;
                cmd.Parameters.Add("@Vorname", OleDbType.VarChar).Value          = kunden.vorname;
                cmd.Parameters.Add("@Nachname", OleDbType.VarChar).Value         = kunden.nachname;
                cmd.Parameters.Add("@Abteilung", OleDbType.VarChar).Value        = kunden.abteilung;
                cmd.Parameters.Add("@Email", OleDbType.VarChar).Value            = kunden.email;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar).Value          = kunden.telefon;
                cmd.Parameters.Add("@Strasse", OleDbType.VarChar).Value          = kunden.strasse;
                cmd.Parameters.Add("@Ort", OleDbType.VarChar).Value              = kunden.ort;
                cmd.Parameters.Add("@Firma", OleDbType.VarChar).Value            = kunden.firma;
                cmd.Parameters.Add("@Abteilungszusatz", OleDbType.VarChar).Value = kunden.abteilungszusatz;
                cmd.Parameters.Add("@Geschäftsbereich", OleDbType.VarChar).Value = kunden.geschäftsbereich;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: "+e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private bool customerDetailIsValid()
        {
            var controlsForCustomerTabPage = this.Controls[0].Controls[0].Controls;

            TextBox emptyItem = controlsForCustomerTabPage.OfType<TextBox>().FirstOrDefault(tb => String.IsNullOrWhiteSpace(tb.Text));
            if (emptyItem != null)
            {
                MessageBox.Show("Geben Sie den " + emptyItem.Name + " ein");
            }
            else if (!herrRadioBtn.Checked && !frauRadioBtn.Checked)
            {
                MessageBox.Show("Wähle ein Geschlecht aus");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {

        }

        private void ContractDetails_Load(object sender, EventArgs e)
        {
            OleDbHelper helper = OleDbHelper.sharedInstance;

            helper.FetchProjectDetails();

            helper.FetchCustomerDetails();

        }
    }
}
