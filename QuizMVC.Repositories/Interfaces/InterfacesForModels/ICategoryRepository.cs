using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface ICategoryRepository: IGenericRepository<Category>
{
    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        return await GetAllAsync(filter: c => !c.isDeleted,
            orderBy: c => c.OrderBy(x => x.Id));
    }

    public async Task<int> GetLastCategoryId()
    {
        return await GetLastId(orderBy: c => c.OrderBy(x => x.Id), max: c => c.Id);
    }
    
    public void Delete(Category category)
    {
        category.isDeleted = true;
        Update(category);
    }
}