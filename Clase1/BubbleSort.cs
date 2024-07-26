namespace Clase1;

public static class BubbleSort
{

    public static void Main()
    {
        // Definir un array de ejemplo
        int[] array = { 90, 34, 25, 12, 22, 11, 64, 100, 255, 0, 88, -1, (25 * 3), 3, 3 };

        // Llamar a la función BubbleSort para ordenar el array
        BubbleSortMethod(array);

        // Imprimir el array ordenado
        Console.WriteLine("Array ordenado: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }

    // Función para ordenar un array usando Bubble Sort
    static void BubbleSortMethod(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < (n - 1); i++)
        {
            for (int j = 0; j < (n - 1 - i); j++)
            {
                // Intercambiar si el elemento actual es mayor que el siguiente
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
