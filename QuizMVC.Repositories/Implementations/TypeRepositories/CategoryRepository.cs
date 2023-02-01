using QuizMVC.Data;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(QuizMvcDbContext context) : base(context)
    {
    }
}