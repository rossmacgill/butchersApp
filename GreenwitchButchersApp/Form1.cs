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
    }
}
