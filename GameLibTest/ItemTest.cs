using RaGae.Game.Blocks.GameLib;
using System.Drawing;
using Xunit;

namespace GameLibTest
{
    public class ItemTest
    {
        [Fact]
        public void CreateItem_Passing()
        {
            Item item = new Item();

            Assert.NotNull(item);
            Assert.True(item.Color == Color.Empty);
        }

        [Fact]
        public void CreateItemWithColor_Passing()
        {
            Item item = new Item()
            {
                Color = Color.Red
            };

            Assert.NotNull(item);
            Assert.True(item.Color == Color.Red);
        }
    }
}
