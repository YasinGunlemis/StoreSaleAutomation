using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Expense
    {
        int id;
        string year, month, explanation, yearMonth;
        decimal electric, water, gas, internet, salaries, extra,totalExpense;

        public int Id { get => id; set => id = value; }
        public string Year { get => year; set => year = value; }
        public string Month { get => month; set => month = value; }
        public string Explanation { get => explanation; set => explanation = value; }
        public string YearMonth { get => yearMonth; set => yearMonth = value; }
        public decimal Electric { get => electric; set => electric = value; }
        public decimal Water { get => water; set => water = value; }
        public decimal Gas { get => gas; set => gas = value; }
        public decimal Internet { get => internet; set => internet = value; }
        public decimal Salaries { get => salaries; set => salaries = value; }
        public decimal Extra { get => extra; set => extra = value; }
        public decimal TotalExpense { get => totalExpense; set => totalExpense = value; }
        
        //Gider Güncelleme İçin
        public Expense(int id, string year, string month, decimal electric, decimal water, decimal gas, decimal internet, decimal salaries, decimal extra, string yearMonth, string explanation, decimal totalExpense)
        {
            this.id = id;
            this.year = year;
            this.month = month;
            this.electric = electric;
            this.water = water;
            this.gas = gas;
            this.internet = internet;
            this.salaries = salaries;
            this.extra = extra;
            this.yearMonth = yearMonth;
            this.explanation = explanation;
            this.totalExpense = totalExpense;
        }

        //Gider Ekleme İçin
        public Expense(string year, string month, decimal electric, decimal water, decimal gas, decimal internet, decimal salaries, decimal extra,string explanation, decimal totalExpense)
        {
            this.year = year;
            this.month = month;
            this.electric = electric;
            this.water = water;
            this.gas = gas;
            this.internet = internet;
            this.salaries = salaries;
            this.extra = extra;
            this.explanation = explanation;
            this.totalExpense = totalExpense;
        }

    }
}
