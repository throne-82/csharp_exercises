namespace Exercises
{
    public static class TimeConversion
    {
        public static string ConvertAMPM(string s)
        {
            string[] separated = s.Split(":");
            string amPm = separated[2].Substring(2, 2);

            separated[2] = separated[2].Remove(2, 2);

            if (amPm.ToLower() == "am")
            {
                if (separated[0] == "12")
                    separated[0] = "00";
            }
            else
            {
                if (separated[0] == "12")
                    separated[0] = "12";
                else
                    separated[0] = (Convert.ToInt32(separated[0]) + 12).ToString();
            }

            return(separated[0] + ":" + separated[1] + ":" + separated[2]);
        }
    }
}
