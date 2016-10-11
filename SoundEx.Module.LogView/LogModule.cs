using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using SoundEx.Infrastructure.Events;
using SoundEx.Module.Log.Views;
using System;
using Prism.Logging;
using SoundEx.Infrastructure.Bases;
using Microsoft.Practices.Unity;

namespace SoundEx.Module.Log
{
    public class LogModule : ModuleBase
    {


        public LogModule()
        {

        }

        public override void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MessageRegion", typeof(LogView));



        }
    }
}