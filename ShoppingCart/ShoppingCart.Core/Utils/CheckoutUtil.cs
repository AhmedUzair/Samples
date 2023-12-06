using ShopingCart.Core.Entities;

namespace ShoppingCart.Core.Utils
{
    public class CheckoutUtil
    {

        public double CalculateCartTotalCost(List<CartItem> items)
        {
            // should calculate items cost with taxes and shipping cost

            return 0;
        }

        public double CalculateShippingCost(int region)
        {
            // should return region specific shipping cost

            return 0;
        }

        public double CalculateTaxes(double productCost)
        {
            // should return product specific taxes

            return 0;
        }
    }
}
