using DataAccess;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BankManager
    {
        static BankManager bankManager;
        BankDal bankDal;
        string controlText;

        public BankManager()
        {
            bankDal = BankDal.GetInstance();
        }

        public string Add(Bank entity)
        {
            try
            {
                controlText = IsBankComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return bankDal.Add(entity);
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
                    return "Please Select A Bank";
                }
                return bankDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Bank Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                return bankDal.GetDataTable();
            }
            catch 
            {
                return new DataTable();
            }
        }

        public string Update(Bank entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Please Select A Bank";
                }
                controlText = IsBankComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return bankDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsBankComplete(Bank bank)
        {
            if (string.IsNullOrEmpty(bank.CompanyBank)||string.IsNullOrEmpty(bank.Branch)||string.IsNullOrEmpty(bank.Authorized)||string.IsNullOrEmpty(bank.Accountno)||string.IsNullOrEmpty(bank.Iban)|| bank.Province.Contains("select")|| bank.District.Contains("select") || string.IsNullOrEmpty(bank.Date))
            {
                return "Please Fill In The Required Fields";
            }
            if (bank.Accountno.Length > 8)
            {
                return "Account Number Must Be 8 Digits";
            }
            return "";
        }

        public string GetCompanyNameByCompanyId(int companyId)
        {
            try
            {
                if (companyId < 1)
                {
                    return "Please Select A Company";
                }
                return bankDal.GetCompanyNameByCompanyId(companyId);
            }
            catch
            {
                return "";
            }
        }
        public static BankManager GetInstance()
        {
            if (bankManager == null)
            {
                bankManager = new BankManager();
            }
            return bankManager;
        }
    }
}
