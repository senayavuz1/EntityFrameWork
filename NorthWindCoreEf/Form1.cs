using NorthWindCoreEf.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindCoreEf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthWindDbContext db = new NorthWindDbContext();
            var result = db.Customers.Where(p => p.City == "London");

            var resultSql = from cust in db.Customers
                            where cust.City == "London"
                            select new {
                                cust.CustomerId,
                                cust.CompanyName,
                                cust.ContactName,
                                cust.City,
                                cust.Country};

            dataGridView1.DataSource = resultSql.ToList();

        }
    }
}
