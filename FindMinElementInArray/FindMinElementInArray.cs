using System.Numerics;

namespace FindMinElementInArray
{
    public static class MinOrMaxElementInArray<T> where T : INumber<T>, IComparable<T>
    {
        private static T GetMinOrMaxElement(List<T> array, Func<T, T, bool> operation)
        {
            if (array == null || array.Count == 0) throw new ArgumentException("Array must have at least 1 element");

            var currectMin = array[0];

            foreach (var element in array)
            {
                if (operation(currectMin, element)) currectMin = element;
            }

            return currectMin;
        }

        public static T GetMinElement(List<T> array)
        {
            return GetMinOrMaxElement(array, (currect, candidate) => candidate < currect);
        }

        public static T GetMaxElement(List<T> array)
        {
            return GetMinOrMaxElement(array, (currect, candidate) => candidate > currect);
        }

        public static T GetMinElementWithLINQ(List<T> array)
        {
            if (array == null || array.Count == 0) throw new ArgumentException("Array must have at least 1 element");

            return array.Min() ?? throw new ArgumentException("Can't find min element in this array");
        }

        public static T GetMaxElementWithLINQ(List<T> array)
        {
            if (array == null || array.Count == 0) throw new ArgumentException("Array must have at least 1 element");

            return array.Max() ?? throw new ArgumentException("Can't find max element in this array"); ;
        }
    }
}