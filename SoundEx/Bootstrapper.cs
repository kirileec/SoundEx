using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using SoundEx.Views;
using System.Windows;
using Prism.Logging;
using SoundEx.Log;
using SoundEx.Infrastructure.Interfaces;

namespace SoundEx
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureContainer()
        {
            RegisterTypeIfMissing(typeof(ISetRichTextBox), typeof(RichTextBoxAppender), true);

            base.ConfigureContainer();

        }


        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            DirectoryModuleCatalog catelog = new DirectoryModuleCatalog();
            catelog.ModulePath = @".\Modules";
            return catelog;
        }

        protected override ILoggerFacade CreateLogger()
        {
            return new Log4NetLogger();
        }




    }
}
