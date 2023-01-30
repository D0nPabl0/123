//napishite prog kotoroya na vhod prinimaet odno chislo (N),
//a na vihode pokazivaet vse chisla v promejutke ot -N do N.

Console.Clear();
Console.Write("Vvedite pervoe chislo: ");
int number = int.Parse(Console.ReadLine());
int i = -1 * number;
while(i <= number){
    Console.Write($"{i} ");
    i++;
}