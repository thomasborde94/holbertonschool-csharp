using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double resultSqr = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            resultSqr += vector[i] * vector[i];
        }
        double result = Math.Sqrt(resultSqr);
        return result;
    }
}
