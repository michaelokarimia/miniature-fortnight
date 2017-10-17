using System.Collections.Generic;

namespace data_structures
{
    public class Hash
    {
        private HashSet<object> _hash;

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

        public Hash()
        {
            _hash = new HashSet<object>();
        }

        public void Add(object item)
        {
            _hash.Add(item);
        }

        public bool Contains(object item)
        {
            

            if (_hash.Contains(item))
                return true;
            else
            {
                _hash.Add(item);
                return false;
            }
        }
    }
}
