using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VendorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        List<Vendor> allVendors;

        public void viewVendors()
        {
            Console.Write("Vendors at this event are:");
            for (int i = 0; i < allVendors.Count; i++)
                Console.Write("\n{0}", allVendors[i].name);
        }

        public bool chargeVendor()
        {
            Random rng = new Random();
            bool transactionComplete = false;
            double price = rng.Next(300, 501);

            Console.Write("Your price will be {0}. Is this amount okay? Please enter Y for YES, or N for NO.", price);
            char key = (char)Console.Read();
            bool validKey;
            do
            {
                if (key == 'Y' || key == 'y')
                    validKey = true;
                else if (key == 'N' || key == 'n')
                    validKey = true;
                else
                    validKey = false;
            }
            while (!validKey);


            if (transactionComplete)
            {
                Console.WriteLine("Transaction successful. You paid: " + price + ".");
                return true;
            }
            else
            {
                Console.Write("Transaction failed. You will be returned without being charged.");
                return false;
            }
        }

        public string addVendor(string name, List<saleObjects> obj)
        {
            Vendor newVendor = new Vendor();
            bool temp = true;

            do
            {
                if (allVendors.Exists(x => x.name.Equals(name)))
                {
                    Console.Write("That name is already taken. Please enter a new name: ");
                    name = Console.ReadLine();
                }
                else
                    temp = false;
            }
            while (temp);
            
            newVendor.name = name;
            newVendor.objects = obj;
            allVendors.Add(newVendor);

            Console.WriteLine(chargeVendor());

            return "A new vendor '" + name + "' has been added to the list of vendors.";
        }

        public string removeVendor(string name)
        {
            allVendors.Remove(allVendors.Find(x => x.name.Equals(name)));
            return "The vendor '" + name + "' has been removed.";
        }
    }
}
