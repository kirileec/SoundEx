using Microsoft.Practices.Unity;
using Prism.Events;
using SoundEx.Infrastructure.Events;
using SoundEx.Infrastructure.Interfaces;
using SoundEx.Module.Log.ViewModels;
using System.Windows.Controls;

namespace SoundEx.Module.Log.Views
{
    /// <summary>
    /// Interaction logic for LogView
    /// </summary>
    public partial class LogView : UserControl
    {
        public LogView(IUnityContainer container)
        {
            InitializeComponent();
            DataContext = new LogViewModel();
            container.Resolve<ISetRichTextBox>().SetRichTextBox(this.richLogView);
        }
    }
}
