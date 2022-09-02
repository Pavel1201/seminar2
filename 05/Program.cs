Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA < numberB)
{
    if(numberA * numberA == numberB)
    {
        Console.WriteLine($"{numberB} - квадрат {numberA}");
    }
    else
    {
           Console.WriteLine($"{numberB} - не является квадратом {numberA}");
    }

}
else
{
    if(numberB * numberB == numberA)
{
    Console.WriteLine($"{numberA} - квадрат {numberB}");
}
else
{
       Console.WriteLine($"{numberA} - не является квадратом {numberB}");
}
}