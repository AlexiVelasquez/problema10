// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese todo su consumo respectivo");
double consumo = double.Parse(Console.ReadLine());
double dscto, total;
if (consumo <= 100)
{
    dscto = consumo * 0.10;
    total = dscto +18/100;
    Console.WriteLine("Total a pagar:" + total + "$");
}
else if (consumo >= 100)
{

    dscto = consumo * 0.20;
    total = dscto +18/100;
    Console.WriteLine("Total a pagar:" + total + "$");

}