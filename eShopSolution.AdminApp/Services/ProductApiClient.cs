using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        public ProductApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductViewModel>>(
                $"/api/products/paging?pageIndex=" +
                $"{request.PageIndex}&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&languageId={request.LanguageId}");
            return data;
        }
    }
}