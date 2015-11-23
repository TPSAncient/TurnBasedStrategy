using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Test.Data;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class SeedDataEditor : EditorWindow
    {
        [MenuItem("Game/SeedData")]
        public static void ShowWindow()
        {
            GetWindow<SeedDataEditor>();
        }

        void OnGUI()
        {
            if (GUI.Button(new Rect(10, 10, 100, 20), "Seed Data"))
            {
                SeedData seed = new SeedData();
                seed.Path = Application.dataPath;
                seed.SaveData();
            }
        }
    }
}
