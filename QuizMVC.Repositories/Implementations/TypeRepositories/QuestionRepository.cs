using QuizMVC.Data;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class QuestionRepository: GenericRepository<Question>, IQuestionRepository
{
    public QuestionRepository(QuizMvcDbContext context) : base(context)
    {
    }
}