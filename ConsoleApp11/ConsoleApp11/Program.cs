using System;
namespace поиск
{
    public class Search
    {
        public static int SimpleSearching(int[] a, int x)
        {
            int i = 0;
            while (i < a.Length && a[i] != x)
                i++;
            if (i < a.Length) return i;
            else return -1;
        }

        public static int BinarySearching(int[] a, int x)
        {
            int middle, left = 0, right = a.Length - 1;
            do
            {
                middle = (left + right) / 2;
                if (x > a[middle])
                    left = middle + 1;
                else right = middle - 1;
            }
            while ((a[middle] != x) && (left <= right));
            if (a[middle] == x) return middle;
            else return -1;
        }
    }
}