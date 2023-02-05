using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Company
    {
        int id;
        string taxno, firm, authStatus, authNameSur,sector, phone1, phone2, email, fax, province, district, taxOffice, adress, scode1, scode2, scode3,oldTaxno;
        byte[] image;

        public int Id { get => id; set => id = value; }
        public string Taxno { get => taxno; set => taxno = value; }
        public string Firm { get => firm; set => firm = value; }
        public string AuthStatus { get => authStatus; set => authStatus = value; }
        public string AuthNameSur { get => authNameSur; set => authNameSur = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Phone1 { get => phone1; set => phone1 = value; }
        public string Phone2 { get => phone2; set => phone2 = value; }
        public string Email { get => email; set => email = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Province { get => province; set => province = value; }
        public string District { get => district; set => district = value; }
        public string TaxOffice { get => taxOffice; set => taxOffice = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Scode1 { get => scode1; set => scode1 = value; }
        public string Scode2 { get => scode2; set => scode2 = value; }
        public string Scode3 { get => scode3; set => scode3 = value; }
        public string OldTaxno { get => oldTaxno; set => oldTaxno = value; }
        public byte[] Image { get => image; set => image = value; }
        
        //Şirket Güncelleme İçin
        public Company(int id, byte[] image, string taxno, string firm, string authStatus, string authNameSur, string sector, string phone1, string phone2, string email, string fax, string province, string district, string adress, string taxOffice, string scode1, string scode2, string scode3, string oldTaxno)
        {
            this.id = id;
            this.image = image;
            this.taxno = taxno;
            this.firm = firm;
            this.authStatus = authStatus;
            this.authNameSur = authNameSur;
            this.sector = sector;
            this.phone1 = phone1;
            this.phone2 = phone2;
            this.email = email;
            this.fax = fax;
            this.province = province;
            this.district = district;
            this.adress = adress;
            this.taxOffice = taxOffice;
            this.scode1 = scode1;
            this.scode2 = scode2;
            this.scode3 = scode3;
            this.oldTaxno = oldTaxno;
        }


        //Şirket Ekleme İçin
        public Company(byte[] image, string taxno, string firm, string authStatus, string authNameSur, string sector, string phone1, string phone2, string email, string fax, string province, string district, string adress, string taxOffice, string scode1, string scode2, string scode3)
        {
            this.image = image;
            this.taxno = taxno;
            this.firm = firm;
            this.authStatus = authStatus;
            this.authNameSur = authNameSur;
            this.sector = sector;
            this.phone1 = phone1;
            this.phone2 = phone2;
            this.email = email;
            this.fax = fax;
            this.province = province;
            this.district = district;
            this.adress = adress;
            this.taxOffice = taxOffice;
            this.scode1 = scode1;
            this.scode2 = scode2;
            this.scode3 = scode3;
        }
    }
}
