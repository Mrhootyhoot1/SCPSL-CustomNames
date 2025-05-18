using System;
using System.Diagnostics.CodeAnalysis;
using CommandSystem;
using Nameplugin;
using UnityEngine;
using ExPlayer = Exiled.API.Features.Player;

namespace Nameplugin
{
    using ExPlayer = Exiled.API.Features.Player;

    [CommandHandler(typeof(ClientCommandHandler))]
    public class NameCommand : ICommand
    {
        public string Command => "name";
        public string[] Aliases => new[] { "n", "setrpname", "rpname" };

        public string Description =>
            "Sets your players nickname for the RP. Leave blank to reset nickname to your steam name";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (Plugin.EnabledCommands.nameon == true)
            {
                var player = ExPlayer.Get((CommandSender)sender);
                if (arguments.Count == 0)
                {
                    player.DisplayNickname = string.Empty;
                    response = "Name reset successfully!";
                    return true;
                }

                string name = string.Join(" ", arguments);
                player.DisplayNickname = string.Join(" ", arguments);


                response = $"Name has been set to {name}";
                return true;
            }
            else
            {
                response = "Name command not enabled!";
                return true;
            }
        }
}

    [CommandHandler(typeof(ClientCommandHandler))]
    public class Cinfocommand : ICommand
    {
        public string Command => "cinfo";
        public string[] Aliases => new[] { "info", "custominfo", "tagthing" };
        public string Description => "Sets your custom info (the text above your name).";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (Plugin.EnabledCommands.cinfoon == true)
            {
                var player = ExPlayer.Get((CommandSender)sender);
                if (arguments.Count == 0)
                {
                    player.CustomInfo = string.Empty;
                    response = "cinfo reset successfully!";
                    return true;
                }

                string cinfo = string.Join(" ", arguments);
                player.CustomInfo = string.Join(" ", arguments);


                response = $"cinfo has been set to {cinfo} ";
                return true;
            }
            else
            {
                response = "Cinfo command not enabled!";
                return true;
            }
        }
    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class EnableNamecommand : ICommand
    {
        public string Command => "enablename";
        public string[] Aliases => new[] { "clientname", "namecommand", "crpn", "namecmd" };

        public string Description =>
            "Toggles the client name command (on by default)";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (Plugin.EnabledCommands.nameon == true)
            {
                Plugin.EnabledCommands.nameon = false;
                response = "name command disabled";
            }
            else
            {
                Plugin.EnabledCommands.nameon = true;
                response = "name command enabled";
            }
            return true;
        }
    }
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class EnableCinfoCommand : ICommand
    {
        public string Command => "EnableCinfo";
        public string[] Aliases => new[] { "cinfocmd", "cinfocommand", "cicmd", "Custominfoclientcommand" };

        public string Description =>
            "Toggles the cinfo client command (on by default)";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (Plugin.EnabledCommands.cinfoon == true)
            {
                Plugin.EnabledCommands.cinfoon = false;
                response = "cinfo command disabled";
            }
            else
            {
                Plugin.EnabledCommands.cinfoon = true;
                response = "cinfo command enabled";
            }
            return true;
        }
    }
}


