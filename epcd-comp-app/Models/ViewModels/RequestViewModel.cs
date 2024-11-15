namespace epcd_comp_app.Models.ViewModels
{
    public class RequestViewModel
    {
       public string FullName { get; set; } = "";

       public string Email { get; set; } = "";

        public string? Age { get; set; }

        
        public string PhoneNumber { get; set; } = "";

       
        public string[] ImageIDs { get; set; } = Array.Empty<string>();
        public string? Comments { get; set; }

        public string PhotoLocation { get; set; } = "";

        public string? PhotoPurpose { get; set; }
    }
}
