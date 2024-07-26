namespace Clase1;

public static class Kata1
{
    public static bool Narcissistic(int value)
    {
        // Code me
        #region code
        int len = Convert.ToString(value).Length;
        long sum = 0;
        long[] arrayNumeros = new long[len];

        for (int i = 0; i < len; i++)
        {
            arrayNumeros[i] = Convert.ToInt64(value.ToString()[i].ToString());
        }

        for (int i = 0; i < len; i++)
        {
            var operation = Math.Pow(arrayNumeros[i], len);
            sum += Convert.ToInt64(operation);
        }
        #endregion

        return value == sum;
    }
}