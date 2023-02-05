using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        int id;
        string trId, name, surname, phone1, phone2, email, province, district, adress, oldTrId;

        public int Id { get => id; set => id = value; }
        public string TrId { get => trId; set => trId = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone1 { get => phone1; set => phone1 = value; }
        public string Phone2 { get => phone2; set => phone2 = value; }
        public string Email { get => email; set => email = value; }
        public string Province { get => province; set => province = value; }
        public string District { get => district; set => district = value; }
        public string Adress { get => adress; set => adress = value; }
        public string OldTrId { get => oldTrId; set => oldTrId = value; }

        //Müşteri Güncelleme İçin
        public Customer(int id, string trId, string name, string surname, string phone1, string phone2, string email, string province, string district, string adress, string oldTrId)
        {
            this.id = id;
            this.trId = trId;
            this.name = name;
            this.surname = surname;
            this.phone1 = phone1;
            this.phone2 = phone2;
            this.email = email;
            this.province = province;
            this.district = district;
            this.adress = adress;
            this.oldTrId = oldTrId;
        }

        //Müşteri Ekleme İçin
        public Customer(string trId, string name, string surname, string phone1, string phone2, string email, string province, string district, string adress)
        {
            this.trId = trId;
            this.name = name;
            this.surname = surname;
            this.phone1 = phone1;
            this.phone2 = phone2;
            this.email = email;
            this.province = province;
            this.district = district;
            this.adress = adress;
        }
    }
}
