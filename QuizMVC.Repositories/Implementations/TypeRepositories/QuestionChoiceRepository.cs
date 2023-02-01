using QuizMVC.Data;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Implementations.TypeRepositories;

public class QuestionChoiceRepository: GenericRepository<QuestionChoice>, IQuestionChoiceRepository
{
    public QuestionChoiceRepository(QuizMvcDbContext context) : base(context)
    {
    }
}