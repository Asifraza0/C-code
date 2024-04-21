class sumofd { 

    public static void Main()
    {


        int input;
        int a = 0;
        int b = 0;
        Console.WriteLine("enter a  random number ");
        input = int.Parse(Console.ReadLine());

        while( input != 0 )
        {

            b = input % 10;

            a = a + b;
            input = input / 10;

           
            }

        Console.WriteLine("sum of the number is:=" + a);
    }

}
