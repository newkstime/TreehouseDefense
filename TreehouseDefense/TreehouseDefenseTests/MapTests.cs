using Xunit;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    public class MapTests
    {
        [Fact()]
        public void MapTest()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Map(0,0));
        }

        [Fact]
        public void OnMapTest()
        {
            int x = 5;
            int y = 6;
            int width = 10;
            int height = 11;

            var point = new Point(x, y);

            var map = new Map(width, height);

            var result = map.OnMap(point);

            Assert.True(result);
        }
    }
}