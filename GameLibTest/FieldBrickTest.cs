using RaGae.Game.Blocks.BrickLib;
using RaGae.Game.Blocks.GameLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace GameLibTest
{
    public class FieldBrickTest
    {
        public static IEnumerable<object[]> GetData_Passing()
        {
            Random r = new Random();

            yield return new object[] {
                new BlueRickyBrick(),
                typeof(BlueRickyBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };

            yield return new object[] {
                new ClevelandBrick(),
                typeof(ClevelandBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
            
            yield return new object[] {
                new HeroBrick(),
                typeof(HeroBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
            
            yield return new object[] {
                new OrangeRickyBrick(),
                typeof(OrangeRickyBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
            
            yield return new object[] {
                new RhodeIslandBrick(),
                typeof(RhodeIslandBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
            
            yield return new object[] {
                new SmashBoyBrick(),
                typeof(SmashBoyBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
            
            yield return new object[] {
                new TeeWeeBrick(),
                typeof(TeeWeeBrick),
                new Point(
                    r.Next(),
                    r.Next()),
                Color.FromArgb(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255))
            };
        }

        [Theory]
        [MemberData(nameof(GetData_Passing))]
        public void CreateBricksAndTestApperance_Passing(BaseBrick brick, Type type, Point point, Color color)
        {
            FieldBrick fieldBrick = new FieldBrick(brick)
            {
                Position = point,
                Color = color
            };

            Assert.NotNull(fieldBrick);
            Assert.Equal(type.Name, fieldBrick.Brick.GetType().Name);

            Assert.True(fieldBrick.Position == point);
            Assert.True(fieldBrick.Color == color);
        }
    }
}
