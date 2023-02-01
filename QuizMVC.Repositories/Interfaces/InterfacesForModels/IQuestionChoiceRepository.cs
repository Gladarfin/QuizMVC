using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IQuestionChoiceRepository : IGenericRepository<QuestionChoice>
{
    public void Delete(QuestionChoice questionChoice)
    {
        questionChoice.isDeleted = true;
    }
}