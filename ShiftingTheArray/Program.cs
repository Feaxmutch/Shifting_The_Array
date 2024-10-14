namespace ShiftingTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 9;
            int[] numbers = new int[4];
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber + 1);
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n\n" + "На сколько позиций влево вы хотите сдвинуть эти числа?");

            int numberMoves = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberMoves; i++)
            {
                int numberBuffer = numbers[firstIndex];

                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }

                numbers[lastIndex] = numberBuffer;
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.ReadKey();
        }
    }
}
