using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Models.Quiz;

namespace QuizMVC.App.Areas.Tables.Controllers;

[Area("Tables")]
public class QuestionAnswersController  : Controller
{
    private readonly QuizMvcDbContext _context;

    public QuestionAnswersController(QuizMvcDbContext context)
    {
        _context = context;
    }
    
    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
    }
    
    public async Task<IActionResult> Index()
    {
        var questionAnswers = await _context.QuestionAnswers.Select(qa => new QuestionAnswer()
            {
                Id = qa.Id,
                
                Question =_context.Questions
                    .Select(q => q)
                    .FirstOrDefault(qt => qt.Id == qa.QuestionId),
                
                RightAnswer = qa.RightAnswer
            })
            .OrderBy(qa => qa.Id)
            .ToListAsync();
        return View(questionAnswers);
    }

    public IActionResult Edit(int id)
    {
        return View(_context.QuestionAnswers.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(int id)
    {
        return View(_context.QuestionAnswers.Select(x => x.Id == id).FirstOrDefault());
    }
}