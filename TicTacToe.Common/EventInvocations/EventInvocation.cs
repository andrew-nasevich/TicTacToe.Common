using System;
using TicTacToe.Common.Interfaces;

namespace TicTacToe.Common.EventInvocations
{
    public class EventInvoker : IEventInvoker
    {
        public void Invoke<TEventArgs>(EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
            where TEventArgs : EventArgs
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}