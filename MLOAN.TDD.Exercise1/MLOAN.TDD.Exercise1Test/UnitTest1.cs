using System;
using Xunit;
using MLOAN.TDD.Exercise1;
namespace MLOAN.TDD.Exercise1Test
{
    public class NumberHelperTest
    {
        public class FindMissings
        {
            [Fact]
            public void Continuously_NoMissing()
            {
               //arrange
               var values = new[] {1,2,3 };
                var sut = new NumberHelper();
                //act
                int[] res = sut.FindMissing(values);

                //assert
                Assert.NotNull(res);
                Assert.Equal(0, res.Length);

            }

            [Fact]
            public void ContinuouslyNoSorted_NoMissing()
            {
                //arrange
                var values = new[] { 1, 3, 2 };
                var sut = new NumberHelper();
                //act
                int[] res = sut.FindMissing(values);

                //assert
                Assert.NotNull(res);
                Assert.Equal(0, res.Length);
            }

            [Fact]
            public void HasSingleMissing()
            {
                //arrange
                var values = new[] { 1, 3, 2,5 };
                var sut = new NumberHelper();
                //act
                int[] res = sut.FindMissing(values);

                //assert
                Assert.NotNull(res);
                Assert.Single(res);

                Assert.Equal(new[] { 4 },res );
            }

            [Fact]
            public void EmptyArray_NoMissing()
            {
                //arrange
                var values = new int[0];
                var sut = new NumberHelper();
                //act
                int[] res = sut.FindMissing(values);

                //assert
                Assert.NotNull(res);
                Assert.Empty(res);
            }
            [Fact]
            public void Null_ThrowException()
            {
                //arrange
                int[]? values = null;
                var sut = new NumberHelper();
                //act
                var ex = Assert.Throws<ArgumentNullException>(() => {
                    sut.FindMissing(values);
                });
                //assert

                Assert.Equal("values", ex.ParamName);
            }

        }

    }
}
