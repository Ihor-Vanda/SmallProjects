namespace FibonacciSequence
{
    public static class FibonacciNumbers
    {
        public static List<int> GetNumbers(int endIndex)
        {
            if (endIndex < 0) throw new ArgumentException($"End index must be at least 0 or more. Current value of count {endIndex}");
            else if (endIndex == 0) return [0];
            else if (endIndex == 1) return [0, 1];
            else return CalculateFibonacciNumbers(endIndex);
        }

        private static List<int> CalculateFibonacciNumbers(int endIndex)
        {
            var fibonacciNumbers = new List<int> { 0, 1 };

            for (int i = 2; i <= endIndex; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
            }

            return fibonacciNumbers;
        }
    }
}