using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ListExtended
    {
        public static List<string> ShorterThan(this List<string> list, int threshold) {
            List<string> result = new List<string>();
            foreach (string s in list) {
                if (s.Length < threshold) {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
