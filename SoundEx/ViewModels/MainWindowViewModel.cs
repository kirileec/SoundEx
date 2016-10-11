using Prism.Mvvm;
using SoundEx.Infrastructure.Bases;
using Microsoft.Practices.Unity;
using SoundEx.Infrastructure.Events;

namespace SoundEx.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
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
