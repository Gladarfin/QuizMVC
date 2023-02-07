using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;

using QuizMVC.Models.Main;
using QuizMVC.Models.Quiz;

namespace QuizMVC.Data;

public class QuizMvcDbContext: DbContext
{
    private readonly byte[] _encryptionKey = Encoding.Default.GetBytes("6D7A1BA429851A4033ED29CBA9416B9E");
    private readonly byte[] _encryptionIV = Encoding.Default.GetBytes("0197AB6E1F30D97C51EAD8FAC1BA9EC6".Substring(0, 16));
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
    public DbSet<QuestionType> QuestionTypes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseEncryption(_provider);
        modelBuilder.Seed();
    }
    
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<DateOnly>()
            .HaveConversion<DateOnlyConverter>()
            .HaveColumnType("date");

        base.ConfigureConventions(builder);
    }
}