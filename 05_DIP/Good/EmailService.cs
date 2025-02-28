using SOLID._05_DIP.Good.Interface;

namespace SOLID._05_DIP.Good
{
    public class EmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Sending email");
        }
    }
}
