/********************************************************************************** 
* 项目名称: Saturn.Common.BaseTypes
* 类名称: ModuleBase
* 类说明: 模块基类
* 作者: Kirile 
* 命名空间: Saturn.Common.BaseTypes
* 组织:    
* 创建时间: 2016-08-23 14:28:44 
* 版本号: 
* CLR版本: 4.0.30319.42000
* 修改时间: 2016-08-23 14:28:44    
* 修改记录:
*        
*
************************************************************************************
* CopyRight ® www.soesoft.xin All rights reserved
***********************************************************************************/

using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Logging;
using Prism.Modularity;
using Prism.Regions;
using System.Threading;

using System.Runtime.CompilerServices;
using System;
using SoundEx.Infrastructure.Events;

namespace SoundEx.Infrastructure.Bases
{
    public class ModuleBase : IModule
    {
        protected IUnityContainer _container;
        protected IRegionManager _regionManager;

        protected IEventAggregator _eventAggregator;
        protected IModuleManager _moduleManager;
        protected ILoggerFacade _logger;

        public AutoResetEvent WaitForCreation { get; set; }

        public ModuleBase()
        {
            _container = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IUnityContainer>();
            _regionManager = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IRegionManager>();

            _eventAggregator = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IEventAggregator>();
            _moduleManager = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IModuleManager>();
            _logger = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<ILoggerFacade>();

            _logger.Log(this.ToString() + " Created", Category.Info, Priority.None);

        }
        /// <summary>
        /// 清理一个区域
        /// </summary>
        /// <param name="regionName">区域名</param>
        protected void ClearRegion(string regionName)
        {
            if (_regionManager.Regions.ContainsRegionWithName(regionName))
            {
                _regionManager.Regions[regionName].RemoveAll();
            }
        }

        /// <summary>
        /// 提供区域名和视图名, 将区域切换到那个视图
        /// </summary>
        /// <param name="regionName">区域名, 请在Constants 下进行定义</param>
        /// <param name="viewName">视图名, 一般在IModule 的 Initialize 方法进行注册, 同样事先在Constans下定义</param>
        protected void NavigateView(string regionName, string viewName)
        {
            // 以下两种方式都可以 建议使用导航
            //ClearRegion(regionName);
            //if (_regionManager.Regions.ContainsRegionWithName(regionName))
            //{
            //    _regionManager.Regions[regionName].Add(_container.Resolve<UserControl>(viewName));
            //}

            if (_regionManager.Regions.ContainsRegionWithName(regionName))
            {
                _regionManager.Regions[regionName].RequestNavigate(new System.Uri(viewName, System.UriKind.Relative));
            }
        }

        public virtual void Initialize()
        {
            _eventAggregator.GetEvent<NavigateViewEvent>().Subscribe((e) => NavigateView(e.regionName, e.viewName), true);

        }


    }
}
