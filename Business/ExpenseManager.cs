using DataAccess;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ExpenseManager 
    {
        static ExpenseManager expenseManager;
        ExpenseDal expenseDal;
        string controlText;

        public ExpenseManager()
        {
            expenseDal = ExpenseDal.GetInstance();
        }

        public string Add(Expense entity)
        {
            try
            {
                controlText = IsExpenseComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return expenseDal.Add(entity);
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
                    return "Please Select A Expense";
                }
                return expenseDal.Delete(id);
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
                return expenseDal.GetDataTable();
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
                if (entity.Id < 1)
                {
                    return "Please Select A Expense";
                }
                controlText = IsExpenseComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return expenseDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsExpenseComplete(Expense expense)
        {
            if (string.IsNullOrEmpty(expense.Year) || string.IsNullOrEmpty(expense.Month))
            {
                return "Please Fill In The Required Fields";
            }
            if (expense.Salaries < 1 || expense.Electric < 1 || expense.Water < 1 || expense.Gas < 1 || expense.Internet < 1)
            {
                return "Please Fill In The Required Fields";
            }
            return "";
        }
        public static ExpenseManager GetInstance()
        {
            if (expenseManager == null)
            {
                expenseManager = new ExpenseManager();
            }
            return expenseManager;
        } 
    }
}
