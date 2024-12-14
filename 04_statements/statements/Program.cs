namespace statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter you age");
            int age = int.Parse( Console.ReadLine());

            string ag = (age >= 18) ? "you give vote" : "you dont give vote";
            Console.WriteLine(ag);
            Console.ReadLine();

        }
    }
}
    