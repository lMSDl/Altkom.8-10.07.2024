namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.II
{
    internal class ShopFacade
    {
        ICartService _cartService;
        IProductsService _productsService;
        IPaymentService _paymentService;

        public ShopFacade(ICartService cartService, IProductsService productsService, IPaymentService paymentService)
        {
            _cartService = cartService;
            _productsService = productsService;
            _paymentService = paymentService;
        }

        public void Buy(params int[] prodcutsIds)
        {
            foreach (var id in prodcutsIds)
            {
                var price = _productsService.GetPrice(id);
                _cartService.AddProduct(id, price);
            }
            _paymentService.Pay(_cartService.GetId(), _cartService.GetValue());
        }
    }
}
