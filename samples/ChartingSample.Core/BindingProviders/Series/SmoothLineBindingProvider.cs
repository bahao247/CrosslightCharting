﻿using Intersoft.Crosslight;
using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample
{
    public class SmoothLineBindingProvider : BindingProvider
    {
        #region Constructors

        public SmoothLineBindingProvider()
        {
            this.AddBinding("ActionPresenterButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ChartView", ChartProperties.ChartProperty, new BindingDescription("Chart", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
        }

        #endregion
    }
}