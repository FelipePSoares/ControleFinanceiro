[assembly: WebActivator.PostApplicationStartMethod(typeof(ControleFinanceiro.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace ControleFinanceiro.App_Start
{
    using System.Reflection;

    using SimpleInjector;
    using SimpleInjector.Integration.Wcf;
    using Repository;
    using Repository.Repository.Contracts;
    using Repository.Repository;
    using System.Web.Mvc;
    using SimpleInjector.Integration.Web.Mvc;

    public static class SimpleInjectorInitializer
    {
        private static Container container;

        public static Container Container
        {
            get
            {
                if (container == null)
                    container = new Container();

                return container;
            }
        }

        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.            
            InitializeContainer(Container);

            Container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            Container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(Container));
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<IDataContext, DataContext>();
            container.Register<ITransacaoRepository, TransacaoRepository>();
            container.Register<IGenericRepository, GenericRepository>();
        }
    }
}