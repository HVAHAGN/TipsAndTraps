using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    public partial class DataModel
    {
        public string Status { get; private set; }

        public DataModel()
        {
            Status = "New";
        }

        public void ClearStatus()
        {
            Status = "";
        }
    }
}
