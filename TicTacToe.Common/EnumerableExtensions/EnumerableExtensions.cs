using System;
using System.Collections.Generic;

namespace TicTacToe.Common.EnumerableExtensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, int index, Action<int, T> action)
        {
            foreach (var el in collection)
            {
                action(index++, el);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var el in collection)
            {
                action(el);
            }
        }
    }
}