namespace ECommerce.Application.Services;

public interface IEmailService
{
    public void SendConfirmationEmail(string toEmail , string username , string passwordToken);
}