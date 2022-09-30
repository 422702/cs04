// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите через пробел число и его степень ");
string[] parts = Console.ReadLine()!.Split(' ');
int number = int.Parse(parts[0]);
int digit = int.Parse(parts[1]);
//Console.WriteLine($"Результат = {Math.Pow(number,digit):F4}");

double result=1.0; //  если степень числа равна 0
if (digit>0) // если степень положительное число
{   result=number;
        for(int i=1;i<digit;i++)
        {
            result=result*number;
        }
}
if(digit<0) // если степень отрицательное число
{   double  denominator=1.0/number;
    result=denominator;
       for(int i=1;i<Math.Abs(digit);i++)
        {
            result=result*denominator;
        }
}

Console.WriteLine($"Результат= {result:F4}");










