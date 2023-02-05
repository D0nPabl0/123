//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Vvedite trehznachnoe chislo: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Vvedeno nepravilnoe chislo");
    return;
    }
    int otvet = num / 10 % 10;
    Console.WriteLine($"2 cifra: {otvet}");
    