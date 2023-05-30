namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For division create two integer variables a and b.
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            if(a == 17 && b == 4)
            {
                
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

                Console.WriteLine("What is the radius of your circle?");


                var radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"The area of your circle with a radius of {radius} is {AreaOfCircle(radius)}");
            }
        }
        //Define a method which will calculate the area of a circle based on its radius. 
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

    }
}
