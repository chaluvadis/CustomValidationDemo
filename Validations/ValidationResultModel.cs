using Microsoft.AspNetCore.Mvc.ModelBinding;
using CustomValidationDemo.Models;
namespace CustomValidationDemo.Validations;
public class ValidationResultModel
{
    public string Message { get; }
    public List<Error> Errors { get; }
    public ValidationResultModel(ModelStateDictionary modelStateDictornay)
    {
        Message = "Validation Failed";
        Errors = modelStateDictornay.Keys
                .SelectMany(key => modelStateDictornay[key].Errors.Select(x => new Error(key, x.ErrorMessage)))
                .ToList();
    }
}

