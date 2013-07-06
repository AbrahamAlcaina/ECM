namespace ECM.Test
{
    using ECM.Infrastructure;

    using Xunit;

    /// <summary>
    /// The and specification test.
    /// </summary>
    public class AndSpecificationTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The and specification satisfied test.
        /// </summary>
        [Fact]
        public void AndSpecificationSatisfiedTest()
        {
            // Arrange
            var specification = new AndSpecification<int>(
                new Specification<int>(x => x > 0), new Specification<int>(y => y < 10));

            // Act
            var sut = specification.IsSatisfiedBy().Compile().Invoke(5);

            // Assert
            Assert.True(sut);
        }

        #endregion
    }
}