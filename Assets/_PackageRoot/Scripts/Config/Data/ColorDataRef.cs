using TriInspector;
using System;
using UnityEngine;

namespace Unity.Theme
{
    [Serializable]
    public class ColorDataRef
    {
        [HideInInspector]                           
        public string   guid;
        public string   name = "New";

        
        
        [Button("X")] void X() => ThemeDatabaseInitializer.Config.RemoveColor(this);

        public static int Compare(ColorDataRef l, ColorDataRef r)
        {
            return l.name.CompareTo(r.name);
        }
    }
}