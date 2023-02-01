using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Models.Quiz;

namespace QuizMVC.App.Areas.Tables.Controllers;
[Area("Tables")]
public class QuestionChoicesController  : Controller
{
    private readonly QuizMvcDbContext _context;

    public QuestionChoicesController(QuizMvcDbContext context)
    {
        _context = context;
    }

    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
    }
    
    public async  Task<IActionResult> Index()
    {
        var questionChoices = await _context.QuestionChoices.Select(qc => new QuestionChoice()
            {
                Id = qc.Id,
            
                Question = _context.Questions
                    .Select(q => q)
                    .FirstOrDefault(qt => qt.Id == qc.QuestionId),
            
                Choice = qc.Choice
            })
            .OrderBy(qc => qc.Id)
            .ToListAsync();
        return View(questionChoices);
    }
    
    public IActionResult Edit(int id)
    {
        return View(_context.QuestionChoices.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(int id)
    {
        return View(_context.QuestionChoices.Select(x => x.Id == id).FirstOrDefault());
    }
}