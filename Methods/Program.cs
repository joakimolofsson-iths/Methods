namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Addera(5, 5);
            Multiplicera(5, 5);*/

            /*HelloWorld();
            HelloWorld("Bacon");
            HelloWorld("Hej", "Världen");*/

            /*int sum = Multiplicera(5, 5);
            Console.WriteLine(sum);*/

            /*double raise = SalaryRaise(30000);
            double afterTax = AfterTax(raise, 30000);
            Console.WriteLine($"5% raise: {raise} | New salary after tax: {afterTax}");*/

            /*string[] stuff = { "Apa", "Bacon", "Fish", "Car", "Person" };
            Console.WriteLine(Joined(stuff));*/

            Callback(10);
        }

        static int Callback(int num)
        {
            Console.WriteLine(num);
            if(num > 0)
            {
                return Callback(num - 1);
            }

            return num;
        }

        /*static string Joined(string[] stuff)
        {
            return string.Join(", ", stuff);
        }*/

        /*static double AfterTax(double raise, int salary)
        {
            double salaryWithRaise = salary + raise;
            return salaryWithRaise - (salaryWithRaise * 0.3);
        }
        static double SalaryRaise(int salary)
        {
            return salary * 0.05;
        }*/

        /*static int Multiplicera(int num1, int num2)
        {
            return num1 * num2;
        }*/

        /*static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void HelloWorld(string val)
        {
            Console.WriteLine($"Hello {val}!");
        }
        static void HelloWorld(string val1, string val2)
        {
            Console.WriteLine($"{val1} {val2}!");
        }*/

        /*static void Addera(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Multiplicera(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }*/
    }
}
