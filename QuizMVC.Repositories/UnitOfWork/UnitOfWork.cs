using QuizMVC.Data;
using QuizMVC.Repositories.Implementations.TypeRepositories;
using QuizMVC.Repositories.Interfaces;
using QuizMVC.Repositories.Interfaces.InterfacesForModels;

namespace QuizMVC.Repositories.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly QuizMvcDbContext _context;

    public UnitOfWork(QuizMvcDbContext context)
    {
        _context = context;
        Category = new CategoryRepository(_context);
        QuestionAnswer = new QuestionAnswerRepository(_context);
        QuestionChoice = new QuestionChoiceRepository(_context);
        Question = new QuestionRepository(_context);
        QuestionType = new QuestionTypeRepository(_context);
        User = new UserRepository(_context);
    }
    
    public ICategoryRepository Category { get; private set; }
    public IQuestionAnswerRepository QuestionAnswer { get; private set; }
    public IQuestionChoiceRepository QuestionChoice { get; private set;}
    public IQuestionRepository Question { get; private set;}
    public IQuestionTypeRepository QuestionType { get; private set;}
    public IUserRepository User { get; private set; }
    
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    void IDisposable.Dispose()
    {
        GC.SuppressFinalize(this);
    }
}