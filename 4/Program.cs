//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Vvedite pervoe chislo: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite vtoroe chislo: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite tretie chislo: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Maksimalnoe chislo: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Maksimalnoe chislo: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Maksimalnoe chislo: " + secondNumber);
}
else
{
    Console.WriteLine("Maksimalnoe chislo: " + thirdNumber);
}