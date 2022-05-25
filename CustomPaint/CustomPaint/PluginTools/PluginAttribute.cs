using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPaint.PluginTools
{
    public  class PluginAttribute : Attribute
    {
        public string ToolName { get; set; } // => toolName; set => toolName = value; }

        public PluginAttribute(string toolName)
        {
            this.ToolName = toolName;
        }


        //public PluginAttribute() { }
    }
}
