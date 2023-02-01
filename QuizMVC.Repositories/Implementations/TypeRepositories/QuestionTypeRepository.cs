using QuizMVC.Data;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class QuestionTypeRepository: GenericRepository<QuestionType>, IQuestionTypeRepository
{
    public QuestionTypeRepository(QuizMvcDbContext context) : base(context)
    {
    }
}