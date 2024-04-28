using System.Net.Mail;

namespace WebAppAutorization.Pages
{
    public class UserProfile : UserProfille
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TgNick { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string UserRole { get; set; }

        public void SendEmail(string subject, string body)
        {
            // Отправка электронного письма через SMTP
            SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("your_email@mail.ru", "your_password");
            client.EnableSsl = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("your_email@mail.ru");
            mailMessage.To.Add(Email);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            client.Send(mailMessage);
        }
    }
}
