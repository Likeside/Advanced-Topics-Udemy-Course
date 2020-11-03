using System.Collections.Generic;

namespace Project_2
{
    public class DelegatesExample
    {

        public delegate bool StringFilter(string item);
        
        public static bool LessThanSeven(string name)
        {
            return name.Length < 7;
        }

        public static bool MoreThanSeven(string name)
        {
            return name.Length > 7;
        }

        public static bool ExactlySeven(string name)
        {
            return name.Length == 7;
        }
        
       public static List<string> NameFilter(string[] items, StringFilter stringFilter)
        {
            List<string> result = new List<string>();
            foreach (var item in items)
            {
                if (stringFilter(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}