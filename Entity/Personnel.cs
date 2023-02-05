using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Personnel
    {
        int id, authId;
        string trId, oldTrId, name, surname, phone, email, province, district, adress;
        byte[] image;

        public int Id { get => id; set => id = value; }
        public int AuthId { get => authId; set => authId = value; }
        public string TrId { get => trId; set => trId = value; }
        public string OldTrId { get => oldTrId; set => oldTrId = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Province { get => province; set => province = value; }
        public string District { get => district; set => district = value; }
        public string Adress { get => adress; set => adress = value; }
        public byte[] Image { get => image; set => image = value; }

        //Personel Güncelleme için
        public Personnel(int id, string trId, string name, string surname, int authId, string phone, string email, string province, string district, string adress, byte[] image, string oldTrId)
        {
            this.id = id;
            this.trId = trId;
            this.name = name;
            this.surname = surname;
            this.authId = authId;
            this.phone = phone;
            this.email = email;
            this.province = province;
            this.district = district;
            this.adress = adress;
            this.image = image;
            this.oldTrId = oldTrId;
        }

        //Personel Ekleme İçin
        public Personnel(string trId, string name, string surname, int authId, string phone, string email, string province, string district, string adress, byte[] image)
        {
            this.trId = trId;
            this.name = name;
            this.surname = surname;
            this.authId = authId;
            this.phone = phone;
            this.email = email;
            this.province = province;
            this.district = district;
            this.adress = adress;
            this.image = image;
        }
    }
}
