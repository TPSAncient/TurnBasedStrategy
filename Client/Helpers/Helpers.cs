using System;
using UnityEngine;
using Object = System.Object;

namespace Client.Helpers
{
    public class Helpers : Object
    {
        public static UnityEngine.Object Find(string name, Type type)
        {
            UnityEngine.Object[] objs = Resources.FindObjectsOfTypeAll(type);

            foreach (UnityEngine.Object obj in objs)
            {
                if (obj.name == name)
                {
                    return obj;
                }
            }

            return null;
        }
    }
}
