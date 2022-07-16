using System;
using BookShelf.Domain.Dispatcher;
using BookShelf.Domain.DispatcherTimer;

namespace BookShelf.Infrastructure.DispatcherTimer;

internal class DispatcherTimerFactory : IDispatcherTimerFactory
{
    private readonly IDispatcher _dispatcher;

    public DispatcherTimerFactory(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    public IDispatcherTimer Create(TimeSpan elapsedTime)
    {
        return new DispatcherTimer(elapsedTime, _dispatcher);
    }
}