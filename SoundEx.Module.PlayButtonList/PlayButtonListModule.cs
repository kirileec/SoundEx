using Prism.Modularity;
using Prism.Regions;
using SoundEx.Module.PlayButtonList.Views;
using System;

namespace SoundEx.Module.PlayButtonList
{
    public class PlayButtonListModule : IModule
    {
        IRegionManager _regionManager;

        public PlayButtonListModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ListRegion", typeof(PlayButtonListView));
        }
    }
}