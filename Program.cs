Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь");
        Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 41: PositivNumbers(); break;
            //case 43: SumNumber(); break;
            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositivNumbers()
{
     Console.Clear();

    Console.Write ("Enter 1 number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Enter 2 number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Enter 3 number: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Enter 4 number: ");
    int num4 = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Enter 5 number: ");
    int num5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Numbers: {num1}, {num2}, {num3}, {num4}, {num5}");

    int [] array  = {num1, num2, num3, num4, num5};
    int count = 0;

     for (int i = 0; i < array.Length;i++)
    {
        if (array[i] > 0)
        {
            count+=1;
        }   
    }
     Console.WriteLine("Numbers > 0 = " + count);; 
}

PositivNumbers();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

