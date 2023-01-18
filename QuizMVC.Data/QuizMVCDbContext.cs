using Microsoft.EntityFrameworkCore;

namespace QuizMVC.Data;

public class QuizMvcDbContext: DbContext
{
    public QuizMvcDbContext(DbContextOptions<QuizMvcDbContext> options)
    :base(options)
    {
        
    }
    
    //DbSets Here
}