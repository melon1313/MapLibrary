using System.Collections;
using System.Drawing;

namespace MapLibrary
{
    public class Map_Solution02
    {
        public static int Alpha => 70;

        public static Color GetHeatMapColorBy(double heatMapIndex = 0)
        {
            var rtnVal = GetColorFromHtmlBy(heatMapIndex);

            return Color.FromArgb(Alpha, rtnVal.R, rtnVal.G, rtnVal.B);
        }

        private static Color GetColorFromHtmlBy(double heatMapIndex)
        {
            foreach (var item in ColorLookUp())
            {
                var someClass = item as SomeClass;

                var IsInRange = heatMapIndex.IsLessThanOrEqualToMaximum(someClass.HeatMapIndex);

                if (IsInRange)
                {
                    return someClass.Color;
                }
            }

            return Color.Gray;
        }

        private static IEnumerable ColorLookUp()
        {
            yield return new SomeClass { HeatMapIndex = 6.4491660, Color = ColorTranslator.FromHtml("#b8de34") };
            yield return new SomeClass { HeatMapIndex = 12.898332, Color = ColorTranslator.FromHtml("#bdff49") };
            yield return new SomeClass { HeatMapIndex = 19.347498, Color = ColorTranslator.FromHtml("#fff32c") };
            yield return new SomeClass { HeatMapIndex = 25.796664, Color = ColorTranslator.FromHtml("#ffff99") };
            yield return new SomeClass { HeatMapIndex = 32.245830, Color = ColorTranslator.FromHtml("#fff32c") };
            yield return new SomeClass { HeatMapIndex = 38.694996, Color = ColorTranslator.FromHtml("#eec713") };
            yield return new SomeClass { HeatMapIndex = 45.144162, Color = ColorTranslator.FromHtml("#ffb669") };
            yield return new SomeClass { HeatMapIndex = 51.593328, Color = ColorTranslator.FromHtml("#ff921e") };
            yield return new SomeClass { HeatMapIndex = 58.042494, Color = ColorTranslator.FromHtml("#ff6000") };
            yield return new SomeClass { HeatMapIndex = 64.491660, Color = ColorTranslator.FromHtml("#ff4242") };
            yield return new SomeClass { HeatMapIndex = 70.940826, Color = ColorTranslator.FromHtml("#f10000") };
            yield return new SomeClass { HeatMapIndex = double.MaxValue, Color = ColorTranslator.FromHtml("#a80000") };
        }

        public class SomeClass
        {
            public double HeatMapIndex { get; set; }
            public Color Color { get; set; }
        }

    }
}
