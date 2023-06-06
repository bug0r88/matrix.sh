Random rnd = new Random();
Console.Write("Введите размер матрицы: ");
int M = Convert.ToInt32(Console.ReadLine()); // переменная для определения размера матрицы
int[,] matrix = new int[M, M];
Console.WriteLine($"Исходная матрица: {M}x{M}");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(-10, 10);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine();
}
int count = 0;//счетчик элементов ниже главной диагонали
for (int i = 1; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        count += Math.Abs(matrix[i,j]);
    }
}
Console.WriteLine("Сумма модулей элементов" + count);
// Выводим таблицу значений функции y = sin(2x + 1)/2 на отрезке [a;b] с шагом h
double a = 0;
double b = Math.PI;
double h = 0.1;

Console.WriteLine("Таблица значений функции y = sin(2x + 1)^2:");
Console.WriteLine("x\t\ty");

for (double x = a; x <= b; x += h)
{
    double y = Math.Pow(Math.Sin(2 * x + 1),2);
    Console.WriteLine("{0:F2}\t\t{1:F4}", x, y);
}
