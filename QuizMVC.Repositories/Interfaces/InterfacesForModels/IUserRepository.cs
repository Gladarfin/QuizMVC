using QuizMVC.Models.Main;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IUserRepository: IGenericRepository<User>
{
    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await GetAllAsync(filter: u => !u.IsDeleted,
            orderBy: u => u.OrderBy(x => x.Id));
    }
    
    public void Delete(User user)
    {
        user.IsDeleted = true;
        Update(user);
    }
}