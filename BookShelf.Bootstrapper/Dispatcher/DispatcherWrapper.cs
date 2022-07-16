using System;
using BookShelf.Domain.Dispatcher;

namespace BookShelf.Bootstrapper.Dispatcher;

internal class DispatcherWrapper : IDispatcher
{
    private readonly System.Windows.Threading.Dispatcher _currentDispatcher;

    public DispatcherWrapper()
    {
        _currentDispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher;
    }

    public void BeginInvoke(Delegate @delegate)
    {
        _currentDispatcher.BeginInvoke(@delegate);
    }
}