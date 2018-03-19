using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApplikation.src.helper
{
    public class CustomComboBoxItem
    {
        public string Text  { get; private set; }
        public object Value { get; private set; }

        public CustomComboBoxItem(String text, Object value)
        {
            this.Text   = text;
            this.Value  = value;
        }

        public override string ToString() => Text;
    }
}
