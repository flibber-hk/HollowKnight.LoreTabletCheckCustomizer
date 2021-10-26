using System;
using System.Collections.Generic;
using System.Linq;
using ItemChanger;
using Modding;

namespace LoreTabletCheckCustomizer
{
    public class LoreTabletCheckCustomizer : Mod, IGlobalSettings<GlobalSettings>
    {
        internal static LoreTabletCheckCustomizer instance;
        public static GlobalSettings globalSettings;
        public void OnLoadGlobal(GlobalSettings s) => globalSettings = s;
        public GlobalSettings OnSaveGlobal() => globalSettings;

        
        public LoreTabletCheckCustomizer() : base(null)
        {
            instance = this;
        }
        
        public override void Initialize()
        {
            Log("Initializing Mod...");

            // Will throw if IC isn't installed, but that's OK
            Finder.GetItemOverride += ModifyTablets;
        }


        private void ModifyTablets(GetItemEventArgs obj)
        {
            throw new NotImplementedException();
        }

        public override string GetVersion()
        {
            return "0.1";
        }
    }
}