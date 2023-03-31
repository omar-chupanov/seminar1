// See https://aka.ms/new-console-template for more information
Console.Write("Укажите число >");
string value;
value = Console.ReadLine();
var numA = Convert.ToInt32(value);
System.Console.Write("Укажите число >");
value = Console.ReadLine();
var numB = Convert.ToInt32(value);
if (numA > numB)
{
System.Console.Write("max= "+ numA );
}
else
{
System.Console.Write ("max= "+ numB );
}
