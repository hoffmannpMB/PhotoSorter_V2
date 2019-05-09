using Autofac;
using System.Reflection;
using MVVM_Base;
using PhotoSorter_V2.UiHelper;
using ViewModels;

namespace PhotoSorter_V2
{
    public class Bootstrapper
    {
        private static Bootstrapper _instance;
        private static readonly object IsLocked = new object();

        private Bootstrapper()
        {
            Container = Build();
            //var t = Container.Resolve<INavigationService>();
        }

        private static IContainer Build()
        {
            var builder = new ContainerBuilder();

            BuildHelper(builder);
            BuildViewModels(builder);

            return builder.Build();
        }

        private static void BuildHelper(ContainerBuilder builder)
        {
            builder.RegisterType<NavigationService>().AsImplementedInterfaces();
        }

        private static void BuildViewModels(ContainerBuilder builder)
        {
            // register all ViewModels as its implemented interfaces, except the MockViewModel.
            builder.RegisterAssemblyTypes(typeof(IMainPageViewModel).GetTypeInfo().Assembly).Where(t => t.Name.EndsWith("ViewModel") && !t.Name.StartsWith("Mock")).AsImplementedInterfaces().SingleInstance();
        }

        public IContainer Container { get; }

        public static Bootstrapper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (IsLocked)
                    {
                        if (_instance == null)
                        {
                            _instance = new Bootstrapper();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}