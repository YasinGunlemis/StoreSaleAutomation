using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        int id, piece;
        string productName, brand, model, year, detail;
        decimal buying, selling;
        byte[] image1, image2, image3;

        public int Id { get => id; set => id = value; }
        public int Piece { get => piece; set => piece = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }
        public string Detail { get => detail; set => detail = value; }
        public decimal Buying { get => buying; set => buying = value; }
        public decimal Selling { get => selling; set => selling = value; }
        public byte[] Image1 { get => image1; set => image1 = value; }
        public byte[] Image2 { get => image2; set => image2 = value; }
        public byte[] Image3 { get => image3; set => image3 = value; }

        //Ürün Güncelleme İçin

        public Product(int id, string productName, string brand, string model, string year, int piece, decimal buying, decimal selling, string detail, byte[] image1, byte[] image2, byte[] image3)
        {
            this.id = id;
            this.productName = productName;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.piece = piece;
            this.buying = buying;
            this.selling = selling;
            this.detail = detail;
            this.image1 = image1;
            this.image2 = image2;
            this.image3 = image3;
        }


        //Ürün Ekleme İçin
        public Product(string productName, string brand, string model, string year, int piece, decimal buying, decimal selling, string detail, byte[] image1, byte[] image2, byte[] image3)
        {
            this.productName = productName;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.piece = piece;
            this.buying = buying;
            this.selling = selling;
            this.detail = detail;
            this.image1 = image1;
            this.image2 = image2;
            this.image3 = image3;
        }
    }
}
