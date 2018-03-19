using ContractApplikation.src.helper;
using ContractApplikation.Src.Model;
using System.Collections.Generic;

namespace ContractApplikation.src.model
{
    public class DataManager
    {
        public List<Ansprechpartner> customerList { get; private set; }
        public List<Projekt> projectList { get; private set; }

        public DataManager()
        {
            customerList = OleDbHelper.FetchCustomerDetails();
            projectList  = OleDbHelper.FetchProjectDetails();
        }

    }
}
