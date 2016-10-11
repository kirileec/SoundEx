using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using SoundEx.Infrastructure.Bases;
using SoundEx.Infrastructure.Events;
using System;
using System.Collections.Generic;

using System.Linq;

namespace SoundEx.Module.Control.ViewModels
{
    public class ControlPanelViewModel : ViewModelBase
    {
        public ControlPanelViewModel()
        {
            this.AddFileCommand = new DelegateCommand(AddFile);
        }

        private void AddFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog.Filter = "MP3文件|*.MP3|WAV文件|*.wav";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string fName =null;
            if (openFileDialog.ShowDialog() == true)
            {
                fName = openFileDialog.FileName;

            }
            if(fName!=null)
            {
                _eventAggregator.GetEvent<MusicAddFileEvent>().Publish(fName);
            }
            


        }

        public DelegateCommand AddFileCommand { get; set; }


    }
}
