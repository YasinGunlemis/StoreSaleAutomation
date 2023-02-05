using DataAccess.Concrete;
using Entity;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;

namespace Business
{
    public class CustomerManager
    {
        static CustomerManager customerManager;
        CustomerDal customerDal;
        string controlText;

        public CustomerManager()
        {
            customerDal = CustomerDal.GetInstance();
        }

        public string Add(Customer entity)
        {
            try
            {
                controlText = IsCustomerComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return customerDal.Add(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                if (id < 1)
                {
                    return "Please Select A Customer";
                }
                return customerDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Customer Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                return customerDal.GetDataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        public string Update(Customer entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Please Select A Customer";
                }
                controlText = IsCustomerComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return customerDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsCustomerComplete(Customer customer)
        {
            //(int id, string trId, string name, string surname, string phone1, string phone2, string email, string province, string district, string adress, string taxoffice, string oldTrId)
            //yasin@gmail.com.tr.m
            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Surname) || string.IsNullOrEmpty(customer.Phone1) || string.IsNullOrEmpty(customer.Adress) || string.IsNullOrEmpty(customer.Email) || string.IsNullOrEmpty(customer.Province) || string.IsNullOrEmpty(customer.District))
            {
                return "Please Fill In The Required Fields";
            }
            if (customer.TrId.Length > 11)
            {
                return "Customer TR-ID Must Be 11 Digits";
            }
            if (customer.Name.Any(char.IsDigit) || customer.Surname.Any(char.IsDigit))
            {
                return "Name and Surname Can't Contain Numbers";
            }
            if ((customer.Email.Substring(customer.Email.Length - 4, 1) != "." && customer.Email.Substring(customer.Email.Length - 3, 1) != ".") && !customer.Email.Contains("@"))
            {
                return "Email Address is Incorrect";
            }
            MailAddress mailAddress = new MailAddress(customer.Email);
            return "";
        }

        public static CustomerManager GetInstance()
        {
            if (customerManager == null)
            {
                customerManager = new CustomerManager();
            }
            return customerManager;
        }
    }
}
