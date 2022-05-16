using System.Drawing;

namespace MapLibrary
{
	public class Map
	{
		public static int Alpha => 70;

        private static Dictionary<double, Color> ColorCodeLookUp = new Dictionary<double, Color>
        {
            { 6.449166, ColorTranslator.FromHtml("#b8de34") },
            { 12.898332, ColorTranslator.FromHtml("#bdff49") },
            { 19.347498, ColorTranslator.FromHtml("#fff32c") },
            { 25.796664, ColorTranslator.FromHtml("#ffff99") },
            { 32.245830, ColorTranslator.FromHtml("#fff32c") },
            { 38.694996, ColorTranslator.FromHtml("#eec713") },
            { 45.144162, ColorTranslator.FromHtml("#ffb669") },
            { 51.593328, ColorTranslator.FromHtml("#ff921e") },
            { 58.042494, ColorTranslator.FromHtml("#ff6000") },
            { 64.491660, ColorTranslator.FromHtml("#ff4242") },
            { 70.940826, ColorTranslator.FromHtml("#f10000") },
            { double.MaxValue, ColorTranslator.FromHtml("#a80000") }
        };

        public static Color GetHeatMapColorBy(double heatMapIndex = 0)
        {
            var rtnVal = GetColorFromHtmlBy(heatMapIndex);

            return Color.FromArgb(Alpha, rtnVal.R, rtnVal.G, rtnVal.B);
        }

        private static Color GetColorFromHtmlBy(double heatMapIndex)
        {
            var keys = ColorCodeLookUp.Keys;

            foreach (var key in keys)
            {
                var IsInRange = heatMapIndex.IsLessThanOrEqualToMaximum(key);

                if (IsInRange)
                {
                    return ColorCodeLookUp[key];
                }
            }

            return Color.Gray;
        }
    }
}