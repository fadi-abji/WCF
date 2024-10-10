using System.ServiceModel;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double Add(double num1, double num2);
        [OperationContract]
        double Sub(double num1, double num2);
        [OperationContract]
        double Multipli(double num1, double num2);
        [OperationContract]
        double Divide(double num1, double num2);
        //[OperationContract]
        //Task<double> SubAsync(double num1, double num2);
        //[OperationContract]
        //Task<double> AddAsync(double num1, double num2);
        //[OperationContract]
        //Task<double> MultipliAsync(double num1, double num2);
        //[OperationContract]
        //Task<double> DivideAsync(double num1, double num2);
    }

}
