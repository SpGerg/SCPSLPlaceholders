using Exiled.API.Features;
using PlaceholdersAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders.Placeholders
{
    public class PlayerPlaceholder : IPlaceholder
    {
        public string Name => "Player placeholder";

        public string Identifier => "player";

        public string Author => "SpGerg";

        public string Description => "All player information.";

        public string OnPlaceholderRequest(Player player, string identifier)
        {
            switch (identifier)
            {
                case "role":
                    return Plugin.Instance.Config.RolesTranslated[player.Role.Type];
                case "side":
                    return Plugin.Instance.Config.SidesTranslated[player.Role.Side];
                case "zone":
                    return Plugin.Instance.Config.ZonesTranslated[player.Zone];
                case "health":
                    return player.Health.ToString();
                case "stamina":
                    return player.Stamina.ToString();
                case "isNorthwood":
                    return Plugin.Instance.Config.BoolsTranslated[player.IsNorthwoodStaff];
                case "nickname":
                    return player.Nickname;
                case "custom_name":
                    return player.CustomName;
                case "custom_info":
                    return player.CustomInfo;
                case "is_cuffed":
                    return Plugin.Instance.Config.BoolsTranslated[player.IsCuffed];
                case "group_name":
                    return player.GroupName;
                case "user_id":
                    return player.UserId;
                case "custom_user_id":
                    return player.CustomUserId;
                case "raw_user_id":
                    return player.RawUserId;
                case "max_health":
                    return player.MaxHealth.ToString();
            }

            return null;
        }
    }
}
