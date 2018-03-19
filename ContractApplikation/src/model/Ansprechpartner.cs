using ContractApplikation.Src.Helper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ContractApplikation.Src.Model
{

    public enum Honorifics
    {
        HERR,
        FRAU
    }

    public class Ansprechpartner
    {
        public String bezeichnung { get; private set; }

        public String vorname { get; private set; }

        public String nachname { get; private set; }

        public String abteilung { get; private set; }

        public String email { get; private set; }

        public String telefon { get; private set; }

        public String strasse { get; private set; }

        public String ort { get; private set; }

        public String firma { get; private set; }

        public String abteilungszusatz { get; private set; }

        public String geschäftsbereich { get; private set; }

        public Ansprechpartner(List<TextBox> listOfTextboxes, Honorifics bezeichnung)
        {
            this.bezeichnung = bezeichnung.ToString();

            foreach (TextBox textBox in listOfTextboxes)
            {
                this.GetType().GetProperty(textBox.Name).SetValue(this, textBox.Text);
            }
        }

        public Ansprechpartner(OleDbDataReader dataReader)
        {
            this.bezeichnung         = dataReader.GetValue(1).ToString();
            this.vorname             = dataReader.GetValue(2).ToString();
            this.nachname            = dataReader.GetValue(3).ToString();
            this.abteilung           = dataReader.GetValue(4).ToString();
            this.email               = dataReader.GetValue(5).ToString();
            this.telefon             = dataReader.GetValue(6).ToString();
            this.strasse             = dataReader.GetValue(7).ToString();
            this.ort                 = dataReader.GetValue(8).ToString();
            this.firma               = dataReader.GetValue(9).ToString();
            this.abteilungszusatz    = dataReader.GetValue(10).ToString();
            this.geschäftsbereich    = dataReader.GetValue(11).ToString();
        }

        public String Name()
        {
            return Utilities.FirstLetterToUpperCase(bezeichnung) + "." + Utilities.FirstLetterToUpperCase(vorname) + " " + Utilities.FirstLetterToUpperCase(nachname);
        }
    }
}
