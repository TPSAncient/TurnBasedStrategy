using Core.Data.Collection;
using Core.Data.Common;

namespace Core.System.TurnSystem
{
    public class TurnManager
    {
        private readonly DefaultDataCollection _collection;
        public int CurrentTurn { get; set; } = 1;

        public TurnManager(DefaultDataCollection collection)
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