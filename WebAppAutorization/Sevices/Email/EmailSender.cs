using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebAppAutorization.Sevices.Email
{
    [Authorize]
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            
            await Task.CompletedTask;
        }
    }
}
