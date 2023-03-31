// See https://aka.ms/new-console-template for more information
Console.Write("Укажите число >");
string value;
value = Console.ReadLine();
var num = Convert.ToInt32(value);
if (num%2 ==0)
{
    System.Console.Write("Число  " + num + " является четным" );
}
else 
{
    System.Console.Write("Число " + num + " не является четным");
}