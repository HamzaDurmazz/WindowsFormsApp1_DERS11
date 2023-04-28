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

namespace WindowsFormsApp1_DERS11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AS6SJ5L;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd=new SqlCommand("select * from Orders",conn);
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lstConnected.Items.Add(dr["OrderId"]);
                    }
                }
            }
            conn.Close();
            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            label1.Text = fark.Milliseconds.ToString();
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AS6SJ5L;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter dap = new SqlDataAdapter("select * from Orders",conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            lstDisconnected.DataSource = dt;
            lstDisconnected.DisplayMember = "OrderId";
            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            label2.Text = fark.Milliseconds.ToString();
        }
        NorthwindEntities1 db = new NorthwindEntities1();
        private void btnEf_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            lstEntityFrameWork.DataSource = db.Orders.ToList();
            lstEntityFrameWork.DisplayMember = "OrderId";
            
            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            label3.Text = fark.Milliseconds.ToString();

        }
    }
}
