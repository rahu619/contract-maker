using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ContractApplikation.Src.Model
{
    public class Projekt
    {
        public String projektNummer { get; private set; }

        public String startDatum { get; private set; }

        public String endDatum { get; private set; }

        public String ansprechPartnerID { get; private set; }

        public String anzahlStunden { get; private set; }

        public String verrechnungssatz { get; private set; }

        public String projektTitel { get; private set; }

        public String gesprächsperson { get; private set; }

        public String disponent { get; private set; }

        public String projektBeschreibung { get; private set; }

        public Projekt(List<TextBox> listOfTextboxes)
        {
            foreach (TextBox textBox in listOfTextboxes)
            {
                this.GetType().GetProperty(textBox.Name).SetValue(this, textBox.Text);
            }
        }

        public Projekt(OleDbDataReader dataReader)
        {
            this.projektNummer       = dataReader.GetValue(1).ToString();
            this.startDatum          = dataReader.GetValue(2).ToString();
            this.endDatum            = dataReader.GetValue(3).ToString();
            this.ansprechPartnerID   = dataReader.GetValue(4).ToString();
            this.anzahlStunden       = dataReader.GetValue(5).ToString();
            this.verrechnungssatz    = dataReader.GetValue(6).ToString();
            this.projektTitel        = dataReader.GetValue(7).ToString();
            this.gesprächsperson     = dataReader.GetValue(8).ToString();
            this.disponent           = dataReader.GetValue(9).ToString();
            this.projektBeschreibung = dataReader.GetValue(10).ToString();
        }
    }
}
