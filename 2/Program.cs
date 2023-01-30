//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Vvedite pervoe chislo: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite vtoroe chislo: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Pervoe chislo bolshe vtorogo" 
: "Vtoroe chislo bolshe pervogo");
