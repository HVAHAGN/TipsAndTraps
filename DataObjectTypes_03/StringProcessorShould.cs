using DataObjectTypesClassLib_03.Tuples;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataObjectTypes_03
{
    public class StringProcessorShould
    {
        [Fact]
        public void ReturnLengthsAndUppercaseStrings()
        {
            var sut = new StringProcessor();

            var inputStrings = new List<string>
            {
                "Hello",
                "Welcome",
                "Howdy"
            };

            var results = sut.ToUpperAndWithLength(inputStrings);

            Assert.Equals(3, results.Count);

            Assert.Equals("5-HELLO", results[0]);
            Assert.Equals("7-WELCOME", results[1]);
            Assert.Equals("5-HOWDY", results[2]);
        }
    }
}
