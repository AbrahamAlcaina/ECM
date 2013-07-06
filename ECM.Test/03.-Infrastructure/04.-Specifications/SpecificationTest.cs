// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecificationTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The specification test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ecm.Test
{
    using ECM.Infrastructure;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    ///   The specification test.
    /// </summary>
    public class SpecificationTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The is greater than five is satisfied by.
        /// </summary>
        /// <param name="number">
        /// The number. 
        /// </param>
        /// <param name="result"></param>
        /// <returns>
        /// The System.Boolean. 
        /// </returns>
        [Theory]
        [InlineData(6, true)]
        [InlineData(5, false)]
        public void IsGreaterThanLimitIsSatisfiedBy(int number, bool result)
        {
            // arrange
            var sut = this.GetSpecificationUpperLimmit(5);

            // act
            var isSatisfiedBy = sut.IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The is not greater than five is satisfied by.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, false)]
        [InlineData(15, false)]
        public void AndFluentIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var sut = new Specification<int>(x => x < 10);

            // act
            var isSatisfiedBy = sut.And(y => y > 5).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The and fluent with specification is satisfied by test.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, false)]
        [InlineData(15, false)]
        public void AndFluentWithSpecificationIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var main = this.GetSpecificationUpperLimmit(5);
            var sut = new Specification<int>(x => x < 10);

            // act
            var isSatisfiedBy = main.And(sut).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The and fluent with three operators.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(5, true)]
        [InlineData(3, false)]
        [InlineData(7, false)]
        [InlineData(15, false)]
        [InlineData(30, false)]
        public void AndFluentWithThreeOperators(int number, bool result)
        {
            // arrange
            var a = new Specification<int>(x => x < 10);
            var b = new Specification<int>(y => y < 20);
            var c = new Specification<int>(z => z == 5);
            var d = new Specification<int>(w => w > 4);

            // act
            var isSatisfiedBy = 
                a
                .And(b)
                .And(c)
                .And(d)
                .IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The and fluent with three operators.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(5, true)]
        [InlineData(11, true)]
        [InlineData(21, false)]
        [InlineData(31, false)]
        [InlineData(30, true)]
        [InlineData(31, false)]
        [InlineData(40, true)]
        [InlineData(41, false)]
        public void OrFluentWithThreeOperators(int number, bool result)
        {
            // arrange
            var a = new Specification<int>(x => x < 10);
            var b = new Specification<int>(y => y < 20);
            var c = new Specification<int>(z => z == 30);
            var d = new Specification<int>(w => w == 40);

            // act
            var isSatisfiedBy =
                a
                .Or(b)
                .Or(c)
                .Or(d)
                .IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The or is satisfied by test.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, true)]
        [InlineData(11, false)]
        public void OrFluentIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var sut = new Specification<int>(x => x < 10);

            // act
            var isSatisfiedBy = sut.Or(y => y < 7).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The or is satisfied by test.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, true)]
        [InlineData(11, false)]
        public void OrFluentWithSpecificationIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var sut = new Specification<int>(x => x < 10);
            var main = new Specification<int>(y => y < 7);

            // act
            var isSatisfiedBy = sut.Or(main).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The not is satisfied by test.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, false)]
        [InlineData(11, false)]
        public void NotIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var sut = new Specification<int>(x => x < 10);

            // act
            var isSatisfiedBy = sut.Not(y => y < 7).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        /// The not equal is satisfied by test.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        [Theory]
        [InlineData(9, true)]
        [InlineData(5, false)]
        [InlineData(11, false)]
        public void NotEqualIsSatisfiedByTest(int number, bool result)
        {
            // arrange
            var maxSixSpecification = this.GetSpecificationUpperLimmit(7);
            var sut = new Specification<int>(x => x > 10);

            // act
            var isSatisfiedBy = sut.Not(maxSixSpecification).IsSatisfiedBy().Compile().Invoke(number);

            // assert
            Assert.Equal(result, isSatisfiedBy);
        }

        /// <summary>
        ///   The specification constructor.
        /// </summary>
        [Fact]
        public void SpecificationConstructor()
        {
            // arrange

            // act
            var sut = new Specification<int>(i => i > 5);

            // assert
            Assert.NotNull(sut.Predicate);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The get default specification.
        /// </summary>
        /// <param name="limit">
        /// The limit.
        /// </param>
        /// <returns>
        /// The <see>
        ///       <cref>Specification</cref>
        ///     </see> of integer.
        /// </returns>
        private Specification<int> GetSpecificationUpperLimmit(int limit)
        {
            return new Specification<int>(i => i > limit);
        }

        #endregion
    }
}