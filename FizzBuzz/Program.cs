namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    

{
        int number;
        Console.WriteLine("enter a number");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0 & number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine("Your number is not FizzBuzz");
        }

        Console.ReadLine();

    }
}



