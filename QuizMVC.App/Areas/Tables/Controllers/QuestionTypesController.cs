using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;

namespace QuizMVC.App.Areas.Tables.Controllers;
[Area("Tables")]
public class QuestionTypesController : Controller
{
    private readonly QuizMvcDbContext _context;

    public QuestionTypesController(QuizMvcDbContext context)
    {
        _context = context;
    }
    
    
    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
    }
    
        
    public async Task<IActionResult> Index()
    {
        var questionTypes = await _context.QuestionTypes
            .Select(qt => qt)
            .OrderBy(qt => qt.Id)
            .ToListAsync();
        return View(questionTypes);
    }
    
    public IActionResult Edit(int id)
    {
        return View(_context.QuestionTypes.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(int id)
    {
        return View(_context.QuestionTypes.Select(x => x.Id == id).FirstOrDefault());
    }
}