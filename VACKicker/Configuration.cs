﻿using Rocket.API;

namespace VACKicker
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public bool Errorkick;

        public void LoadDefaults()
        {
            Enabled = true;
            Errorkick = false;
        }
    }
}
