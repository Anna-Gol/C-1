Console.Write("Enter positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;

if(number <= 0)
{
    Console.WriteLine("Enter the number greater than zero!");
}

else
{

    while(i <= number) 
    {
        if (i % 2 == 0)
        {
            Console.Write(i +" ");
        }

    i++;
    }
}