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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label supplier_AddressLabel;
            System.Windows.Forms.Label supplier_PostcodeLabel;
            System.Windows.Forms.Label supplier_TelLabel;
            System.Windows.Forms.Label product_TypeLabel1;
            this.client_IDLabel = new System.Windows.Forms.Label();
            this.client_NameLabel = new System.Windows.Forms.Label();
            this.client_addressLabel = new System.Windows.Forms.Label();
            this.client_PostcodeLabel = new System.Windows.Forms.Label();
            this.client_TelLabel = new System.Windows.Forms.Label();
            this.client_TypeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stock = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new GreenwitchButchersApp.ClientDataSet();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.client_NameTextBox = new System.Windows.Forms.TextBox();
            this.client_addressTextBox = new System.Windows.Forms.TextBox();
            this.client_PostcodeTextBox = new System.Windows.Forms.TextBox();
            this.client_TelTextBox = new System.Windows.Forms.TextBox();
            this.client_TypeTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new GreenwitchButchersApp.ProductDataSet();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.clientsTableAdapter = new GreenwitchButchersApp.ClientDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new GreenwitchButchersApp.ClientDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new GreenwitchButchersApp.ProductDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new GreenwitchButchersApp.ProductDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.product_Stock_LevelTextBox = new System.Windows.Forms.TextBox();
            this.product_Stock_LevelLabel = new System.Windows.Forms.Label();
            this.product_PriceTextBox = new System.Windows.Forms.TextBox();
            this.product_PriceLabel = new System.Windows.Forms.Label();
            this.supplier_IDTextBox = new System.Windows.Forms.TextBox();
            this.supplier_IDLabel = new System.Windows.Forms.Label();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_NameLabel = new System.Windows.Forms.Label();
            this.product_TypeTextBox = new System.Windows.Forms.TextBox();
            this.product_TypeLabel = new System.Windows.Forms.Label();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.suppliersDataSet = new GreenwitchButchersApp.SuppliersDataSet();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new GreenwitchButchersApp.SuppliersDataSetTableAdapters.SupplierTableAdapter();
            this.tableAdapterManager2 = new GreenwitchButchersApp.SuppliersDataSetTableAdapters.TableAdapterManager();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.supplier_AddressTextBox = new System.Windows.Forms.TextBox();
            this.supplier_PostcodeTextBox = new System.Windows.Forms.TextBox();
            this.supplier_TelTextBox = new System.Windows.Forms.TextBox();
            this.product_TypeTextBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            supplierIDLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            supplier_AddressLabel = new System.Windows.Forms.Label();
            supplier_PostcodeLabel = new System.Windows.Forms.Label();
            supplier_TelLabel = new System.Windows.Forms.Label();
            product_TypeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Stock.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
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
            // Stock
            // 
            this.Stock.Controls.Add(this.Customers);
            this.Stock.Controls.Add(this.tabPage2);
            this.Stock.Controls.Add(this.Suppliers);
            this.Stock.Location = new System.Drawing.Point(78, 150);
            this.Stock.Name = "Stock";
            this.Stock.SelectedIndex = 0;
            this.Stock.Size = new System.Drawing.Size(1104, 396);
            this.Stock.TabIndex = 3;
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
            this.Customers.Size = new System.Drawing.Size(1096, 370);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
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
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource1, "Client_ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(207, 38);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(819, 20);
            this.client_IDTextBox.TabIndex = 1;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1090, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.clientDataSet;
            // 
            // product_Stock_LevelTextBox
            // 
            this.product_Stock_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Product_Stock_Level", true));
            this.product_Stock_LevelTextBox.Location = new System.Drawing.Point(263, 232);
            this.product_Stock_LevelTextBox.Name = "product_Stock_LevelTextBox";
            this.product_Stock_LevelTextBox.Size = new System.Drawing.Size(722, 20);
            this.product_Stock_LevelTextBox.TabIndex = 12;
            // 
            // product_Stock_LevelLabel
            // 
            this.product_Stock_LevelLabel.AutoSize = true;
            this.product_Stock_LevelLabel.Location = new System.Drawing.Point(150, 235);
            this.product_Stock_LevelLabel.Name = "product_Stock_LevelLabel";
            this.product_Stock_LevelLabel.Size = new System.Drawing.Size(107, 13);
            this.product_Stock_LevelLabel.TabIndex = 11;
            this.product_Stock_LevelLabel.Text = "Product Stock Level:";
            // 
            // product_PriceTextBox
            // 
            this.product_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Product_Price", true));
            this.product_PriceTextBox.Location = new System.Drawing.Point(263, 206);
            this.product_PriceTextBox.Name = "product_PriceTextBox";
            this.product_PriceTextBox.Size = new System.Drawing.Size(722, 20);
            this.product_PriceTextBox.TabIndex = 10;
            // 
            // product_PriceLabel
            // 
            this.product_PriceLabel.AutoSize = true;
            this.product_PriceLabel.Location = new System.Drawing.Point(150, 209);
            this.product_PriceLabel.Name = "product_PriceLabel";
            this.product_PriceLabel.Size = new System.Drawing.Size(74, 13);
            this.product_PriceLabel.TabIndex = 9;
            this.product_PriceLabel.Text = "Product Price:";
            // 
            // supplier_IDTextBox
            // 
            this.supplier_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Supplier_ID", true));
            this.supplier_IDTextBox.Location = new System.Drawing.Point(263, 180);
            this.supplier_IDTextBox.Name = "supplier_IDTextBox";
            this.supplier_IDTextBox.Size = new System.Drawing.Size(722, 20);
            this.supplier_IDTextBox.TabIndex = 8;
            // 
            // supplier_IDLabel
            // 
            this.supplier_IDLabel.AutoSize = true;
            this.supplier_IDLabel.Location = new System.Drawing.Point(150, 183);
            this.supplier_IDLabel.Name = "supplier_IDLabel";
            this.supplier_IDLabel.Size = new System.Drawing.Size(62, 13);
            this.supplier_IDLabel.TabIndex = 7;
            this.supplier_IDLabel.Text = "Supplier ID:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(263, 154);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(722, 20);
            this.product_NameTextBox.TabIndex = 6;
            // 
            // product_NameLabel
            // 
            this.product_NameLabel.AutoSize = true;
            this.product_NameLabel.Location = new System.Drawing.Point(150, 157);
            this.product_NameLabel.Name = "product_NameLabel";
            this.product_NameLabel.Size = new System.Drawing.Size(78, 13);
            this.product_NameLabel.TabIndex = 5;
            this.product_NameLabel.Text = "Product Name:";
            // 
            // product_TypeTextBox
            // 
            this.product_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Product_Type", true));
            this.product_TypeTextBox.Location = new System.Drawing.Point(263, 128);
            this.product_TypeTextBox.Name = "product_TypeTextBox";
            this.product_TypeTextBox.Size = new System.Drawing.Size(722, 20);
            this.product_TypeTextBox.TabIndex = 4;
            // 
            // product_TypeLabel
            // 
            this.product_TypeLabel.AutoSize = true;
            this.product_TypeLabel.Location = new System.Drawing.Point(150, 131);
            this.product_TypeLabel.Name = "product_TypeLabel";
            this.product_TypeLabel.Size = new System.Drawing.Size(74, 13);
            this.product_TypeLabel.TabIndex = 3;
            this.product_TypeLabel.Text = "Product Type:";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(263, 102);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(722, 20);
            this.productIDTextBox.TabIndex = 2;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(150, 105);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(61, 13);
            this.productIDLabel.TabIndex = 1;
            this.productIDLabel.Text = "Product ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Controls.Add(this.productIDLabel);
            this.tabPage2.Controls.Add(this.productIDTextBox);
            this.tabPage2.Controls.Add(this.product_TypeLabel);
            this.tabPage2.Controls.Add(this.product_TypeTextBox);
            this.tabPage2.Controls.Add(this.product_NameLabel);
            this.tabPage2.Controls.Add(this.product_NameTextBox);
            this.tabPage2.Controls.Add(this.supplier_IDLabel);
            this.tabPage2.Controls.Add(this.supplier_IDTextBox);
            this.tabPage2.Controls.Add(this.product_PriceLabel);
            this.tabPage2.Controls.Add(this.product_PriceTextBox);
            this.tabPage2.Controls.Add(this.product_Stock_LevelLabel);
            this.tabPage2.Controls.Add(this.product_Stock_LevelTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1096, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.productBindingSource;
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
            this.bindingNavigator2.Size = new System.Drawing.Size(1090, 25);
            this.bindingNavigator2.TabIndex = 13;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
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
            this.Suppliers.Size = new System.Drawing.Size(1096, 370);
            this.Suppliers.TabIndex = 2;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // suppliersDataSet
            // 
            this.suppliersDataSet.DataSetName = "SuppliersDataSet";
            this.suppliersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.suppliersDataSet;
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
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(134, 73);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 0;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(236, 70);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplierIDTextBox.TabIndex = 1;
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
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Name", true));
            this.supplier_NameTextBox.Location = new System.Drawing.Point(236, 96);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_NameTextBox.TabIndex = 3;
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
            // supplier_AddressTextBox
            // 
            this.supplier_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Address", true));
            this.supplier_AddressTextBox.Location = new System.Drawing.Point(236, 122);
            this.supplier_AddressTextBox.Name = "supplier_AddressTextBox";
            this.supplier_AddressTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_AddressTextBox.TabIndex = 5;
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
            // supplier_PostcodeTextBox
            // 
            this.supplier_PostcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Postcode", true));
            this.supplier_PostcodeTextBox.Location = new System.Drawing.Point(236, 148);
            this.supplier_PostcodeTextBox.Name = "supplier_PostcodeTextBox";
            this.supplier_PostcodeTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_PostcodeTextBox.TabIndex = 7;
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
            // supplier_TelTextBox
            // 
            this.supplier_TelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Supplier_Tel", true));
            this.supplier_TelTextBox.Location = new System.Drawing.Point(236, 174);
            this.supplier_TelTextBox.Name = "supplier_TelTextBox";
            this.supplier_TelTextBox.Size = new System.Drawing.Size(681, 20);
            this.supplier_TelTextBox.TabIndex = 9;
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
            // product_TypeTextBox1
            // 
            this.product_TypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource1, "Product_Type", true));
            this.product_TypeTextBox1.Location = new System.Drawing.Point(236, 200);
            this.product_TypeTextBox1.Name = "product_TypeTextBox1";
            this.product_TypeTextBox1.Size = new System.Drawing.Size(681, 20);
            this.product_TypeTextBox1.TabIndex = 11;
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
            this.bindingNavigator3.Size = new System.Drawing.Size(1090, 25);
            this.bindingNavigator3.TabIndex = 12;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1194, 558);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Stock.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.Suppliers.ResumeLayout(false);
            this.Suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);

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

        private System.Windows.Forms.TabControl Stock;
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
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Label product_TypeLabel;
        private System.Windows.Forms.TextBox product_TypeTextBox;
        private System.Windows.Forms.Label product_NameLabel;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.Label supplier_IDLabel;
        private System.Windows.Forms.TextBox supplier_IDTextBox;
        private System.Windows.Forms.Label product_PriceLabel;
        private System.Windows.Forms.TextBox product_PriceTextBox;
        private System.Windows.Forms.Label product_Stock_LevelLabel;
        private System.Windows.Forms.TextBox product_Stock_LevelTextBox;
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
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox supplier_AddressTextBox;
        private System.Windows.Forms.TextBox supplier_PostcodeTextBox;
        private System.Windows.Forms.TextBox supplier_TelTextBox;
        private System.Windows.Forms.TextBox product_TypeTextBox1;
    }
}

