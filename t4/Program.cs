// See https://aka.ms/new-console-template for more information
Console.Write("Укажите число >");
string value;
value = Console.ReadLine();
var num = Convert.ToInt32(value);
var i = 1;
while (i <= num)
{
     if(i % 2 == 0)
    {
        System.Console.Write(i);
    }
    i = i + 1;
}

