﻿using System;
using System.Collections.Generic;
using System.Text;
using MTGAHelper.Tracker.WPF.Config;

namespace MTGAHelper.Tracker.WPF.ViewModels
{
    public class OptionsWindowVM
    {
        //public string UserId { get; set; } = "Test";
        public string LogFilePath { get; set; } = "Test";
        public string GameFilePath { get; set; } = "Test";
        public bool RunOnStartup { get; set; } = true;
        public bool MinimizeToSystemTray { get; set; } = false;
        public bool AutoShowHideForMatch { get; set; }

        public bool ForceCardPopup { get; set; } = false;
        public string ForceCardPopupSide { get; set; } = "On the left";
        public string[] ForceCardPopupSides { get; set; } = new string[]
        {
            "On the left",
            "On the right",
        };

        public bool ShowLimitedRatings { get; set; } = true;
        public string ShowLimitedRatingsSource { get; set; } = "ChannelFireball (LSV)";
        public string[] ShowLimitedRatingsSources { get; set; } = new string[]
        {
            "ChannelFireball (LSV)",
            "DraftSim",
        };
    }
}
