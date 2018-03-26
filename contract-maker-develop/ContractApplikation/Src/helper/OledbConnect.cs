using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApplikation.Src.Helper
{
    public static class OledbConnect
    {
        static OleDbConnection _conn;
        readonly static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["name"].ConnectionString;

        static OledbConnect()
        {
            if (conn == null)
            {
                using (var conn = new OleDbConnection())
                {
                    conn.ConnectionString = CONNECTION_STRING;
                    conn.Open();
                    _conn = conn;
                }
            }

        }

        public static OleDbConnection conn
        {
            get { return _conn; }
        }
    }
}
