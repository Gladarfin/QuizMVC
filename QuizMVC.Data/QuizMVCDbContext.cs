using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;
using QuizMVC.Models.Main;
using QuizMVC.Models.Quiz;

namespace QuizMVC.Data;

public class QuizMvcDbContext: DbContext
{

    private readonly byte[] _encryptionKey = AesProvider.GenerateKey(AesKeySize.AES128Bits).Key.ToArray();
    private readonly byte[] _encryptionIV = AesProvider.GenerateKey(AesKeySize.AES128Bits).Key.ToArray();
    private readonly IEncryptionProvider _provider;
    public QuizMvcDbContext(DbContextOptions<QuizMvcDbContext> options)
    :base(options)
    {
        _provider = new AesProvider(_encryptionKey, _encryptionIV);
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    public DbSet<QuestionChoice> QuestionChoices { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseEncryption(_provider);
        modelBuilder.Seed();
    }
}