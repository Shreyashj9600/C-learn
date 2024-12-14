namespace Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);

            // boolien data type

            //int a = 90;
            //int b = 70;

            //bool c = a > b;
            //Console.WriteLine(c);


            // implicit conversion data type 
            int a = 20;
            float b = a;
            Console.WriteLine(b);


            // explicet conversion data type 
            float c = 2022.3333f;
            int d = (int)c;
            Console.WriteLine(d);

            string num1 = "50";
            string num2 = "60";

            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}
