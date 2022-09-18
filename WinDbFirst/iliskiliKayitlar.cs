using System;
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
    public partial class iliskiliKayitlar : Form
    {
        NorthwindEntities db = new NorthwindEntities(); 
        public iliskiliKayitlar()
        {
            InitializeComponent();
        }

        private void iliskiliKayitlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string CustomerId = row.Cells[0].Value.ToString();

            var orderResult = db.Orders.Where(o=> o.CustomerID == CustomerId);
            dataGridView2.DataSource = orderResult.ToList();



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            int OrderId = (int)row.Cells[0].Value;

            var orderResult = db.Order_Details.Where(o=> o.OrderID == OrderId);

            dataGridView3.DataSource = orderResult.ToList();
        }
    }
}
