namespace Syntaxandayntaxsugarexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing
            int num = 10;
            string name = "Seth";
            int numm; //you can just declare an explicit typing
            //Inferred typing
            var otherNumber = 20;
            var otherName_1 = "John";
            //var nummm; //cant just declare a var.  It must be initialized

            //Ternary operator 
            var age = 20;

            var message = (age >= 18 ) ? "You are an adult" : "You are a minor";
            Console.WriteLine(message);

            //concatanation interpolation
            Console.WriteLine("Hello, my age is " + age);//concatanization

            Console.WriteLine($"Hello my age is {age}");//interpolation

        }
    }
}