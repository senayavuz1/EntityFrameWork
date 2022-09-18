using CodeFirstWin.Contexts;
using CodeFirstWin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstWin
{
    public partial class Form1 : Form
    {
        PostgreContext postgredb;
        SqlServerContext sqlserver;
        public Form1()
        {
            InitializeComponent();
            postgredb = new PostgreContext();
            sqlserver = new SqlServerContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAdi = txtKategoriAd.Text;
            kategori.Aciklama = textBox1.Text;
            //kategori.CreateDate = DateTime.Now;
            postgredb.Kategoriler.Add(kategori);
            postgredb.SaveChanges();
            dataGridView1.DataSource = postgredb.Kategoriler.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = postgredb.Kategoriler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kategori kategori = postgredb.Kategoriler.Find(4);
            kategori.KategoriAdi = "Elektronik";
            postgredb.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = sqlserver.Kategoriler.Where(x=>x.UstKategori==null).ToList();
            foreach (var item in result)
            {
                var node = new TreeNode(item.KategoriAdi);
                var altKategoriler = sqlserver.Kategoriler.Where(p=>p.UstKategori.Id==item.Id).ToList();
                foreach (var altKategori in altKategoriler)
                {
                    var altNode = new TreeNode(altKategori.KategoriAdi);
                }
            }
        }
    }
}
