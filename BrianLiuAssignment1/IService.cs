using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BrianLiuAssignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool IsPrimeNumber(int number);
        
        [OperationContract]
        int SumOfDigits(int number);

        [OperationContract]
        string ReverseOfString(string input);

        [OperationContract]
        string WrapInHTMLTags(string tag, string data);

        [OperationContract]
        string SortNumbers(bool ascending, List<double> data);
    }

}
