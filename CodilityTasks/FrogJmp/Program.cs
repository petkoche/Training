namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Solution(10, 85, 30));
        }

        public static int Solution(int X, int Y, int D)
        {
            if((X-Y) % D == 0)
            {
                return ((Y - X) / D);
            }
            else
            {
                return (((Y - X) / D) + 1);
            }
        }
    }
}
