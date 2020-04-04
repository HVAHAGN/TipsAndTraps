using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrganizingAndStructuring_04.Tests
{
    public class DataModelShould
    {
        [Fact]
        public void HaveDefaultStatus()
        {
            var sut = new DataModel();

            Assert.Equal("New", sut.Status);
        }

        [Fact]
        public void ClearStatus()
        {
            var sut = new DataModel();

            sut.ClearStatus();

            Assert.Equal("", sut.Status);
        }
    }
}
