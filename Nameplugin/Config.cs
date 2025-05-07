using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Nameplugin
{



    public class Config : IConfig
    {
        [Description("Whether the name plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

    }
}