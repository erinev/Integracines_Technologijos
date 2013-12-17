using System.ServiceModel;

namespace SecureServiceLibrary
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string Labas();
    }
}
