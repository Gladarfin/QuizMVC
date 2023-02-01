using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Models.Quiz;

namespace QuizMVC.App.Areas.Tables.Controllers;

[Area("Tables")]
public class QuestionsController  : Controller
{
    private readonly QuizMvcDbContext _context;

    public QuestionsController(QuizMvcDbContext context)
    {
        _context = context;
    }
    
    
    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
    }
    
    public async Task<IActionResult> Index()
    {
        var questions = await _context.Questions.Select(q => new Question()
            {
                Id = q.Id,
            
                Category = _context.Categories
                    .Select(cn => cn)
                    .FirstOrDefault(c => c.Id == q.CategoryId), 
            
                QuestionText = q.QuestionText,
                Updated = q.Updated,
            
                QuestionType = _context.QuestionTypes
                    .Select(qt => qt)
                    .FirstOrDefault(t => t.Id == q.QuestionTypeId),
            
                IsActive = q.IsActive
            })
            .OrderBy(q => q.Id)
            .ToListAsync();
        return View(questions);
    }
    
    public IActionResult Edit(int id)
    {
        return View(_context.Questions.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(int id)
    {
        return View(_context.Questions.Select(x => x.Id == id).FirstOrDefault());
    }
}