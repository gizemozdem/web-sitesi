
using RealEstate.Dapper.Api.Dtos;


namespace RealEstate.Dapper.Api.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
            Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        

    }
}
