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

namespace GreenwitchButchersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Supplier' table. You can move, or remove it, as needed.
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodctListMainDataSet1.ProductList' table. You can move, or remove it, as needed.
            this.productListTableAdapter.Fill(this.prodctListMainDataSet1.ProductList);
            // TODO: This line of code loads data into the 'prodctListMainDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter3.Fill(this.prodctListMainDataSet1.Product);
            // TODO: This line of code loads data into the 'everythingDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.everythingDataSet.Product);
            // TODO: This line of code loads data into the 'staffDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.staffDataSet1.Staff);
            // TODO: This line of code loads data into the 'supplierSentListDataSet.SupplierSentList' table. You can move, or remove it, as needed.
            this.supplierSentListTableAdapter.Fill(this.supplierSentListDataSet.SupplierSentList);
            // TODO: This line of code loads data into the 'everythingDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.everythingDataSet.Staff);
            // TODO: This line of code loads data into the 'stockDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.stockDataSet.Product);
            // TODO: This line of code loads data into the 'stockDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.stockDataSet.Product);
            // TODO: This line of code loads data into the 'everythingDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.everythingDataSet.Order);
            // TODO: This line of code loads data into the 'everythingDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.everythingDataSet.Clients);
            // TODO: This line of code loads data into the 'orderDataset.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.orderDataset.Order);
            // TODO: This line of code loads data into the 'suppliersDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.suppliersDataSet.Supplier);
            // TODO: This line of code loads data into the 'clientDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientDataSet.Clients);


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter1.Fill(this.everythingDataSet.Order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void supplierList_SentLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.suppliersDataSet.Supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
