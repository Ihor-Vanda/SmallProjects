using System.Collections.Generic;

namespace Calculators
{
    public interface ICalculation<T>
    {
        T AddValues(T firstValue, T secondValue);
        T MinusValues(T firstValue, T secondValue);
        T MultyplyValues(T firstValue, T secondValue);
        T DivisionValues(T firstValue, T secondValue);
    }
}