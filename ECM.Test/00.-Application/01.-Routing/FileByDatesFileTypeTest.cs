namespace ECM.Test._00._Application._01._Routing
{
    using ECM.Application.Routing;

    using Xunit;

    public class FileByDatesFileTypeTest
    {
        #region Methods

        [Fact]
        public void ToStringWorksProperly()
        {
            // arrange 
            var sut = new FileByDatesFileType();

            // act 
            var result = sut.ToString();

            // assert
            Assert.Equal("", result);
        }

        #endregion
    }
}