using System;
using System.Windows.Forms;

namespace ContractApplikation.Src.Model
{
    class Projekt
    {
        public String projektNummer { get; private set; }

        public String vorname { get; private set; }

        public String nachname { get; private set; }

        public String startDatum { get; private set; }

        public String endDatum { get; private set; }

        public String ansprechPartnerID { get; private set; }

        public String anzahlStunden { get; private set; }

        public String verrechnungssatz { get; private set; }

        public String projektTitel { get; private set; }

        public String gesprächsperson { get; private set; }

        public String disponent { get; private set; }

        public String projektBeschreibung { get; private set; }

        public Projekt(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                this.GetType().GetProperty(control.Name).SetValue(this, control.Text);
            }
        }
    }
}
