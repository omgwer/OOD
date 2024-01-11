namespace Lab2_4.Comparer
{
    public class SortedDictionaryComparer : IComparer<int>
    {
        public int Compare( int x, int y )
        {
            if ( x > y )
            {
                return -1;
            }
            else if ( x < y )
            {
                return 1;
            }

            return 0;
        }
    }
}