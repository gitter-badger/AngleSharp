﻿namespace AngleSharp.Css.MediaFeatures
{
    using System;
    using AngleSharp.Css.Values;
    using AngleSharp.Dom.Css;

    sealed class WidthMediaFeature : MediaFeature
    {
        #region ctor

        public WidthMediaFeature(String name)
            : base(name)
        {
        }

        #endregion

        #region Internal Properties

        internal override IValueConverter Converter
        {
            // Default: Allowed
            get { return Converters.LengthConverter; }
        }

        #endregion

        #region Methods

        public override Boolean Validate(RenderDevice device)
        {
            var length = Length.Zero;
            var desired = length.ToPixel();
            var available = (Single)device.ViewPortWidth;

            if (IsMaximum)
                return available <= desired;
            else if (IsMinimum)
                return available >= desired;

            return desired == available;
        }

        #endregion
    }
}
