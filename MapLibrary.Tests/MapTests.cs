using NUnit.Framework;
using System.Drawing;

namespace MapLibrary.Tests
{
    public class MapTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-5, "#b8de34")]
        [TestCase(5.3, "#b8de34")]
        [TestCase(7.234, "#bdff49")]
        [TestCase(12.898332, "#bdff49")]
        [TestCase(13.234, "#fff32c")]
        [TestCase(23.234, "#ffff99")]
        [TestCase(28.234, "#fff32c")]
        [TestCase(37.234, "#eec713")]
        [TestCase(43.234, "#ffb669")]
        [TestCase(47.234, "#ff921e")]
        [TestCase(57.234, "#ff6000")]
        [TestCase(63.234, "#ff4242")]
        [TestCase(67.234, "#f10000")]
        [TestCase(100.234, "#a80000")]
        [TestCase(64.491660, "#ff4242")]
        [Category("Solution01")]
        public void GetHeatMapColor(double heatMapIndex, string colorCode)
        {
            var rtnVal = ColorTranslator.FromHtml(colorCode);
            var color = Map.GetHeatMapColorBy(heatMapIndex);

            
            var result = color.ToArgb();
            var expected = Color.FromArgb(Map.Alpha, rtnVal.R, rtnVal.G, rtnVal.B).ToArgb();

            Assert.AreEqual(expected, result);
        }

        
        [TestCase(-5, "#b8de34")]
        [TestCase(5.3, "#b8de34")]
        [TestCase(7.234, "#bdff49")]
        [TestCase(12.898332, "#bdff49")]
        [TestCase(13.234, "#fff32c")]
        [TestCase(23.234, "#ffff99")]
        [TestCase(28.234, "#fff32c")]
        [TestCase(37.234, "#eec713")]
        [TestCase(43.234, "#ffb669")]
        [TestCase(47.234, "#ff921e")]
        [TestCase(57.234, "#ff6000")]
        [TestCase(63.234, "#ff4242")]
        [TestCase(67.234, "#f10000")]
        [TestCase(100.234, "#a80000")]
        [TestCase(64.491660, "#ff4242")]
        [Category("Solution02")]
        public void GetHeatMapColor_Solution02(double heatMapIndex, string colorCode)
        {
            var rtnVal = ColorTranslator.FromHtml(colorCode);
            var color = Map_Solution02.GetHeatMapColorBy(heatMapIndex);


            var result = color.ToArgb();
            var expected = Color.FromArgb(Map_Solution02.Alpha, rtnVal.R, rtnVal.G, rtnVal.B).ToArgb();

            Assert.AreEqual(expected, result);
        }
    }
}