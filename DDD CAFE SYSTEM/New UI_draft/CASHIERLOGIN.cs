using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace New_UI_draft
{
    public partial class CASHIERLOGIN : Form
    {
        public static string passingText;

        SqlConnection con = new SqlConnection(@"Data Source=ASPIRE-ES1-132;Initial Catalog=CAFE;Integrated Security=True");

        public CASHIERLOGIN()
        {
            InitializeComponent();
        }

        private void Bttnlogin_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Cashier WHERE cashierId = '" + txtcashierid.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (txtcashierid.Text != "")
            {
                if (txtcashierid.Text != "")
                {
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][0].ToString() == "2020001" || dt.Rows[0][0].ToString() == "2020004")
                        {
                            passingText = txtcashierid.Text;
                            MAINFORM mf = new MAINFORM();
                            mf.Show();
                            this.Hide();
                        }
                        else if (dt.Rows[0][0].ToString() == "2020002" || dt.Rows[0][0].ToString() == "2020003")
                        {
                            MessageBox.Show("Sorry, the Cashier is currently OFF DUTY.", "DDD Cafe Cashier Login");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the Cashier ID doesn't belong to the cafe. Please try again.", "DDD Cafe Cashier Login");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please input cashier ID");
            }
            con.Close();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            this.cashierTableAdapter.Fill(this.cAFEDataSet.Cashier);            
        }

        //===================== TITLE BAR ======================
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //========================================================
    }
}
