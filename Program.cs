// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Prompt("Введите число:");

if (10000 <= value && value < 100000)
{
    if (value / 10000 == value % 10 && value / 1000 % 10 == value % 100 / 10)
    {
        System.Console.WriteLine($" Число {value} является полиндромом");
    }
    else
        System.Console.WriteLine($" Число {value} не является полиндромом");
}
else
System.Console.WriteLine("Введите положительное пятизначное число");*/




// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


/*double distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double lenght = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return Math.Round(lenght, 2);
} 

Console.Write("Input an x-coordinate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordinate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an z-coordinate of point A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an x-coordinate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordinate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an z-coordinate of point B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = distance(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");*/




// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void Square(int number)
{
    int index = 1;
    while (index <= number)
    {
        System.Console.WriteLine($"Квадрат числа {index} это {index * index}");
        index++;
    }
}
int number = Prompt("Введите число:");
Square(number);*/