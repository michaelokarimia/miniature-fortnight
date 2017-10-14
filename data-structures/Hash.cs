using System.Collections.Generic;

namespace data_structures
{
    public class Hash
    {
        public static int DuplicateDays(int[] daysRequested)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach(int day in daysRequested)
            {
                if( hash.Contains(day))
                {
                    return day;
                }
                else
                {
                    hash.Add(day);
                }
            }

            return 0;
        }
    }
}
