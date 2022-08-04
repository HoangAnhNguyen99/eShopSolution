using eSheopSolution.Utilities.Constants;
using eShopSolution.ApiIntegration;
using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace eShopSolution.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;

        public CartController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("{id}/{languageId}")]
        public async IActionResult AddToCart(int id, string languageId)
        {
            var product = await _productApiClient.GetById(id, languageId);
            var curentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(HttpContext.Session.GetString(SystemConstants.CartSession));
            int quantity = 1;
            if (curentCart.Any(x => x.ProductId == id))
            {
                quantity = curentCart.First(x => x.ProductId == id).Quantity + 1;
            }
            var cartItem = new CartItemViewModel()
            {
                ProductId = id,
                Description = product.Description,
                Image = product.ThumbnailImage,
                Name = product.Name,
                Quantity = quantity
            };
            if (curentCart == null) curentCart = new List<CartItemViewModel>();
            curentCart.Add(cartItem);
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(curentCart));
            return View();
        }
    }
}