using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using epcd_comp_app.Models;
using epcd_comp_app.Data;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using epcd_comp_app.Models.ViewModels;
using Microsoft.AspNetCore.Localization;

namespace epcd_comp_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly RequestDbContext _context;


    public HomeController(ILogger<HomeController> logger,RequestDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public IActionResult Index()
    {
        ViewData["name"] = "jehad";
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    [HttpPost("submit")]
    public IActionResult Submit(RequestViewModel request)
    {
        try
        {
            RequestModel model = new RequestModel
            {
                FullName = request.FullName,
                PhoneNumber = "055555",
                Age = "12",
                PhotoPurpose = "21",
                PhotoLocation = "21111",
                Email = request.Email,
                Comments = "sss",
                CreationTime = DateTime.Now
            };
            _context.Requests.Add(model);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
        // Log the submitted fullName
        Console.Write(request.Email);

        // Return a response indicating success or failure
        return View(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    [HttpPost]
    public IActionResult SetLanguage(string culture, string returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        );

        return LocalRedirect(returnUrl);
    }
}