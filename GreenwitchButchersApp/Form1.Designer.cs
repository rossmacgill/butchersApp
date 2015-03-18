namespace GreenwitchButchersApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label clients_IDLabel;
            System.Windows.Forms.Label order_StatusLabel;
            System.Windows.Forms.Label total_PriceLabel;
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label supplierList_SentLabel;
            System.Windows.Forms.Label supplier_ConfirmedLabel;
            System.Windows.Forms.Label product_TypeLabel1;
            System.Windows.Forms.Label supplier_TelLabel;
            System.Windows.Forms.Label supplier_PostcodeLabel;
            System.Windows.Forms.Label supplier_AddressLabel;
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label product_TypeLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label product_PriceLabel;
            System.Windows.Forms.Label product_Stock_LevelLabel;
            System.Windows.Forms.Label client_NameLabel1;
            System.Windows.Forms.Label staff_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label staffIdLabel;
            System.Windows.Forms.Label staff_NameLabel1;
            System.Windows.Forms.Label staff_PasswordLabel;
            System.Windows.Forms.Label staff_Access_LevelLabel;
            this.client_IDLabel = new System.Windows.Forms.Label();
            this.client_NameLabel = new System.Windows.Forms.Label();
            this.client_addressLabel = new System.Windows.Forms.Label();
            this.client_PostcodeLabel = new System.Windows.Forms.Label();
            this.client_TelLabel = new System.Windows.Forms.Label();
            this.client_TypeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Orders = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new GreenwitchButchersApp.ClientDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.client_NameTextBox = new System.Windows.Forms.TextBox();
            this.client_addressTextBox = new System.Windows.Forms.TextBox();
            this.client_PostcodeTextBox = new System.Windows.Forms.TextBox();
            this.client_TelTextBox = new System.Windows.Forms.TextBox();
            this.client_TypeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new GreenwitchButchersApp.StockDataSet();
            this.product_TypeTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.supplier_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_PriceTextBox = new System.Windows.Forms.TextBox();
            this.product_Stock_LevelTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersDataSet = new GreenwitchButchersApp.SuppliersDataSet();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.supplier_AddressTextBox = new System.Windows.Forms.TextBox();
            this.supplier_PostcodeTextBox = new System.Windows.Forms.TextBox();
            this.supplier_TelTextBox = new System.Windows.Forms.TextBox();
            this.product_TypeTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierSentListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierSentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierSentListDataSet = new GreenwitchButchersApp.SupplierSentListDataSet();
            this.staff_NameTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.everythingDataSet = new GreenwitchButchersApp.everythingDataSet();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new GreenwitchButchersApp.ProductDataSet();
            this.client_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clients_IDTextBox = new System.Windows.Forms.TextBox();
            this.order_StatusTextBox = new System.Windows.Forms.TextBox();
            this.total_PriceTextBox = new System.Windows.Forms.TextBox();
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.supplier_ConfirmedTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataset = new GreenwitchButchersApp.OrderDataset();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.supplierTableAdapter = new GreenwitchButchersApp.SuppliersDataSetTableAdapters.SupplierTableAdapter();
            this.tableAdapterManager2 = new GreenwitchButchersApp.SuppliersDataSetTableAdapters.TableAdapterManager();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new GreenwitchButchersApp.OrderDatasetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager3 = new GreenwitchButchersApp.OrderDatasetTableAdapters.TableAdapterManager();
            this.orderTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new GreenwitchButchersApp.ClientDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new GreenwitchButchersApp.ClientDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new GreenwitchButchersApp.everythingDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager4 = new GreenwitchButchersApp.everythingDataSetTableAdapters.TableAdapterManager();
            this.orderTableAdapter1 = new GreenwitchButchersApp.everythingDataSetTableAdapters.OrderTableAdapter();
            this.productTableAdapter = new GreenwitchButchersApp.ProductDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new GreenwitchButchersApp.ProductDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter1 = new GreenwitchButchersApp.StockDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager5 = new GreenwitchButchersApp.StockDataSetTableAdapters.TableAdapterManager();
            this.staffTableAdapter = new GreenwitchButchersApp.everythingDataSetTableAdapters.StaffTableAdapter();
            this.supplierSentListTableAdapter = new GreenwitchButchersApp.SupplierSentListDataSetTableAdapters.SupplierSentListTableAdapter();
            this.tableAdapterManager6 = new GreenwitchButchersApp.SupplierSentListDataSetTableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.staffDataSet1 = new GreenwitchButchersApp.StaffDataSet1();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new GreenwitchButchersApp.StaffDataSet1TableAdapters.StaffTableAdapter();
            this.tableAdapterManager7 = new GreenwitchButchersApp.StaffDataSet1TableAdapters.TableAdapterManager();
            this.staffIdTextBox = new System.Windows.Forms.TextBox();
            this.staff_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.staff_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.staff_Access_LevelTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new GreenwitchButchersApp.everythingDataSetTableAdapters.ProductTableAdapter();
            this.prodctListMainDataSet1 = new GreenwitchButchersApp.ProdctListMainDataSet1();
            this.productBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter3 = new GreenwitchButchersApp.ProdctListMainDataSet1TableAdapters.ProductTableAdapter();
            this.tableAdapterManager8 = new GreenwitchButchersApp.ProdctListMainDataSet1TableAdapters.TableAdapterManager();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productListTableAdapter = new GreenwitchButchersApp.ProdctListMainDataSet1TableAdapters.ProductListTableAdapter();
            this.productListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderIdLabel = new System.Windows.Forms.Label();
            clients_IDLabel = new System.Windows.Forms.Label();
            order_StatusLabel = new System.Windows.Forms.Label();
            total_PriceLabel = new System.Windows.Forms.Label();
            staff_IDLabel = new System.Windows.Forms.Label();
            supplierList_SentLabel = new System.Windows.Forms.Label();
            supplier_ConfirmedLabel = new System.Windows.Forms.Label();
            product_TypeLabel1 = new System.Windows.Forms.Label();
            supplier_TelLabel = new System.Windows.Forms.Label();
            supplier_PostcodeLabel = new System.Windows.Forms.Label();
            supplier_AddressLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            product_TypeLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            product_PriceLabel = new System.Windows.Forms.Label();
            product_Stock_LevelLabel = new System.Windows.Forms.Label();
            client_NameLabel1 = new System.Windows.Forms.Label();
            staff_NameLabel = new System.Windows.Forms.Label();
            staffIdLabel = new System.Windows.Forms.Label();
            staff_NameLabel1 = new System.Windows.Forms.Label();
            staff_PasswordLabel = new System.Windows.Forms.Label();
            staff_Access_LevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Orders.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.everythingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodctListMainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(31, 38);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(48, 13);
            orderIdLabel.TabIndex = 16;
            orderIdLabel.Text = "Order Id:";
            // 
            // clients_IDLabel
            // 
            clients_IDLabel.AutoSize = true;
            clients_IDLabel.Location = new System.Drawing.Point(235, 38);
            clients_IDLabel.Name = "clients_IDLabel";
            clients_IDLabel.Size = new System.Drawing.Size(55, 13);
            clients_IDLabel.TabIndex = 18;
            clients_IDLabel.Text = "Clients ID:";
            // 
            // order_StatusLabel
            // 
            order_StatusLabel.AutoSize = true;
            order_StatusLabel.Location = new System.Drawing.Point(847, 231);
            order_StatusLabel.Name = "order_StatusLabel";
            order_StatusLabel.Size = new System.Drawing.Size(69, 13);
            order_StatusLabel.TabIndex = 22;
            order_StatusLabel.Text = "Order Status:";
            // 
            // total_PriceLabel
            // 
            total_PriceLabel.AutoSize = true;
            total_PriceLabel.Location = new System.Drawing.Point(148, 218);
            total_PriceLabel.Name = "total_PriceLabel";
            total_PriceLabel.Size = new System.Drawing.Size(61, 13);
            total_PriceLabel.TabIndex = 24;
            total_PriceLabel.Text = "Total Price:";
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Location = new System.Drawing.Point(523, 37);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(46, 13);
            staff_IDLabel.TabIndex = 26;
            staff_IDLabel.Text = "Staff ID:";
            // 
            // supplierList_SentLabel
            // 
            supplierList_SentLabel.AutoSize = true;
            supplierList_SentLabel.Location = new System.Drawing.Point(148, 270);
            supplierList_SentLabel.Name = "supplierList_SentLabel";
            supplierList_SentLabel.Size = new System.Drawing.Size(78, 13);
            supplierList_SentLabel.TabIndex = 28;
            supplierList_SentLabel.Text = "Suppliers Sent:";
            supplierList_SentLabel.Click += new System.EventHandler(this.supplierList_SentLabel_Click);
            // 
            // supplier_ConfirmedLabel
            // 
            supplier_ConfirmedLabel.AutoSize = true;
            supplier_ConfirmedLabel.Location = new System.Drawing.Point(148, 569);
            supplier_ConfirmedLabel.Name = "supplier_ConfirmedLabel";
            supplier_ConfirmedLabel.Size = new System.Drawing.Size(98, 13);
            supplier_ConfirmedLabel.TabIndex = 30;
            supplier_ConfirmedLabel.Text = "Supplier Confirmed:";
            // 
            // product_TypeLabel1
            // 
            product_TypeLabel1.AutoSize = true;
            product_TypeLabel1.Location = new System.Drawing.Point(134, 203);
            product_TypeLabel1.Name = "product_TypeLabel1";
            product_TypeLabel1.Size = new System.Drawing.Size(74, 13);
            product_TypeLabel1.TabIndex = 10;
            product_TypeLabel1.Text = "Product Type:";
            // 
            // supplier_TelLabel
            // 
            supplier_TelLabel.AutoSize = true;
            supplier_TelLabel.Location = new System.Drawing.Point(134, 177);
            supplier_TelLabel.Name = "supplier_TelLabel";
            supplier_TelLabel.Size = new System.Drawing.Size(66, 13);
            supplier_TelLabel.TabIndex = 8;
            supplier_TelLabel.Text = "Supplier Tel:";
            // 
            // supplier_PostcodeLabel
            // 
            supplier_PostcodeLabel.AutoSize = true;
            supplier_PostcodeLabel.Location = new System.Drawing.Point(134, 151);
            supplier_PostcodeLabel.Name = "supplier_PostcodeLabel";
            supplier_PostcodeLabel.Size = new System.Drawing.Size(96, 13);
            supplier_PostcodeLabel.TabIndex = 6;
            supplier_PostcodeLabel.Text = "Supplier Postcode:";
            // 
            // supplier_AddressLabel
            // 
            supplier_AddressLabel.AutoSize = true;
            supplier_AddressLabel.Location = new System.Drawing.Point(134, 125);
            supplier_AddressLabel.Name = "supplier_AddressLabel";
            supplier_AddressLabel.Size = new System.Drawing.Size(89, 13);
            supplier_AddressLabel.TabIndex = 4;
            supplier_AddressLabel.Text = "Supplier Address:";
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Location = new System.Drawing.Point(134, 99);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(79, 13);
            supplier_NameLabel.TabIndex = 2;
            supplier_NameLabel.Text = "Supplier Name:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(134, 73);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 0;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(159, 114);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 13;
            productIDLabel.Text = "Product ID:";
            // 
            // product_TypeLabel
            // 
            product_TypeLabel.AutoSize = true;
            product_TypeLabel.Location = new System.Drawing.Point(159, 140);
            product_TypeLabel.Name = "product_TypeLabel";
            product_TypeLabel.Size = new System.Drawing.Size(74, 13);
            product_TypeLabel.TabIndex = 15;
            product_TypeLabel.Text = "Product Type:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(159, 166);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 17;
            product_NameLabel.Text = "Product Name:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(159, 192);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(62, 13);
            supplier_IDLabel.TabIndex = 19;
            supplier_IDLabel.Text = "Supplier ID:";
            // 
            // product_PriceLabel
            // 
            product_PriceLabel.AutoSize = true;
            product_PriceLabel.Location = new System.Drawing.Point(159, 218);
            product_PriceLabel.Name = "product_PriceLabel";
            product_PriceLabel.Size = new System.Drawing.Size(74, 13);
            product_PriceLabel.TabIndex = 21;
            product_PriceLabel.Text = "Product Price:";
            // 
            // product_Stock_LevelLabel
            // 
            product_Stock_LevelLabel.AutoSize = true;
            product_Stock_LevelLabel.Location = new System.Drawing.Point(159, 244);
            product_Stock_LevelLabel.Name = "product_Stock_LevelLabel";
            product_Stock_LevelLabel.Size = new System.Drawing.Size(107, 13);
            product_Stock_LevelLabel.TabIndex = 23;
            product_Stock_LevelLabel.Text = "Product Stock Level:";
            // 
            // client_NameLabel1
            // 
            client_NameLabel1.AutoSize = true;
            client_NameLabel1.Location = new System.Drawing.Point(30, 64);
            client_NameLabel1.Name = "client_NameLabel1";
            client_NameLabel1.Size = new System.Drawing.Size(67, 13);
            client_NameLabel1.TabIndex = 31;
            client_NameLabel1.Text = "Client Name:";
            // 
            // staff_NameLabel
            // 
            staff_NameLabel.AutoSize = true;
            staff_NameLabel.Location = new System.Drawing.Point(728, 41);
            staff_NameLabel.Name = "staff_NameLabel";
            staff_NameLabel.Size = new System.Drawing.Size(63, 13);
            staff_NameLabel.TabIndex = 33;
            staff_NameLabel.Text = "Staff Name:";
            // 
            // client_IDLabel
            // 
            this.client_IDLabel.AutoSize = true;
            this.client_IDLabel.Location = new System.Drawing.Point(117, 41);
            this.client_IDLabel.Name = "client_IDLabel";
            this.client_IDLabel.Size = new System.Drawing.Size(50, 13);
            this.client_IDLabel.TabIndex = 0;
            this.client_IDLabel.Text = "Client ID:";
            // 
            // client_NameLabel
            // 
            this.client_NameLabel.AutoSize = true;
            this.client_NameLabel.Location = new System.Drawing.Point(117, 67);
            this.client_NameLabel.Name = "client_NameLabel";
            this.client_NameLabel.Size = new System.Drawing.Size(67, 13);
            this.client_NameLabel.TabIndex = 2;
            this.client_NameLabel.Text = "Client Name:";
            // 
            // client_addressLabel
            // 
            this.client_addressLabel.AutoSize = true;
            this.client_addressLabel.Location = new System.Drawing.Point(117, 93);
            this.client_addressLabel.Name = "client_addressLabel";
            this.client_addressLabel.Size = new System.Drawing.Size(76, 13);
            this.client_addressLabel.TabIndex = 4;
            this.client_addressLabel.Text = "Client address:";
            // 
            // client_PostcodeLabel
            // 
            this.client_PostcodeLabel.AutoSize = true;
            this.client_PostcodeLabel.Location = new System.Drawing.Point(117, 119);
            this.client_PostcodeLabel.Name = "client_PostcodeLabel";
            this.client_PostcodeLabel.Size = new System.Drawing.Size(84, 13);
            this.client_PostcodeLabel.TabIndex = 6;
            this.client_PostcodeLabel.Text = "Client Postcode:";
            // 
            // client_TelLabel
            // 
            this.client_TelLabel.AutoSize = true;
            this.client_TelLabel.Location = new System.Drawing.Point(117, 145);
            this.client_TelLabel.Name = "client_TelLabel";
            this.client_TelLabel.Size = new System.Drawing.Size(54, 13);
            this.client_TelLabel.TabIndex = 8;
            this.client_TelLabel.Text = "Client Tel:";
            // 
            // client_TypeLabel
            // 
            this.client_TypeLabel.AutoSize = true;
            this.client_TypeLabel.Location = new System.Drawing.Point(117, 171);
            this.client_TypeLabel.Name = "client_TypeLabel";
            this.client_TypeLabel.Size = new System.Drawing.Size(63, 13);
            this.client_TypeLabel.TabIndex = 10;
            this.client_TypeLabel.Text = "Client Type:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.Customers);
            this.Orders.Controls.Add(this.tabPage2);
            this.Orders.Controls.Add(this.Suppliers);
            this.Orders.Controls.Add(this.tabPage3);
            this.Orders.Controls.Add(this.tabPage1);
            this.Orders.Location = new System.Drawing.Point(78, 150);
            this.Orders.Name = "Orders";
            this.Orders.SelectedIndex = 0;
            this.Orders.Size = new System.Drawing.Size(1193, 612);
            this.Orders.TabIndex = 4;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.bindingNavigator1);
            this.Customers.Controls.Add(this.client_IDLabel);
            this.Customers.Controls.Add(this.client_IDTextBox);
            this.Customers.Controls.Add(this.client_NameLabel);
            this.Customers.Controls.Add(this.client_NameTextBox);
            this.Customers.Controls.Add(this.client_addressLabel);
            this.Customers.Controls.Add(this.client_addressTextBox);
            this.Customers.Controls.Add(this.client_PostcodeLabel);
            this.Customers.Controls.Add(this.client_PostcodeTextBox);
            this.Customers.Controls.Add(this.client_TelLabel);
            this.Customers.Controls.Add(this.client_TelTextBox);
            this.Customers.Controls.Add(this.client_TypeLabel);
            this.Customers.Controls.Add(this.client_TypeTextBox);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1185, 586);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clientsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1179, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.clientDataSet;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource1, "Client_ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(207, 38);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_IDTextBox.TabIndex = 1;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.clientDataSet;
            // 
            // client_NameTextBox
            // 
            this.client_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_Name", true));
            this.client_NameTextBox.Location = new System.Drawing.Point(207, 64);
            this.client_NameTextBox.Name = "client_NameTextBox";
            this.client_NameTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_NameTextBox.TabIndex = 3;
            // 
            // client_addressTextBox
            // 
            this.client_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_address", true));
            this.client_addressTextBox.Location = new System.Drawing.Point(207, 90);
            this.client_addressTextBox.Name = "client_addressTextBox";
            this.client_addressTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_addressTextBox.TabIndex = 5;
            // 
            // client_PostcodeTextBox
            // 
            this.client_PostcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_Postcode", true));
            this.client_PostcodeTextBox.Location = new System.Drawing.Point(207, 116);
            this.client_PostcodeTextBox.Name = "client_PostcodeTextBox";
            this.client_PostcodeTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_PostcodeTextBox.TabIndex = 7;
            // 
            // client_TelTextBox
            // 
            this.client_TelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_Tel", true));
            this.client_TelTextBox.Location = new System.Drawing.Point(207, 142);
            this.client_TelTextBox.Name = "client_TelTextBox";
            this.client_TelTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_TelTextBox.TabIndex = 9;
            // 
            // client_TypeTextBox
            // 
            this.client_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_Type", true));
            this.client_TypeTextBox.Location = new System.Drawing.Point(207, 168);
            this.client_TypeTextBox.Name = "client_TypeTextBox";
            this.client_TypeTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_TypeTextBox.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(productIDLabel);
            this.tabPage2.Controls.Add(this.productIDTextBox);
            this.tabPage2.Controls.Add(product_TypeLabel);
            this.tabPage2.Controls.Add(this.product_TypeTextBox);
            this.tabPage2.Controls.Add(product_NameLabel);
            this.tabPage2.Controls.Add(this.product_NameTextBox);
            this.tabPage2.Controls.Add(supplier_IDLabel);
            this.tabPage2.Controls.Add(this.supplier_IDTextBox);
            this.tabPage2.Controls.Add(product_PriceLabel);
            this.tabPage2.Controls.Add(this.product_PriceTextBox);
            this.tabPage2.Controls.Add(product_Stock_LevelLabel);
            this.tabPage2.Controls.Add(this.product_Stock_LevelTextBox);
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1185, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(272, 111);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(432, 20);
            this.productIDTextBox.TabIndex = 14;
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataMember = "Product";
            this.productBindingSource3.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_TypeTextBox
            // 
            this.product_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Product_Type", true));
            this.product_TypeTextBox.Location = new System.Drawing.Point(272, 137);
            this.product_TypeTextBox.Name = "product_TypeTextBox";
            this.product_TypeTextBox.Size = new System.Drawing.Size(432, 20);
            this.product_TypeTextBox.TabIndex = 16;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(272, 163);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(432, 20);
            this.product_NameTextBox.TabIndex = 18;
            // 
            // supplier_IDTextBox
            // 
            this.supplier_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Supplier_ID", true));
            this.supplier_IDTextBox.Location = new System.Drawing.Point(272, 189);
            this.supplier_IDTextBox.Name = "supplier_IDTextBox";
            this.supplier_IDTextBox.Size = new System.Drawing.Size(432, 20);
            this.supplier_IDTextBox.TabIndex = 20;
            // 
            // product_PriceTextBox
            // 
            this.product_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Product_Price", true));
            this.product_PriceTextBox.Location = new System.Drawing.Point(272, 215);
            this.product_PriceTextBox.Name = "product_PriceTextBox";
            this.product_PriceTextBox.Size = new System.Drawing.Size(432, 20);
            this.product_PriceTextBox.TabIndex = 22;
            // 
            // product_Stock_LevelTextBox
            // 
            this.product_Stock_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource3, "Product_Stock_Level", true));
            this.product_Stock_LevelTextBox.Location = new System.Drawing.Point(272, 241);
            this.product_Stock_LevelTextBox.Name = "product_Stock_LevelTextBox";
            this.product_Stock_LevelTextBox.Size = new System.Drawing.Size(432, 20);
            this.product_Stock_LevelTextBox.TabIndex = 24;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.productBindingSource3;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1179, 25);
            this.bindingNavigator2.TabIndex = 13;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Suppliers
            // 
            this.Suppliers.Controls.Add(this.bindingNavigator3);
            this.Suppliers.Controls.Add(supplierIDLabel);
            this.Suppliers.Controls.Add(this.supplierIDTextBox);
            this.Suppliers.Controls.Add(supplier_NameLabel);
            this.Suppliers.Controls.Add(this.supplier_NameTextBox);
            this.Suppliers.Controls.Add(supplier_AddressLabel);
            this.Suppliers.Controls.Add(this.supplier_AddressTextBox);
            this.Suppliers.Controls.Add(supplier_PostcodeLabel);
            this.Suppliers.Controls.Add(this.supplier_PostcodeTextBox);
            this.Suppliers.Controls.Add(supplier_TelLabel);
            this.Suppliers.Controls.Add(this.supplier_TelTextBox);
            this.Suppliers.Controls.Add(product_TypeLabel1);
            this.Suppliers.Controls.Add(this.product_TypeTextBox1);
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers.Size = new System.Drawing.Size(1185, 586);
            this.Suppliers.TabIndex = 2;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.supplierBindingSource1;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(1179, 25);
            this.bindingNavigator3.TabIndex = 12;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.suppliersDataSet;
            // 
            // suppliersDataSet
            // 
            this.suppliersDataSet.DataSetName = "SuppliersDataSet";
            this.suppliersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(236, 70);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplierIDTextBox.TabIndex = 1;
            // 
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Name", true));
            this.supplier_NameTextBox.Location = new System.Drawing.Point(236, 96);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_NameTextBox.TabIndex = 3;
            // 
            // supplier_AddressTextBox
            // 
            this.supplier_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Address", true));
            this.supplier_AddressTextBox.Location = new System.Drawing.Point(236, 122);
            this.supplier_AddressTextBox.Name = "supplier_AddressTextBox";
            this.supplier_AddressTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_AddressTextBox.TabIndex = 5;
            // 
            // supplier_PostcodeTextBox
            // 
            this.supplier_PostcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Postcode", true));
            this.supplier_PostcodeTextBox.Location = new System.Drawing.Point(236, 148);
            this.supplier_PostcodeTextBox.Name = "supplier_PostcodeTextBox";
            this.supplier_PostcodeTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_PostcodeTextBox.TabIndex = 7;
            // 
            // supplier_TelTextBox
            // 
            this.supplier_TelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Tel", true));
            this.supplier_TelTextBox.Location = new System.Drawing.Point(236, 174);
            this.supplier_TelTextBox.Name = "supplier_TelTextBox";
            this.supplier_TelTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_TelTextBox.TabIndex = 9;
            // 
            // product_TypeTextBox1
            // 
            this.product_TypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Product_Type", true));
            this.product_TypeTextBox1.Location = new System.Drawing.Point(236, 200);
            this.product_TypeTextBox1.Name = "product_TypeTextBox1";
            this.product_TypeTextBox1.Size = new System.Drawing.Size(681, 20);
            this.product_TypeTextBox1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.productDataGridView);
            this.tabPage1.Controls.Add(this.productListDataGridView);
            this.tabPage1.Controls.Add(this.supplierDataGridView);
            this.tabPage1.Controls.Add(this.supplierSentListDataGridView);
            this.tabPage1.Controls.Add(staff_NameLabel);
            this.tabPage1.Controls.Add(this.staff_NameTextBox);
            this.tabPage1.Controls.Add(client_NameLabel1);
            this.tabPage1.Controls.Add(this.client_NameTextBox1);
            this.tabPage1.Controls.Add(orderIdLabel);
            this.tabPage1.Controls.Add(this.orderIdTextBox);
            this.tabPage1.Controls.Add(clients_IDLabel);
            this.tabPage1.Controls.Add(this.clients_IDTextBox);
            this.tabPage1.Controls.Add(order_StatusLabel);
            this.tabPage1.Controls.Add(this.order_StatusTextBox);
            this.tabPage1.Controls.Add(total_PriceLabel);
            this.tabPage1.Controls.Add(this.total_PriceTextBox);
            this.tabPage1.Controls.Add(staff_IDLabel);
            this.tabPage1.Controls.Add(this.staff_IDTextBox);
            this.tabPage1.Controls.Add(supplierList_SentLabel);
            this.tabPage1.Controls.Add(supplier_ConfirmedLabel);
            this.tabPage1.Controls.Add(this.supplier_ConfirmedTextBox);
            this.tabPage1.Controls.Add(this.bindingNavigator4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1185, 586);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.supplierDataGridView.DataSource = this.supplierBindingSource1;
            this.supplierDataGridView.Location = new System.Drawing.Point(252, 394);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.Size = new System.Drawing.Size(647, 126);
            this.supplierDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn5.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Supplier_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Supplier_Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Supplier_Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Supplier_Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Supplier_Postcode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Supplier_Postcode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Supplier_Tel";
            this.dataGridViewTextBoxColumn9.HeaderText = "Supplier_Tel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Product_Type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Product_Type";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // supplierSentListDataGridView
            // 
            this.supplierSentListDataGridView.AllowUserToOrderColumns = true;
            this.supplierSentListDataGridView.AutoGenerateColumns = false;
            this.supplierSentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierSentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplierSentListDataGridView.DataSource = this.supplierSentListBindingSource;
            this.supplierSentListDataGridView.Location = new System.Drawing.Point(252, 270);
            this.supplierSentListDataGridView.Name = "supplierSentListDataGridView";
            this.supplierSentListDataGridView.Size = new System.Drawing.Size(448, 109);
            this.supplierSentListDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierSentListId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierSentListId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Confirmed";
            this.dataGridViewTextBoxColumn4.HeaderText = "Confirmed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // supplierSentListBindingSource
            // 
            this.supplierSentListBindingSource.DataMember = "SupplierSentList";
            this.supplierSentListBindingSource.DataSource = this.supplierSentListDataSet;
            // 
            // supplierSentListDataSet
            // 
            this.supplierSentListDataSet.DataSetName = "SupplierSentListDataSet";
            this.supplierSentListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staff_NameTextBox
            // 
            this.staff_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_Name", true));
            this.staff_NameTextBox.Location = new System.Drawing.Point(797, 38);
            this.staff_NameTextBox.Name = "staff_NameTextBox";
            this.staff_NameTextBox.Size = new System.Drawing.Size(187, 20);
            this.staff_NameTextBox.TabIndex = 34;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.everythingDataSet;
            // 
            // everythingDataSet
            // 
            this.everythingDataSet.DataSetName = "everythingDataSet";
            this.everythingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_NameTextBox1
            // 
            this.client_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Client_Name", true));
            this.client_NameTextBox1.Location = new System.Drawing.Point(103, 61);
            this.client_NameTextBox1.Name = "client_NameTextBox1";
            this.client_NameTextBox1.Size = new System.Drawing.Size(453, 20);
            this.client_NameTextBox1.TabIndex = 32;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "OrderId", true));
            this.orderIdTextBox.Location = new System.Drawing.Point(135, 35);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(73, 20);
            this.orderIdTextBox.TabIndex = 17;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.everythingDataSet;
            // 
            // clients_IDTextBox
            // 
            this.clients_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Clients_ID", true));
            this.clients_IDTextBox.Location = new System.Drawing.Point(339, 35);
            this.clients_IDTextBox.Multiline = true;
            this.clients_IDTextBox.Name = "clients_IDTextBox";
            this.clients_IDTextBox.Size = new System.Drawing.Size(73, 20);
            this.clients_IDTextBox.TabIndex = 19;
            // 
            // order_StatusTextBox
            // 
            this.order_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Order_Status", true));
            this.order_StatusTextBox.Location = new System.Drawing.Point(951, 228);
            this.order_StatusTextBox.Name = "order_StatusTextBox";
            this.order_StatusTextBox.Size = new System.Drawing.Size(175, 20);
            this.order_StatusTextBox.TabIndex = 23;
            // 
            // total_PriceTextBox
            // 
            this.total_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Total_Price", true));
            this.total_PriceTextBox.Location = new System.Drawing.Point(252, 215);
            this.total_PriceTextBox.Name = "total_PriceTextBox";
            this.total_PriceTextBox.Size = new System.Drawing.Size(292, 20);
            this.total_PriceTextBox.TabIndex = 25;
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Staff_ID", true));
            this.staff_IDTextBox.Location = new System.Drawing.Point(627, 34);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(73, 20);
            this.staff_IDTextBox.TabIndex = 27;
            // 
            // supplier_ConfirmedTextBox
            // 
            this.supplier_ConfirmedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource1, "Supplier_Confirmed", true));
            this.supplier_ConfirmedTextBox.Location = new System.Drawing.Point(252, 566);
            this.supplier_ConfirmedTextBox.Name = "supplier_ConfirmedTextBox";
            this.supplier_ConfirmedTextBox.Size = new System.Drawing.Size(368, 20);
            this.supplier_ConfirmedTextBox.TabIndex = 31;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator4.BindingSource = this.orderBindingSource;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator4.Size = new System.Drawing.Size(1179, 25);
            this.bindingNavigator4.TabIndex = 16;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.orderDataset;
            // 
            // orderDataset
            // 
            this.orderDataset.DataSetName = "OrderDataset";
            this.orderDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "of {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Move previous";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Position";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Move last";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager2.UpdateOrder = GreenwitchButchersApp.SuppliersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager3.ProductListTableAdapter = null;
            this.tableAdapterManager3.SupplierSentListTableAdapter = null;
            this.tableAdapterManager3.SupplierTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = GreenwitchButchersApp.OrderDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderTableAdapterBindingSource
            // 
            this.orderTableAdapterBindingSource.DataSource = typeof(GreenwitchButchersApp.OrderDatasetTableAdapters.OrderTableAdapter);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = GreenwitchButchersApp.ClientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "Clients";
            this.clientsBindingSource2.DataSource = this.everythingDataSet;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.ClientsTableAdapter = this.clientsTableAdapter1;
            this.tableAdapterManager4.OrderTableAdapter = this.orderTableAdapter1;
            this.tableAdapterManager4.ProductListTableAdapter = null;
            this.tableAdapterManager4.ProductTableAdapter = null;
            this.tableAdapterManager4.StaffTableAdapter = null;
            this.tableAdapterManager4.SupplierSentListTableAdapter = null;
            this.tableAdapterManager4.SupplierTableAdapter = null;
            this.tableAdapterManager4.UpdateOrder = GreenwitchButchersApp.everythingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager1.UpdateOrder = GreenwitchButchersApp.ProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager5.UpdateOrder = GreenwitchButchersApp.StockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // supplierSentListTableAdapter
            // 
            this.supplierSentListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager6
            // 
            this.tableAdapterManager6.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager6.SupplierSentListTableAdapter = this.supplierSentListTableAdapter;
            this.tableAdapterManager6.UpdateOrder = GreenwitchButchersApp.SupplierSentListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1341, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_2);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bindingNavigator5);
            this.tabPage3.Controls.Add(staffIdLabel);
            this.tabPage3.Controls.Add(this.staffIdTextBox);
            this.tabPage3.Controls.Add(staff_NameLabel1);
            this.tabPage3.Controls.Add(this.staff_NameTextBox1);
            this.tabPage3.Controls.Add(staff_PasswordLabel);
            this.tabPage3.Controls.Add(this.staff_PasswordTextBox);
            this.tabPage3.Controls.Add(staff_Access_LevelLabel);
            this.tabPage3.Controls.Add(this.staff_Access_LevelTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1185, 586);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Staff";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // staffDataSet1
            // 
            this.staffDataSet1.DataSetName = "StaffDataSet1";
            this.staffDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.staffDataSet1;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager7
            // 
            this.tableAdapterManager7.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager7.StaffTableAdapter = this.staffTableAdapter1;
            this.tableAdapterManager7.UpdateOrder = GreenwitchButchersApp.StaffDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffIdLabel
            // 
            staffIdLabel.AutoSize = true;
            staffIdLabel.Location = new System.Drawing.Point(309, 56);
            staffIdLabel.Name = "staffIdLabel";
            staffIdLabel.Size = new System.Drawing.Size(44, 13);
            staffIdLabel.TabIndex = 0;
            staffIdLabel.Text = "Staff Id:";
            // 
            // staffIdTextBox
            // 
            this.staffIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "StaffId", true));
            this.staffIdTextBox.Location = new System.Drawing.Point(414, 53);
            this.staffIdTextBox.Name = "staffIdTextBox";
            this.staffIdTextBox.Size = new System.Drawing.Size(348, 20);
            this.staffIdTextBox.TabIndex = 1;
            // 
            // staff_NameLabel1
            // 
            staff_NameLabel1.AutoSize = true;
            staff_NameLabel1.Location = new System.Drawing.Point(309, 82);
            staff_NameLabel1.Name = "staff_NameLabel1";
            staff_NameLabel1.Size = new System.Drawing.Size(63, 13);
            staff_NameLabel1.TabIndex = 2;
            staff_NameLabel1.Text = "Staff Name:";
            // 
            // staff_NameTextBox1
            // 
            this.staff_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "Staff_Name", true));
            this.staff_NameTextBox1.Location = new System.Drawing.Point(414, 79);
            this.staff_NameTextBox1.Name = "staff_NameTextBox1";
            this.staff_NameTextBox1.Size = new System.Drawing.Size(348, 20);
            this.staff_NameTextBox1.TabIndex = 3;
            // 
            // staff_PasswordLabel
            // 
            staff_PasswordLabel.AutoSize = true;
            staff_PasswordLabel.Location = new System.Drawing.Point(309, 108);
            staff_PasswordLabel.Name = "staff_PasswordLabel";
            staff_PasswordLabel.Size = new System.Drawing.Size(81, 13);
            staff_PasswordLabel.TabIndex = 4;
            staff_PasswordLabel.Text = "Staff Password:";
            // 
            // staff_PasswordTextBox
            // 
            this.staff_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "Staff_Password", true));
            this.staff_PasswordTextBox.Location = new System.Drawing.Point(414, 105);
            this.staff_PasswordTextBox.Name = "staff_PasswordTextBox";
            this.staff_PasswordTextBox.Size = new System.Drawing.Size(348, 20);
            this.staff_PasswordTextBox.TabIndex = 5;
            // 
            // staff_Access_LevelLabel
            // 
            staff_Access_LevelLabel.AutoSize = true;
            staff_Access_LevelLabel.Location = new System.Drawing.Point(309, 134);
            staff_Access_LevelLabel.Name = "staff_Access_LevelLabel";
            staff_Access_LevelLabel.Size = new System.Drawing.Size(99, 13);
            staff_Access_LevelLabel.TabIndex = 6;
            staff_Access_LevelLabel.Text = "Staff Access Level:";
            // 
            // staff_Access_LevelTextBox
            // 
            this.staff_Access_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "Staff_Access_Level", true));
            this.staff_Access_LevelTextBox.Location = new System.Drawing.Point(414, 131);
            this.staff_Access_LevelTextBox.Name = "staff_Access_LevelTextBox";
            this.staff_Access_LevelTextBox.Size = new System.Drawing.Size(348, 20);
            this.staff_Access_LevelTextBox.TabIndex = 7;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.bindingNavigator5.BindingSource = this.staffBindingSource1;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator5.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator5.Size = new System.Drawing.Size(1179, 25);
            this.bindingNavigator5.TabIndex = 8;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Move previous";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Position";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem4.Text = "of {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Move last";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "Delete";
            // 
            // productBindingSource4
            // 
            this.productBindingSource4.DataMember = "Product";
            this.productBindingSource4.DataSource = this.everythingDataSet;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // prodctListMainDataSet1
            // 
            this.prodctListMainDataSet1.DataSetName = "ProdctListMainDataSet1";
            this.prodctListMainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource5
            // 
            this.productBindingSource5.DataMember = "Product";
            this.productBindingSource5.DataSource = this.prodctListMainDataSet1;
            // 
            // productTableAdapter3
            // 
            this.productTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager8
            // 
            this.tableAdapterManager8.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager8.ProductListTableAdapter = this.productListTableAdapter;
            this.tableAdapterManager8.ProductTableAdapter = this.productTableAdapter3;
            this.tableAdapterManager8.UpdateOrder = GreenwitchButchersApp.ProdctListMainDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productListBindingSource
            // 
            this.productListBindingSource.DataMember = "ProductList";
            this.productListBindingSource.DataSource = this.prodctListMainDataSet1;
            // 
            // productListTableAdapter
            // 
            this.productListTableAdapter.ClearBeforeFill = true;
            // 
            // productListDataGridView
            // 
            this.productListDataGridView.AutoGenerateColumns = false;
            this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.productListDataGridView.DataSource = this.productListBindingSource;
            this.productListDataGridView.Location = new System.Drawing.Point(41, 91);
            this.productListDataGridView.Name = "productListDataGridView";
            this.productListDataGridView.Size = new System.Drawing.Size(454, 90);
            this.productListDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProductListId";
            this.dataGridViewTextBoxColumn11.HeaderText = "ProductListId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn12.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn13.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Quailty";
            this.dataGridViewTextBoxColumn14.HeaderText = "Quailty";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.productDataGridView.DataSource = this.productBindingSource5;
            this.productDataGridView.Location = new System.Drawing.Point(527, 94);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(599, 87);
            this.productDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn15.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Product_Type";
            this.dataGridViewTextBoxColumn16.HeaderText = "Product_Type";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn17.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Supplier_ID";
            this.dataGridViewTextBoxColumn18.HeaderText = "Supplier_ID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Product_Price";
            this.dataGridViewTextBoxColumn19.HeaderText = "Product_Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Product_Stock_Level";
            this.dataGridViewTextBoxColumn20.HeaderText = "Product_Stock_Level";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1341, 794);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.Suppliers.ResumeLayout(false);
            this.Suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierSentListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.everythingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodctListMainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.BindingSource productBindingSource;

        private System.Windows.Forms.TabControl Orders;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private ClientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ClientDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox client_IDTextBox;
        private System.Windows.Forms.TextBox client_NameTextBox;
        private System.Windows.Forms.TextBox client_addressTextBox;
        private System.Windows.Forms.TextBox client_PostcodeTextBox;
        private System.Windows.Forms.TextBox client_TelTextBox;
        private System.Windows.Forms.TextBox client_TypeTextBox;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private ProductDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ProductDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label client_IDLabel;
        private System.Windows.Forms.Label client_NameLabel;
        private System.Windows.Forms.Label client_addressLabel;
        private System.Windows.Forms.Label client_PostcodeLabel;
        private System.Windows.Forms.Label client_TelLabel;
        private System.Windows.Forms.Label client_TypeLabel;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TabPage Suppliers;
        private SuppliersDataSet suppliersDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private SuppliersDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private SuppliersDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private OrderDataset orderDataset;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private OrderDatasetTableAdapters.OrderTableAdapter orderTableAdapter;
        private OrderDatasetTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.BindingSource orderTableAdapterBindingSource;
        private everythingDataSet everythingDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private everythingDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private everythingDataSetTableAdapters.TableAdapterManager tableAdapterManager4;
        private everythingDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox clients_IDTextBox;
        private System.Windows.Forms.TextBox order_StatusTextBox;
        private System.Windows.Forms.TextBox total_PriceTextBox;
        private System.Windows.Forms.TextBox staff_IDTextBox;
        private System.Windows.Forms.TextBox supplier_ConfirmedTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox supplier_AddressTextBox;
        private System.Windows.Forms.TextBox supplier_PostcodeTextBox;
        private System.Windows.Forms.TextBox supplier_TelTextBox;
        private System.Windows.Forms.TextBox product_TypeTextBox1;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private StockDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private StockDataSetTableAdapters.TableAdapterManager tableAdapterManager5;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox product_TypeTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox supplier_IDTextBox;
        private System.Windows.Forms.TextBox product_PriceTextBox;
        private System.Windows.Forms.TextBox product_Stock_LevelTextBox;
        private System.Windows.Forms.TextBox client_NameTextBox1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private everythingDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.TextBox staff_NameTextBox;
        private SupplierSentListDataSet supplierSentListDataSet;
        private System.Windows.Forms.BindingSource supplierSentListBindingSource;
        private SupplierSentListDataSetTableAdapters.SupplierSentListTableAdapter supplierSentListTableAdapter;
        private SupplierSentListDataSetTableAdapters.TableAdapterManager tableAdapterManager6;
        private System.Windows.Forms.DataGridView supplierSentListDataGridView;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.TabPage tabPage3;
        private StaffDataSet1 staffDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private StaffDataSet1TableAdapters.StaffTableAdapter staffTableAdapter1;
        private StaffDataSet1TableAdapters.TableAdapterManager tableAdapterManager7;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.TextBox staffIdTextBox;
        private System.Windows.Forms.TextBox staff_NameTextBox1;
        private System.Windows.Forms.TextBox staff_PasswordTextBox;
        private System.Windows.Forms.TextBox staff_Access_LevelTextBox;
        private System.Windows.Forms.BindingSource productBindingSource4;
        private everythingDataSetTableAdapters.ProductTableAdapter productTableAdapter2;
        private ProdctListMainDataSet1 prodctListMainDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource5;
        private ProdctListMainDataSet1TableAdapters.ProductTableAdapter productTableAdapter3;
        private ProdctListMainDataSet1TableAdapters.TableAdapterManager tableAdapterManager8;
        private ProdctListMainDataSet1TableAdapters.ProductListTableAdapter productListTableAdapter;
        private System.Windows.Forms.BindingSource productListBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridView productListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

