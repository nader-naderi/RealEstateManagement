using Microsoft.AspNetCore.Mvc;

using RealEstateManagement.Models;
using RealEstateManagement.Models.ViewModels;

using System.Diagnostics;

namespace RealEstateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContactForm(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            // TODO: Implement the email sending logic here, e.g., using SendGrid, MailKit, or SMTP.

            // For example, using SendGrid:
            // var client = new SendGridClient("YOUR_SENDGRID_API_KEY");
            // var from = new EmailAddress("test@example.com", "Example User");
            // var subject = "Contact Form Submission";
            // var htmlContent = "<strong>Name:</strong> " + model.Name + "<br><strong>Email:</strong> " + model.Email + "<br><strong>Message:</strong> " + model.Message;
            // var msg = MailHelpers.CreateSingleEmailToMultipleRecipients(from, "recipient@example.com", subject, "", htmlContent);
            // var response = await client.SendEmailAsync(msg);

            // Display a success message or redirect to a thank you page
            ViewBag.SuccessMessage = "Thank you for your message! We'll get back to you soon.";
            return View("Contact", model);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
