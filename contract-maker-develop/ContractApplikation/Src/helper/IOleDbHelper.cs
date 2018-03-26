using ContractApplikation.Src.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApplikation.Src.Helper
{
    interface IOleDbHelper:IDisposable
    {

        bool AddCustomerDetailToDatabase(Ansprechpartner kunden, OleDbConnection conn);
        bool AddProjectDetailToDatabase(Projekt project, OleDbConnection conn);
        bool InsertCustomerDetail(Ansprechpartner kunden);
        bool InsertProjectDetail(Projekt projekt);
        IEnumerable<Ansprechpartner> FetchCustomerDetails();
        IEnumerable<Projekt> FetchProjectDetails();
    }
}
