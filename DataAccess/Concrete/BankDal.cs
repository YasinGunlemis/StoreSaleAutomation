using Entity;
using DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Security.Policy;

namespace DataAccess.Concrete
{
    public class BankDal : IRepository<Bank>
    {
        static BankDal bankDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        public BankDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Bank entity)
        {
            try
            {
                //(@bank varchar(30), @province varchar(13),@district varchar(20), @branch varchar(30), @iban varchar(30),@accountno varchar(20),
                //@authorized varchar(30),@phone varchar(15), @date varchar(10),@companyId smallint)
                dataReader = sqlService.StoreReader("BankAdd", new SqlParameter("@bank", entity.CompanyBank), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@branch", entity.Branch), new SqlParameter("@iban", entity.Iban), new SqlParameter("@accountno", entity.Accountno), new SqlParameter("@authorized", entity.Authorized), new SqlParameter("@phone", entity.Phone), new SqlParameter("@date", entity.Date), new SqlParameter("@companyId", entity.CompanyId));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Company Bank Account Number Exist";
                }
                return "Company Bank Informations Added Successfully";
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
                sqlService.Stored("BankDelete", new SqlParameter("@id", id));
                return "The Company's Bank Information Has Been Deleted";
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
                DataTable dataTable = sqlService.GetDataTable("BankListCompany");
                return dataTable;
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
                //(@id smallint,@bank varchar(30), @province varchar(13),@district varchar(20), @branch varchar(30), @iban varchar(30),@accountno varchar(20),
                //@authorized varchar(30),@phone varchar(15), @date varchar(10),@companyId smallint, @oldAccountno varchar(20))
                dataReader = sqlService.StoreReader("BankUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@bank", entity.CompanyBank), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@branch", entity.Branch), new SqlParameter("@iban", entity.Iban), new SqlParameter("@accountno", entity.Accountno), new SqlParameter("@authorized", entity.Authorized), new SqlParameter("@phone", entity.Phone), new SqlParameter("@date", entity.Date), new SqlParameter("@companyId", entity.CompanyId), new SqlParameter("@oldAccountno", entity.OldAccountno));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Account Number : " + entity.Accountno + " Belongs To Another Account";
                }
                return "Company Bank Informations Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetCompanyNameByCompanyId(int companyId)
        {
            try
            {
                string company = "";
                dataReader = sqlService.StoreReader("CompanyName", new SqlParameter("@companyId", companyId));
                if (dataReader.Read())
                {
                    company = dataReader["COMPANY"].ToString();
                }
                dataReader.Close();
                return company;
            }
            catch
            {
                return "";
            }
        }

        public static BankDal GetInstance()
        {
            if (bankDal == null)
            {
                bankDal = new BankDal();
            }
            return bankDal;
        }
    }
}
