using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSapp
{
    internal class Suppliers
    {
        public int SupplierId;
        public string SupplierName;
        public string PhoneNumber;
        public string Address;
        public string Email;
        public Suppliers(int supplierId, string supplierName, string phoneNumber, string address, string email)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }
        public Suppliers() { }
        public void SetSupplierId(int supplierId)
        {
            SupplierId = supplierId;
        }
        public void SetSupplierName(string supplierName)
        {
            SupplierName = supplierName;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
