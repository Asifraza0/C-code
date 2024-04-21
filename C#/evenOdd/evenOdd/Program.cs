public class Program {
   
    public static void Main(string[] args) {

        int a;
        Console.WriteLine("enter any number");
        a=int.Parse(Console.ReadLine());

        if (a% 2 == 0)
        {

            Console.WriteLine("even number =" + a);

        }
        else {

            Console.WriteLine("odd number =" + a);
        }


    }  

}
