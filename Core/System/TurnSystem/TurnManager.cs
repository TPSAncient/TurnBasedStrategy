using Core.Data.Common;

namespace Core.System.TurnSystem
{
    public class TurnManager
    {
        private readonly DataCollection _collection;
        public int CurrentTurn { get; set; } = 1;

        public TurnManager(DataCollection collection)
        {
            _collection = collection;
        }

        public TurnManager()
        {

        }

        public void ChangeBuildingState()
        {
            
        }

        public int EndTurn()
        {
            // if is player set endedturn true
            return CurrentTurn = CurrentTurn+1;
        }
    }
}