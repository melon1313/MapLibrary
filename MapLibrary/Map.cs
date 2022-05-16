using System.Drawing;

namespace MapLibrary
{
	public class Map
	{
		public static int Alpha => 70;

		public static Color GetHeatMapColorBy(double heatMapIndex = 0)
        {
            Color rtnVal = Color.Gray;

            rtnVal = GetColorFromHtmlBy(heatMapIndex);

            return Color.FromArgb(Alpha, rtnVal.R, rtnVal.G, rtnVal.B);
        }

        private static Color GetColorFromHtmlBy(double heatMapIndex)
        {
            Color rtnVal;
            if (heatMapIndex.IsLessThan(6.449166))
            {
                rtnVal = ColorTranslator.FromHtml("#b8de34");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(6.449166, 12.898332))
            {
                rtnVal = ColorTranslator.FromHtml("#bdff49");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(12.898332, 19.347498))
            {
                rtnVal = ColorTranslator.FromHtml("#fff32c");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(19.347498, 25.796664))
            {
                rtnVal = ColorTranslator.FromHtml("#ffff99");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(25.796664, 32.245830))
            {
                rtnVal = ColorTranslator.FromHtml("#fff32c");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(32.245830, 38.694996))
            {
                rtnVal = ColorTranslator.FromHtml("#eec713");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(38.694996, 45.144162))
            {
                rtnVal = ColorTranslator.FromHtml("#ffb669");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(45.144162, 51.593328))
            {
                rtnVal = ColorTranslator.FromHtml("#ff921e");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(51.593328, 58.042494))
            {
                rtnVal = ColorTranslator.FromHtml("#ff6000");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(58.042494, 64.491660))
            {
                rtnVal = ColorTranslator.FromHtml("#ff4242");
            }
            else if (heatMapIndex.IsWithinInCludeMaximum(64.491660, 70.940826))
            {
                rtnVal = ColorTranslator.FromHtml("#f10000");
            }
            else if (heatMapIndex.IsGreaterThan(70.940826))
            {
                rtnVal = ColorTranslator.FromHtml("#a80000");
            }
            else
            {
                rtnVal = ColorTranslator.FromHtml("#b8de34");
            }

            return rtnVal;
        }

    }

	public static class CommonHelper
    {
        public static bool IsWithinInCludeMaximum(this double number, double minimum, double maximum)
        {
            return number > minimum && number <= maximum;
        }

        public static bool IsGreaterThan(this double number, double otherNumber)
        {
			return number > otherNumber;
        }

        public static bool IsLessThan(this double number, double otherNumber)
        {
            return number < otherNumber;
        }
    }
}