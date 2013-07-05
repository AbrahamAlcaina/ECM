namespace Ecm.Test
{
    using ECM.Infrastructure;

    using Xunit;

    /// <summary>
    /// The not equal specification test.
    /// </summary>
    internal class NotEqualSpecificationTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The not equal specification satisfied test.
        /// </summary>
        [Fact]
        public void NotEqualSpecificationSatisfiedTest()
        {
            // Arrange
            var specification = new NotEqualSpecification<int>(
                new Specification<int>(x => x > 0), new Specification<int>(y => y > 10));

            // Act
            var sut = specification.IsSatisfiedBy().Compile().Invoke(5);

            // Assert
            Assert.True(sut);
        }

        #endregion
    }
}