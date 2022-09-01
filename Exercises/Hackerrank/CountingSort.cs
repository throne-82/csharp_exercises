namespace Exercises.Hackerrank
{
    public static class CountingSort
    {
        public static List<int> Find_CountingSort(List<int> arr)
        {
            int[] freq = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                freq[arr[i]]++;
            }

            return freq.ToList();
        }
    }
}
