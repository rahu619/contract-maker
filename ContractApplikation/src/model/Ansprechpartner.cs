using System;
using System.Windows.Forms;

namespace ContractApplikation.Src.Model
{

    public enum Honorifics
    {
        HERR,
        FRAU
    }

    class Ansprechpartner
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

        public Ansprechpartner(System.Collections.Generic.List<TextBox> listOfTextboxes, Honorifics bezeichnung)
        {
            this.bezeichnung = bezeichnung.ToString();

            foreach (TextBox textBox in listOfTextboxes)
            {
                this.GetType().GetProperty(textBox.Name).SetValue(this, textBox.Text);
            }
        }
    }
}
