/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr, int n)
{
    int[] summ = new int[n];
    double[] sred = new double[n];
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
            summ[i] += matr[j, i];
        }
        System.Console.WriteLine();
        
    }

    Console.WriteLine(string.Join(" ", summ));

    foreach (double elem in summ)
    {
        Console.WriteLine($"среднее арифметическое числа {elem} равняется {elem/n}"); 
    }
    
}

 
int m = ReadInt("Введите количетсво строк: ");
int n = ReadInt("Введите количество столбцов: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix, n);