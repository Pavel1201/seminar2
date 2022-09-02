//Console.WriteLine("введите трехзначное ");
//int number = int.Parse(Console.ReadLine());
int number = new Random().Next(100,1000);
int digitHundreds = number / 100;
int digitUnits = number % 10;

Console.WriteLine($"Число {number}");
Console.WriteLine($"Число без десятков получается {digitHundreds*10 + digitUnits}");
