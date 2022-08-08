namespace Exercises
{
    public static class MinMaxSum
    {
        public static string FindMinMaxSum(List<int> arr)
        {
            long max = arr[0];
            long min = arr[0];
            long sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min = arr[i];
                sum += arr[i];
            }
            return ((sum - max) + " " + (sum - min));
        }
    }
}
