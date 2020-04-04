using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    public class Project
    {
        public string Name { get; set; }

        public Project()
        {
            Initialize();
        }

        protected virtual void Initialize()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
