
        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        Console.WriteLine("Введите число:");
        int number;
        bool success = int.TryParse(Console.ReadLine()!, out number);

        void SumNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.Write($"{sum}");
        }

        SumNumber(number);