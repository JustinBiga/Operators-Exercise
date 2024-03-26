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



            //Exercise 2

            Console.WriteLine("Enter the radius of your circle");

            // double radius = double.Parse(Console.ReadLine());
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)

        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }

}
