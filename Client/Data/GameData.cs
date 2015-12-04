using System;
using Core.Data.Common;
using UnityEngine;

namespace Client.Data
{
    [Serializable]
    public class GameData : IData
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _tagName;
        [SerializeField]
        private DataType _dataType;
        [SerializeField]
        private string _tagCountry;

        

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

        public string TagCountry
        {
            get { return _tagCountry; }
            set { _tagCountry = value; }
        }
    }
}