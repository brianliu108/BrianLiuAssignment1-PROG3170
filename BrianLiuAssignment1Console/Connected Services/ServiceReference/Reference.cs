//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrianLiuAssignment1Console.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrimeNumber", ReplyAction="http://tempuri.org/IService/IsPrimeNumberResponse")]
        bool IsPrimeNumber(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsPrimeNumber", ReplyAction="http://tempuri.org/IService/IsPrimeNumberResponse")]
        System.Threading.Tasks.Task<bool> IsPrimeNumberAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumOfDigits", ReplyAction="http://tempuri.org/IService/SumOfDigitsResponse")]
        int SumOfDigits(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumOfDigits", ReplyAction="http://tempuri.org/IService/SumOfDigitsResponse")]
        System.Threading.Tasks.Task<int> SumOfDigitsAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseOfString", ReplyAction="http://tempuri.org/IService/ReverseOfStringResponse")]
        string ReverseOfString(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseOfString", ReplyAction="http://tempuri.org/IService/ReverseOfStringResponse")]
        System.Threading.Tasks.Task<string> ReverseOfStringAsync(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/WrapInHTMLTags", ReplyAction="http://tempuri.org/IService/WrapInHTMLTagsResponse")]
        string WrapInHTMLTags(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/WrapInHTMLTags", ReplyAction="http://tempuri.org/IService/WrapInHTMLTagsResponse")]
        System.Threading.Tasks.Task<string> WrapInHTMLTagsAsync(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SortNumbers", ReplyAction="http://tempuri.org/IService/SortNumbersResponse")]
        string SortNumbers(bool ascending, double[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SortNumbers", ReplyAction="http://tempuri.org/IService/SortNumbersResponse")]
        System.Threading.Tasks.Task<string> SortNumbersAsync(bool ascending, double[] data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BrianLiuAssignment1Console.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BrianLiuAssignment1Console.ServiceReference.IService>, BrianLiuAssignment1Console.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsPrimeNumber(int number) {
            return base.Channel.IsPrimeNumber(number);
        }
        
        public System.Threading.Tasks.Task<bool> IsPrimeNumberAsync(int number) {
            return base.Channel.IsPrimeNumberAsync(number);
        }
        
        public int SumOfDigits(int number) {
            return base.Channel.SumOfDigits(number);
        }
        
        public System.Threading.Tasks.Task<int> SumOfDigitsAsync(int number) {
            return base.Channel.SumOfDigitsAsync(number);
        }
        
        public string ReverseOfString(string input) {
            return base.Channel.ReverseOfString(input);
        }
        
        public System.Threading.Tasks.Task<string> ReverseOfStringAsync(string input) {
            return base.Channel.ReverseOfStringAsync(input);
        }
        
        public string WrapInHTMLTags(string tag, string data) {
            return base.Channel.WrapInHTMLTags(tag, data);
        }
        
        public System.Threading.Tasks.Task<string> WrapInHTMLTagsAsync(string tag, string data) {
            return base.Channel.WrapInHTMLTagsAsync(tag, data);
        }
        
        public string SortNumbers(bool ascending, double[] data) {
            return base.Channel.SortNumbers(ascending, data);
        }
        
        public System.Threading.Tasks.Task<string> SortNumbersAsync(bool ascending, double[] data) {
            return base.Channel.SortNumbersAsync(ascending, data);
        }
    }
}
