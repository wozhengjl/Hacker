using System;
using System.Collections.Generic;
namespace DoubleColor.Redballs.Common
{
    /// <summary>
    /// Summary description for ObjectExtension
    /// </summary>
    public static class ObjectExtension
    {
        public static void Perform<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            if (null != sequence && null != action)
            {
                foreach (T item in sequence)
                {
                    action(item);
                }
            }
        }
    }
}