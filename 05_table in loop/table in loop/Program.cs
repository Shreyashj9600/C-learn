namespace table_in_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + number * i);
            }
            Console.WriteLine("end the loop");
            Console.ReadLine();
        }
    }
}
