using RaGae.Game.Blocks.BrickLib;
using RaGae.Game.Blocks.BrickLib.Enumeration;
using System;
using System.Collections.Generic;
using Xunit;

namespace BrickLibTest
{
    public class BrickFactoryTest
    {
        public static IEnumerable<object[]> GetData_Passing()
        {
            yield return new object[] {
                nameof(BlueRickyBrick),
                typeof(BlueRickyBrick),
                new bool[,]
                {
                    { true, false, false },
                    { true, true,  true  }
                }
            };

            yield return new object[] {
                nameof(ClevelandBrick),
                typeof(ClevelandBrick),
                new bool[,]
                {
                    { true,  true,  false },
                    { false, true,  true  }
                }
            };

            yield return new object[] {
                nameof(HeroBrick),
                typeof(HeroBrick),
                new bool[,]
                {
                    { true, true, true, true }
                }
            };

            yield return new object[] {
                nameof(OrangeRickyBrick),
                typeof(OrangeRickyBrick),
                new bool[,]
                {
                    { false, false, true },
                    { true,  true,  true }
                }
            };

            yield return new object[] {
                nameof(RhodeIslandBrick),
                typeof(RhodeIslandBrick),
                new bool[,]
                {
                    { true, true },
                    { true, true }
                }
            };

            yield return new object[] {
                nameof(SmashBoyBrick),
                typeof(SmashBoyBrick),
                new bool[,]
                {
                    { false, true, true },
                    { true,  true, false  }
                }
            };

            yield return new object[] {
                nameof(TeeWeeBrick),
                typeof(TeeWeeBrick),
                new bool[,]
                {
                    { false, true, false },
                    { true,  true, true  }
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetData_Passing))]
        public void CreateBricksAndTestApperance_Passing(string brickName, Type type, bool[,] result)
        {
            BaseBrick brick = BrickFactory.CreateBrick(brickName);

            Assert.NotNull(brick);
            Assert.Equal(type.Name, brick.GetType().Name);
            Assert.Equal(brick.Apperance, result);
        }

        [Fact]
        public void CreateBrick_Failing()
        {
            BaseBrick brick = null;

            NullReferenceException ex = Assert.Throws<NullReferenceException>(() => brick = BrickFactory.CreateBrick(string.Empty));

            Assert.Null(brick);
            Assert.Equal($"{nameof(BrickFactory)}.{nameof(BrickFactory.CreateBrick)}", ex.Message);
        }

        [Fact]
        public void RandomBrick_Passing()
        {
            BaseBrick brick = BrickFactory.RandomBrick;

            Assert.NotNull(brick);
            Assert.True(brick.GetType().IsSubclassOf(typeof(BaseBrick)));
        }
    }
}
