using Prism.Commands;
using Prism.Mvvm;
using SoundEx.Infrastructure.Bases;
using SoundEx.Infrastructure.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SoundEx.Infrastructure.Constants;
using System.Windows.Controls;
using dotBASS;
using dotBASS.Tags;

namespace SoundEx.Module.PlayButtonList.ViewModels
{
    public class PlayButtonListViewModel : ViewModelBase
    {
        public PlayButtonListViewModel()
        {
            BASS.BASS_Init(-1, 44100, BASSInitFlags.BASS_DEVICE_DEFAULTS, IntPtr.Zero);
            this.musics = new ObservableCollection<Music>();

            _eventAggregator.GetEvent<MusicAddFileEvent>().Subscribe(e => AddFile(e));


            MusicService musicservice = new MusicService();
            var _music = musicservice.AddTestMusic(@"D:\CodeBase\音效软件\Win32\Debug\单车.mp3");
            this.musics.Add(_music);

            _music = musicservice.AddTestMusic(@"D:\CodeBase\音效软件\Win32\Debug\苦瓜.mp3");
            this.musics.Add(_music);

        }

        private void AddFile(string e)
        {
            MusicService musicservice = new MusicService();
            var _music = musicservice.AddTestMusic(e);
            this.musics.Add(_music);
        }

        public ObservableCollection<Music> musics { get; set; }

        private Music _music;
        public Music music
        {
            get { return _music; }
            set
            {
                SetProperty(ref _music, value);
                foreach (var item in musics.Where(x => x.status == MusicStatus.Play).ToList())
                {
                    if (item.status == MusicStatus.Play)
                    {
                        item.status = MusicStatus.Pause;                        
                    }

                }

                value.status = MusicStatus.Play;
 
            }
        }


        ~PlayButtonListViewModel()
        {
            BASS.BASS_Free();
        }


    }
}
