namespace CardinalToOrdinary
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresa el numero: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"{number}{CardinalToOrdinary(number)}");
            }
        }

        static string CardinalToOrdinary(int number)
        {
            if(number <= 0)
            {
                return "";
            }
            if(number <= 3 || number > 20)
            {
                int finalNumber = int.Parse(number.ToString().ToCharArray().Last().ToString());
                switch (finalNumber)
                {
                    case 1:
                        return "st";
                    case 2:
                        return "nd";
                    case 3:
                        return "rd";
                }
            }

            return "th";
        }
    }
}
