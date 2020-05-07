using Interview.Common;
using System.Numerics;

namespace Interview.Problems02
{
    /// <summary>
    ///     快速求第n项斐波那契数
    /// </summary>
    public class Problem016
    {
        public static BigInteger FastPower(ulong x, ulong y)
        {
            var p = new BigInteger(x);
            var power = BigInteger.One;
            while (y > 0)
            {
                if ((y & 1) == 1)
                    power *= p;
                p *= p;
                y >>= 1;
            }
            return power;
        }

        public static Matrix2 FastPower(Matrix2 x, ulong y)
        {
            var p = new Matrix2(x.M00, x.M01, x.M10, x.M11);
            var power = new Matrix2(BigInteger.One, BigInteger.Zero, BigInteger.Zero, BigInteger.One);
            while (y > 0)
            {
                if ((y & 1) == 1)
                    power.Multiply(p);
                p.Multiply(p);
                y >>= 1;
            }
            return power;
        }

        public static BigInteger FastFibonacci(ulong n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;
            if (n == 3)
                return 2;

            var matrix = new Matrix2(BigInteger.One, BigInteger.One, BigInteger.One, BigInteger.Zero);
            var result = FastPower(matrix, n - 3);
            return result.M00 + result.M01 + result.M10 + result.M11;
        }
    }
}
