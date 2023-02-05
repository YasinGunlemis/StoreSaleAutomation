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
    public class ProductDal : IRepository<Product>
    {
        static ProductDal productDal;
        SqlService sqlService;
        //SqlDataReader dataReader;
        //bool result;

        public ProductDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Product entity)
        {
            try
            {
                /*  [ProductAdd] (@productName varchar(20), @brand varchar(20), @model varchar(20), @year char(4), @piece smallint, 
                    @buying decimal(18,2), @selling decimal(18,2),@detail varchar(500),@imageUrl1 nvarchar(50),@imageUrl2 nvarchar(50),@imageUrl3 nvarchar(50)) 
                
                sqlService.Stored("ProductAdd", new SqlParameter("@productName", entity.ProductName), new SqlParameter("@brand", entity.Brand), new SqlParameter("@model", entity.Model), new SqlParameter("@year", entity.Year), new SqlParameter("@piece", entity.Piece), new SqlParameter("@buying", entity.Buying), new SqlParameter("@selling", entity.Selling), new SqlParameter("@detail", entity.Detail), new SqlParameter("@image1", entity.Image1), new SqlParameter("@image2", entity.Image2), new SqlParameter("@image3", entity.Image3));
*/
                SqlCommand cmd = new SqlCommand("[ProductAdd]", sqlService.OpenConnection());
                if (entity.Image1 != null && entity.Image2 != null && entity.Image3 != null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = entity.Image2;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = entity.Image3;
                }
                else if (entity.Image1 != null && entity.Image2 != null && entity.Image3 == null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = entity.Image2;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                else if (entity.Image1 != null && entity.Image2 == null && entity.Image3 == null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                cmd.Parameters.AddWithValue("@productName", entity.ProductName);
                cmd.Parameters.AddWithValue("@brand", entity.Brand);
                cmd.Parameters.AddWithValue("@model", entity.Model);
                cmd.Parameters.AddWithValue("@year", entity.Year);
                cmd.Parameters.AddWithValue("@piece", entity.Piece);
                cmd.Parameters.AddWithValue("@buying", entity.Buying);
                cmd.Parameters.AddWithValue("@selling", entity.Selling);
                cmd.Parameters.AddWithValue("@detail", entity.Detail);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                return entity.ProductName + " Product Added Successfully";
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
                //[ProductDelete] (@id int)
                sqlService.Stored("ProductDelete", new SqlParameter("@id", id));
                return "Product Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Product Get(int id)
        {
            return null;
        }

        public DataTable GetDataTable()
        {
            try
            {
                DataTable dataTable = sqlService.GetDataTable("ProductList");
                return dataTable;
            }
            catch
            {
                return new DataTable();
            }
        }

        public string Update(Product entity)
        {
            try
            {
                /*  [ProductUpdate] (@id int, @productName varchar(20), @brand varchar(20), @model varchar(20), @year char(4), @piece smallint, 
                @buying decimal(18,2), @selling decimal(18,2),@detail varchar(500),@image1 image,@image2 image,@image3 image)     

                sqlService.Stored("ProductUpdate", new SqlParameter("@id", entity.Id), new SqlParameter("@productName", entity.ProductName), new SqlParameter("@brand", entity.Brand), new SqlParameter("@model", entity.Model), new SqlParameter("@year", entity.Year), new SqlParameter("@piece", entity.Piece), new SqlParameter("@buying", entity.Buying), new SqlParameter("@selling", entity.Selling), new SqlParameter("@detail", entity.Detail), new SqlParameter("@image1", entity.Image1), new SqlParameter("@image2", entity.Image2), new SqlParameter("@image3", entity.Image3));
               */

                SqlCommand cmd = new SqlCommand("[ProductUpdate]", sqlService.OpenConnection());
                if (entity.Image1 != null && entity.Image2 != null && entity.Image3 != null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = entity.Image2;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = entity.Image3;
                }
                else if (entity.Image1 != null && entity.Image2 != null && entity.Image3 == null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = entity.Image2;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                else if (entity.Image1 != null && entity.Image2 == null && entity.Image3 == null)
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = entity.Image1;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@image1", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image2", SqlDbType.Image).Value = DBNull.Value;
                    cmd.Parameters.Add("@image3", SqlDbType.Image).Value = DBNull.Value;
                }
                cmd.Parameters.AddWithValue("@id", entity.Id);
                cmd.Parameters.AddWithValue("@productName", entity.ProductName);
                cmd.Parameters.AddWithValue("@brand", entity.Brand);
                cmd.Parameters.AddWithValue("@model", entity.Model);
                cmd.Parameters.AddWithValue("@year", entity.Year);
                cmd.Parameters.AddWithValue("@piece", entity.Piece);
                cmd.Parameters.AddWithValue("@buying", entity.Buying);
                cmd.Parameters.AddWithValue("@selling", entity.Selling);
                cmd.Parameters.AddWithValue("@detail", entity.Detail);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                return entity.ProductName + " Product Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void ProductDecreaseOrIncrease(string selection, int productId, int quantity)
        {
            try
            {
                if (selection == "Decrease")
                {
                    sqlService.Stored("ProductDecrease", new SqlParameter("@productId", productId), new SqlParameter("@quatity", quantity));
                }
                else
                {
                    sqlService.Stored("ProductIncrease", new SqlParameter("@productId", productId), new SqlParameter("@quatity", quantity));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        DataTable dt;
        public DataTable GetProductsBy(string data, string brand)
        {
            try
            {
                if (data.Contains("Name"))
                {
                    dt = sqlService.GetDataTable("ProductsByProductName");
                }
                else if (data.Contains("Brand"))
                {
                    dt = sqlService.GetDataTable("ProductsByBrand", new SqlParameter("@brand",brand));
                }
                return dt;
            }
            catch
            {
                return new DataTable();
            }
        }

        public DataTable GetDecreasingProductsByPiece(int piece)
        {
            try
            {
                return sqlService.GetDataTable("DecreasingProducts",new SqlParameter("@piece",piece));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetRecentlyAddedProducts(int number)
        {
            try
            {
                return sqlService.GetDataTable("RecentlyAddedProducts", new SqlParameter("@number", number));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ProductDal GetInstance()
        {
            if (productDal == null)
            {
                productDal = new ProductDal();
            }
            return productDal;
        }
    }
}
