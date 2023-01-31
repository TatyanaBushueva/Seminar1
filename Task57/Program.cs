// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

/*int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
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

int[,] UnikElemQantity(int[] arr)
{
    int count = 0;
    int[] uniqarr = arr.Distinct().ToArray();
    int[,] arr2D = new int[uniqarr.Length,1];
    int currentElem = arr[i];
    for (int i = 0; i < arr.length; i++)
    {
        if (arr(i) == arr[i + 1]) count++;
        else
        {
            arr2D[k,0] = currentElem;
            arr2D[k,1] = count;
            k++; 
        }

    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = MatrixToArray(array2D);
PrintArray(array);
Array.Sort(array);
PrintArray(array);*/

int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 10;
//int randLength = matrixMaxValue - matrixMinValue-1;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue );
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);

int[] firstArray = NumberDictionary(firstMatrix);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Array.Sort(firstArray);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Dictionary(firstArray);


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

int[] NumberDictionary (int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i,j];
            index++;
        }
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Dictionary (int[] array)
{
    int number = array[0];
    int count = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else 
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }    
    }
    Console.WriteLine($"{number} -> {count}");
}









