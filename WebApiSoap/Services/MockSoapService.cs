using WebApiSoap.Interfaces;

namespace WebApiSoap.Services
{
    public class MockSoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            Task.Delay(90000).Wait();
            return $"Sum of two number is: {num1 + num2}";
        }

    }
}
