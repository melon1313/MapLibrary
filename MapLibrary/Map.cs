using System.Drawing;

namespace MapLibrary
{
	public class Map
	{
		private static Color GetHeatMapColor(double index = 0)
		{
			Color rtnVal = Color.Gray;
			if (index <= 6.449166)
			{
				rtnVal = ColorTranslator.FromHtml("#b8de34");
			}
			else if (index > 6.449166 && index <= 12.898332)
			{
				rtnVal = ColorTranslator.FromHtml("#bdff49");
			}
			else if (index > 12.898332 && index <= 19.347498)
			{
				rtnVal = ColorTranslator.FromHtml("#fff32c");
			}
			else if (index > 19.347498 && index <= 25.796664)
			{
				rtnVal = ColorTranslator.FromHtml("#ffff99");
			}
			else if (index > 25.796664 && index <= 32.245830)
			{
				rtnVal = ColorTranslator.FromHtml("#fff32c");
			}
			else if (index > 32.245830 && index <= 38.694996)
			{
				rtnVal = ColorTranslator.FromHtml("#eec713");
			}
			else if (index > 38.694996 && index <= 45.144162)
			{
				rtnVal = ColorTranslator.FromHtml("#ffb669");
			}
			else if (index > 45.144162 && index <= 51.593328)
			{
				rtnVal = ColorTranslator.FromHtml("#ff921e");
			}
			else if (index > 51.593328 && index <= 58.042494)
			{
				rtnVal = ColorTranslator.FromHtml("#ff6000");
			}
			else if (index > 58.042494 && index <= 64.491660)
			{
				rtnVal = ColorTranslator.FromHtml("#ff4242");
			}
			else if (index > 64.491660 && index <= 70.940826)
			{
				rtnVal = ColorTranslator.FromHtml("#f10000");
			}
			else if (index > 70.940826)
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