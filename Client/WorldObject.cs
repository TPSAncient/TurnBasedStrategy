using UnityEngine;

namespace Client
{
    public class WorldObject : MonoBehaviour
    {
        #region Data acces values

        public string Tag = "";
        public WorldObjectEnum SelectedObjectType = WorldObjectEnum.None;
        
        #endregion

        public bool IsWorldObjectSelected = false;
    }
}
