Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine($"{numberA} кратно {numberB}");

}
else 
{
    Console.WriteLine($"{numberA} не кратно {numberB}, остаток от деления {numberA % numberB}");


}