// Задача 39
// Напишите программу, 
// которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т. д.)


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



void ReverseArrayVersion2(int[] array)
{
int index1 = 0;
int index2 = array.Length - 1;

while (index1 < index2)
{
int obj = array[index1];
array[index1] = array[index2];
array[index2] = obj;
index1++;
index2--;
}
}


void ReversArray(int[] arr)
{
for (int i = 0; i < arr.Length / 2; i++)
{
int temp = arr[i];
arr[i] = arr[arr.Length - 1 -i];
arr[arr.Length - 1 - i] = temp;
}
}

int[] array = CreateArrayRndInt(12, 1, 10);
PrintArray(array);
ReversArray(array);
PrintArray(array); 
Array.Reverse(array);
PrintArray(array);
ReverseArrayVersion2(array);
PrintArray(array);

