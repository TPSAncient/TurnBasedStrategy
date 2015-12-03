﻿using Core.Data.Common;
using UnityEngine;

namespace Client.Data
{
    public class WorldObject : MonoBehaviour, IData
    {
        #region Idata implementation

        [SerializeField]
        private string _name;
        [SerializeField]
        private string _tagName;
        [SerializeField]
        private DataType _dataType;


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

        #endregion

        public bool IsWorldObjectSelected = false;

        public float DelayTime = ResourceManager.BeforeToolTipIsShownDuration;

        void OnMouseEnter()
        {
            DelayTime += Time.time;
        }

        void OnMouseExit()
        {
            DelayTime = ResourceManager.BeforeToolTipIsShownDuration;
        }

        void OnMouseOver()
        {
            if (Time.time > DelayTime)
            {

                //print(TagName);
            }
        }

    }
}
