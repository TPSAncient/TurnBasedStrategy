using Core.Data.Common;
using UnityEngine;

namespace Client
{
    public class WorldObject : MonoBehaviour
    {
        #region Data acces values

        public string Tag = "";
        public DataType SelectedObjectType = DataType.None;
        
        #endregion

        public bool IsWorldObjectSelected = false;
    }
}
