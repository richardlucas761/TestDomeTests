using FluentAssertions;

namespace MegaStoreTests
{
    [TestClass]
    public sealed class MegaStoreTests
    {
        [TestMethod]
        public void GetDiscountedPriceReturnsSixPercentReductionForStandardDiscount()
        {
            // Arrange

            // Act
            var result = MegaStore.MegaStore.GetDiscountedPrice(100, 100, MegaStore.DiscountType.Standard);

            // Assert
            result.Should().Be(94);
        }

        [TestMethod]
        public void GetDiscountedPriceReturnsSixPercentReductionForSeasonalDiscount()
        {
            // Arrange

            // Act
            var result = MegaStore.MegaStore.GetDiscountedPrice(100, 100, MegaStore.DiscountType.Seasonal);

            // Assert
            result.Should().Be(88);
        }

        [TestMethod]
        public void GetDiscountedPriceReturnsSixPercentReductionForWeightDiscountWhereWeightLessThanOrEqualToTen()
        {
            // Arrange

            // Act
            var result = MegaStore.MegaStore.GetDiscountedPrice(10, 100, MegaStore.DiscountType.Weight);

            // Assert
            result.Should().Be(94);
        }

        [TestMethod]
        public void GetDiscountedPriceReturnsSixPercentReductionForWeightDiscountWhereWeightGreaterThanTen()
        {
            // Arrange

            // Act
            var result = MegaStore.MegaStore.GetDiscountedPrice(12, 100, MegaStore.DiscountType.Weight);

            // Assert
            result.Should().Be(82);
        }
    }
}
