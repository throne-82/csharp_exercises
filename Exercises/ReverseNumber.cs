namespace Exercises
{
    public static class ReverseNumber
    {
        public static int reverseInteger(int num)
        {
            bool flag = true;
            bool isNegative = false;
            int count = 0;
            int cent = 1;
            int newNum = 0;
            int aux;
            int bla = 1;

            if (num < 0)
            {
                num *= -1;
                isNegative = true;
            }

            do
            {
                if (num < cent * 10)
                {
                    flag = false;
                }
                else
                {
                    cent *= 10;
                    count++;
                }
            } while (flag);

            for (int i = count; i >= 0; i--)
            {
                if (cent != 1)
                {
                    aux = (num / cent);
                    num -= (aux * cent);
                    newNum += aux * bla;
                    cent /= 10;
                }
                else
                {
                    newNum += num * (cent * (int)Math.Pow(10, count));
                }
                bla *= 10;
            }
            if (isNegative)
                newNum *= -1;

            return newNum;
        }

        public static int reverseDigits(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;
        }

    }
}
