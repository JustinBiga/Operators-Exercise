namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            //Addition

            int sum = a + b;
            Console.WriteLine($"{a} + {b} is equal to {sum}");

            //Subtraction

            int sub = a - b;

            Console.WriteLine($"{a}-{b} is equal to {sub}");

            //multiplication

            int multiply = a * b;

            Console.WriteLine($"{a} * {b} is equal to {multiply}");

            //Division

            int divide = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {divide} remainder {remainder}");





        }
    }
}
