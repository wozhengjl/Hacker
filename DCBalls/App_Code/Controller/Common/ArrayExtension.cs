namespace DoubleColor.Redballs.Common
{
    using System;

    /// <summary>
    /// Static extensions to Array
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns a flag that indicates if the given parameter is null or empty.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this Array array)
        {
            // While we originally targeted this for Identity[] we let it be for all arrays.
            return null == array || 0 == array.Length;
        }
    }

    /// <summary>
    /// Generic array class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Array<T>
    {
        /// <summary>
        /// An empty array object.
        /// </summary>
        public static readonly T[] Empty = new T[0];
    }
}