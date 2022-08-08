//List<int> x = new List<int> { 3, 7, 8, 5, 12, 14, 21, 13, 18 };
//List<int> x2 = new List<int> { 3, 7, 8, 5, 12, 14, 21, 15, 18, 14 };


//var res = Exercises.Hackerrank.DaysOfStatistics.Find_Quartiles(x.ToArray());
//var res2 = Exercises.Hackerrank.DaysOfStatistics.Find_Quartiles(x2.ToArray());


//res.ForEach(p => Console.WriteLine(p));

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//res2.ForEach(p => Console.WriteLine(p));

int[] values = { 6, 12, 8, 10, 20, 16 };
int[] freqs = { 5, 4, 3, 2, 1, 5};

double findInter = Exercises.Hackerrank.DaysOfStatistics.Find_InterquartileRange(values, freqs);
Console.WriteLine(string.Format("{0:F1}", findInter));