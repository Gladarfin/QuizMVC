using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IQuestionAnswerRepository : IGenericRepository<QuestionAnswer>
{
    public void Delete(QuestionAnswer questionAnswer)
    {
        questionAnswer.isDeleted = true;
    }
}