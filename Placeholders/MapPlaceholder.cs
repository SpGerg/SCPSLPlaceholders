using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using PlaceholdersAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders.Placeholders
{
    internal class MapPlaceholder : IPlaceholder, IPlaceholderHook
    {
        public string Name => "Map placeholders";

        public string Identifier => "map";

        public string Author => "SpGerg";

        public string Description => "Map placeholders";

        public string OnPlaceholderRequest(string identifier)
        {
            switch (identifier)
            {
                case "ragdolls_count":
                    return Ragdoll.List.Count().ToString();
                case "pickups_count":
                    return Pickup.List.Count().ToString();
                case "is_lcz_decontaminated":
                    return Plugin.Instance.Config.BoolsTranslated[Map.IsLczDecontaminated];
                case "seed":
                    return Map.Seed.ToString();
            }

            return null;
        }
    }
}
