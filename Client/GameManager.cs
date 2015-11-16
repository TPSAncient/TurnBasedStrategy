using Core.System;
using UnityEngine;

namespace Client
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton

        private static GameManager _instance = null;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameManager();
                }

                return _instance;
            }
        }

        #endregion

        public SystemManager SystemManager { get; set; }

        void Awake()
        {
            // Don't destroy this class when loading new scene
            DontDestroyOnLoad(this);

            // Game Starting place
            SystemManager = new SystemManager();
        }

        // test
    }
}
