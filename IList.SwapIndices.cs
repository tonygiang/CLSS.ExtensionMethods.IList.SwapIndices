// A part of the C# Language Syntactic Sugar suite.

using System;
using System.Collections.Generic;

namespace CLSS
{
  public static partial class IListSwapIndices
  {
    /// <summary>
    /// Swaps 2 elements at the specified index positions in place.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IList{T}"/> to swap indices.
    /// </typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IList{T}"/> to swap indices.</param>
    /// <param name="index1">The first index number to be swapped.</param>
    /// <param name="index2">The second index number to be swapped.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is
    /// null.</exception>
    public static T SwapIndices<T, TElement>(this T source,
      int index1,
      int index2)
      where T : IList<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      var e1 = source[index1];
      source[index1] = source[index2];
      source[index2] = e1;
      return source;
    }

    /// <summary>
    /// Swaps 2 elements at the specified index positions in place.
    /// </summary>
    /// <typeparam name="T">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IList{T}"/> to swap indices.</param>
    /// <param name="index1">The first index number to be swapped.</param>
    /// <param name="index2">The second index number to be swapped.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is
    /// null.</exception>
    public static IList<T> SwapIndices<T>(this IList<T> source,
      int index1,
      int index2)
    {
      if (source == null) throw new ArgumentNullException("source");
      var e1 = source[index1];
      source[index1] = source[index2];
      source[index2] = e1;
      return source;
    }
  }
}