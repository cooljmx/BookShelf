using System;
using System.Threading;
using BookShelf.Domain.Dispatcher;
using BookShelf.Domain.DispatcherTimer;

namespace BookShelf.Infrastructure.DispatcherTimer;

internal class DispatcherTimer : IDispatcherTimer
{
    private readonly IDispatcher _dispatcher;
    private readonly TimeSpan _elapsedTime;
    private readonly Timer _timer;

    public DispatcherTimer(
        TimeSpan elapsedTime,
        IDispatcher dispatcher)
    {
        _elapsedTime = elapsedTime;
        _dispatcher = dispatcher;
        _timer = new Timer(TimerCallback);
    }

    public void Start()
    {
        _timer.Change(TimeSpan.Zero, _elapsedTime);
    }

    public event Action Tick;

    private void TimerCallback(object state)
    {
        _dispatcher.BeginInvoke(() => Tick?.Invoke());
    }

    public void Dispose()
    {
        _timer.Dispose();
    }
}