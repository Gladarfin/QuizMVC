using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Models.Main;

namespace QuizMVC.App.Areas.Tables.Controllers;

[Area("Tables")]

public class UsersController  : Controller
{
    private readonly QuizMvcDbContext _context;

    public UsersController(QuizMvcDbContext context)
    {
        _context = context;
    }
    
    
    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
    }
    
    public async Task<IActionResult> Index()
    {
        var users = await _context.Users
            .Select(x => new User()
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Name = x.Name,
                Surname = x.Surname,
                DateOfBirth = x.DateOfBirth,
                IsDeleted = x.IsDeleted,
                RegistrationDate = x.RegistrationDate,
                Rating = x.Rating
            })
            .OrderBy(x => x.Id)
            .ToListAsync();
        return View(users);
    }
    
    public IActionResult Edit(int id)
    {
        return View(_context.Users.Select(x => x.Id == id).FirstOrDefault());
    }
    
    public IActionResult Details(int id)
    {
        return View(_context.Users.Select(x => x.Id == id).FirstOrDefault());
    }
}