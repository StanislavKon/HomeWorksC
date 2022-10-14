/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решение 1:
Console.Clear();
string Palindrome(int num)
{
    string res;
    string numString = Convert.ToString(num);
    
    if (numString.Length == 5)
    {
        char one = numString[0];
        char two = numString[1];
        char four = numString[3];
        char five = numString[4];
        if (one == five && two == four)
            res = $"Число {num} - палиндром.";
        else
            res = $"Число {num} не является палиндромом.";
    }
    else
        res = "Введите пятизначное число.";
    return res;
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(num);
Console.WriteLine(result);
Console.ReadLine();
*/

/*
// Решение 2:

Console.Clear();
int ReverseNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result *= 10;
        result = result + num % 10;
        num /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverseNum = ReverseNumber(num);

if(num == reverseNum)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число {num} - палиндром.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {num} НЕ является палиндромом.");
}
Console.ReadLine();

/*
Console.Clear();
void Palindrome(int num)
{
    int symbol_1 = num / 10000;
    int symbol_5 = num % 10;
    int symbol_2 = num / 1000 % 10;
    int symbol_4 = num / 10 % 10;
    if(symbol_1==symbol_5 && symbol_2==symbol_4)
        Console.WriteLine($"Число {num} - палиндром.");
    else
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);
Console.ReadLine();
*/

/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double FindDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}
Console.Write("Введите коордитану X точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка A будет иметь координаты ({ax}, {ay}, {az}).");
Console.Write("Введите коордитану X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка B будет иметь координаты ({bx}, {by}, {bz}).");
Console.WriteLine($"Расстояние между точкой A({ax}, {ay}, {az}) и точкой B({bx}, {by}, {bz}) примерно равно равно {Math.Round(FindDistance(ax, ay, az, bx, by, bz), 2)}.");
*/


/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
void FindCubesofNumbers(int N)
{
    int count = 1;
    if(N<1)
        Console.WriteLine("Введите число больше 1");
    else
    {
        while(count<=N)
        {
            Console.Write($"{Math.Pow(count,3)} ");
            count++;
        }
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Кубы чисел от 1 до {N}: ");
FindCubesofNumbers(N);
Console.ReadLine(); 
*/

/*
if (result_1 != result_2)
{
    Console.WriteLine($"Число {number} - не палиндорм.");
}
else 
    while(i-2<=end-1)
    {
        double del1= Math.Pow(10, a-1);
        int result_3 = (int) (number / del % 10);
        int result_4 = number / b % 10;
        if(result_3==result_4)
        {
            a--;
            b*=10;
            i--;
           count++;
           Console.WriteLine(count);
        }
        
    }
*/