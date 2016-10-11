using Prism.Events;
using SoundEx.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundEx.Infrastructure.Events
{
    public class MusicControlEvent: PubSubEvent<MusicControlEvent>
    {
        public string path { get; set; }
        public MusicControlType controlType { get; set; }

    }




}
