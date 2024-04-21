public class Program
{

    public static void Main(string[] args)
    {

        int  fnumber;
      
        int snumber;
        Console.WriteLine("Enter two number for swapping  :");
       
        fnumber = int.Parse(Console.ReadLine());
        snumber = int.Parse(Console.ReadLine());
        Console.WriteLine("before swapping  firstNumber : =" + fnumber + "\n  secondNumber" + snumber);

        fnumber = fnumber +  snumber;

        snumber= fnumber - snumber;
        fnumber = snumber - fnumber;

       
        Console.WriteLine("after swapping  firtNumber =" + fnumber + "\n secondnumber" + snumber);



        


    }
}



