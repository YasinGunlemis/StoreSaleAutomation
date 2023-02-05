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
    public class CompanyManager
    {
        static CompanyManager companyManager;
        CompanyDal companyDal;
        public string controlText;

        public CompanyManager()
        {
            companyDal = CompanyDal.GetInstance();
        }

        public string Add(Company entity)
        {
            try
            {
                controlText = IsCompanyComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return companyDal.Add(entity);
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
                    return "Please Select A Company";
                }
                return companyDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Company Get(int id)
        {
            try
            {
                return null;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetDataTable()
        {
            try
            {
                return companyDal.GetDataTable();
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable GetCompanyNames()
        {
            try
            {
                return companyDal.GetCompanyNames();
            }
            catch
            {
                return new DataTable();
            }
        }

        public string AuthName(int id)
        {
            try
            {
                return companyDal.AuthName(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(Company entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Please Select A Company";
                }
                controlText = IsCompanyComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return companyDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsCompanyComplete(Company company)
        {
            if (string.IsNullOrEmpty(company.Firm) || string.IsNullOrEmpty(company.AuthNameSur) || string.IsNullOrEmpty(company.TaxOffice) || string.IsNullOrEmpty(company.Adress) || string.IsNullOrEmpty(company.AuthStatus))
            {
                return "Please Fill In The Required Fields";
            }
            if (company.Taxno.Length > 9)
            {
                return "Tax No Must Be 9 Digits";
            }
            return "";
        }

        public static CompanyManager GetInstance()
        {
            if (companyManager == null)
            {
                companyManager = new CompanyManager();
            }
            return companyManager;
        }
    }
}
