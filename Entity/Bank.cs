using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bank
    {
        int id, companyId;
        string bank, province, district, branch, iban, accountno, authorized, phone, date,oldAccountno;

        public int Id { get => id; set => id = value; }
        public int CompanyId { get => companyId; set => companyId = value; }
        public string CompanyBank { get => bank; set => bank = value; }
        public string Province { get => province; set => province = value; }
        public string District { get => district; set => district = value; }
        public string Branch { get => branch; set => branch = value; }
        public string Iban { get => iban; set => iban = value; }
        public string Accountno { get => accountno; set => accountno = value; }
        public string Authorized { get => authorized; set => authorized = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Date { get => date; set => date = value; }
        public string OldAccountno { get => oldAccountno; set => oldAccountno = value; }

        //Şirket Banka Hesabı Güncelleme İçin
        public Bank(int id, string bank, string province, string district, string branch, string iban, string accountno, string authorized, string phone, string date, int companyId, string oldAccountno)
        {
            this.id = id;
            this.bank = bank;
            this.province = province;
            this.district = district;
            this.branch = branch;
            this.iban = iban;
            this.accountno = accountno;
            this.authorized = authorized;
            this.phone = phone;
            this.date = date;
            this.companyId = companyId;
            this.oldAccountno = oldAccountno;
        }

        //Şirket Banka Hesabı Ekleme İçin
        public Bank(string bank, string province, string district, string branch, string iban, string accountno, string authorized, string phone, string date, int companyId)
        {
            this.bank = bank;
            this.province = province;
            this.district = district;
            this.branch = branch;
            this.iban = iban;
            this.accountno = accountno;
            this.authorized = authorized;
            this.phone = phone;
            this.date = date;
            this.companyId = companyId;
        }
    }
}
