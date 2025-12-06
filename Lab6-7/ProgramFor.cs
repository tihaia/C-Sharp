// using System;
// using System.Diagnostics;

// int[] arr1 = [1, 2, 3];
// int[] arr2 = [4, 5, 6];
// int[] result = new int[arr1.Length];

// ArraySum(arr1, arr2, result);

// Console.WriteLine("Результаты попарных сумм: ");

// for (int i = 0; i < result.Length; i++)
// {
//     Console.WriteLine(result[i] + " ");
// }

// static void ArraySum(int[] arr1, int[] arr2, int[] sum)
// {
//     Debug.Assert(arr1.Length == arr2.Length && arr1.Length == sum.Length, "Длины всех массивов должны совпадать.");
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         sum[i] = arr1[i] + arr2[i];
//     }
// }
