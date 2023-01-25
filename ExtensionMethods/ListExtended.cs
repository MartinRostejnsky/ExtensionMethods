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
        public static List<string> Contains(this List<string> list, string x)
        {
            List<string> result = new List<string>();
            foreach (string s in list)
            {
                if (s.Contains(x))
                {
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<string> LengthBetween(this List<string> list, int x, int y)
        {
            List<string> result = new List<string>();
            foreach (string s in list)
            {
                if (s.Length <= y & s.Length >= x)
                {
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<string> ContainsUpperLetter(this List<string> list)
        {
            List<string> result = new List<string>();
            foreach (string s in list)
            {
                bool ContainsUpper = false;
                foreach (char x in s)
                {
                    if (char.IsUpper(x))
                    {
                        ContainsUpper = true;
                        break;
                    }
                }
                if (ContainsUpper)
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
