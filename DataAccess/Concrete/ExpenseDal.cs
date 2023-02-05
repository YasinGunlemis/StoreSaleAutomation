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
    public class ExpenseDal : IRepository<Expense>
    {
        static ExpenseDal expenseDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public ExpenseDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Expense entity)
        {
            try
            {
                /*  [ExpenseAdd](@year char(4),@month char(9), @electric decimal(18,2),@water decimal(18,2),@gas decimal(18,2), @internet decimal(18,2),
                     @salaries decimal(18,2), @extra decimal(18,2),@explanation varchar(500))    */
                dataReader = sqlService.StoreReader("ExpenseAdd", new SqlParameter("@year", entity.Year), new SqlParameter("@month", entity.Month), new SqlParameter("@electric", entity.Electric), new SqlParameter("@water", entity.Water), new SqlParameter("@gas", entity.Gas), new SqlParameter("@internet", entity.Internet), new SqlParameter("@salaries", entity.Salaries), new SqlParameter("@extra", entity.Extra), new SqlParameter("@explanation", entity.Explanation), new SqlParameter("@totalExpense", entity.TotalExpense));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.Year + " " + entity.Month + " Date Are Registered in the System";
                }
                return entity.Year + " " + entity.Month + " Expense Added Successfully";
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
                //[ExpenseDelete](@id int)
                sqlService.Stored("ExpenseDelete", new SqlParameter("@id", id));
                return "Expense Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Expense Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("ExpenseList");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public string Update(Expense entity)
        {
            try
            {
                /*  [ExpenseUpdate](@id int,@year char(4),@month char(9), @electric decimal(18,2),@water decimal(18,2),@gas decimal(18,2), @internet decimal(18,2),
                    @salaries decimal(18,2), @extra decimal(18,2),@explanation varchar(500),@yearMonth char(13))    */
                dataReader = sqlService.StoreReader("ExpenseUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@year", entity.Year), new SqlParameter("@month", entity.Month), new SqlParameter("@electric", entity.Electric), new SqlParameter("@water", entity.Water), new SqlParameter("@gas", entity.Gas), new SqlParameter("@internet", entity.Internet), new SqlParameter("@salaries", entity.Salaries), new SqlParameter("@extra", entity.Extra), new SqlParameter("@explanation", entity.Explanation), new SqlParameter("@yearMonth", entity.YearMonth), new SqlParameter("@totalExpense", entity.TotalExpense));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.Year + " " + entity.Month + " Date Expenses Belong Another Date";
                }
                return entity.Year + " " + entity.Month + " Expense Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static ExpenseDal GetInstance()
        {
            if (expenseDal == null)
            {
                expenseDal = new ExpenseDal();
            }
            return expenseDal;
        }
    }
}
