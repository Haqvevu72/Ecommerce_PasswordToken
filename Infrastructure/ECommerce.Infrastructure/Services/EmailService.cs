using System.Net;
using System.Net.Mail;
using ECommerce.Application.Services;

namespace ECommerce.Infrastructure.Services;

public class EmailService: IEmailService
{
    public void SendConfirmationEmail(string toEmail, string username , string passwordToken)
    {
        try
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, // Change as necessary
                Credentials = new NetworkCredential("novruzluqyds20@gmail.com", "tadc tvrs hvnd edtl"),
                EnableSsl = true
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("novruzluqyds20@gmail.com"),
                Subject = "Email Confirmation",
                Body = $"Hello {username} , please click link below to change your password,\n\n {passwordToken}",
                IsBodyHtml = false,
            };
            mailMessage.To.Add(toEmail);

            smtpClient.Send(mailMessage);
            Console.WriteLine("Confirmation email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending email: " + ex.Message);
        }
    }
}