Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB == max)
{
    Console.WriteLine("numbers are equal");
}

else 

    if (numberB > max)
    {
        max = numberB;
        Console.WriteLine("max number = " + max);
    }

    else 
    {
        max = numberA;
        Console.WriteLine("max number = " + max);
    }