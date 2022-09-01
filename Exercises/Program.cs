//class Solution
//{
//    static void Main(String[] args)
//    {
//        string myStr = Console.ReadLine().Trim();

//        string[] ssize = myStr.Split(null);
//        double l1 = Convert.ToDouble(ssize[0]);
//        double l2 = Convert.ToDouble(ssize[1]);

//        double p1 = 160 + 40 * (l1 + (l1 * l1));
//        double p2 = 128 + 40 * (l2 + (l2 * l2));

//        Console.WriteLine(Math.Round(l1, 3));
//        Console.WriteLine(Math.Round(l2, 3));
//    }
//}

string bla = "1, Arthur, Dev";
//byte[] asciiBytes = Encoding.ASCII.GetBytes(bla);

string[] Registro = bla.Split(',');
Console.WriteLine("O profissional id: " + Registro[0] + " de nome" + Registro[1] + " trabalha como " + Registro[2]);