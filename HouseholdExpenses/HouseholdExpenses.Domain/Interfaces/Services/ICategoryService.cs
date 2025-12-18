using HouseholdExpenses.Domain.Entity;

namespace HouseholdExpenses.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task CreateCategory (Category category);
        Task<Category> GetCategoryById (Guid idCategory);
        Task <IEnumerable<Category>> GetAllCategories ();
    }
}
