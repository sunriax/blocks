using Ragae.Game.Blocks.BrickLib;
using Ragae.Game.Blocks.BrickLib.Enumeration;
using System;
using System.Collections.Generic;
using Xunit;

namespace BrickLibTest
{
    public class BrickTest
    {
        public static IEnumerable<object[]> GetData_Passing()
        {
            yield return new object[] { new BlueRickyBrick(), new bool[,]
            {
                { true, false, false },
                { true, true,  true  }
            }};

            yield return new object[] { new ClevelandBrick(), new bool[,]
            {
                { true,  true,  false },
                { false, true,  true  }
            }};

            yield return new object[] { new HeroBrick(), new bool[,]
            {
                { true, true, true, true }
            }};

            yield return new object[] { new OrangeRickyBrick(), new bool[,]
            {
                { false, false, true },
                { true,  true,  true }
            }};

            yield return new object[] { new RhodeIslandBrick(), new bool[,]
            {
                { true, true },
                { true, true }
            }};

            yield return new object[] { new SmashBoyBrick(), new bool[,]
            {
                { false, true, true },
                { true,  true, false  }
            }};

            yield return new object[] { new TeeWeeBrick(), new bool[,]
            {
                { false, true, false },
                { true,  true, true  }
            }};
        }

        [Theory]
        [MemberData(nameof(GetData_Passing))]
        public void CreateBricksAndTestApperance_Passing(BaseBrick brick, bool[,] result)
        {
            Assert.NotNull(brick);
            Assert.Equal(brick.Apperance, result);

        }

        [Theory]
        [MemberData(nameof(GetData_Passing))]
        public void CreateConstructorAndRotateRight_Passing(BaseBrick brick, bool[,] result)
        {
            Assert.NotNull(brick);

            bool[,] temp = result;

            for (int i = 0; i < 3; i++)
            {
                temp = this.Rotate(temp);

                brick.Rotate(Rotation.Right);
                Assert.Equal(brick.Apperance, temp);
            }
        }

        [Theory]
        [MemberData(nameof(GetData_Passing))]
        public void CreateConstructorAndRotateLeft_Passing(BaseBrick brick, bool[,] result)
        {
            Assert.NotNull(brick);

            bool[,] temp = result;

            for (int i = 0; i < 3; i++)
            {
                temp = this.Rotate(this.Rotate(this.Rotate(temp)));

                brick.Rotate(Rotation.Left);
                Assert.Equal(brick.Apperance, temp);
            }
        }

        private bool[,] Rotate(bool[,] data)
        {
            bool[,] temp = new bool[data.GetLength(1), data.GetLength(0)];

            for (int y = 0; y < data.GetLength(0); y++)
            {
                for (int x = 0; x < data.GetLength(1); x++)
                {
                    temp[(data.GetLength(1) - x - 1), y] = data[y, x];
                }
            }
            return temp;
        }
    }
}
