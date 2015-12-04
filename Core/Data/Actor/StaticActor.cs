using System;
using UnityEngine;

namespace Core.Data.Actor
{
    [Serializable]
    public class StaticActor
    {
        private bool _isPlayer;
        private string _tagCountry;
        private bool _endedTurn;

        public bool IsPlayer
        {
            get { return _isPlayer; }
            set { _isPlayer = value; }
        }

        public string TagCountry
        {
            get { return _tagCountry; }
            set { _tagCountry = value; }
        }

        public bool EndedTurn
        {
            get { return _endedTurn; }
            set { _endedTurn = value; }
        }
    }
}