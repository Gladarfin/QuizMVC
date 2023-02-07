using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace QuizMVC.Data;

public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
{
    public DateOnlyConverter() 
        : base(dateOnly => 
                dateOnly.ToDateTime(TimeOnly.MinValue), 
            dateTime => DateOnly.FromDateTime(dateTime)) { }
}