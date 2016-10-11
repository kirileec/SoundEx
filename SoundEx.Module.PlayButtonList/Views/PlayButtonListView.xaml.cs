using Prism.Events;
using SoundEx.Infrastructure.Constants;
using SoundEx.Infrastructure.Events;
using SoundEx.Module.PlayButtonList.ViewModels;
using System.Windows.Controls;

namespace SoundEx.Module.PlayButtonList.Views
{
    /// <summary>
    /// Interaction logic for PlayButtonList
    /// </summary>
    public partial class PlayButtonListView : UserControl
    {
        public PlayButtonListView()
        {
            InitializeComponent();
            DataContext = new PlayButtonListViewModel();
            
        }

    }
}
