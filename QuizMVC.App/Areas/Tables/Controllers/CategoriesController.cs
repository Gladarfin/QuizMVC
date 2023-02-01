using Microsoft.AspNetCore.Mvc;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces;

namespace QuizMVC.App.Areas.Tables.Controllers;

[Area("Tables")]
public class CategoriesController :Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoriesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IActionResult> Index()
    {
        var categories = await _unitOfWork.Category.GetAllCategories();
        return View(categories);
    }
    
    #region CRUD operations

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CategoryDTO categoryDto)
    {
        var category = new Category()
        {
            Id = await _unitOfWork.Category.GetLastCategoryId() + 1,
            Name = categoryDto.Name,
            Description = categoryDto.Description,
            isDeleted = false
        };
        await _unitOfWork.Category.Add(category);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Edit(int id)
    {
        return View(await _unitOfWork.Category.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, CategoryDTO categoryDto)
    {
        var categoryToUpdate = await _unitOfWork.Category.GetByIdAsync(id);
        
        if (!ModelState.IsValid) 
            return View(categoryToUpdate);
        
        categoryToUpdate.Name = categoryDto.Name;
        categoryToUpdate.Description = categoryDto.Description;
        await _unitOfWork.Category.Update(categoryToUpdate);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Details(int id)
    {
        return View(await _unitOfWork.Category.GetByIdAsync(id));
    }
    public async Task<IActionResult> Delete(int id)
    {
        var category = await _unitOfWork.Category.GetByIdAsync(id);
        return View(category);
    }
    

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var categoryToDelete = await _unitOfWork.Category.GetByIdAsync(id);
        _unitOfWork.Category.Delete(categoryToDelete);
        return RedirectToAction("Index");
    }

    #endregion



}