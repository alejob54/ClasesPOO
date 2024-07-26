namespace Clase1;
using System.Linq;

public class MergeTwoArrays
{
    public int[] DoWork(int[] array1, int[] array2)
    {

        // Combine both arrays
        var combinedList = array1.Concat(array2).ToList();
        // Sort the combined list
        combinedList.Sort();

        // Remove duplicates and convert back to array
        var result = combinedList.Distinct().ToArray();

        return result;

        // int l = array1.Length + array2.Length;
        // int?[] result = new int?[l];
        // int aux = 0;
        // foreach (var data in array1)
        // {
        //     //codigo
        //     if (!ValidateNumberInArray(result, data))
        //     {
        //         result[aux] = data;
        //         aux++;
        //     }
        // }
        // aux = 0;
        // foreach (var data in array2)
        // {
        //     if (!ValidateNumberInArray(result, data))
        //     {
        //         result[array1.Length + aux] = data;
        //         aux++;
        //     }
        // }

        // //metodo de ordenamiento de Seleccion https://github.com/gbaudino/MetodosDeOrdenamiento
        // //deja los numeros duplicados
        // for (int i = 0; i < l; i++)
        // {
        //     for (int j = 0 + i; j < l; j++)
        //     {
        //         if (result[i] > result[j])
        //         {
        //             if (result[i] != null)
        //             {
        //                 aux = result[i].Value;
        //                 result[i] = result[j];
        //                 result[j] = aux;
        //             }
        //         }
        //         else
        //         {
        //             continue;
        //         }
        //     }
        // }

        // List<int> resultList = new List<int>();
        // for (int i = 0; i < result.Length; i++)
        // {
        //     if (result[i] != null)
        //     {
        //         resultList.Add(result[i].Value);
        //     }
        // }

        // var array = resultList.ToArray();
        // return array;
    }

    /// <summary>
    /// Validates ocurrence of a number in a given array
    /// </summary>
    /// <param name="array">array to validate</param>
    /// <param name="number">number to validate</param>
    /// <returns>true if exists, false if doesnt exist</returns>
    private bool ValidateNumberInArray(int?[] array, int number)
    {
        bool found = false;

        if (array == null)
        {
            return false;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                found = true;
                break;
            }
        }

        return found;
    }
}
