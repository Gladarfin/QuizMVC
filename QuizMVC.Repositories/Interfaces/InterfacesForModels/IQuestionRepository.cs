using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IQuestionRepository : IGenericRepository<Question>
{
    public void Delete(QuestionChoice questionChoice)
    {
        questionChoice.IsDeleted = true;
    }
}