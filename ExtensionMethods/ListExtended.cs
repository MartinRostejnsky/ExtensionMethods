using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ListExtended
    {
        public static bool IsCountEven<T>(this List<T> list) {
            return (list.Count % 2 == 0);
        }

        public static List<T> Even<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++) {
                if (i % 2 == 0) {
                    result.Add(list[i]);
                }
            }
            return result;
        }
        public static List<T> Selection<T>(this List<T> list, int x, int y)
        {
            List<T> result = new List<T>();
            for (int i = x; i < y; i++)
            {
                result.Add(list[i]);
            }
            return result;
        }

        public static T RandomItem<T>(this List<T> list)
        {
            int num = Random.Shared.Next(0, list.Count);
            return list[num];
        }
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

        public static List<string> Upper(this List<string> list)
        {
            List<string> result = new List<string>();
            foreach (string s in list)
            {
                result.Add(s.ToUpper());
            }
            return result;
        }
        public static List<string> SuitableAsPassword(this List<string> list)
        {
            List<string> result = new List<string>();
            foreach (string s in list)
            {
                bool ContainsUpper = false;
                bool ContainsLower = false;
                bool ContainsDigit = false;
                foreach (char x in s)
                {
                    if (char.IsUpper(x))
                    {
                        ContainsUpper = true;
                    }
                    if (char.IsLower(x))
                    {
                        ContainsLower = true;
                    }
                    if (char.IsDigit(x))
                    {
                        ContainsDigit = true;
                    }
                }
                if (ContainsUpper & ContainsLower & ContainsDigit & s.Length <= 16 & s.Length >= 8)
                {
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<int> Divisible(this List<int> list, int x)
        {
            List<int> result = new List<int>();
            foreach (int i in list) {
                if (i % x == 0) {
                    result.Add(i);
                }
            }
            return result;
        }
        public static List<int> Magnitude(this List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                int num = i;
                int magnitude = 0;

                while (num > 0)
                {
                    magnitude++;
                    num = num / 10;
                }
                result.Add(magnitude);
            }
            return result;
        }

        public static List<string> Hexadecimal(this List<int> list)
        {
            List<string> result = new List<string>();
            foreach (int x in list)
            {
                result.Add(x.AsHex());
            }
            return result;
        }

        public static List<int> Condition(this List<int> list, Func<int, bool> condition)
        {
            List<int> result = new List<int>();
            foreach (int x in list)
            {
                if (condition(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public static List<int> Process(this List<int> list, Func<int, int> proc)
        {
            List<int> result = new List<int>();
            foreach (int x in list)
            {
                result.Add(proc(x));
            }
            return result;
        }


        public static string AsHex(this int num)
        {
            return num.ToString("X");
        }

    }
}
