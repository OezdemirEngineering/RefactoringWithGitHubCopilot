using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_9_Smells_Comments
{
    internal class LinearInterpolator
    {

        private readonly double[] XArray;
        private readonly double[] YArray;

        public LinearInterpolator(double[] x, double[] y)
        {
            this.XArray = x;
            this.YArray = y;
        }

        public double Interpolate(double xValue)
        {
            if (XArray.Length != YArray.Length)
            {
                throw new ArgumentException("XArray and YArray arrays must have the same length");
            }
            if (XArray.Length == 0)
            {
                throw new ArgumentException("XArray array must have at least one element");
            }
            if (XArray.Length == 1)
            {
                return YArray[0];
            }
            if (xValue <= XArray[0])
            {
                return YArray[0];
            }
            if (xValue >= XArray[XArray.Length - 1])
            {
                return YArray[YArray.Length - 1];
            }
            for (int i = 0; i < XArray.Length - 1; i++)
            {
                if (xValue >= XArray[i] && xValue <= XArray[i + 1])
                {
                    return YArray[i] + (YArray[i + 1] - YArray[i]) * (xValue - XArray[i]) / (XArray[i + 1] - XArray[i]);
                }
            }
            throw new InvalidOperationException("This should never happen");
        }



    }
}
