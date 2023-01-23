// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
// копирования.

int[] arrayOrigin = CreateArrayRndInt(18, -3, 3);
int[] arrayCopy = CopyArray(arrayOrigin);
//arrayCopy[0] = 30;
PrintArray(arrayOrigin);
PrintArray(arrayCopy);

int[] CopyArray(int[] arr)
{
int[] result = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
result[i] = arr[i];
}
return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
