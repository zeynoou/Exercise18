namespace Exercise18
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers :");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Convert.ToInt32(b);
            var result3 = Divisible(result1, result2);
            Console.WriteLine(result3);
        }

        public static bool Divisible(int a, int b)
        {
            if((a / b) == 0)
                return true;
            else
                return false;
        }
    }

}