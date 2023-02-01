using QuizMVC.Models.Quiz;

namespace QuizMVC.Repositories.Interfaces.InterfacesForModels;

public interface IQuestionTypeRepository : IGenericRepository<QuestionType>
{
    public async Task<IEnumerable<QuestionType>> GetAllQuestionTypes()
    {
        return await GetAllAsync(filter: qt => !qt.isDeleted,
            orderBy: qt => qt.OrderBy(x => x.Id));
    }

    public async Task<int> GetLastQuestionTypeId()
    {
        return await GetLastId(
            orderBy: qt => qt.OrderBy(x => x.Id), 
            max: qt => qt.Id);
    }
    
    public void Delete(QuestionType questionType)
    {
        questionType.isDeleted = true;
        Update(questionType);
    }
}