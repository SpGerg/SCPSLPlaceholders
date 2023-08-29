using Exiled.API.Features;
using PlaceholdersAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders.Placeholders
{
    public class ServerPlaceholder : IPlaceholder, IPlaceholderHook
    {
        public string Name => "Server placeholder";

        public string Identifier => "server";

        public string Author => "SpGerg";

        public string Description => "Server placeholders";

        public string OnPlaceholderRequest(string identifier)
        {
            switch (identifier)
            {
                case "name":
                    return Server.Name;
                case "ip_address":
                    return Server.IpAddress;
                case "is_beta":
                    return Plugin.Instance.Config.BoolsTranslated[Server.IsBeta];
                case "max_player_count":
                    return Server.MaxPlayerCount.ToString();
                case "player_count":
                    return Server.PlayerCount.ToString();
                case "version":
                    return Server.Version;
                case "is_dedicated":
                    return Plugin.Instance.Config.BoolsTranslated[Server.IsDedicated];
                case "is_whitelisted":
                    return Plugin.Instance.Config.BoolsTranslated[Server.IsWhitelisted];
                case "is_friendly_fire":
                    return Plugin.Instance.Config.BoolsTranslated[Server.FriendlyFire];
                case "is_idle_mode_enabled":
                    return Plugin.Instance.Config.BoolsTranslated[Server.IsIdleModeEnabled];
                case "tps":
                    return Server.Tps.ToString();
                
            }

            return null;
        }
    }
}
