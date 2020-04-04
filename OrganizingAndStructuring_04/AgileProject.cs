using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    public class AgileProject : Project
    {
        protected int Length { get; set; }
        public AgileProject()
        {
            Name = "New Agile Project (unnamed)";
        }
        protected override void Initialize()
        {
            Length = Name.Length;
        }
    }
}
