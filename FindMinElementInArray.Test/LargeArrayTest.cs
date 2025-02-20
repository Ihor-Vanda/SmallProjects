using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMinElementInArray.Test
{
    public class LargeArrayTest
    {
        public class LargeArrayTests
        {
            [Fact]
            public void GetMinElement_LargeArray_ReturnsCorrectMinValue()
            {
                // Arrange
                const int size = 1_000_000;
                var random = new Random();
                var array = new List<int>(size);

                for (int i = 0; i < size; i++)
                {
                    array.Add(random.Next(100, 10000));
                }

                int expectedMin = -50;
                int randomIndex = random.Next(0, size);
                array[randomIndex] = expectedMin;

                // Act
                int actualMin = MinOrMaxElementInArray<int>.GetMinElement(array);

                // Assert
                Assert.Equal(expectedMin, actualMin);
            }

            [Fact]
            public void GetMaxElement_LargeArray_ReturnsCorrectMaxValue()
            {
                // Arrange
                const int size = 1_000_000;
                var random = new Random();
                var array = new List<int>(size);

                for (int i = 0; i < size; i++)
                {
                    array.Add(random.Next(1, 5000));
                }

                int expectedMax = 10000;
                int randomIndex = random.Next(0, size);
                array[randomIndex] = expectedMax;

                // Act
                int actualMax = MinOrMaxElementInArray<int>.GetMaxElement(array);

                // Assert
                Assert.Equal(expectedMax, actualMax);
            }
        }
    }
}