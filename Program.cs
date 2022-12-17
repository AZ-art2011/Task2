// Задача 2

Console.WriteLine("Вас приветствует программа сравнения двух чисел");

Console.WriteLine("Введите первое число");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numSecond = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (numFirst > numSecond){
    max = numFirst;
    min = numSecond;
}
else
{
    max = numSecond;
    min = numFirst;
}

Console.WriteLine($"Число {max} - большее");
Console.WriteLine($"Число {min} - меньшее");