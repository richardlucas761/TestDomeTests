namespace MegaStore
{
    /// <summary>
    /// Provide a MegaStore discounted price.
    /// </summary>
    public static class MegaStore
    {
        /// <summary>
        /// Get a discounted price based on a discount type, the cart weight and total price before discount.
        /// </summary>
        /// <param name="cartWeight">Weigh of goods in the cart</param>
        /// <param name="totalPrice">Total price of goods</param>
        /// <param name="discountType">Discount scheme being applied</param>
        /// <returns>A discounted price based on a discount type, the cart weight and total price before discount.</returns>
        public static double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType)
        {
            if (discountType == DiscountType.Standard)
            {
                return DiscountedPrice(totalPrice, 6);
            }
            else if (discountType == DiscountType.Seasonal)
            {
                return DiscountedPrice(totalPrice, 12);
            }
            else if (discountType == DiscountType.Weight)
            {
                if (cartWeight <= 10)
                {
                    return DiscountedPrice(totalPrice, 6);
                }
                else
                {
                    return DiscountedPrice(totalPrice, 18);
                }
            }

            return 0.0;
        }

        private static double DiscountedPrice(double originalPrice, double discount)
        {
            return originalPrice - (originalPrice * (discount / 100));
        }
    }
}