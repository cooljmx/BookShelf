using System;

namespace BookShelf.ViewModels.Windows
{
    public interface IWindow
    {
        void Show();
        bool? ShowDialog();

        void Close();

        event EventHandler Closed;
    }

    public interface IWindow<TWindowViewModel> : IWindow
        where TWindowViewModel : IWindowViewModel
    {
    }
}