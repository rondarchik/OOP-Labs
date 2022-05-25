using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPaint.PluginTools
{
    public class Plugin
    {
        private Dictionary<string, Type> pluginDict = new Dictionary<string, Type>();

        public string Load(OpenFileDialog openFileDialog)
        {
            string name = "";

            Assembly plugin = Assembly.LoadFrom(openFileDialog.FileName);
            Type[] types = plugin.GetTypes();
            foreach (Type current in types)
            {
                foreach (Attribute attribute in current.GetCustomAttributes())
                {
                    PluginAttribute attr = attribute as PluginAttribute;
                    if (attr != null)
                    {
                        pluginDict.Add(attr.ToolName, current);
                        name = attr.ToolName;
                    }
                }
            }

            return name;
        }

        public Type GetPluginType(string pluginName)
        {
            return pluginDict[pluginName];
        }
    }
}
