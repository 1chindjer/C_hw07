// +++++++++++++++++++++++++++++++++++++++ Задача 1 +++++++++++++++++++++++++++++++++++++
// Console.Write("Введите число M:  ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число N:  ");
// int N = int.Parse(Console.ReadLine());
// double[,] array = GenerateArray(M, N);
// PrintArray(array);
// // метод генерации массива
// double[,] GenerateArray(int M, int N) {
//     Random random = new Random();
//     double[,] array = new double[M, N];
//     for (int i = 0; i < M; i++) {
//       for (int j = 0; j < N; j++) {
//         array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); // случайное число от -10 до 10
//       }
//     }
//     return array;
//   }
// // метод печати массива
// void PrintArray(double[,] array) {
//         int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//     }
// }
// +++++++++++++++++++++++++++++++++++++++ Задача 2 +++++++++++++++++++++++++++++++++++++
// Console.Write("Введите число строки поиска:  ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число столбца поиска:  ");
// int N = int.Parse(Console.ReadLine());
// Console.Write("Введите размер массива A ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите размер массива B ");
// int B = int.Parse(Console.ReadLine());
// double[,] array = GenerateArray(A, B);
// proverka (array, M, N);
// PrintArray(array);

// метод создает рандомный массив
// double[,] GenerateArray(int A, int B) {
//     Random random = new Random();
//     double[,] array = new double[A, B];
//     for (int i = 0; i < A; i++) {
//       for (int j = 0; j < B; j++) {
//         array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); // случайное число от -10 до 10
//       }
//     }
//     return array;
//   }
// // метод выводит сгенерированный массив
// void PrintArray(double[,] array) {
//         int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//     }
// }
// // метод проверяет наличие элемента
// void proverka (double[,] array, int M, int N){
//     int A = array.GetLength(0);
//     int B = array.GetLength(1);
//     if (M >= 0 && M < A && N >= 0 && N < B) {
//       Console.WriteLine($"Элемент найден: array[{M}, {N}] = {array[M, N]}");
//     } else {
//       Console.WriteLine("Элемент не найден: указанные индексы выходят за пределы массива.");
// }
// }
// +++++++++++++++++++++++++++++++++++++++ Задача 2 +++++++++++++++++++++++++++++++++++++
Console.Write("Введите размер массива A ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива B ");
int B = int.Parse(Console.ReadLine());
int [,] array = GenerateArray(A, B);

Calc(array);
PrintArray(array);

//метод создает рандомный массив
int[,] GenerateArray(int A, int B) {
    Random random = new Random();
    int [,] array = new int[A, B];
    for (int i = 0; i < A; i++) {
      for (int j = 0; j < B; j++) {
        array[i, j] = random.Next(-10, 11); // случайное число от -10 до 10
      }
    }
    return array;
  }
// метод выводит сгенерированный массив
void PrintArray(int[,] array) {
        int M = array.GetLength(0);
    int N = array.GetLength(1);
    for (int i = 0; i < M; i++) {
        for (int j = 0; j < N; j++) {
            Console.Write(array[i, j] + "\t");
      }
      Console.WriteLine();
    }
}
// считаем среднее арифметическое и выводим его
void Calc (int[,] array){
    int M = array.GetLength(0);
    int N = array.GetLength(1);

    for (int j = 0; j < N; j++) {
      double sum = 0;
      for (int i = 0; i < M; i++) {
        sum += array[i, j];
      }
      double average = Math.Round(sum / M, 2);
      Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {average}");
}}