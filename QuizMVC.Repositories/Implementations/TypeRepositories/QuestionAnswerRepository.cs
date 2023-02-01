using QuizMVC.Data;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class QuestionAnswerRepository: GenericRepository<QuestionAnswer>, IQuestionAnswerRepository
{
    public QuestionAnswerRepository(QuizMvcDbContext context): base(context)
    {
    }
}