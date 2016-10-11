using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundEx.Infrastructure.Events
{
    public class NavigateViewEvent : PubSubEvent<NavigateViewEvent>
    {
        public string regionName { get; set; }
        public string viewName { get; set; }
    }
}
