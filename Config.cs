using Exiled.API.Enums;
using Exiled.API.Interfaces;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSLPlaceholders
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }

        public bool Debug { get; set; }

        public Dictionary<RoleTypeId, string> RolesTranslated { get; set; } = new Dictionary<RoleTypeId, string>
        {
            { RoleTypeId.ChaosConscript, "Conscript" },
            { RoleTypeId.ChaosMarauder, "Marauder" },
            { RoleTypeId.ChaosRepressor, "Repressor" },
            { RoleTypeId.ChaosRifleman, "Rifleman" },
            { RoleTypeId.Spectator, "Spectator" },
            { RoleTypeId.ClassD, "Class-D" },
            { RoleTypeId.CustomRole, "Custom role" },
            { RoleTypeId.Scp939, "SCP-939" },
            { RoleTypeId.Scp096, "SCP-096" },
            { RoleTypeId.Scp049, "SCP-049" },
            { RoleTypeId.Scp173, "SCP-173" },
            { RoleTypeId.Scp106, "SCP-106" },
            { RoleTypeId.Scp0492, "SCP-049-2" },
            { RoleTypeId.FacilityGuard, "Facility guard" },
            { RoleTypeId.Filmmaker, "Filmmaker" },
            { RoleTypeId.None, "None" },
            { RoleTypeId.NtfCaptain, "Captain" },
            { RoleTypeId.NtfPrivate, "Private" },
            { RoleTypeId.NtfSergeant, "Sergeant" },
            { RoleTypeId.NtfSpecialist, "Specialist" },
            { RoleTypeId.Overwatch, "Overwatch" },
            { RoleTypeId.Tutorial, "Tutorial" },
            { RoleTypeId.Scientist, "Scientist" },
        };

        public Dictionary<Side, string> SidesTranslated { get; set; } = new Dictionary<Side, string>
        {
            { Side.Tutorial, "Tutorial side" },
            { Side.Scp, "Scp side" },
            { Side.Mtf, "Mtf side" },
            { Side.ChaosInsurgency, "C.I side" },
            { Side.None, "None side" }
        };
        public Dictionary<bool, string> BoolsTranslated { get; set; } = new Dictionary<bool, string>
        {
            { true, "yes" },
            { false, "no" },
        };

        public Dictionary<ZoneType, string> ZonesTranslated { get; set; } = new Dictionary<ZoneType, string>
        {
            { ZoneType.Surface, "Surface zone" },
            { ZoneType.HeavyContainment, "Heavy containment zone" },
            { ZoneType.Entrance, "Entrance zone" },
            { ZoneType.LightContainment, "Light containment zone" },
            { ZoneType.Unspecified, "Unspecified zone" },
            { ZoneType.Other, "Other zone" },
        };
    }
}
