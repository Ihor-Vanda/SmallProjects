using System.Numerics;

namespace Calculators.ArabicNumbers
{
    public class Calculator<T> : ICalculation<T> where T : INumber<T>
    {
        public T AddValues(T firstValue, T secondValue) => firstValue + secondValue;

        public T DivisionValues(T firstValue, T secondValue) => firstValue / secondValue;

        public T MinusValues(T firstValue, T secondValue) => firstValue - secondValue;

        public T MultyplyValues(T firstValue, T secondValue) => firstValue * secondValue;
    }
}