using System;
using System.Collections.Specialized;
using Exiled.API.Features;
using Exiled.Loader;
using PlayerRoles;

namespace Nameplugin
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Nameplugin";
        public override string Prefix { get; } = "NP";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override string Author { get; } = "Mrhootyhoot1";
        public static bool nameon = true;

        public override void OnEnabled()
        {
            base.OnEnabled();

    }

        public override void OnDisabled()
        {
            base.OnDisabled(); 
        }

        public static class EnabledCommands
        {
            public static bool nameon = true;
            public static bool cinfoon = true;

        }
    }
}