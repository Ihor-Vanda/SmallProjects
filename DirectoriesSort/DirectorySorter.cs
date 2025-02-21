namespace DirectoriesSort
{
    public static class DirectorySorter
    {
        public static IEnumerable<DirectoryInfo> GetSortedDirectories<T>(
            string path,
            Func<DirectoryInfo, T> sortSelector,
            bool descending = false)
        {
            if (path == null || string.IsNullOrEmpty(path)) throw new ArgumentException($"Path isn't correct: {path}");

            var directories = new DirectoryInfo(path).GetDirectories();

            return descending
                ? directories.OrderByDescending(sortSelector)
                : directories.OrderBy(sortSelector);
        }
    }

}