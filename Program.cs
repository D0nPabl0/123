﻿//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
Console.Clear();
int num;
Console.Write("Vvedite nomer dnya nedeli: ");
num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) Console.WriteLine("Segodnya vihodnoy");
    else Console.WriteLine("Segodnya rabochiy den");
}
else Console.WriteLine("Ne vernoe chislo");
return;
