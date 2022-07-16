using System;

namespace BookShelf.Domain.DispatcherTimer;

public interface IDispatcherTimer : IDisposable
{
    void Start();

    event Action Tick;
}