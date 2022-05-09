using System;
using System.Collections.Generic;

namespace Linq.Comparers
{
    /// <summary>
    /// Custom comparer class for use with ordering operators.
    /// </summary>
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y) =>
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}