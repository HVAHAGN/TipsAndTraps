using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataObjectTypes_03
{
   public class ObjectReferenceEqualsExample
    {
        [Fact]
        public void ExampleWhereReferenceTypeUsesValueEqualitySemantics()
        {
            Uri a = new Uri("https://pluralsight.com");
            Uri b = new Uri("https://pluralsight.com");
            var areEqual = a == b;  //true

            var isSameReference = object.ReferenceEquals(a, b);  //false
            b = a;
            isSameReference = object.ReferenceEquals(a, b);  //true
        }
    }
}
