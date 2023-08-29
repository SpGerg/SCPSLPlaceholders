using Exiled.API.Features;
using PlaceholdersAPI.Features;
using SCPSLPlaceholders.Placeholders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; } = new Plugin();

        public override void OnEnabled()
        {
            PLAPI.Register(new PlayerPlaceholder());
            PLAPI.Register(new ServerPlaceholder());
            PLAPI.Register(new MapPlaceholder());
            PLAPI.Register(new RoundPlaceholder());

            base.OnEnabled();
        }
    }
}
