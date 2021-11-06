using static GameLibTest.Helper.GameLibHelper;
using RaGae.Game.Blocks.BrickLib;
using RaGae.Game.Blocks.GameLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xunit;
using RaGae.Game.Blocks.GameLib.Factory;

namespace GameLibTest
{
    public class FieldTest
    {
        private static GameFactory factory;

        public FieldTest() => factory = GameFactory.Instance(new Size(10, 10));

        public static IEnumerable<object[]> GetBrickData()
        {
            yield return new object[] { new BlueRickyBrick() };
            yield return new object[] { new ClevelandBrick() };
            yield return new object[] { new HeroBrick() };
            yield return new object[] { new OrangeRickyBrick() };
            yield return new object[] { new RhodeIslandBrick() };
            yield return new object[] { new SmashBoyBrick() };
            yield return new object[] { new TeeWeeBrick() };
        }

        [Fact]
        public void CreateField_Passing()
        {
            Field field = factory.CreateField();

            Assert.NotNull(field);

            Assert.NotNull(field.Line);
            Assert.True(field.Line.Count == 0);

            Assert.True(field.Size == factory.Size);
        }

        [Theory]
        [MemberData(nameof(GetBrickData))]
        public void CreateNextBricksAndAddBrick2Field_Passing(BaseBrick brick)
        {

            Field field = factory.CreateField();
            field.Next = new FieldBrick(brick);

            Assert.NotNull(field);
            Assert.NotNull(field.Next);

            Assert.False(field.Brick2Field());
        }

        [Theory]
        [MemberData(nameof(GetBrickData))]
        public void CreateCurrentBricksAndAddBrick2Field_Passing(BaseBrick brick)
        {
            Random r = new Random();

            Field field = factory.CreateField();
            field.Current = new FieldBrick(brick)
            {
                Position = new Point(factory.Size.Width / 2, r.Next(0, factory.Size.Height)),
                Color = Color.Red
            };

            FillBlock(field.Line, new Size(field.Size.Width, field.Current.Position.Y));

            Assert.NotNull(field);
            Assert.NotNull(field.Current);

            Assert.True(field.Brick2Field());

            Assert.True(field.Line.Count == (field.Current.Position.Y + field.Current.Brick.Apperance.GetLength(0)));

            Assert.True(CheckFieldPosition(field.Line, field.Current));
        }

        [Theory]
        [MemberData(nameof(GetBrickData))]
        public void CreateCurrentBricksAndAddBrick2Field_Failing(BaseBrick brick)
        {
            Random r = new Random();

            Field field = factory.CreateField();
            field.Current = new FieldBrick(brick)
            {
                Position = new Point(factory.Size.Width / 2, r.Next(0, factory.Size.Height)),
                Color = Color.Red
            };

            FillBlock(field.Line, new Size(field.Size.Width, field.Current.Position.Y));

            Assert.NotNull(field);
            Assert.NotNull(field.Current);

            Assert.True(field.Brick2Field());

            Assert.True(field.Line.Count == (field.Current.Position.Y + field.Current.Brick.Apperance.GetLength(0)));

            field.Current.Position = new Point(
                field.Current.Position.X == 0 ? (field.Current.Position.X + 1) : (field.Current.Position.X - 1),
                field.Current.Position.Y);

            Assert.False(CheckFieldPosition(field.Line, field.Current));

        }

        public static IEnumerable<object[]> GetLineData_Passing()
        {
            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10),
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetLineData_Passing))]
        public void CreateFieldAndCheckMegaLine_Passing(List<Item[]> line)
        {
            Field field = factory.CreateField();
            field.Line.AddRange(line);

            Assert.NotNull(field);
            Assert.True(field.MegaLine());
        }

        public static IEnumerable<object[]> GetLineData_Failing()
        {
            yield return new object[]
            {
                new List<Item[]>()
                {
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10),
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetLineData_Failing))]
        public void CreateFieldAndCheckMegaLine_Failing(List<Item[]> line)
        {
            Field field = factory.CreateField();
            field.Line.AddRange(line);

            Assert.NotNull(field);
            Assert.False(field.MegaLine());
        }



        public static IEnumerable<object[]> GetLineData()
        {
            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    EmptyLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10)
                }
            };

            yield return new object[]
            {
                new List<Item[]>()
                {
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    EmptyLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                    FillLine(10),
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetLineData))]
        public void CreateFieldAndCheckFullLines_Passing(List<Item[]> line)
        {
            Field field = factory.CreateField();
            field.Line.AddRange(line);

            Assert.NotNull(field);

            foreach (Item[] item in field.Line)
            {
                if(item.Any(x => x is not null))
                {
                    Assert.Contains(item, field.FullLines());
                }
            }
        }
    }
}
