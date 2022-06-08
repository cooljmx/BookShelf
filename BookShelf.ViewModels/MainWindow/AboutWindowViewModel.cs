using BookShelf.Domain.Settings;
using BookShelf.ViewModels.Windows;

namespace BookShelf.ViewModels.MainWindow
{
    public class AboutWindowViewModel : WindowViewModel<IAboutWindowMementoWrapper>, IAboutWindowViewModel
    {
        public AboutWindowViewModel(IAboutWindowMementoWrapper windowMementoWrapper)
            : base(windowMementoWrapper)
        {
        }
    }
}