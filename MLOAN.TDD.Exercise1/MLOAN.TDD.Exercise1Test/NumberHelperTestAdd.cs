using System;
using Xunit;
using MLOAN.TDD.Exercise1;
using System.Collections.Generic;

namespace MLOAN.TDD.Exercise1Test
{
    public partial class NumberHelperTestAdd
    {
        public NumberHelperTestAdd()
        {

        }
        public class Add
        {

            [Theory]
            [InlineData(10, 20, 30)]
            [InlineData(1, 2, 3)]
            [InlineData(-10, 20, 10)]
            [InlineData(-10, -20, -30)]
            public void Basic(int x, int y, int result)
            {
                var sut = new NumberHelper();
                var actual = sut.Add(x, y);
                Assert.Equal(result, actual);
            }

            public static IEnumerable<object[]> ValuesWithZero()
            {
                for (int i = 0; i < 1000; i++)
                {
                    yield return new object[] { i, 0, i };
                }
            }
            [Theory]
            [MemberData(nameof(ValuesWithZero))]
            public void BasicTwo(int x, int y, int result)
            {
                var sut = new NumberHelper();
                var actual = sut.Add(x, y);
                Assert.Equal(result, actual);
            }
        }
    }
}
