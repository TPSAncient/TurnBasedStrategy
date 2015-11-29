using Core.Data.World.Country;

namespace Core.Data.Actor
{
    public class StaticActor
    {
        public bool IsPlayer { get; set; }

        public StaticCountry Country { get; set; }

        public bool EndedTurn { get; set; }
    }
}