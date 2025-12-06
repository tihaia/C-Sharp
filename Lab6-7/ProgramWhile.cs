// using System;
// using System.Diagnostics;

// int[] arr1 = [1, 2, 3];
// int[] arr2 = [4, 5, 6];
// int[] result = new int[arr1.Length];

// ArraySum(arr1, arr2, result);

// Console.WriteLine("Результаты попарных сумм: ");

// {
//     int i = 0;
//     while (i < result.Length)
//     {
//         Console.WriteLine(result[i] + " ");
//         i++;
//     }
// }
// static void ArraySum(int[] arr1, int[] arr2, int[] sum)
// {
//     Debug.Assert(arr1.Length == arr2.Length && arr1.Length == sum.Length, "Длины всех массивов должны совпадать.");
//     {
//         int i = 0;
//         while (i < arr1.Length)
//         {
//             sum[i] = arr1[i] + arr2[i];
//             i++;
//         }
//     }
// }
