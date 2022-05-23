using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.Figures
{
    public class PluginAttribute : Attribute
    {
        public string ToolName { get; set; }

        public PluginAttribute(string toolName) => ToolName = toolName;

        public PluginAttribute() { }
    }
}
