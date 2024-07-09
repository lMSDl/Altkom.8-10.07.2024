using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        static ICartService _cartService;
        static IProductsService _productsService;
        static IPaymentService _paymentService;


        public static void Execute()
        {

            int[] productIds = new int[] { 2, 63, 55, 121 };

            /*foreach (var id in productIds)
            {
                var price = _productsService.GetPrice(id);
                _cartService.AddProduct(id, price);
            }
            _paymentService.Pay(_cartService.GetId(), _cartService.GetValue());*/

            var shop = new ShopFacade(_cartService, _productsService, _paymentService);
            shop.Buy(productIds);
        }

    }
}
