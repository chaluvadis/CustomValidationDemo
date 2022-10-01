using System.Text.Json.Serialization;

namespace CustomValidationDemo.Models;
public class Error
{
    [JsonPropertyOrder(order: 1)]
    public string Field { get; }
    [JsonPropertyOrder(order: 2)]
    public string Message { get; }
    public Error(string field, string message)
    {
        Field = field != string.Empty ? field : null;
        Message = message;
    }
}

