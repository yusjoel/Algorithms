using System.Numerics;

namespace Interview.Common
{
    public class Matrix2
    {
        private readonly BigInteger[] data = new BigInteger[4];

        public Matrix2(BigInteger m00, BigInteger m01, BigInteger m10, BigInteger m11)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
        }

        /// <summary>
        ///     第0行第0列
        /// </summary>
        public BigInteger M00
        {
            get => data[0];
            set => data[0] = value;
        }

        /// <summary>
        ///     第0行第1列
        /// </summary>
        public BigInteger M01
        {
            get => data[1];
            set => data[1] = value;
        }

        /// <summary>
        ///     第1行第0列
        /// </summary>
        public BigInteger M10
        {
            get => data[2];
            set => data[2] = value;
        }

        /// <summary>
        ///     第1行第1列
        /// </summary>
        public BigInteger M11
        {
            get => data[3];
            set => data[3] = value;
        }

        /// <summary>
        ///     右乘一个矩阵
        /// </summary>
        /// <param name="right"></param>
        public void Multiply(Matrix2 right)
        {
            var m00 = M00 * right.M00 + M01 * right.M10;
            var m01 = M00 * right.M01 + M01 * right.M11;
            var m10 = M10 * right.M00 + M11 * right.M10;
            var m11 = M10 * right.M01 + M11 * right.M11;
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
        }
    }
}
