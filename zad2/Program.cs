/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}
void Fiend(int[,] matrix, int s)
{
    int f=0;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(0); j ++)
        {
            if (matrix[i, j] == s)
            {
                f=1;
            }

        }
    }
if(f==1)
    {
        System.Console.WriteLine($"Элемент {s} присутствует");
    } else
    {
        System.Console.WriteLine($"Элемент {s} отсутствует");
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();
    }

}




System.Console.WriteLine("Введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Элемент");
int s = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Fiend(matrix, s);
System.Console.WriteLine();
