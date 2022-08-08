namespace Exercises
{
    public static class AnagramsInAString
    {
        public static int[] FindAnagrams(string s, string t)
        {
            List<int> indexes = new List<int>();
            List<int> result = new List<int>();
            bool seq = true;

            char[] t_characters = t.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t_characters.Length; j++)
                {
                    if (s[i] == t_characters[j])
                    {
                        indexes.Add(i);
                        break;
                    }
                }
            }

            for (int i = 0; i < (indexes.Count - (t_characters.Length - 1)); i++)
            {
                for (int j = 1; j <= t_characters.Length - 1; j++)
                {
                    if ((indexes[i + j] - indexes[i + (j - 1)]) == 1)
                    {
                        seq = true;
                    }
                    else
                    {
                        seq = false;
                        break;
                    }
                }

                if (seq)
                {
                    result.Add(indexes[i]);
                }
            }

            return result.ToArray();
        }
    }
}
