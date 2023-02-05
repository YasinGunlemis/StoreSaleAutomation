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
    public class BillManager
    {
        static BillManager billManager;
        BillDal billDal;

        public BillManager()
        {
            billDal = BillDal.GetInstance();
        }

        public int Add(Bill entity)
        {
            try
            {
                return billDal.Add(entity);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string Update(Bill entity)
        {
            try
            {                
                return billDal.Update(entity);
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

                billDal.InsertBillProducts(dataTable);
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
                return billDal.GetCustomers();
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
                return billDal.GetBills();
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
                return billDal.GetBillProducts();
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
                return billDal.GetBestLeastSelling(ascDesc);
            }
            catch
            {
                return new DataTable();
            }
        }
        public static BillManager GetInstance()
        {
            if (billManager == null)
            {
                billManager = new BillManager();
            }
            return billManager;
        }
    }
}
