using Core.Data.Common;

namespace Core.System
{
    public class TurnManager
    {
        private readonly DataCollection _collection;
        public int CurrentTurn { get; set; }

        public TurnManager(DataCollection collection)
        {
            _collection = collection;
        }

        public void ChangeBuildingState()
        {
            
        }    
    }
}