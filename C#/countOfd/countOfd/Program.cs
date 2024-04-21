public class Program
{

    public static void Main(string[] args)
    {

        int number;
        int counter = 0;
        int b;
        Console.WriteLine("Enter a number :");
        number = int.Parse(Console.ReadLine());




        {
            while (number > 0)
            {
                b = number % 10;
                number /= 10;
                counter++;
            }
            Console.WriteLine("total  number: =" + counter);

        }


    }
}



