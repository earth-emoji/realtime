using System.Threading.Tasks;

namespace RealTime.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
