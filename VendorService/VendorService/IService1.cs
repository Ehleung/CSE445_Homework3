using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VendorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/viewVendors", ResponseFormat = WebMessageFormat.Json)]
        void viewVendors();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/addVendor/{name}", ResponseFormat = WebMessageFormat.Json)]
        string addVendor(string name, List<saleObjects> objects);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/removeVendor/{name}", ResponseFormat = WebMessageFormat.Json)]
        string removeVendor(string name);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/chargeVendor", ResponseFormat = WebMessageFormat.Json)]
        bool chargeVendor();
    }

    [DataContract]
    public class Vendor
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public List<saleObjects> objects { get; set; }
    }

    [DataContract]
    public class saleObjects
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public double price { get; set; }
    }
}
