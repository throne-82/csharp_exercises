namespace Exercises.Hackerrank
{
    public static class DaysOfStatistics
    {
        #region Day 0
        public static Object[] Find_MeanMedianMode(int n, string strNums)
        {
            object[] result = new Object[3];

            decimal[] nums = new decimal[n];
            string[] stringNums = strNums.Split(null);

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToDecimal(stringNums[i]);
            }

            result[0] = Mean(nums.ToList(), n);
            result[1] = Median(nums, n);
            result[2] = Mode(nums, n);

            return result;
        }

        private static decimal Mean(List<decimal> nums, int n)
        {
            decimal sum = 0;

            foreach (var item in nums)
            {
                sum += item;
            }

            return sum / n;
        }

        private static decimal Median(decimal[] nums, int n)
        {
            decimal median;

            nums = Order(nums, n);

            if (n % 2 == 0)
                median = (nums[(n / 2) - 1] + nums[(n / 2)]) / 2;
            else
                median = nums[(n / 2)];

            return Convert.ToDecimal(median);
        }

        private static int Median(int[] nums, int n)
        {
            nums = Order(nums, n);

            if (n % 2 == 0)
                return (nums[(n / 2) - 1] + nums[(n / 2)]) / 2;
            else
                return nums[(n / 2)];
        }

        private static int Mode(decimal[] nums, int n)
        {
            nums = Order(nums, n);
            int[] occurrences = new int[n];
            int maxOccurs = 0;
            decimal value = nums[0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j])
                        occurrences[i]++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (maxOccurs < occurrences[i])
                {
                    maxOccurs = occurrences[i];
                    value = nums[i];
                }
            }

            return Convert.ToInt32(value);
        }

        private static decimal[] Order(decimal[] a, int n)
        {
            int temp = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = (int)a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        private static int[] Order(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = (int)a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        public static double Find_WightedMean(int n, int[] x, int[] w)
        {
            double zSum = 0.0;
            double wSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                zSum += x[i] * w[i];
                wSum += w[i];
            }

            return Math.Round(zSum / wSum, 1);
        }
        #endregion

        #region Day 1
        public static double Find_StandardDeviation(List<int> arr)
        {
            double squareSum = 0.0;

            foreach (int i in arr)
            {
                squareSum += Math.Pow((i - (arr.Sum() / arr.Count())), 2);
            }

            return Math.Round(Math.Sqrt(squareSum / arr.Count()), 1);
        }

        public static int[] SubArray(this int[] data, int index, int length)
        {
            int[] result = new int[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
        public static List<int> Find_Quartiles(int[] arr)
        {
            int n = arr.Length;
            int mid = n / 2;

            if (n % 2 != 0)
                return new List<int> { Median(arr.SubArray(0, mid), mid), Median(arr, n), Median(arr.SubArray(mid + 1, mid), mid) };
            else
                return new List<int> { Median(arr.SubArray(0, mid), mid), Median(arr, n), Median(arr.SubArray(mid, mid), mid) };
        }
        #endregion
    }



}
