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
    public class BillDal
    {
        static BillDal billDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        int returnId;

        public BillDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public int Add(Bill entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("BillAdd", new SqlParameter("@customer",entity.Customer), new SqlParameter("@billAmountDue",entity.BillAmountDue));
                if (dataReader.Read())
                {
                    returnId = dataReader[0].ConInt();
                }
                dataReader.Close();
                return returnId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public string Update(Bill entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("BillUpdate",new SqlParameter("@billId",entity.BillId), new SqlParameter("@billAmountDue",entity.BillAmountDue));
                dataReader.Close();
                return "Bill Added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public void InsertBillProducts(DataTable dataTable)
        {
            try
            {
                sqlService.Stored("InsertBillProducts", new SqlParameter("@billProducts",dataTable));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetCustomers()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("AllCustomerNameList");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public DataTable GetBills()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("GetBills");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public DataTable GetBillProducts()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("BillPoducts");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public DataTable GetBestLeastSelling(bool ascDesc)
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("BestLeastSellingProducts", new SqlParameter("@ascDesc",ascDesc));
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bill Get(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDataTable()
        {
            throw new NotImplementedException();
        }

        public static BillDal GetInstance()
        {
            if(billDal == null)
            {
                billDal = new BillDal();
            }
            return billDal;
        }
    }
}
