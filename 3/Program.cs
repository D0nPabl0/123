// napishite programmy,
// kotoroya budet vidavat nazvanie dnya nedeli po zadannomy nomery.
Console.Clear();
Console.Write("Vvedite nomer dnya nedeli: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Vveden nepravilniy nomer");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Ponedelnik");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Vtornik");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Sreda");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Chetverg");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Pyatnica");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("subbota");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("voskresenie");
}