namespace Clase1;

public class SumaEnteros
{
    public int Suma(string originalNumber)
    {
        var arreglo = originalNumber.ToArray();
        bool flag = true;
        int suma = 0;

        //Code
        while (flag == true)
        {
            suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                int x = Int16.Parse(arreglo[i].ToString());
                suma += x;
            }
            var arreglo2 = suma.ToString().ToArray();
            if (arreglo2.Length > 1)
            {
                arreglo = arreglo2;
            }
            else
            {
                flag = false;
            }
        }

        return suma;
    }
}
