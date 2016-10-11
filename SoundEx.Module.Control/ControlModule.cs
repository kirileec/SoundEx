using Prism.Modularity;
using Prism.Regions;
using SoundEx.Module.Control.Views;
using System;

namespace SoundEx.Module.Control
{
    public class ControlModule : IModule
    {
        IRegionManager _regionManager;

        public ControlModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ControlRegion", typeof(ControlPanelView));
        }
    }
}