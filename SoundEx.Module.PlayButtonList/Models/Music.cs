using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotBASS;
using dotBASS.Tags;

namespace SoundEx.Module.PlayButtonList
{
    public enum MusicStatus
    {
        Play,Pause,Stopped

    }

    public class Music
    {
        public string content { get; set; }
        public string path { get; set; }
        public string relativePath { get; set; }
        private MusicStatus _status;
        public MusicStatus status
        {
            get { return _status; }
            set
            {
                if(_status==MusicStatus.Pause)
                {
                    BASS.BASS_ChannelSetPosition(stream, this.position, BASSPosMode.BASS_POS_BYTE);
                    BASS.BASS_ChannelPlay(this.stream, false);
                }
                else if (_status==MusicStatus.Play)
                {
                    this.position = BASS.BASS_ChannelGetPosition(stream, BASSPosMode.BASS_POS_BYTE);
                    BASS.BASS_ChannelPause(this.stream);
                }
                else if(_status==MusicStatus.Stopped)
                {
                    BASS.BASS_ChannelPlay(stream, true);
                }
                _status = value;



            }
        }
        public ulong position { get; set; }

        public UInt32 stream { get; set; }

        public BASS_TAG bassTAG { get; set; }


        ~Music()
        {
            BASS.BASS_StreamFree(this.stream);
        }


    }
}
