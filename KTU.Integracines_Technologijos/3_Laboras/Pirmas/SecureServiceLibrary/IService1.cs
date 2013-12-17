using System.ServiceModel;

namespace SecureServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Labas();

        [OperationContract]
        string Suma(int a, int b);
    }
}