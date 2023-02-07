using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Models.DTO;
using QuizMVC.Models.Main;
using QuizMVC.Repositories.Interfaces;

namespace QuizMVC.App.Areas.Tables.Controllers;

[Area("Tables")]

public class UsersController  : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public UsersController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IActionResult> Index()
    {
        var users = await _unitOfWork.User.GetAllUsers();
        return View(users);
    }

    #region CRUD operations

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(UserDTO userDto)
    {
        var user = new User
        {
            Username = userDto.Username,
            Password = userDto.Password,
            Email = userDto.Email,
            Name = userDto.Name,
            Surname = userDto.Surname,
            DateOfBirth = userDto.DateOfBirth,
            IsDeleted = false
        };
        await _unitOfWork.User.Add(user);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Edit(Guid id)
    {
        return View(await _unitOfWork.User.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Guid id, UserDTO userDto)
    {
        var userToUpdate = await _unitOfWork.User.GetByIdAsync(id);
        
        if (!ModelState.IsValid) 
            return View(userToUpdate);
        
        userToUpdate.Username = userDto.Username;
        userToUpdate.Password = userDto.Password;
        userToUpdate.Email = userDto.Email;
        userToUpdate.Name = userDto.Name;
        userToUpdate.Surname = userDto.Surname;
        userToUpdate.DateOfBirth = userDto.DateOfBirth;
        
        await _unitOfWork.User.Update(userToUpdate);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Details(Guid id)
    {
        return View(await _unitOfWork.User.GetByIdAsync(id));
    }
    public async Task<IActionResult> Delete(Guid id)
    {
        var user = await _unitOfWork.User.GetByIdAsync(id);
        return View(user);
    }
    

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var userToDelete = await _unitOfWork.User.GetByIdAsync(id);
        _unitOfWork.User.Delete(userToDelete);
        return RedirectToAction("Index");
    }

    #endregion
}