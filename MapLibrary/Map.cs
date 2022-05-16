using System.Drawing;

namespace MapLibrary
{
	public class Map
	{
		private static Color GetHeatMapColor(double heatMapIndex = 0)
		{
			Color rtnVal = Color.Gray;
			if (heatMapIndex <= 6.449166)
			{
				rtnVal = ColorTranslator.FromHtml("#b8de34");
			}
			else if (heatMapIndex > 6.449166 && heatMapIndex <= 12.898332)
			{
				rtnVal = ColorTranslator.FromHtml("#bdff49");
			}
			else if (heatMapIndex > 12.898332 && heatMapIndex <= 19.347498)
			{
				rtnVal = ColorTranslator.FromHtml("#fff32c");
			}
			else if (heatMapIndex > 19.347498 && heatMapIndex <= 25.796664)
			{
				rtnVal = ColorTranslator.FromHtml("#ffff99");
			}
			else if (heatMapIndex > 25.796664 && heatMapIndex <= 32.245830)
			{
				rtnVal = ColorTranslator.FromHtml("#fff32c");
			}
			else if (heatMapIndex > 32.245830 && heatMapIndex <= 38.694996)
			{
				rtnVal = ColorTranslator.FromHtml("#eec713");
			}
			else if (heatMapIndex > 38.694996 && heatMapIndex <= 45.144162)
			{
				rtnVal = ColorTranslator.FromHtml("#ffb669");
			}
			else if (heatMapIndex > 45.144162 && heatMapIndex <= 51.593328)
			{
				rtnVal = ColorTranslator.FromHtml("#ff921e");
			}
			else if (heatMapIndex > 51.593328 && heatMapIndex <= 58.042494)
			{
				rtnVal = ColorTranslator.FromHtml("#ff6000");
			}
			else if (heatMapIndex > 58.042494 && heatMapIndex <= 64.491660)
			{
				rtnVal = ColorTranslator.FromHtml("#ff4242");
			}
			else if (heatMapIndex > 64.491660 && heatMapIndex <= 70.940826)
			{
				rtnVal = ColorTranslator.FromHtml("#f10000");
			}
			else if (heatMapIndex > 70.940826)
			{
				rtnVal = ColorTranslator.FromHtml("#a80000");
			}
			else
			{
				rtnVal = ColorTranslator.FromHtml("#b8de34");
			}

			return Color.FromArgb(70, rtnVal.R, rtnVal.G, rtnVal.B);
		}
	}