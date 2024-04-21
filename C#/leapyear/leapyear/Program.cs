public class Program
{

    public static void Main(string[] args)
    {

        int a;
        Console.WriteLine("enter any number to check leap-year");
        a = int.Parse(Console.ReadLine());

        if (a % 4 ==0)
        {

            Console.WriteLine("leap year =" + a);

        }
        else
        {

            Console.WriteLine("it's not a leap-year =" + a);
        }


    }

}

