// Задача 30: Напишите программу, которая
// 1.выводит массив из 8 элементов, 
// 2.заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
// }


// void PrintArray(int[] arr)
// {
//        for (int i = 0; i < arr.length; i++)
//     {
//         Console.WriteLine(arr[i] + " ");
//     } 
// }


// int[] array = new int[8]; // 0,1,2,3,4,5,6,7

// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
//     Random rnd = Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


int[] array = new int[8]; // 0,1,2,3,4,5,6,7

            FillArray(array);
            PrintArray(array);

            void FillArray(int[] arr)
            {
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(0, 2);
                }
            }

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

