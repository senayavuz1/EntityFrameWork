using OkulCodeFirst.Entities;
using System;
using SinemaEntity.Entites;
namespace OkulCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            PostgreDbContext db = new PostgreDbContext();
            Sehir sehir = new Sehir();
            sehir.SehirAdi = "Adana";
            sehir.CreateDate = DateTime.Now;
            //sehir.UpdateDate = DateTime.Now;
            try
            {

                db.Sehirler.Add(sehir);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
           
        }
    }
}
