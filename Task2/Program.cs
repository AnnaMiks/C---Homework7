// // // Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 1, 7 -> такого числа в массиве нет
// // 1, 1 -> 1


int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите количество строк в массиве");
int n = Prompt("Введите количество столбцов в массиве");

int[,] GenereteArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}



int Index(int[,] matr, int index1, int index2)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((i + 1) == index1 && (j + 1) == index2)
                result = matr[i, j];
        }
    }
    return result;
}


int[,] array = GenereteArray(m, n);
PrintArray(array);
System.Console.WriteLine();

int a = Prompt("Введите номер строки");
int b = Prompt("Введите номер столбца");

if ((a - 1) > m || (b - 1) > n)
    Console.WriteLine("такого числа нет");
else
{
    int number = Index(array, a, b);
    Console.WriteLine($"Ваш элемент {number}");
}
