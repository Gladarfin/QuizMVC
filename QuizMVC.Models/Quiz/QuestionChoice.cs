﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMVC.Models.Quiz;

public class QuestionChoice
{
    [Key]
    public int Id { get; set; }
    public int QuestionId { get; set; }
    [ForeignKey("QuestionId")]
    public Question Question { get; set; }
    
    [Required]
    public string Choice { get; set; }
    
    public bool isDeleted { get; set; }
}