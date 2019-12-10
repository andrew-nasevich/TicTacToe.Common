using System;

namespace TicTacToe.Common.EventExtensions
{
    public static class EventExtensions
    {
        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) 
            where TEventArgs: EventArgs
        {
            eventHandler?.Invoke(sender, e);
        }

        public static void Raise(this EventHandler eventHandler, object sender, EventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}