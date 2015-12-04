namespace Core.Data.Building
{
    public class GameBuilding : StaticBuilding
    {
        public GameBuilding()
        {
        }

        public GameBuilding(StaticBuilding building) : base(building){ }

        public bool IsBuilt { get; set; }
        public bool StartBuilding { get; set; }
        public int RemainingBuildTime { get; set; }

    }
}