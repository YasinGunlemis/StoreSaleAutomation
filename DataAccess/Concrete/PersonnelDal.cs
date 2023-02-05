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
    public class PersonnelDal : IRepository<Personnel>
    {
        static PersonnelDal personnelDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        int authId;
        public PersonnelDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Personnel entity)
        {
            try
            {
                /*  [PersonnelAdd] (@trId char(11), @name varchar(20), @surname varchar(20),@authId tinyint,@phone varchar(15),  
                    @email varchar(40), @province varchar(13), @district varchar(20), @adress varchar(100))     */

                //(entity.Image==null) ? (object)DBNull.Value : entity.Image)
                //(entity.Image == null) ? new SqlParameter("@image",(object)DBNull.Value) : new SqlParameter("@image", entity.Image)
                //if (entity.Image != null) { cmd.Parameters.Add("@image", SqlDbType.Image).Value = entity.Image; }
                //else { cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value; }

                //condition ? value_if_true : value_if_false

                //dataReader = sqlService.StoreReader("PersonnelAdd", new SqlParameter("@trId", entity.TrId), new SqlParameter("@name", entity.Name), new SqlParameter("@surname", entity.Surname), new SqlParameter("@authId", entity.AuthId), new SqlParameter("@phone", entity.Phone), new SqlParameter("@email", entity.Email), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@adress", entity.Adress),
                //    new SqlParameter("@image", entity.Image));
                
                SqlCommand cmd = new SqlCommand("PersonnelAdd", sqlService.OpenConnection());
                if (entity.Image != null) { cmd.Parameters.Add("@image", SqlDbType.Image).Value = entity.Image; }
                else { cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value; }
                cmd.Parameters.AddWithValue("@trId", entity.TrId);
                cmd.Parameters.AddWithValue("@name", entity.Name);
                cmd.Parameters.AddWithValue("@surname", entity.Surname);
                cmd.Parameters.AddWithValue("@authId", entity.AuthId);
                cmd.Parameters.AddWithValue("@phone", entity.Phone);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@province", entity.Province);
                cmd.Parameters.AddWithValue("@district", entity.District);
                cmd.Parameters.AddWithValue("@adress", entity.Adress);
                cmd.CommandType = CommandType.StoredProcedure;
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "TR-ID : " + entity.TrId + " is Registered in the System";
                }
                sqlService.CloseConnection();
                return "Personnel : " + entity.Name + " Added Successfully";
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
                //[PersonnelDelete] (@trId char(11))
                sqlService.Stored("PersonnelDelete", new SqlParameter("@id", id));
                return "Personnel Deleted Successfully";
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
                DataTable dataTable = sqlService.GetDataTable("PersonnelList");
                return dataTable;
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
                /*  [PersonnelUpdate] (@id tinyint,@trId char(11), @name varchar(20), @surname varchar(20),@authId tinyint,@phone varchar(15),  
                    @email varchar(40), @province varchar(13), @district varchar(20), @adress varchar(100),@imageUrl nvarchar(150),@oldTrId char(11))     */

                //dataReader = sqlService.StoreReader("PersonnelUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@trId", entity.TrId), new SqlParameter("@name", entity.Name), new SqlParameter("@surname", entity.Surname), new SqlParameter("@authId", entity.AuthId), new SqlParameter("@phone", entity.Phone), new SqlParameter("@email", entity.Email), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@adress", entity.Adress), new SqlParameter("@image", entity.Image), new SqlParameter("@oldTrId", entity.OldTrId));

                SqlCommand cmd = new SqlCommand("PersonnelUpdate", sqlService.OpenConnection());
                if (entity.Image != null) { cmd.Parameters.Add("@image", SqlDbType.Image).Value = entity.Image; }
                else { cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value; }
                cmd.Parameters.AddWithValue("@id", entity.Id);
                cmd.Parameters.AddWithValue("@trId", entity.TrId);
                cmd.Parameters.AddWithValue("@name", entity.Name);
                cmd.Parameters.AddWithValue("@surname", entity.Surname);
                cmd.Parameters.AddWithValue("@authId", entity.AuthId);
                cmd.Parameters.AddWithValue("@phone", entity.Phone);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@province", entity.Province);
                cmd.Parameters.AddWithValue("@district", entity.District);
                cmd.Parameters.AddWithValue("@adress", entity.Adress);
                cmd.Parameters.AddWithValue("@oldTrId", entity.OldTrId);
                cmd.CommandType = CommandType.StoredProcedure;
                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "TR-ID : " + entity.TrId + " Belongs To Another Personnel";
                }
                return "Personnel Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public object[] Login(string trId, string password)
        {
            try
            {
                //PersonLogin (@trId char(11),@password nvarchar(15))
                object[] infos = null;
                dataReader = sqlService.StoreReader("PersonLogin", new SqlParameter("@trId", trId), new SqlParameter("@password", password));
                while (dataReader.Read())
                {
                    string personnelTrId, name, surname;
                    int auth;
                    personnelTrId = dataReader[0].ToString();
                    name = dataReader[1].ToString();
                    surname = dataReader[2].ToString();
                    auth = dataReader[3].ConInt();
                    infos = new object[] { personnelTrId, name, surname, auth };
                }
                dataReader.Close();
                return infos;
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
                DataTable dataTable = sqlService.GetDataTable("ProvinceList");
                return dataTable;
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
                DataTable dataTable = sqlService.GetDataTable("DistrictList", new SqlParameter("@provinceId", provinceId));
                return dataTable;
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
                //create proc AuthId(@auth varchar(50))
                dataReader = sqlService.StoreReader("AuthId", new SqlParameter("@auth", auth));
                if (dataReader.Read())
                {
                    authId = dataReader[0].ConInt();
                }
                dataReader.Close();
                return authId;
            }
            catch
            {
                return 0;
            }
        }
        public static PersonnelDal GetInstance()
        {
            if (personnelDal == null)
            {
                personnelDal = new PersonnelDal();
            }
            return personnelDal;
        }
    }
}
