using Autofac;
using System.Reflection;
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
        }

        private static IContainer Build()
        {
            var builder = new ContainerBuilder();

            BuildViewModels(builder);

            return builder.Build();
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