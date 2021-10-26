using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoreTabletCheckCustomizer
{
    public class GlobalSettings
    {
        public IndicatorStyle TabletIndicatorStyle = IndicatorStyle.None;
        public ReplaceStyle TabletReplaceStyle = ReplaceStyle.Default;
        public IndicatorStyle EntryIndicatorStyle = IndicatorStyle.None;
        public ReplaceStyle EntryReplaceStyle = ReplaceStyle.Default;
    }

    public enum IndicatorStyle
    {
        None = 0,
        // Will show soul particles until checked
        Particles,
        // The tablet will change size until checked
        Resizing,
        // The tablet will rotate until checked
        Rotating,
        // Replace the tablet with a shiny if not with anything else
        AlwaysReplace
    }
    public enum ReplaceStyle
    {
        Default = 0,
        // If the tablet is replaced, completely destroy the associated sprite(s)
        DestroySprite
    }
}
