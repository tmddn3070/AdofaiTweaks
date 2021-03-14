﻿using AdofaiTweaks.Core;

namespace AdofaiTweaks.Tweaks.JudgmentVisuals
{
    /// <summary>
    /// Settings for the Judgment Visuals tweak.
    /// </summary>
    public class JudgmentVisualsSettings : TweakSettings
    {
        /// <summary>
        /// Shows the hit error meter.
        /// </summary>
        public bool ShowHitErrorMeter { get; set; }

        /// <summary>
        /// The scale multiplier for the hit error meter.
        /// </summary>
        public float ErrorMeterScale { get; set; } = 1f;

        /// <summary>
        /// The length of time in seconds that a tick is visible on screen.
        /// </summary>
        public float ErrorMeterTickLife { get; set; } = 4f;

        /// <summary>
        /// How much the bottom arrow moves towards new hits. This is the alpha
        /// value for the Exponential Moving Average formula.
        /// </summary>
        public float ErrorMeterSensitivity { get; set; } = 0.2f;

        /// <summary>
        /// Hides Perfect judgments.
        /// </summary>
        public bool HidePerfects { get; set; }
    }
}
