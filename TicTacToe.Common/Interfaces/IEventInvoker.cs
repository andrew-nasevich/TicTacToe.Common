using System;

namespace TicTacToe.Common.Interfaces
{
    public interface IEventInvoker
    { 
        void Invoke<TEventArgs>(EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
            where TEventArgs : EventArgs;
    }
}