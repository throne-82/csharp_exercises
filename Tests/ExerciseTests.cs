using Xunit;
using static Exercises.ReverseNumber;
using static Exercises.Witnesses;
using static Exercises.AnagramsInAString;
using static Exercises.MinMaxSum;
using static Exercises.TimeConversion;
using static Exercises.SparseArrays;
using static Exercises.Hackerrank.DaysOfStatistics;


using System.Collections.Generic;

namespace Tests
{
    public class ExerciseTests
    {
        [Fact]
        public void Test_ReverseNumbers()
        {
            var result = reverseInteger(135);
            var resultNegative = reverseInteger(-321);

            Assert.Equal(531, result);
            Assert.Equal(-123, resultNegative);
        }

        [Fact]
        public void Test_Witnessess()
        {
            int[] array = { 3, 6, 3, 4, 1 };

            Assert.Equal(3, CountWitnesses(array));
        }

        [Fact]
        public void Test_FindAnagrams()
        {
            int[] array = { 3, 7 };

            Assert.Equal(array, FindAnagrams("acdbacdacb", "abc"));
        }

        [Fact]
        public void Test_FindMinMaxSum()
        {
            List<int> arr = new List<int>();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            Assert.Equal("10 14", FindMinMaxSum(arr));
        }

        [Fact]
        public void Test_ConvertTime()
        {
            string s = "07:05:45PM";
            string t = "07:05:45AM";
            string u = "12:01:00PM";
            string v = "12:01:00AM";

            Assert.Equal("19:05:45", ConvertAMPM(s));
            Assert.Equal("07:05:45", ConvertAMPM(t));
            Assert.Equal("12:01:00", ConvertAMPM(u));
            Assert.Equal("00:01:00", ConvertAMPM(v));
        }

        [Fact]
        public void Test_SparseArrays()
        {
            #region Mock 1 (a,b)
            List<string> a = new List<string>();
            List<string> b = new List<string>();

            a.Add("aba");
            a.Add("baba");
            a.Add("aba");
            a.Add("xzxb");

            b.Add("aba");
            b.Add("xzxb");
            b.Add("ab");
            #endregion

            #region Mock 2 (c,d)
            List<string> c = new List<string>();
            List<string> d = new List<string>();

            c.Add("def");
            c.Add("de");
            c.Add("fgh");

            d.Add("de");
            d.Add("lmn");
            d.Add("fgh");
            #endregion 

            #region Mock 3 (e,f)
            List<string> e = new List<string>();
            List<string> f = new List<string>();

            e.Add("abcde");
            e.Add("sdaklfj");
            e.Add("asdjf");
            e.Add("na");
            e.Add("basdn");
            e.Add("sdaklfj");
            e.Add("asdjf");
            e.Add("na");
            e.Add("asdjf");
            e.Add("na");
            e.Add("basdn");
            e.Add("sdaklfj");
            e.Add("asdjf");

            f.Add("abcde");
            f.Add("sdaklfj");
            f.Add("asdjf");
            f.Add("na");
            f.Add("basdn");
            #endregion  

            int[] result_1 = { 2, 1, 0 };
            int[] result_2 = { 1, 0, 1 };
            int[] result_3 = { 1, 3, 4, 3, 2 };

            Assert.Equal(result_1, FindSparseArrays(a, b));
            Assert.Equal(result_2, FindSparseArrays(c, d));
            Assert.Equal(result_3, FindSparseArrays(e, f));
        }

        [Fact]
        public void Test_MeanMedianMode()
        {
            int n = 10;
            string strNums = "64630 11735 14216 99233 14470 4978 73429 38120 51135 67060";

            object[] result = new object[] { (decimal)43900.6, (decimal)44627.5, (int)4978 };

            Assert.Equal(result, Find_MeanMedianMode(n, strNums));
        }

        [Fact]
        public void Test_WightedMean()
        {
            #region Mock_1
            int n = 5;
            int[] x = { 10, 40, 30, 50, 20 };
            int[] w = { 1, 2, 3, 4, 5 };
            double result = 32.0;
            #endregion

            #region Mock_2
            int n2 = 20;
            int[] x2 = { 10, 40, 30, 50, 20, 10, 40, 30, 50, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] w2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 40, 30, 50, 20, 10, 40, 30, 50, 20 };
            double result2 = 9.6;
            #endregion

            Assert.Equal(result, Find_WightedMean(n, x, w));
            Assert.Equal(result2, Find_WightedMean(n2, x2, w2));
        }

        [Fact]
        public void Test_StandardDeviation()
        {
            #region Mock_1
            List<int> arr = new List<int>();
            double result = 14.1;

            arr.Add(10);
            arr.Add(40);
            arr.Add(30);
            arr.Add(50);
            arr.Add(20);
            #endregion

            Assert.Equal(result, Find_StandardDeviation(arr));
        }

        [Fact]
        public void Test_Quartiles()
        {
            #region Mock_1
            List<int> x = new List<int> { 3, 7, 8, 5, 12, 14, 21, 13, 18 };
            int[] result = { 6, 12, 16 };
            #endregion

            #region Mock_2
            List<int> x2 = new List<int> { 3, 7, 8, 5, 12, 14, 21, 15, 18, 14 };
            int[] result2 = { 7, 13, 15 };
            #endregion

            Assert.Equal(result, Find_Quartiles(x.ToArray()));
            Assert.Equal(result2, Find_Quartiles(x2.ToArray()));
        }

        [Fact]
        public void Test_InterquartileRange()
        {
            #region Mock_1
            int[] values = { 6, 12, 8, 10, 20, 16 };
            int[] freqs = { 5, 4, 3, 2, 1, 5 };
            double result = 9.0;
            #endregion

            Assert.Equal(result, Find_InterquartileRange(values, freqs));
        }
    }
}
