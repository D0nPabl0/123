Console.Clear();
Console.Write("Vvedite trehznachnoe chislo: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Vvedeno nepravilnoe chislo");
    return;
    }
    int otvet = num % 10;
    Console.WriteLine($"3 cifra: {otvet}");