namespace Exercises.Hackerrank
{
    public static class FlippingBits
    {
        public static long Find_FlippingBits(long N)
        {
            uint res = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = (int)(N & 1);
                res += (uint)((1 - bit) << i);
                N >>= 1;
            }
            return res; 
        }
    }
}
