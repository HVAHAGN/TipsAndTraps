using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    public class StringProcessor
    {
        public List<string> ToUpperAndWithLength(List<string> stringsToProcess)
        {
            var results = new List<string>();

            foreach (var s in stringsToProcess)
            {
                var result = Process(s);

                results.Add($"{result.Length}-{result.UppercaseVersion}");
            }

            return results;
        }

        private (int Length, string UppercaseVersion) Process(string s)
        {
            return (s.Length, s.ToUpperInvariant());
        }
    }
}
