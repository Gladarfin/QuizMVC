using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ICategoryRepository Category { get; }
    IQuestionRepository Question { get; }
    IQuestionTypeRepository QuestionType { get; }
    IUserRepository User { get; }

    Task SaveAsync();
}