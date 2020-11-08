namespace Generics
{
    // Example of a constraint to a class (the Product class in this case)
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
