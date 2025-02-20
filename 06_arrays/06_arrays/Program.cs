// var nubmers = new[] { 5, 10, 15 };
//
// foreach (var number in nubmers)
// {
//     Console.WriteLine(number);
// }

int[,] numbers = new int[3, 5] {
    { 1, 2, 3, 4, 5 },
    { 3, 10, 44, 12, 1 },
    { -2, 17, 19, 40, 100 }
};

foreach (var number in numbers)
{
    Console.WriteLine(number);
}





// int[,] numbers = new int[3, 5] {
//     { 1, 2, 3, 4, 5 },
//     { 3, 10, 44, 12, 1 },
//     { -2, 17, 19, 40, 100 }
// };
//
// // Console.WriteLine(numbers[2, 3]);
//
// for (var i = 0; i < numbers.GetLength(0); i++)
// {
//     for (var j = 0; j < numbers.GetLength(1); j++)
//     {
//         Console.WriteLine(numbers[i, j]);
//     }
// }




// var numbers = new[] { 5, 7, 14, 22, 1 };
//
// for (var i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }





// var numbers = new int[5];
//
// Console.WriteLine(numbers[0]);
// Console.WriteLine(numbers[1]);
// Console.WriteLine(numbers[2]);
// Console.WriteLine(numbers[3]);
// Console.WriteLine(numbers[4]);
//
// numbers[0] = 15;
// Console.WriteLine();
// Console.WriteLine(numbers[0]);
//
// Console.WriteLine(numbers[5]);






// var numbers1 = new int[5];
//
// var numbers2 = new int[] { 1, 3, 8 };
//
// int[] numbers3;
// numbers3 = new int[2] { 10, -5 };
