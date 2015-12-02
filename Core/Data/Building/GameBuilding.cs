namespace Core.Data.Building
{
    public class GameBuilding : StaticBuilding
    {
        public bool IsBuilt { get; set; }
        public bool StartBuilding { get; set; }
        public int RemainingBuildTime { get; set; }

    }
}