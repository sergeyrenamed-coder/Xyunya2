using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число (оценку): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade == 1 || grade == 2)
            Console.WriteLine("неудовлетворительно");
        else if (grade == 3)
            Console.WriteLine("удовлетворительно");
        else if (grade == 4)
            Console.WriteLine("хорошо");
        else if (grade == 5)
            Console.WriteLine("отлично");
        else
            Console.WriteLine("Это не является оценкой ученика (допустимы 1, 2, 3, 4, 5).");
    }
}
