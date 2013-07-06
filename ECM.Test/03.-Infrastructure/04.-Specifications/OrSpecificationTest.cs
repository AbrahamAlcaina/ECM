namespace Test.Domain.Specifications
{
    using ECM.Infrastructure;

    using Xunit;

    /// <summary>
    /// The or specification test.
    /// </summary>
    public class OrSpecificationTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The or specification satisfied test.
        /// </summary>
        [Fact]
        public void OrSpecificationSatisfiedTest()
        {
            // Arrange
            var specification = new AndSpecification<int>(
                new Specification<int>(x => x > 0), new Specification<int>(y => y > 4));

            // Act
            var sut = specification.IsSatisfiedBy().Compile().Invoke(5);

            // Assert
            Assert.True(sut);
        }

        #endregion
    }
}