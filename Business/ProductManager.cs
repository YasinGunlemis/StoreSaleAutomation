using DataAccess;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager
    {
        static ProductManager productManager;
        ProductDal productDal;
        string controlText;

        public ProductManager()
        {
            productDal = ProductDal.GetInstance();
        }

        public string Add(Product entity)
        {
            try
            {
                controlText = IsProductComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return productDal.Add(entity);
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
                    return "Please Select A Product";
                }
                return productDal.Delete(id);
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
                return productDal.GetDataTable();
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
                if (entity.Id < 1)
                {
                    return "Please Select A Product";
                }
                controlText = IsProductComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return productDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //int id, string productName, string brand, string model, string year, int piece, decimal buying, decimal selling, string detail
        string IsProductComplete(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName) || string.IsNullOrEmpty(product.Detail) || string.IsNullOrEmpty(product.Brand) || string.IsNullOrEmpty(product.Year))
            {
                return "Please Fill In The Required Fields";
            }
            return "";
        }

        public void ProductDecreaseOrIncrease(string selection, int productId, int quantity)
        {
            try
            {
                productDal.ProductDecreaseOrIncrease(selection, productId, quantity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetProductsBy(string data, string brand)
        {
            try
            {
                return productDal.GetProductsBy(data,brand);
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
                return productDal.GetDecreasingProductsByPiece(piece);
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
                return productDal.GetRecentlyAddedProducts(number);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static ProductManager GetInstance()
        {
            if (productManager == null)
            {
                productManager = new ProductManager();
            }
            return productManager;
        }
    }
}
