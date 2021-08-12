using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace BasicLibrary
{
    public class PluginInvoker
    {
       //Плагин для подсчета периметра и плошади фигур
        public static List<IMath> InvokeMathPlugin()
        {
            
            var pluginAssembly = Assembly.LoadFrom("C:/Users/1/source/repos/lab2/MathLibrary/bin/Debug/MathPlugin.dll");
            var pluginType = pluginAssembly.GetTypes().Where(t => typeof(IMath).IsAssignableFrom(t));
            var plugins = new List<IMath>();
            foreach (var type in pluginType)
            {
                var plugin = pluginAssembly.CreateInstance(type.FullName) as IMath;
                plugins.Add(plugin);
            }
            return plugins;

        }
       //Плагин для сериализации Xml в Json и дессериализации
        public static List<IFormatter> InvokeTransformPlugin()
        {
            var pluginAssembly = Assembly.LoadFrom("C:/Users/1/source/repos/lab2/XmlToJson/bin/Debug/XmlToJson.dll");
            var pluginType = pluginAssembly.GetTypes().Where(t => typeof(IFormatter).IsAssignableFrom(t));
            var plugins = new List<IFormatter>();
            foreach (var type in pluginType)
            {
                var plugin = pluginAssembly.CreateInstance(type.FullName) as IFormatter;
                plugins.Add(plugin);
            }
            return plugins;
        }
    }
}

