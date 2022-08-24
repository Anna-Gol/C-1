Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max && numberB > numberC)
{
    max = numberB;
    Console.WriteLine("max number = " + max);
}

else 
    if (numberC > max && numberC > max)
    {
        max = numberC;
        Console.WriteLine("max number = " + max);
    }

    else 
    {
        max = numberA;
        Console.WriteLine("max number = " + max);    
    }