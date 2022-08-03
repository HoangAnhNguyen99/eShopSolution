using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);

        Task<CategoryViewModel> GetById(string languageId, int id);
    }
}