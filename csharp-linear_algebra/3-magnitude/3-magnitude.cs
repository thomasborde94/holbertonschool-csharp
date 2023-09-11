using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length > 3 || vector.Length < 2)
            return -1;
        double resultSqr = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            resultSqr += vector[i] * vector[i];
        }
        double result = Math.Sqrt(resultSqr);
        return Math.Round(result, 2);
    }
}
