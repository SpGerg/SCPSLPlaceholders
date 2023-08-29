using Exiled.API.Features;
using PlaceholdersAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders.Placeholders
{
    public class RoundPlaceholder : IPlaceholder, IPlaceholderHook
    {
        public string Name => "Round placeholders";

        public string Identifier => "round";

        public string Author => "SpGerg";

        public string Description => "Round placeholders";

        public string OnPlaceholderRequest(string identifier)
        {
            switch (identifier)
            {
                case "escaped_scp":
                    return Round.SurvivingSCPs.ToString();
                case "escaped_d_classes":
                    return Round.EscapedDClasses.ToString();
                case "escaped_scientists":
                    return Round.EscapedScientists.ToString();
                case "kills":
                    return Round.Kills.ToString();
                case "elapsed_time":
                    return Round.ElapsedTime.ToString();
                case "is_ended":
                    return Plugin.Instance.Config.BoolsTranslated[Round.IsEnded];
                case "is_started":
                    return Plugin.Instance.Config.BoolsTranslated[Round.IsStarted];
                case "is_locked":
                    return Plugin.Instance.Config.BoolsTranslated[Round.IsLocked];
                case "in_progress":
                    return Plugin.Instance.Config.BoolsTranslated[Round.InProgress];
                
            }

            return null;
        }
    }
}
