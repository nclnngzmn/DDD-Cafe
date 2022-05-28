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
using System.Diagnostics.Eventing.Reader;

namespace New_UI_draft
{
    public partial class MAINFORM : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ASPIRE-ES1-132;Initial Catalog=CAFE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public MAINFORM()
        {
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFEDataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter1.Fill(this.cAFEDataSet.Receipt);
            // TODO: This line of code loads data into the 'cAFEDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.cAFEDataSet.Orders);
            // TODO: This line of code loads data into the 'cAFEDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.cAFEDataSet.Product);
           
            lbldatepurchase.Text = DateTime.Today.ToShortDateString();
            txtcashier.Text = CASHIERLOGIN.passingText;

            comboboxproducts.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT productName FROM dbo.Product ORDER by productId ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboboxproducts.Items.Add(dr["productName"].ToString());

            }
            con.Close();
        }

        // EXIT BUTTON
        private void Bnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to EXIT?", "DDD Cafe POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Txtquantity_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            con.Open();
            if (int.TryParse(txtquantity.Text, out quantity))
            {
                SqlCommand stockcontrol = new SqlCommand("UPDATE dbo.Product SET stock = stock - @qty WHERE productName = @itn", con);
                stockcontrol.Parameters.AddWithValue("@qty", txtquantity.Text);
                stockcontrol.Parameters.AddWithValue("@itn", comboboxproducts.Text);
                stockcontrol.ExecuteNonQuery();
            }
            /*else
            {
                        
                MessageBox.Show("ORDER ADDED! SELECT FROM PRODUCTS TO ORDER AGAIN");
            }*/
            con.Close();
        }

        private void Comboboxproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand pricecheck = new SqlCommand("SELECT price FROM dbo.Product WHERE productName = '" + comboboxproducts.Text + "'", con);
            dr = pricecheck.ExecuteReader();

            while (dr.Read())
            {
                txtproductprice.Text = dr.GetValue(0).ToString();
            }
            con.Close();
                        
        }
        
        private void Bnaddorder_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["qty", row].Value = txtquantity.Text;
            dataGridView1["productname", row].Value = comboboxproducts.SelectedItem.ToString();
            dataGridView1["subtotal", row].Value = txtsubtotal.Text;

            comboboxproducts.Text = "";
            txtproductprice.Text = "";
            txtquantity.Text = "";

            MessageBox.Show("ORDER ADDED! SYSTEM IS OPEN FOR ADDITIONAL ORDERS");
        }

        private void bncomputesubtotal_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtquantity.TextLength > 0 && txtproductprice.TextLength > 0)
            {
                txtsubtotal.Text = Convert.ToString(Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(txtproductprice.Text));
            }
            con.Close();
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Bnpay_Click(object sender, EventArgs e)
        {
            double tl, ar, cg;
            double.TryParse(txttotal.Text, out tl);
            double.TryParse(txtamountreceive.Text, out ar);
            cg = ar - tl;

            if (cg > 0)
            {
                txtchange.Text = cg.ToString();
            }
            else if (cg == 0)
            {
                txtchange.Text = "Exact Amount Received.";
            }
            else if (cg < 0)
            {
                txtchange.Text = "Insufficient Amount.";
            }

            lblreceiptar.Text = txtamountreceive.Text;
            lblamountreceivechange.Text = txtchange.Text;
        }

        private void Bndeleteorder_Click(object sender, EventArgs e)
        {
            string i;
            i = Convert.ToString(dataGridView1.SelectedRows[0]);
            if (txtvoid.Text == "dddcafedabest")
            {
              

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                /*
                con.Open();
                string deleteorder;
                SqlDataAdapter dl = new SqlDataAdapter();
                deleteorder = "DELETE FROM dbo.Orders WHERE productName = '" + i + "'";
                cmd = new SqlCommand(deleteorder, con);
                dl.InsertCommand = new SqlCommand(deleteorder, con);
                dl.InsertCommand.ExecuteNonQuery();                
                con.Close();*/
            }
            else
            {
                MessageBox.Show("HELLO CASHIER! SIGAW KA NG HEPHEP HOORAY TO VOID THE ORDERS. TY HIHI.", "DDD Cafe POS");
            }
        }

        private void Bnordercheckout_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            txttotal.Text = sum.ToString();

            lblreceipttotal.Text = txttotal.Text;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Maxi_Click(object sender, EventArgs e)
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

        public void finishtransaction(string quantity, int subtotal, int total, string date, string amountreceive, int change)
        {
            con.Open();
            int productId = 0;

            String getdata, insertorder, insertreceipt;
            getdata = ("SELECT TOP 1 * FROM dbo.Product ORDER BY productId ASC");



            cmd = new SqlCommand(getdata, con);
            SqlDataReader dz = cmd.ExecuteReader();
            while (dz.Read())
            {
                productId = Convert.ToInt32(dz.GetValue(0));
            }
            dz.Close();
            cmd.Dispose();
            //cmd.ExecuteNonQuery();

            SqlDataAdapter or = new SqlDataAdapter();
            insertorder = "INSERT INTO dbo.Orders (productId, quantity, subtotal) VALUES ('" + Convert.ToString(productId) + "', '" + quantity + "', '" + Convert.ToString(subtotal) + "')";
            cmd = new SqlCommand(insertorder, con);
            or.InsertCommand = new SqlCommand(insertorder, con);
            or.InsertCommand.ExecuteNonQuery();
            //or.Close();
            //cmd.Dispose();

            SqlDataAdapter re = new SqlDataAdapter();
            insertreceipt = "INSERT INTO dbo.Receipt (cashierId, total, dateOfPurchase, amountReceive, change) VALUES ('" + Convert.ToString(txtcashier.Text) + "', '" + Convert.ToString(total) + "', '" + date + "', '" + Convert.ToString(amountreceive) + "', '" + Convert.ToString(change) + "')";
            cmd = new SqlCommand(insertreceipt, con);
            re.InsertCommand = new SqlCommand(insertreceipt, con);
            re.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();


        }

        private void Bnfintransaction_Click(object sender, EventArgs e)
        {
            string quantity;
            int subtotal; int total; string date; string amountreceive; int change;
            quantity = txtquantity.Text;
            subtotal = Convert.ToInt32(txtsubtotal.Text);
            total = Convert.ToInt32(txttotal.Text);
            date = lbldatepurchase.Text;
            amountreceive = txtamountreceive.Text;
            change = Convert.ToInt32(txtchange.Text);
            finishtransaction(quantity, subtotal, total, date, amountreceive, change);            
            MessageBox.Show("TRANSACTION COMPLETE! THANK YOU FOR VISITING DDDCAFE!", "DDD Cafe Cashier Login");
        }

        private void lblcashiername_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
