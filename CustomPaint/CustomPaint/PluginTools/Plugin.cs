using CustomPaint.Creators;
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

            Assembly assembly = Assembly.LoadFrom(openFileDialog.FileName);
            Type[] types = assembly.GetExportedTypes();
            foreach (Type current in types)
            {
                foreach (Attribute attribute in current.GetCustomAttributes())
                {
                    PluginAttribute? att = attribute as PluginAttribute;
                    if (att != null)
                    {
                        pluginDict.Add(att.ToolName, current);
                        name = att.ToolName;
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
