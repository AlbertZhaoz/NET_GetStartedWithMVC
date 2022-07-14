using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace GetStartedWithASPNETMVC.Utility
{
    public class DIFactoryHelper
    {
        private static IUnityContainer container =  new UnityContainer();
        static DIFactoryHelper()
        {
            // Unity在MVC中的应用
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Configs\\unity.config");
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
            section.Configure(container, "albertcontainer");
        }

        public static IUnityContainer GetContainer()
        {
            return container;
        }
    }
}