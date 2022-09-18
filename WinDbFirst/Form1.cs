﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbFirst
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Shippers shippers = new Shippers();
            shippers.Phone = textBox2.Text;
            shippers.CompanyName = textBox1.Text;

            db.Shippers.Add(shippers);
            db.SaveChanges();
            dataGridView1.DataSource = db.Shippers.ToList();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            dataGridView1.DataSource = db.Shippers.ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {  
            // Update 1. Yol

            int shipperId = int.Parse(textBox1.Text);
            //var shipper = db.Shippers.Where(x=>x.ShipperID== shipperId).FirstOrDefault();
            //shipper.Phone = " +90 212 444 55 55";
            //db.SaveChanges();

            // Update 2. Yol
            var shipper = db.Shippers.Find(shipperId);
            if (shipper != null)
                shipper.Phone = "+90 555 45 45";
            db.Entry<Shippers>(shipper).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            RefreshGrid();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int shipperId = int.Parse(textBox1.Text);

            //1. Yol 
            //var shipper = db.Shippers.Find(shipperId);
            //db.Shippers.Remove(shipper);

            //db.SaveChanges();

            //2. Yol 
            var shipper = db.Shippers.Find(shipperId);
            db.Entry<Shippers>(shipper).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();



            RefreshGrid();

        }
    }
}
