using QuizMVC.Data;
using QuizMVC.Models.Main;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class UserRepository: GenericRepository<User>, IUserRepository
{
    public UserRepository(QuizMvcDbContext context) : base(context)
    {
    }
}