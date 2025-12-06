
// int FirstNum = InputInt("FirstNum");
// int SecondNum = InputInt("SecondNum");
// int ThirdNum = InputInt("ThirdNum");

// int result = FirstNum * SecondNum * ThirdNum;
// Console.WriteLine(result);

// static int InputInt(string name)
// {
//     while (true)
//     {
//         Console.Write($"Enter {name}: ");
//         string str = Console.ReadLine()!;
//         bool parsed = int.TryParse(str, out int result);
//         if (!parsed)
//         {
//             Console.WriteLine("Please enter a valid number");
//             continue;
//         }
//         if (result <= 2)
//         {
//             Console.WriteLine("Number must be more than 2");
//             continue;
//         }

//         return result;
//     }
// }