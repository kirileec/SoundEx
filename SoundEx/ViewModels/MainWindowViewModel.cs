using Prism.Mvvm;

namespace SoundEx.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "SoundEx";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
