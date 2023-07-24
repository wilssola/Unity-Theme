using TriInspector;
using System;
using UnityEngine;

namespace Unity.Theme
{
    [Serializable]
    public class ColorData
    {
        [HideInInspector]                           public string   guid;
        [ReadOnly]
                      public string   name = "New";
                        public Color    color = Color.white;

        
        
        [Button("X")] void X() => ThemeDatabaseInitializer.Config.RemoveColor(this);

        public static int Compare(ColorData l, ColorData r)
        {
            return l.name.CompareTo(r.name);
        }
    }
}