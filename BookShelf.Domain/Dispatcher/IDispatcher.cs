using System;

namespace BookShelf.Domain.Dispatcher;

public interface IDispatcher
{
    void BeginInvoke(Delegate @delegate);
}