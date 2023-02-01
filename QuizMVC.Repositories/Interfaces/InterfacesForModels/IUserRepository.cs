using QuizMVC.Models.Main;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IUserRepository: IGenericRepository<User>
{
    public void Delete(User user)
    {
        user.IsDeleted = true;
    }
}