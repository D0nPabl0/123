Console.Clear();
Console.Write("Vvedite pervoe chislo: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Vvedite vtoroe chislo: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 * number1 == number2){
    Console.WriteLine("Da");
}
else{
    Console.WriteLine("net");
}