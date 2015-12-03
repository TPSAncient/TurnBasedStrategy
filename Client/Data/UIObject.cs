using Core.Data.Common;
using UnityEngine;

namespace Client.Data
{
    public class UIObject : MonoBehaviour, IUIData
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _tagName;
        [SerializeField]
        private DataType _dataType;
        [SerializeField]
        private string _tagRegion;
        [SerializeField]
        private string _tagLocation;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string TagName
        {
            get { return _tagName; }
            set { _tagName = value; }
        }

        public DataType DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        public string TagRegion
        {
            get { return _tagRegion; }
            set { _tagRegion = value; }
        }

        public string TagLocation
        {
            get { return _tagLocation; }
            set { _tagLocation = value; }
        }
    }
}
