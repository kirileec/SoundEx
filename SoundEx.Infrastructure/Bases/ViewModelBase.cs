using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism.Logging;
using Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;

namespace SoundEx.Infrastructure.Bases
{
    public class ViewModelBase : BindableBase
    {
        protected IUnityContainer _container;
        protected ILoggerFacade _logger;
        protected IRegionManager _regionManager;
        protected IEventAggregator _eventAggregator;

        public ViewModelBase()
        {
            _container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            _logger = ServiceLocator.Current.GetInstance<ILoggerFacade>();
            _regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            _eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
        }
    }
}
