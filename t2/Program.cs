Console.Write("Укажите число >");
string value;
value = Console.ReadLine();
var numA = Convert.ToInt32(value);
System.Console.Write("Укажите число >");
value = Console.ReadLine();
var numB = Convert.ToInt32(value);
System.Console.Write("Укажите число >");
value = Console.ReadLine();
var numC = Convert.ToInt32(value);
var max = numA;
if (max < numB)
{
    max = numB;
    if (max< numC)
    {
        max = numC;
        System.Console.Write("max =" + numC);
    }
    if (max>numC)
    {
        System.Console.Write("max =" + numB);
    }
}
if (max<numC)
{
    System.Console.Write("max =" + numC);
}
else 
{
    System.Console.Write("max =" + numA);
} 



   

