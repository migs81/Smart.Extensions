using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Migs.Extensions.Collections
{
    /// <summary>
    /// Contains extension methods for collections.
    /// </summary>
    public static class CollectionExt
    {
        /// <summary>
        /// Determines whether [is null or empty].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if [is null or empty] [the specified source]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is not null && source.Any();

        /// <summary>
        /// Determines whether this instance is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull<T>(this IEnumerable<T> source) => source is null;

        /// <summary>
        /// Adds a range of objects to the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="collection">The collection.</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/>, <paramref name="collection"/></exception>
        public static void AddRange<T>(this ObservableCollection<T> source, IEnumerable<T> collection)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = collection ?? throw new ArgumentNullException(nameof(collection));

            foreach (T item in collection)
                source.Add(item);
        }

        /// <summary>
        /// Converts the given collection to a new observable collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source) => new(source);

        /// <summary>
        /// Distincts by specific property.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                    yield return element;
            }
        }
    }
}
