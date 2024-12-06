
using System.ComponentModel.DataAnnotations;


namespace SampleApp.API.Entities;
public class User
{
    public Guid Id {get ;set;}
    
    [MinLength(5,ErrorMessage = "Минимальное длина имени 5")]
    [SampleApp.API.Validations.MaxLength(10)]
    public string Name {get ;set;} = string.Empty;
}