//Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Vvedite chislo: ");
Console.WriteLine((int.Parse(Console.ReadLine())
 & 1) == 0? "Da": "Net");