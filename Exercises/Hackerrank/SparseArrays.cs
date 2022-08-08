namespace Exercises
{
    public static class SparseArrays
    {
        public static List<int> FindSparseArrays(List<string> strings, List<string> queries)
        {
            int[] result = new int[queries.Count];

            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = 0; j < queries.Count; j++)
                {
                    if (strings[i] == queries[j])
                        result[j]++;
                }
            }
            return result.ToList();
        }
    }
}
