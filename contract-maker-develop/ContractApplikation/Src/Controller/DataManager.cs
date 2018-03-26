using ContractApplikation.Src.Helper;
using ContractApplikation.Src.Model;
using System.Collections.Generic;
using System.Linq;

namespace ContractApplikation.Src.Controller
{
    public class DataManager
    {
        public List<Ansprechpartner> CustomerList { get; private set; }
        public List<Projekt> ProjectList { get; private set; }

        IOleDbHelper oledbHelper;

        public DataManager()
        {
            this.oledbHelper = new OleDbHelper();
            CustomerList = oledbHelper.FetchCustomerDetails().ToList();
            ProjectList  = oledbHelper.FetchProjectDetails().ToList();
        }

        public void AddCustomer(Ansprechpartner customer)
        {
            CustomerList.Add(customer);
            oledbHelper.InsertCustomerDetail(customer);
        }

        public void AddProject(Projekt project)
        {
            ProjectList.Add(project);
            oledbHelper.InsertProjectDetail(project);
        }
    }
}
