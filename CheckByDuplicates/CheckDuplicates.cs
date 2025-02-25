namespace CheckByDublicates
{
    public static class CheckDuplicates<T>
    {

        public static bool IsCollectionHaveDuplicates(IEnumerable<T> collection)
        {
            if (collection == null || !collection.Any()) throw new ArgumentException("Collection can't be null or empty");

            return collection.Distinct().Count() != collection.Count();
        }

        public static IEnumerable<T> RemoveDuplicates(IEnumerable<T> collection)
        {
            if (collection == null || !collection.Any()) throw new ArgumentException("Collection can't be null or empty");

            return collection.Distinct();
        }

        public static bool MyIsCollectionHaveDuplicates(IEnumerable<T> collection)
        {
            int count = collection.Count();
            if (collection == null || count == 0) throw new ArgumentException("Collection can't be null or empty");

            return collection.ToHashSet().Count != count;
        }

        public static IEnumerable<T> MyRemoveDuplicates(IEnumerable<T> collection)
        {
            if (collection == null || !collection.Any()) throw new ArgumentException("Collection can't be null or empty");

            HashSet<T> newCollection = new();
            foreach (T item in collection)
            {
                newCollection.Add(item);
            }


            return newCollection;
        }
    }
}