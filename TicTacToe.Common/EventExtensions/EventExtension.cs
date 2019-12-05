using System;

namespace TicTacToe.Common.EventExtensions
{
    public static class EventExtension
    {
        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}