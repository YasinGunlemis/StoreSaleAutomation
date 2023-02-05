using DataAccess.Database;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CustomerDal : IRepository<Customer>
    {
        static CustomerDal customerDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public CustomerDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Customer entity)
        {
            try
            {
                /*  [CustomerAdd](@trId char(11),@name varchar(20),@surname varchar(20),@phone1 varchar(15),@phone2 varchar(15),@email varchar(40), @province varchar(13),
                    @district varchar(20), @adress varchar(100), @taxoffice varchar(30))    */
                dataReader = sqlService.StoreReader("CustomerAdd", new SqlParameter("@trId", entity.TrId), new SqlParameter("@name", entity.Name), new SqlParameter("@surname", entity.Surname), new SqlParameter("@phone1", entity.Phone1), new SqlParameter("@phone2", entity.Phone2), new SqlParameter("@email", entity.Email), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@adress", entity.Adress));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "TR-ID : " + entity.TrId + " is Registered in the System";
                }
                return "Customer Added Successfully";
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
                //[CustomerDelete] (@id smallint)
                sqlService.Stored("CustomerDelete", new SqlParameter("@id", id));
                return "Customer Deleted";
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
                DataTable dataTable = sqlService.GetDataTable("CustomerList");
                return dataTable;
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
                /*  [CustomerUpdate](@id smallint,@trId char(11),@name varchar(20),@surname varchar(20),@phone1 varchar(15),@phone2 varchar(15),@email varchar(40), 
                        @province varchar(13),@district varchar(20), @adress varchar(100), @taxoffice varchar(30),@oldTrId char(11))     */
                dataReader = sqlService.StoreReader("CustomerUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@trId", entity.TrId), new SqlParameter("@name", entity.Name), new SqlParameter("@surname", entity.Surname), new SqlParameter("@phone1", entity.Phone1), new SqlParameter("@phone2", entity.Phone2), new SqlParameter("@email", entity.Email), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@adress", entity.Adress), new SqlParameter("@oldTrId", entity.OldTrId));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "TR-ID : " + entity.TrId + " Belongs To Another Customer";
                }
                return "Customer Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static CustomerDal GetInstance()
        {
            if (customerDal == null)
            {
                customerDal = new CustomerDal();
            }
            return customerDal;
        }
    }
}
