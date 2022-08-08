List<int> x = new List<int> { 3, 7, 8, 5, 12, 14, 21, 13, 18 };
List<int> x2 = new List<int> { 3, 7, 8, 5, 12, 14, 21, 15, 18, 14 };


var res = Exercises.Hackerrank.DaysOfStatistics.Find_Quartiles(x.ToArray());
var res2 = Exercises.Hackerrank.DaysOfStatistics.Find_Quartiles(x2.ToArray());


res.ForEach(p => Console.WriteLine(p));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

res2.ForEach(p => Console.WriteLine(p));