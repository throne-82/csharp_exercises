namespace Exercises.Hackerrank
{
    public static class LonelyInteger
    {
        public static int Find_LonelyInteger(List<int> a)
        {
            int result = 0;
            a.Sort();

            if (a.Count == 1)
                return a[0];

            for (int i = 1; i < a.Count; i++)
            {
                if ((i+1) == a.Count)
                {
                    if (a[i] != a[i - 1])
                        result = a[i];
                }
                else
                {
                    if (a[i] != a[i - 1] && a[i] != a[i + 1])
                        result = a[i];
                }
            }

            return result;
        }
    }
}
