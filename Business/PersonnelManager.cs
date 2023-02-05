using DataAccess;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonnelManager
    {
        static PersonnelManager personnelManager;
        PersonnelDal personnelDal;
        string controlText;

        public PersonnelManager()
        {
            personnelDal = PersonnelDal.GetInstance();
        }

        public string Add(Personnel entity)
        {
            try
            {
                controlText = IsPersonnelComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return personnelDal.Add(entity);
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
                    return "Please Select A Personnel";
                }
                return personnelDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Personnel Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                return personnelDal.GetDataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        public string Update(Personnel entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Please Select A Personnel";
                }
                controlText = IsPersonnelComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return personnelDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsPersonnelComplete(Personnel personnel)
        {
            //int id, string trId, string name, string surname, int authId, string phone, string email, string province, string district, string adress
            if (string.IsNullOrEmpty(personnel.Name) || string.IsNullOrEmpty(personnel.Surname) || string.IsNullOrEmpty(personnel.Phone) || string.IsNullOrEmpty(personnel.Email) || string.IsNullOrEmpty(personnel.Province) || string.IsNullOrEmpty(personnel.District) || string.IsNullOrEmpty(personnel.Adress))
            {
                return "Please Fill In The Required Fields";
            }
            if (personnel.AuthId.ToString() == "")
            {
                return "Please,Specify Staff Auth";
            }
            if (personnel.Name.Any(char.IsDigit) || personnel.Surname.Any(char.IsDigit))
            {
                return "Name and Surname Can't Contain Numbers";
            }
            if ((personnel.Email.Substring(personnel.Email.Length - 4, 1) != "." && personnel.Email.Substring(personnel.Email.Length - 3, 1) != ".") && !personnel.Email.Contains("@"))
            {
                return "Email Address is Incorrect";
            }
            MailAddress mailAddress = new MailAddress(personnel.Email);
            return "";
        }

        public object[] Login(string trId, string password)
        {
            try
            {
                return personnelDal.Login(trId, password);
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetProvince()
        {
            try
            {
                return personnelDal.GetProvince();
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable GetDistrict(int provinceId)
        {
            try
            {

                return personnelDal.GetDistrict(provinceId);
            }
            catch
            {
                return new DataTable();
            }
        }

        public int GetAuthId(string auth)
        {
            try
            {
                return personnelDal.GetAuthId(auth);
            }
            catch
            {
                return 0;
            }
        }
        public static PersonnelManager GetInstance()
        {
            if (personnelManager == null)
            {
                personnelManager = new PersonnelManager();
            }
            return personnelManager;
        }
    }
}
