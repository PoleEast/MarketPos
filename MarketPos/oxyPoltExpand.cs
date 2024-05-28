using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPos
{
    static class OxyPoltExpand
    {
        private const string XAXIS_KEY = "x";
        private const string YAXIS_KEY = "y";

        public static PlotModel Transpose(this PlotModel model)
        {

            // Update plot to generate default axes etc.
            ((IPlotModel)model).Update(false);

            foreach (var axis in model.Axes)
            {
                switch (axis.Position)
                {
                    case AxisPosition.Bottom:
                        axis.Position = AxisPosition.Left;
                        break;
                    case AxisPosition.Left:
                        axis.Position = AxisPosition.Bottom;
                        break;
                    case AxisPosition.Right:
                        axis.Position = AxisPosition.Top;
                        break;
                    case AxisPosition.Top:
                        axis.Position = AxisPosition.Right;
                        break;
                    case AxisPosition.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            foreach (var annotation in model.Annotations)
            {
                if (annotation.XAxis != null && annotation.XAxisKey == null)
                {
                    if (annotation.XAxis.Key == null)
                    {
                        annotation.XAxis.Key = XAXIS_KEY;
                    }

                    annotation.XAxisKey = annotation.XAxis.Key;
                }

                if (annotation.YAxis != null && annotation.YAxisKey == null)
                {
                    if (annotation.YAxis.Key == null)
                    {
                        annotation.YAxis.Key = YAXIS_KEY;
                    }

                    annotation.YAxisKey = annotation.YAxis.Key;
                }
            }

            foreach (var series in model.Series.OfType<XYAxisSeries>())
            {
                if (series.XAxisKey == null)
                {
                    if (series.XAxis == null) // this can happen if the series is invisible initially
                    {
                        series.XAxisKey = XAXIS_KEY;
                    }
                    else
                    {
                        if (series.XAxis.Key == null)
                        {
                            series.XAxis.Key = XAXIS_KEY;
                        }

                        series.XAxisKey = series.XAxis.Key;
                    }
                }

                if (series.YAxisKey == null)
                {
                    if (series.YAxis == null)
                    {
                        series.YAxisKey = YAXIS_KEY;
                    }
                    else
                    {
                        if (series.YAxis.Key == null)
                        {
                            series.YAxis.Key = YAXIS_KEY;
                        }

                        series.YAxisKey = series.YAxis.Key;
                    }
                }
            }

            return model;
        }
    }
}
