using Microsoft.AspNetCore.Mvc;
using QuizMVC.Models.DTO;
using QuizMVC.Models.Quiz;
using QuizMVC.Repositories.Interfaces;

namespace QuizMVC.App.Areas.Tables.Controllers;
[Area("Tables")]
public class QuestionTypesController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionTypesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IActionResult> Index()
    {
        var questionTypes = await _unitOfWork.QuestionType.GetAllQuestionTypes();
        return View(questionTypes);
    }
    
    #region CRUD operations

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(QuestionTypeDTO questionTypeDto)
    {
        var questionType = new QuestionType()
        {
            Id = await _unitOfWork.QuestionType.GetLastQuestionTypeId() + 1,
            Type = questionTypeDto.Type,
            IsDeleted = false
        };
        await _unitOfWork.QuestionType.Add(questionType);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Edit(int id)
    {
        return View(await _unitOfWork.QuestionType.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, QuestionTypeDTO questionTypeDto)
    {
        var questionTypeToUpdate = await _unitOfWork.QuestionType.GetByIdAsync(id);
        
        if (!ModelState.IsValid) 
            return View(questionTypeToUpdate);
        
        questionTypeToUpdate.Type = questionTypeDto.Type;
        await _unitOfWork.QuestionType.Update(questionTypeToUpdate);
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> Details(int id)
    {
        return View(await _unitOfWork.QuestionType.GetByIdAsync(id));
    }
    public async Task<IActionResult> Delete(int id)
    {
        var questionType = await _unitOfWork.QuestionType.GetByIdAsync(id);
        return View(questionType);
    }
    
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var questionTypeToDelete = await _unitOfWork.QuestionType.GetByIdAsync(id);
        _unitOfWork.QuestionType.Delete(questionTypeToDelete);
        return RedirectToAction("Index");
    }

    #endregion
}