using System;
using System.Collections.Generic;
using System.Linq;
using TriInspector;

namespace Unity.Theme
{
    [Serializable]
    public class ThemeData
    {
        [HideLabel]
        public string themeName = "New Theme";

        [GUIColor(1, 0.2f, 0.2f, 1), Button("REMOVE")]
        void Remove() => ThemeDatabaseInitializer.Config.RemoveTheme(this);

        [HideReferencePicker, HideLabel]
        [TableList(AlwaysExpanded = true, HideAddButton = true, HideRemoveButton = true)]
        public List<ColorData> colors = new List<ColorData>();

        public ColorData GetColorByGuid(string guid) => string.IsNullOrEmpty(guid) ? null : colors?.FirstOrDefault(x => x.guid == guid);
    }
}