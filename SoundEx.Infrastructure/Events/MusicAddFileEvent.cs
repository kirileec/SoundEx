using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace SoundEx.Infrastructure.Events
{
    public class MusicAddFileEvent:PubSubEvent<string>
    {
    }
}
