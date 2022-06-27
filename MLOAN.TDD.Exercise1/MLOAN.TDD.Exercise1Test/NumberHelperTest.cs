using System;
using Xunit;
using MLOAN.TDD.Exercise1;
namespace MLOAN.TDD.Exercise1Test
{
    public class NumberHelperTest
    {
        public class FindMissingsFixture
        {
            public int MagicNumber { get; set; } = 555;
            //varialble like global can be reach by any method
            //any method can set this variable and every method would see the new
            //value that was set

            public FindMissingsFixture()
            {
                MagicNumber = 666;
            }
            
        }

        
        public class FindMissings :IClassFixture<FindMissings>, IDisposable 
        {
            //IClassFixture can close memory when programe done in 'class' level
            //IDisposable can close memory when programe done in 'method' level
            private NumberHelper sut;

            public FindMissings()
            {
                sut = new();
            }
            public void Dispose()
            {
               // throw new NotImplementedException();
            }

            [Fact]
            public void Continuously_NoMissing()
            {
                //arrange
                var values = new[] { 1, 2, 3 };

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
                var values = new[] { 1, 3, 2, 5 };

                //act
                int[] res = sut.FindMissing(values);

                //assert
                Assert.NotNull(res);
                Assert.Single(res);

                Assert.Equal(new[] { 4 }, res);
            }

            [Fact]
            public void EmptyArray_NoMissing()
            {
                //arrange
                var values = new int[0];

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

                //act
                var ex = Assert.Throws<ArgumentNullException>(() =>
                {
                    sut.FindMissing(values);
                });
                //assert

                Assert.Equal("values", ex.ParamName);
            }

        }

    }
}
