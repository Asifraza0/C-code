public class Program
{

    public static void Main(string[] args)
    {

        int number;
        int reverse = 0;
        int b;
        Console.WriteLine("Enter a number :");
        number = int.Parse(Console.ReadLine());




        {
            while (number > 0)
            {
                b = number % 10;
                reverse = reverse * 10 + b;
                number /= 10;
            }
            Console.WriteLine("reverse number: =" + reverse);

        }


    }
}




