// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.Extensions.Configuration;
//
// namespace QuizMVC.Data;
//
// /// <summary>
// /// This class is just to make creation scaffolded items work
// /// </summary>
// public class QuizMVCDbContextFactory : IDesignTimeDbContextFactory<QuizMvcDbContext>
// {
//     public QuizMvcDbContext CreateDbContext(string[] args)
//     {
//         var configuration = new ConfigurationBuilder()
//             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//             .AddJsonFile("appsettings.json")
//             .Build();
//
//         var optionsBuilder = new DbContextOptionsBuilder<QuizMvcDbContext>();
//         optionsBuilder.UseNpgsql(configuration.GetConnectionString("QuizMVCConnection"));
//
//         return new QuizMvcDbContext(optionsBuilder.Options);
//     }
// }