using SOLID._05_DIP.Good.Interface;

namespace SOLID._05_DIP.Good
{
    public class FakeEmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Sending fake email");
        }
    }
}
