using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace WinDbFirst
{
    public partial class EfSorgular : Form
    { 
        NorthwindEntities db = new NorthwindEntities();
        public EfSorgular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Soru
            // Fiyati 20 ila 50 arasin olan stoklarin Id,UrunAdi,Fiyati,Stok Miktari gelsin.
            #endregion

            #region Linq to Sql (Metod Yöntemi)
            //var query = db.Products
            //    .Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
            //    .Select(p => new
            //    {
            //       p.ProductID,
            //       p.ProductName,
            //       p.UnitPrice,
            //       p.QuantityPerUnit
            //    });

            //query.OrderBy(x => x.ProductName);

            //dataGridView1.DataSource = query.ToList();
            #endregion

            #region Sql
            var quer2 = from p in db.Products
                        where p.UnitPrice >= 20 && p.UnitPrice <= 50
                        orderby p.ProductID
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.UnitPrice,
                            p.QuantityPerUnit

                        };

            dataGridView1.DataSource = quer2.ToList();
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Soru
            // siparisler tablosundan MusteriSirketAdi,Calisanin Adi ,Calisan Soyadi,Sipris Id,Siparis Tarihi,Kargo sirketinin adi

            #endregion

            #region Sql
            /*
             Select c.CompnayName,e.FirstName,e.LastName,o.OrderId,
            o.OrderDate,s.CompnayName 
            from Orders o 
            inner join Customers c on c.CustomerId= o.CustomerID
            inner join Employees e on e.EmployeeId = o.EmployeeId
            inner join Shippers s on s.ShipperId = o.ShipVia
             
             */


            #endregion

            #region Linq To Metod

            var result = db.Orders.Select(p => new
            {
                MusteriAdi      =   p.Customers.CompanyName,
                CalisanAdi      =   p.Employees.FirstName,
                CalisanSoyadi   =   p.Employees.LastName,
                SiparisId       =   p.OrderID,
                SiparisTarihi   =   p.OrderDate,
                Kargo           =   p.Shippers.CompanyName
            });

            dataGridView1.DataSource = result.ToList();
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Soru
            // Musteri isimlerinde Restaurante kelimesi gecen
            // kaç musteri vardir

            #endregion

            #region Linq Metod
            //var reqult = db.Customers.Where(p => p.CompanyName.Contains("Restaurante"));
            //dataGridView1.DataSource = reqult.ToList();
            #endregion

            #region Linq To Sql

            var result = from p in db.Customers
                         where p.CompanyName.Contains("Restaurante")
                         select p;
            dataGridView1.DataSource=result.ToList();
            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kategorisi SeaFood olan MidyeDolma urununu Product tablosuna
            // fiyati 3.5 adeti 50 tane olacak sekilde ekleyin. 



            #region 1. Yol
            //Products midyeDolma = new Products();
            //midyeDolma.ProductName = "Midye dolma";
            //midyeDolma.UnitPrice = 3.5m;
            //midyeDolma.UnitsInStock = 50;
            //var cat = db.Categories.Where(c => c.CategoryName == "SeaFood").FirstOrDefault();
            //midyeDolma.CategoryID = cat.CategoryID;

            //db.Products.Add(midyeDolma);
            //db.SaveChanges(); 
            #endregion

            #region 2.Yol

            //db.Products.Add(new Products
            //{
            //    ProductName = "Kokarec",
            //    UnitPrice = 30,
            //    UnitsInStock = 0,
            //    CategoryID = db.Categories.Where(c => c.CategoryName == "SeaFood").FirstOrDefault().CategoryID
            //}); 
            //db.SaveChanges();

            #endregion

            #region 3. Yol

            //db.Categories
            //.Where(c => c.CategoryName == "SeaFood")
            //.FirstOrDefault()
            //.Products.Add(new Products 
            //{ 
            //    ProductName = "Kola",
            //    UnitPrice =10,
            //    UnitsInStock = 10
            
            //});
            //db.SaveChanges();
            #endregion

        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region  Soru
            // Calisanlarin Ad,Soyad ,DogumTarih ve yaşlarini listeleyin.

            #endregion

            #region Linq To Metod
            DateTime trh = DateTime.Now;

            var result = db.Employees.Select(p => new
            {
                AdSoyad = p.FirstName + " " + p.LastName,
                DogumTarihi = p.BirthDate,
                Yas = trh.Year - p.BirthDate.Value.Year //SqlFunctions.DateDiff("year", p.BirthDate, DateTime.Now)

            });

          

            #endregion
            dataGridView1.DataSource=result.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region soru
            //Kategorilerine gore urun sayisi

            #endregion

            #region Linq  To Metod
            var result = db.Products
                        .GroupBy(p => p.Categories.CategoryName)
                        .Select(g => new
                        {
                            KategoriAdi= g.Key,
                            ToplamStok=g.Sum(q=>q.UnitsInStock)
                        });

            dataGridView1.DataSource = result.ToList();
            #endregion



        }
    }
}
