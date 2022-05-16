using System.Drawing;

namespace MapLibrary
{
	public class Map
	{
		public static int Alpha => 70;

        private static Dictionary<double, string> ColorCodeLookUp = new Dictionary<double, string>
        {
            { 6.449166, "#b8de34" },
            { 12.898332, "#bdff49" },
            { 19.347498, "#fff32c" },
            { 25.796664, "#ffff99" },
            { 32.245830, "#fff32c" },
            { 38.694996, "#eec713" },
            { 45.144162, "#ffb669" },
            { 51.593328, "#ff921e" },
            { 58.042494, "#ff6000" },
            { 64.491660, "#ff4242" },
            { 70.940826, "#f10000" },
            {double.MaxValue, "#a80000" }
        };

        public static Color GetHeatMapColorBy(double heatMapIndex = 0)
        {
            var rtnVal = GetColorFromHtmlBy(heatMapIndex);

            return Color.FromArgb(Alpha, rtnVal.R, rtnVal.G, rtnVal.B);
        }

        private static Color GetColorFromHtmlBy(double heatMapIndex)
        {

            GetKeyFromColorLookUpBy(heatMapIndex, out var key);

            if (!ColorCodeLookUp.ContainsKey(key)) return Color.Gray;

            var colorCode = ColorCodeLookUp[key];
            var rtnVal = ColorTranslator.FromHtml(colorCode);

            return rtnVal;
        }

        private static double GetKeyFromColorLookUpBy(double heatMapIndex, out double finalKey)
        {
            var keys = ColorCodeLookUp.Keys;
            finalKey = heatMapIndex;

            foreach (var key in keys)
            {
                var IsInRange = heatMapIndex.IsLessThanOrEqualToMaximum(key);

                if (IsInRange)
                {
                    finalKey = key;
                    break;
                }
            }

            return finalKey;
        }
    }
}