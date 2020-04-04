using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectTypesClassLib_03.StructPerformance
{
    public struct NoRefWithOverride
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is WithRefWithOverride))
                return false;

            var other = (WithRefWithOverride)obj;

            return X == other.X &&
                   Y == other.Y;
        }

        // GetHashCode override and == != operators omitted
    }
}
