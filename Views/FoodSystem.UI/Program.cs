using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
namespace FoodSystem.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pedido());
        }
    }
    public class Container : Form
    {
        private IContainer _container;
        public Container()
        {
            var business = typeof(FoodSystemEntryPoint).Assembly;
            var eFrameworkContext = typeof(DataContext.EFDataContextEntryPoint).Assembly;

            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(business);
            builder.RegisterAssemblyTypes(eFrameworkContext).AsImplementedInterfaces();
            _container = builder.Build();
        }
        protected TEntity Resolve<TEntity>() => _container.Resolve<TEntity>();
        protected override void OnClosed(EventArgs e)
        {
            _container.Dispose();
            base.OnClosed(e);
        }
    }
}
