using SoundEx.Module.Control.ViewModels;
using System.Windows.Controls;

namespace SoundEx.Module.Control.Views
{
    /// <summary>
    /// Interaction logic for ControlPanelView
    /// </summary>
    public partial class ControlPanelView : UserControl
    {
        public ControlPanelView()
        {
            InitializeComponent();
            DataContext = new ControlPanelViewModel();
        }
    }
}
