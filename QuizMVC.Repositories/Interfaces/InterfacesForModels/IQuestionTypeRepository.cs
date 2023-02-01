using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IQuestionTypeRepository : IGenericRepository<QuestionType>
{
    public void Delete(QuestionType questionType)
    {
        questionType.isDeleted = true;
    }
}