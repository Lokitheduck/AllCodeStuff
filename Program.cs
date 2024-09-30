namespace AllCodeStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please input a number");
            int NumberChoosen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input another number");
            int NumberChoosen1 = Convert.ToInt32(Console.ReadLine());


            // hi love guithub
            if (NumberChoosen == NumberChoosen1)
            {
                Console.WriteLine(NumberChoosen + "is equal to" + NumberChoosen1);

            }
            else
            {
                Console.WriteLine(NumberChoosen + "is not equal to " + NumberChoosen1);

            }

           
            
        }
    }
}
