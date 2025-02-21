using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int initialNumber, int stopNumber)
        {
            if (stopNumber < initialNumber) throw new ArgumentException("Stop number must be more than initial");

            var sequence = new StringBuilder();

            for (int i = initialNumber; i <= stopNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) sequence.Append("FizzBuzz");
                else if (i % 3 == 0) sequence.Append("Fizz");
                else if (i % 5 == 0) sequence.Append("Buzz");
                else sequence.Append(i);

                if (i + 1 <= stopNumber) sequence.Append(", ");
            }
            return sequence.ToString();
        }
    }
}