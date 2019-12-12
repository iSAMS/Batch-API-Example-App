using System;
using System.Windows.Forms;
using Autofac;
using iSAMS.BatchAPI.Demo.Core.Services.Implementations;
using iSAMS.BatchAPI.Demo.Core.Services.Interfaces;

namespace iSAMS.BatchAPI.Demo.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Configure Autofac container with service dependency type registrations.
            var builder = new ContainerBuilder();
            builder.RegisterType<RequestService>().As<IRequestService>();
            builder.RegisterType<FiltersXmlService>().As<IFiltersXmlService>();
            builder.Register(f => new RequestForm(f.Resolve<IFiltersXmlService>(), f.Resolve<IRequestService>())).As<RequestForm>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var container = builder.Build())
            {
                Application.Run(container.Resolve<RequestForm>());
            }
        }
    }
}