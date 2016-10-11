using dotBASS;
using dotBASS.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundEx.Module.PlayButtonList
{
    public class MusicService
    {

        public Music AddTestMusic(string path)
        {
            UInt32 stream = BASS.BASS_StreamCreateFile(path, 0, 0, BASSFlag.BASS_DEFAULT);

            Music music =new Music();

            music.path = path;
            music.relativePath = (new Uri(System.Environment.CurrentDirectory)).MakeRelativeUri(new Uri(path)).ToString();
            music.stream = stream;
            music.position = 0;
            music.bassTAG = BASS_TAG.BASS_ChannelGetTags(stream, BASSTagFlags.BASS_TAG_ID3V2);
            music.content = System.IO.Path.GetFileName(path);
            music.status = MusicStatus.Stopped;
            return music;

        }
   



    }
}
