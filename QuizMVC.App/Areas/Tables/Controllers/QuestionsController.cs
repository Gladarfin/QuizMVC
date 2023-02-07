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
    
    public IActionResult Edit(Guid id)
    {
        return View(_context.Questions.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(Guid id)
    {
        return View(_context.Questions.Select(x => x.Id == id).FirstOrDefault());
    }

    public IActionResult Create()
    {
        var qtList = _context.QuestionTypes.Where(x => !x.IsDeleted).ToList();
        qtList.Insert(0, new QuestionType {  Id = 0, Type = "-- Select Question Type --"});
        ViewBag.message = qtList;
        
        
        return View();
    }
}