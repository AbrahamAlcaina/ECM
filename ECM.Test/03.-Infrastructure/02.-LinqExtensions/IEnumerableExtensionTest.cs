namespace ECM.Test._03._Infrastructure._02._LinqExtensions
{
    using System.Collections.Generic;

    using Xunit;

    public  class EnumerableExtensionTest
    {
        [Fact]
        public void ForEachTest()
        {
            // arrange
            var list = new List<int> { 1, 2, 3 };
            var result = 0;
            
            // act
            list.ForEach( i => result += i);

            // assert
            Assert.Equal(6, result);
        }
    }
}