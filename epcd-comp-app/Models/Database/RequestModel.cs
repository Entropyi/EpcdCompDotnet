using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace epcd_comp_app.Models;

public class RequestModel
{
    [Key]
    public int RequestId { get; set; }

    [Required] public string? FullName { get; set; } = String.Empty;

    [Required] public string? Email { get; set; } = String.Empty;
    
    public string? Age { get; set; } = String.Empty;
    
    [Required]
    public string PhoneNumber { get; set; } = String.Empty;
   
    [Required]
    public string[]? ImageIDs { get; set; } = Array.Empty<string>();

    public string? Comments { get; set; } = String.Empty;

    [Required] public string? PhotoLocation { get; set; } = String.Empty;
    
    public string? PhotoPurpose { get; set; }

    [Required] public DateTime? CreationTime { get; set; } = DateTime.Now;
}

public class ClassB
{
    public int ClassBId { get; set; }
    public int RequestModelsId { get; set; }
    public List<RequestModel> RequestModels { get; set; }
}