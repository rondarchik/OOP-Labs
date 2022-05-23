using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;
using CustomPaint.Figures;

namespace CustomPaint
{
    public class PluginLoading
    {
        private Dictionary<string, Type> pluginDict = new Dictionary<string, Type>();

        public string Load(OpenFileDialog open)
        {
            string name = "";

            Assembly plugin = Assembly.LoadFrom(open.FileName);
            Type[] types = plugin.GetTypes();

            foreach (var current in types)
            {
                foreach (var attribute in current.GetCustomAttributes())
                {
                    var att = attribute as PluginAttribute;
                    
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
