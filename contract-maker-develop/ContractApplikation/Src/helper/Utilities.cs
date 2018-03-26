

using ContractApplikation.Src.Model;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ContractApplikation.Src.Helper
{
    static class Utilities
    {
        public static string FirstLetterToUpperCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            s = s.ToLower();
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static TextBox generateTextBoxWithNameAndValue(string name, string value)
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Name = name;
            newTextBox.Text = value;
            return newTextBox;
        }


    }
}
