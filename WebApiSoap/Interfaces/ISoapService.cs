using System.ServiceModel;

namespace WebApiSoap.Interfaces
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }

 
}
