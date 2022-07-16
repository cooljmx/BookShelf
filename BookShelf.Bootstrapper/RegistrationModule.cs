using Autofac;
using BookShelf.Bootstrapper.Dispatcher;
using BookShelf.Bootstrapper.Factories;
using BookShelf.Domain.Dispatcher;
using BookShelf.Views.Factories;

namespace BookShelf.Bootstrapper;

public class RegistrationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<WindowFactory>().As<IWindowFactory>().SingleInstance();
        builder.RegisterType<DispatcherWrapper>().As<IDispatcher>().SingleInstance();
    }
}