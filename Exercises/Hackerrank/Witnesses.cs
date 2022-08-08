namespace Exercises
{
    public static class Witnesses
    {
        public static int CountWitnesses(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int res = 0;
            int max = 0;
            int n = arr.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    res++;
                }
            }
            return res;
        }
    }
}
