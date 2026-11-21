using System.Collections.ObjectModel;

namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for collections.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Determines whether the given collection is null or empty.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
        /// <param name="source">The sequence to check.</param>
        /// <returns>
        ///     <see langword="true"/> if the sequence is <see langword="null"/> or empty; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T>? source) => source is null || !source.Any();

        /// <summary>
        /// Determines whether the given collection is null.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
        /// <param name="source">The sequence to check.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull<T>(this IEnumerable<T>? source) => source is null;

        /// <summary>
        /// Adds the elements of the specified collection to the end of the <see cref="ObservableCollection{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the collection.</typeparam>
        /// <param name="source">The collection to add the elements to.</param>
        /// <param name="collection">The collection whose elements should be added.</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="source"/> or <paramref name="collection"/> is <see langword="null"/>.
        /// </exception>
        public static void AddRange<T>(this ObservableCollection<T> source, IEnumerable<T> collection)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = collection ?? throw new ArgumentNullException(nameof(collection));
            
            foreach (var item in collection)
                source.Add(item);
        }

        /// <summary>
        /// Creates a new <see cref="ObservableCollection{T}"/> containing the elements of the specified sequence.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
        /// <param name="source">The sequence whose elements should be added to the collection.</param>
        /// <returns>A new <see cref="ObservableCollection{T}"/> containing the elements of the specified sequence.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source) => new(source);
    }
}
