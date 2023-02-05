using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bill
    {
        string customer;
        decimal billAmountDue;
        int billId;

        public string Customer { get => customer; set => customer = value; }
        public decimal BillAmountDue { get => billAmountDue; set => billAmountDue = value; }
        public int BillId { get => billId; set => billId = value; }

        public Bill(string customer, decimal billAmountDue)
        {
            this.customer = customer;
            this.billAmountDue = billAmountDue;
        }

        public Bill(int billId, decimal billAmountDue)
        {
            this.billId = billId;
            this.billAmountDue = billAmountDue;
        }
    }
}
