using DataAccess.Database;
using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
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
    public class CompanyDal : IRepository<Company>
    {
        static CompanyDal companyDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        string auth;

        public CompanyDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Company entity)
        {
            try
            {
                /*  [CompanyAdd] (@taxno char(9),@company varchar(50),@authStatus varchar(30),@authnamesur varchar(30),@authTr char(11),@sector varchar(15),
                    @phone1 varchar(15),@phone2 varchar(15),@email varchar(40),@fax varchar(15),@province varchar(13),@district varchar(20),@taxFoffice varchar(30), 
                    @adress varchar(100), @scode1 varchar(100),@scode2 varchar(100),@scode3 varchar(100))   */
                //(entity.Image==null) ? (object)DBNull.Value : entity.Image)
                //
                //if (img != null)
                //    cmd.Parameters.Add("@Image", SqlDbType.Image).Value = img;
                //else
                //    cmd.Parameters.Add("@Image", SqlDbType.Image).Value = DBNull.Value;
                //new SqlParameter("@image", entity.Image)

                //dataReader = sqlService.StoreReader("CompanyAdd", new SqlParameter("@image", entity.Image), new SqlParameter("@taxno", entity.Taxno), new SqlParameter("@company", entity.Firm), new SqlParameter("@authStatus", entity.AuthStatus), new SqlParameter("@authnamesur", entity.AuthNameSur), new SqlParameter("@sector", entity.Sector), new SqlParameter("@phone1", entity.Phone1), new SqlParameter("@phone2", entity.Phone2), new SqlParameter("@email", entity.Email), new SqlParameter("@fax", entity.Fax), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@taxFoffice", entity.TaxOffice), new SqlParameter("@adress", entity.Adress), new SqlParameter("@scode1", entity.Scode1), new SqlParameter("@scode2", entity.Scode2), new SqlParameter("@scode3", entity.Scode3));

                SqlCommand cmd = new SqlCommand("CompanyAdd", sqlService.OpenConnection());
                if (entity.Image != null) { cmd.Parameters.Add("@image", SqlDbType.Image).Value = entity.Image; }
                else { cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value; }
                cmd.Parameters.AddWithValue("@taxno", entity.Taxno);
                cmd.Parameters.AddWithValue("@company", entity.Firm);
                cmd.Parameters.AddWithValue("@authStatus", entity.AuthStatus);
                cmd.Parameters.AddWithValue("@authnamesur", entity.AuthNameSur);
                cmd.Parameters.AddWithValue("@sector", entity.Sector);
                cmd.Parameters.AddWithValue("@phone1", entity.Phone1);
                cmd.Parameters.AddWithValue("@phone2", entity.Phone2);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@fax", entity.Fax);
                cmd.Parameters.AddWithValue("@province", entity.Province);
                cmd.Parameters.AddWithValue("@district", entity.District);
                cmd.Parameters.AddWithValue("@taxoffice", entity.TaxOffice);
                cmd.Parameters.AddWithValue("@adress", entity.Adress);
                cmd.Parameters.AddWithValue("@scode1", entity.Scode1);
                cmd.Parameters.AddWithValue("@scode2", entity.Scode2);
                cmd.Parameters.AddWithValue("@scode3", entity.Scode3);
                cmd.CommandType = CommandType.StoredProcedure;
                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Company Exist";
                }
                sqlService.CloseConnection();
                return "Company Added Successfully";
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
                sqlService.Stored("CompanyDelete", new SqlParameter("@id", id));
                return "Company Informations Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Company Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("CompanyList");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public DataTable GetCompanyNames()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("CompanyNames");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public string AuthName(int id)
        {
            try
            {
                dataReader = sqlService.StoreReader("AuthName", new SqlParameter("@id", id));
                if (dataReader.Read())
                {
                    auth = dataReader["AUTH_NAME_SUR"].ToString();
                }
                dataReader.Close();
                return auth;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(Company entity)
        {
            /*  [CompanyUpdate] (@id smallint,@taxno char(9),@company varchar(50),@authStatus varchar(30),@authnamesur varchar(30),@authTr char(11),@sector varchar(15),
                @phone1 varchar(15),@phone2 varchar(15),@phone3 varchar(15),@email varchar(40),@fax varchar(15),@province varchar(13),@district varchar(20),@taxFoffice varchar(30),@adress varchar(100), @scode1 varchar(100),@scode2 varchar(100),@scode3 varchar(100),@oldTaxno char(9))     */

            try
            {
                //dataReader = sqlService.StoreReader("CompanyUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@image", entity.Image), new SqlParameter("@taxno", entity.Taxno), new SqlParameter("@company", entity.Firm), new SqlParameter("@authStatus", entity.AuthStatus), new SqlParameter("@authnamesur", entity.AuthNameSur), new SqlParameter("@sector", entity.Sector), new SqlParameter("@phone1", entity.Phone1), new SqlParameter("@phone2", entity.Phone2), new SqlParameter("@email", entity.Email), new SqlParameter("@fax", entity.Fax), new SqlParameter("@province", entity.Province), new SqlParameter("@district", entity.District), new SqlParameter("@taxFoffice", entity.TaxOffice), new SqlParameter("@adress", entity.Adress), new SqlParameter("@scode1", entity.Scode1), new SqlParameter("@scode2", entity.Scode2), new SqlParameter("@scode3", entity.Scode3), new SqlParameter("@oldTaxno", entity.OldTaxno));

                SqlCommand cmd = new SqlCommand("CompanyUpdate", sqlService.OpenConnection());

                cmd.Parameters.AddWithValue("@id", entity.Id);
                if (entity.Image != null) { cmd.Parameters.Add("@image", SqlDbType.Image).Value = entity.Image; }
                else { cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value; }
                cmd.Parameters.AddWithValue("@taxno", entity.Taxno);
                cmd.Parameters.AddWithValue("@company", entity.Firm);
                cmd.Parameters.AddWithValue("@authStatus", entity.AuthStatus);
                cmd.Parameters.AddWithValue("@authnamesur", entity.AuthNameSur);
                cmd.Parameters.AddWithValue("@sector", entity.Sector);
                cmd.Parameters.AddWithValue("@phone1", entity.Phone1);
                cmd.Parameters.AddWithValue("@phone2", entity.Phone2);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@fax", entity.Fax);
                cmd.Parameters.AddWithValue("@province", entity.Province);
                cmd.Parameters.AddWithValue("@district", entity.District);
                cmd.Parameters.AddWithValue("@taxoffice", entity.TaxOffice);
                cmd.Parameters.AddWithValue("@adress", entity.Adress);
                cmd.Parameters.AddWithValue("@scode1", entity.Scode1);
                cmd.Parameters.AddWithValue("@scode2", entity.Scode2);
                cmd.Parameters.AddWithValue("@scode3", entity.Scode3);
                cmd.Parameters.AddWithValue("@oldTaxno", entity.OldTaxno);
                cmd.CommandType = CommandType.StoredProcedure;
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Tax No : " + entity.Taxno + " Belongs To Another Company";
                }
                sqlService.CloseConnection();
                return "Company Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static CompanyDal GetInstance()
        {
            if (companyDal == null)
            {
                companyDal = new CompanyDal();
            }
            return companyDal;
        }
    }
}
