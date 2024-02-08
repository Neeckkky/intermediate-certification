//1 Задача 
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(M, N);

void PrintNaturalNumbers(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNaturalNumbers(M + 1, N);
    }
    else
    {
        return;
    }
}


//2 Задача
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine("Результат функции Аккермана: " + result);

int Ackermann(int m, int n)
{   
if (m == 0)
{
    return n + 1;
}
 else if (m > 0 && n == 0)
{
    return Ackermann(m - 1, 1);
}
else
{
    return Ackermann(m - 1, Ackermann(m, n - 1));
}
}


// 3 Задача
int[] array = {1, 2, 5, 0, 10, 34};
Console.WriteLine("Элементы массива в обратном порядке:");
ReverseArray(array, array.Length - 1);

void ReverseArray(int[] array2,int indexx)
{
   if (indexx >=0)
   {
    Console.WriteLine(array2[indexx]);
    ReverseArray(array2, indexx - 1);
   }
}
