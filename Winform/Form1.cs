using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.SanPhamServiceReference;

namespace WinForm
{
    public partial class Form1 : Form
    {
        SanPhamServiceClient sp = new SanPhamServiceClient();
        public Form1()
        {
            InitializeComponent();
            Ds_SanPham();
        }

        public void Ds_SanPham()
        {            
            dataGridView1.DataSource = sp.ShowListProduct();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
