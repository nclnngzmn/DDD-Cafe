namespace New_UI_draft
{
    partial class MAINFORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewreceipt = new System.Windows.Forms.DataGridView();
            this.cashierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReceiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cAFEDataSet = new New_UI_draft.CAFEDataSet();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dDDCAFEDataSet = new New_UI_draft.CAFEDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldatepurchase = new System.Windows.Forms.Label();
            this.txtcashier = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblamountreceivechange = new System.Windows.Forms.Label();
            this.lblreceiptar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblreceipttotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lablar = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblcashiername = new System.Windows.Forms.Label();
            this.bnprintreceipt = new System.Windows.Forms.Button();
            this.bnexit = new System.Windows.Forms.Button();
            this.bnpay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.txtamountreceive = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bndeleteorder = new System.Windows.Forms.Button();
            this.dataGridVieworder = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnaddorder = new System.Windows.Forms.Button();
            this.dataGridViewproducts = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.lblprodname = new System.Windows.Forms.Label();
            this.comboboxproducts = new System.Windows.Forms.ComboBox();
            this.dddcafeDataSet1 = new New_UI_draft.CAFEDataSet();
            this.productTableAdapter = new New_UI_draft.CAFEDataSetTableAdapters.ProductTableAdapter();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new New_UI_draft.CAFEDataSetTableAdapters.OrdersTableAdapter();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bncomputesubtotal = new System.Windows.Forms.Button();
            this.bnordercheckout = new System.Windows.Forms.Button();
            this.txtvoid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TOP = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.maxi = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bnfintransaction = new System.Windows.Forms.Button();
            this.receiptTableAdapter = new New_UI_draft.CAFEDataSetTableAdapters.ReceiptTableAdapter();
            this.productTableAdapter1 = new New_UI_draft.CAFEDataSetTableAdapters.ProductTableAdapter();
            this.ordersTableAdapter1 = new New_UI_draft.CAFEDataSetTableAdapters.OrdersTableAdapter();
            this.receiptTableAdapter1 = new New_UI_draft.CAFEDataSetTableAdapters.ReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDCAFEDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dddcafeDataSet1)).BeginInit();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewreceipt
            // 
            this.dataGridViewreceipt.AutoGenerateColumns = false;
            this.dataGridViewreceipt.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewreceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewreceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashierIdDataGridViewTextBoxColumn,
            this.receiptIdDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn,
            this.dateOfPurchaseDataGridViewTextBoxColumn,
            this.amountReceiveDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn});
            this.dataGridViewreceipt.DataSource = this.receiptBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewreceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewreceipt.GridColor = System.Drawing.Color.Linen;
            this.dataGridViewreceipt.Location = new System.Drawing.Point(713, 214);
            this.dataGridViewreceipt.Name = "dataGridViewreceipt";
            this.dataGridViewreceipt.RowHeadersVisible = false;
            this.dataGridViewreceipt.Size = new System.Drawing.Size(240, 514);
            this.dataGridViewreceipt.TabIndex = 44;
            // 
            // cashierIdDataGridViewTextBoxColumn
            // 
            this.cashierIdDataGridViewTextBoxColumn.DataPropertyName = "cashierId";
            this.cashierIdDataGridViewTextBoxColumn.HeaderText = "cashierId";
            this.cashierIdDataGridViewTextBoxColumn.Name = "cashierIdDataGridViewTextBoxColumn";
            this.cashierIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptIdDataGridViewTextBoxColumn1
            // 
            this.receiptIdDataGridViewTextBoxColumn1.DataPropertyName = "receiptId";
            this.receiptIdDataGridViewTextBoxColumn1.HeaderText = "receiptId";
            this.receiptIdDataGridViewTextBoxColumn1.Name = "receiptIdDataGridViewTextBoxColumn1";
            this.receiptIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dateOfPurchaseDataGridViewTextBoxColumn
            // 
            this.dateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "dateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "dateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.Name = "dateOfPurchaseDataGridViewTextBoxColumn";
            // 
            // amountReceiveDataGridViewTextBoxColumn
            // 
            this.amountReceiveDataGridViewTextBoxColumn.DataPropertyName = "amountReceive";
            this.amountReceiveDataGridViewTextBoxColumn.HeaderText = "amountReceive";
            this.amountReceiveDataGridViewTextBoxColumn.Name = "amountReceiveDataGridViewTextBoxColumn";
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            // 
            // receiptBindingSource1
            // 
            this.receiptBindingSource1.DataMember = "Receipt";
            this.receiptBindingSource1.DataSource = this.cAFEDataSet;
            // 
            // cAFEDataSet
            // 
            this.cAFEDataSet.DataSetName = "CAFEDataSet";
            this.cAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dDDCAFEDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dDDCAFEDataSet
            // 
            this.dDDCAFEDataSet.DataSetName = "DDDCAFEDataSet";
            this.dDDCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centie ", 12F);
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(710, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Change";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldatepurchase);
            this.groupBox1.Controls.Add(this.txtcashier);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblamountreceivechange);
            this.groupBox1.Controls.Add(this.lblreceiptar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblreceipttotal);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lablar);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblcashiername);
            this.groupBox1.Font = new System.Drawing.Font("Centie ", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(994, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 626);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVOICE";
            // 
            // lbldatepurchase
            // 
            this.lbldatepurchase.AutoSize = true;
            this.lbldatepurchase.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatepurchase.Location = new System.Drawing.Point(171, 71);
            this.lbldatepurchase.Name = "lbldatepurchase";
            this.lbldatepurchase.Size = new System.Drawing.Size(41, 16);
            this.lbldatepurchase.TabIndex = 58;
            this.lbldatepurchase.Text = "DATE";
            // 
            // txtcashier
            // 
            this.txtcashier.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashier.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtcashier.Location = new System.Drawing.Point(27, 65);
            this.txtcashier.Name = "txtcashier";
            this.txtcashier.Size = new System.Drawing.Size(100, 22);
            this.txtcashier.TabIndex = 57;
            this.txtcashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Centie ", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QTY,
            this.productname,
            this.subtotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Centie ", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(9, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 399);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // productname
            // 
            this.productname.HeaderText = "PRODUCT NAME";
            this.productname.Name = "productname";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            // 
            // lblamountreceivechange
            // 
            this.lblamountreceivechange.AutoSize = true;
            this.lblamountreceivechange.Location = new System.Drawing.Point(250, 584);
            this.lblamountreceivechange.Name = "lblamountreceivechange";
            this.lblamountreceivechange.Size = new System.Drawing.Size(42, 13);
            this.lblamountreceivechange.TabIndex = 8;
            this.lblamountreceivechange.Text = "00.00";
            // 
            // lblreceiptar
            // 
            this.lblreceiptar.AutoSize = true;
            this.lblreceiptar.Location = new System.Drawing.Point(250, 565);
            this.lblreceiptar.Name = "lblreceiptar";
            this.lblreceiptar.Size = new System.Drawing.Size(42, 13);
            this.lblreceiptar.TabIndex = 7;
            this.lblreceiptar.Text = "00.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 582);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Change";
            // 
            // lblreceipttotal
            // 
            this.lblreceipttotal.AutoSize = true;
            this.lblreceipttotal.Location = new System.Drawing.Point(250, 541);
            this.lblreceipttotal.Name = "lblreceipttotal";
            this.lblreceipttotal.Size = new System.Drawing.Size(42, 13);
            this.lblreceipttotal.TabIndex = 5;
            this.lblreceipttotal.Text = "00.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 529);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Total";
            // 
            // lablar
            // 
            this.lablar.AutoSize = true;
            this.lablar.Location = new System.Drawing.Point(40, 552);
            this.lablar.Name = "lablar";
            this.lablar.Size = new System.Drawing.Size(105, 13);
            this.lablar.TabIndex = 3;
            this.lablar.Text = "Amount Receive";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Centie ", 12F);
            this.lbldate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbldate.Location = new System.Drawing.Point(171, 45);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(149, 16);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "date of purchase :";
            // 
            // lblcashiername
            // 
            this.lblcashiername.AutoSize = true;
            this.lblcashiername.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashiername.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblcashiername.Location = new System.Drawing.Point(24, 45);
            this.lblcashiername.Name = "lblcashiername";
            this.lblcashiername.Size = new System.Drawing.Size(91, 16);
            this.lblcashiername.TabIndex = 1;
            this.lblcashiername.Text = "cashier ID :";
            this.lblcashiername.Click += new System.EventHandler(this.lblcashiername_Click);
            // 
            // bnprintreceipt
            // 
            this.bnprintreceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnprintreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnprintreceipt.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprintreceipt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnprintreceipt.Location = new System.Drawing.Point(778, 609);
            this.bnprintreceipt.Name = "bnprintreceipt";
            this.bnprintreceipt.Size = new System.Drawing.Size(119, 33);
            this.bnprintreceipt.TabIndex = 47;
            this.bnprintreceipt.Text = "Print Receipt";
            this.bnprintreceipt.UseVisualStyleBackColor = true;
            // 
            // bnexit
            // 
            this.bnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnexit.Font = new System.Drawing.Font("Centie ", 13F);
            this.bnexit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnexit.Location = new System.Drawing.Point(1232, 704);
            this.bnexit.Name = "bnexit";
            this.bnexit.Size = new System.Drawing.Size(73, 34);
            this.bnexit.TabIndex = 46;
            this.bnexit.Text = "Exit";
            this.bnexit.UseVisualStyleBackColor = true;
            this.bnexit.Click += new System.EventHandler(this.Bnexit_Click);
            // 
            // bnpay
            // 
            this.bnpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnpay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnpay.Font = new System.Drawing.Font("Centie ", 13F);
            this.bnpay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnpay.Location = new System.Drawing.Point(893, 73);
            this.bnpay.Name = "bnpay";
            this.bnpay.Size = new System.Drawing.Size(74, 36);
            this.bnpay.TabIndex = 41;
            this.bnpay.Text = "Pay";
            this.bnpay.UseVisualStyleBackColor = true;
            this.bnpay.Click += new System.EventHandler(this.Bnpay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Centie ", 12F);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(710, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "Amount\r\nReceived";
            // 
            // txtchange
            // 
            this.txtchange.BackColor = System.Drawing.Color.Linen;
            this.txtchange.Font = new System.Drawing.Font("Centie ", 12F);
            this.txtchange.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtchange.Location = new System.Drawing.Point(816, 147);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(113, 25);
            this.txtchange.TabIndex = 39;
            this.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtamountreceive
            // 
            this.txtamountreceive.Font = new System.Drawing.Font("Centie ", 12F);
            this.txtamountreceive.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtamountreceive.Location = new System.Drawing.Point(816, 94);
            this.txtamountreceive.Name = "txtamountreceive";
            this.txtamountreceive.Size = new System.Drawing.Size(37, 25);
            this.txtamountreceive.TabIndex = 38;
            this.txtamountreceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Linen;
            this.txttotal.Font = new System.Drawing.Font("Centie ", 12F);
            this.txttotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txttotal.Location = new System.Drawing.Point(816, 63);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(37, 25);
            this.txttotal.TabIndex = 37;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centie ", 12F);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(710, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total";
            // 
            // bndeleteorder
            // 
            this.bndeleteorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bndeleteorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bndeleteorder.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bndeleteorder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bndeleteorder.Location = new System.Drawing.Point(537, 113);
            this.bndeleteorder.Name = "bndeleteorder";
            this.bndeleteorder.Size = new System.Drawing.Size(85, 36);
            this.bndeleteorder.TabIndex = 35;
            this.bndeleteorder.Text = "delete order";
            this.bndeleteorder.UseVisualStyleBackColor = true;
            this.bndeleteorder.Click += new System.EventHandler(this.Bndeleteorder_Click);
            // 
            // dataGridVieworder
            // 
            this.dataGridVieworder.AutoGenerateColumns = false;
            this.dataGridVieworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridVieworder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVieworder.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Centie ", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieworder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridVieworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieworder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn1,
            this.receiptIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.dataGridVieworder.DataSource = this.ordersBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieworder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridVieworder.GridColor = System.Drawing.Color.Linen;
            this.dataGridVieworder.Location = new System.Drawing.Point(408, 214);
            this.dataGridVieworder.Name = "dataGridVieworder";
            this.dataGridVieworder.RowHeadersVisible = false;
            this.dataGridVieworder.Size = new System.Drawing.Size(260, 514);
            this.dataGridVieworder.TabIndex = 32;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "orderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 84;
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn1.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            this.productIdDataGridViewTextBoxColumn1.Width = 102;
            // 
            // receiptIdDataGridViewTextBoxColumn
            // 
            this.receiptIdDataGridViewTextBoxColumn.DataPropertyName = "receiptId";
            this.receiptIdDataGridViewTextBoxColumn.HeaderText = "receiptId";
            this.receiptIdDataGridViewTextBoxColumn.Name = "receiptIdDataGridViewTextBoxColumn";
            this.receiptIdDataGridViewTextBoxColumn.Width = 94;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 96;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.Width = 95;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.cAFEDataSet;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bindingSource1;
            // 
            // bnaddorder
            // 
            this.bnaddorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnaddorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnaddorder.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnaddorder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnaddorder.Location = new System.Drawing.Point(401, 49);
            this.bnaddorder.Name = "bnaddorder";
            this.bnaddorder.Size = new System.Drawing.Size(85, 42);
            this.bnaddorder.TabIndex = 31;
            this.bnaddorder.Text = "add order";
            this.bnaddorder.UseVisualStyleBackColor = true;
            this.bnaddorder.Click += new System.EventHandler(this.Bnaddorder_Click);
            // 
            // dataGridViewproducts
            // 
            this.dataGridViewproducts.AllowUserToDeleteRows = false;
            this.dataGridViewproducts.AutoGenerateColumns = false;
            this.dataGridViewproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewproducts.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewproducts.DataSource = this.productBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewproducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewproducts.GridColor = System.Drawing.Color.Linen;
            this.dataGridViewproducts.Location = new System.Drawing.Point(28, 214);
            this.dataGridViewproducts.Name = "dataGridViewproducts";
            this.dataGridViewproducts.ReadOnly = true;
            this.dataGridViewproducts.RowHeadersVisible = false;
            this.dataGridViewproducts.Size = new System.Drawing.Size(356, 514);
            this.dataGridViewproducts.TabIndex = 29;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 102;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 123;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 73;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.cAFEDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bindingSource1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(32, 113);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(53, 22);
            this.txtquantity.TabIndex = 27;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.TextChanged += new System.EventHandler(this.Txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblprodname.Location = new System.Drawing.Point(122, 44);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(116, 16);
            this.lblprodname.TabIndex = 26;
            this.lblprodname.Text = "Product Name";
            // 
            // comboboxproducts
            // 
            this.comboboxproducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxproducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxproducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboboxproducts.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxproducts.ForeColor = System.Drawing.Color.Sienna;
            this.comboboxproducts.FormattingEnabled = true;
            this.comboboxproducts.Location = new System.Drawing.Point(25, 63);
            this.comboboxproducts.Name = "comboboxproducts";
            this.comboboxproducts.Size = new System.Drawing.Size(307, 21);
            this.comboboxproducts.TabIndex = 25;
            this.comboboxproducts.SelectedIndexChanged += new System.EventHandler(this.Comboboxproducts_SelectedIndexChanged);
            this.comboboxproducts.DropDownStyleChanged += new System.EventHandler(this.Comboboxproducts_SelectedIndexChanged);
            // 
            // dddcafeDataSet1
            // 
            this.dddcafeDataSet1.DataSetName = "DDDCAFEDataSet";
            this.dddcafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.Color.Linen;
            this.txtsubtotal.Font = new System.Drawing.Font("Centie ", 12F);
            this.txtsubtotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtsubtotal.Location = new System.Drawing.Point(265, 113);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(36, 25);
            this.txtsubtotal.TabIndex = 50;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Centie ", 12F);
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(262, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "subtotal";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // txtproductprice
            // 
            this.txtproductprice.BackColor = System.Drawing.Color.Linen;
            this.txtproductprice.Font = new System.Drawing.Font("Centie ", 12F);
            this.txtproductprice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtproductprice.Location = new System.Drawing.Point(139, 114);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(36, 25);
            this.txtproductprice.TabIndex = 52;
            this.txtproductprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Centie ", 12F);
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(122, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "product price";
            // 
            // bncomputesubtotal
            // 
            this.bncomputesubtotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bncomputesubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bncomputesubtotal.Font = new System.Drawing.Font("Centie ", 10F);
            this.bncomputesubtotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bncomputesubtotal.Location = new System.Drawing.Point(139, 151);
            this.bncomputesubtotal.Name = "bncomputesubtotal";
            this.bncomputesubtotal.Size = new System.Drawing.Size(86, 47);
            this.bncomputesubtotal.TabIndex = 53;
            this.bncomputesubtotal.Text = "Compute Subtotal";
            this.bncomputesubtotal.UseVisualStyleBackColor = true;
            this.bncomputesubtotal.Click += new System.EventHandler(this.bncomputesubtotal_Click);
            // 
            // bnordercheckout
            // 
            this.bnordercheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnordercheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnordercheckout.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnordercheckout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnordercheckout.Location = new System.Drawing.Point(403, 106);
            this.bnordercheckout.Name = "bnordercheckout";
            this.bnordercheckout.Size = new System.Drawing.Size(85, 44);
            this.bnordercheckout.TabIndex = 54;
            this.bnordercheckout.Text = "order checkout";
            this.bnordercheckout.UseVisualStyleBackColor = true;
            this.bnordercheckout.Click += new System.EventHandler(this.Bnordercheckout_Click);
            // 
            // txtvoid
            // 
            this.txtvoid.Location = new System.Drawing.Point(506, 84);
            this.txtvoid.Name = "txtvoid";
            this.txtvoid.Size = new System.Drawing.Size(155, 20);
            this.txtvoid.TabIndex = 55;
            this.txtvoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Centie ", 12F);
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(492, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "hello ma\'am pa-void pls";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(813, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 57;
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.SaddleBrown;
            this.TOP.Controls.Add(this.mini);
            this.TOP.Controls.Add(this.close);
            this.TOP.Controls.Add(this.maxi);
            this.TOP.Location = new System.Drawing.Point(-1, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(1376, 25);
            this.TOP.TabIndex = 58;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = global::New_UI_draft.Properties.Resources.maxi;
            this.mini.Location = new System.Drawing.Point(55, 4);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(16, 16);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 61;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::New_UI_draft.Properties.Resources.close2;
            this.close.Location = new System.Drawing.Point(11, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 59;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // maxi
            // 
            this.maxi.BackColor = System.Drawing.Color.Transparent;
            this.maxi.Image = global::New_UI_draft.Properties.Resources.mini;
            this.maxi.Location = new System.Drawing.Point(33, 4);
            this.maxi.MaximumSize = new System.Drawing.Size(16, 16);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(16, 16);
            this.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxi.TabIndex = 60;
            this.maxi.TabStop = false;
            this.maxi.Click += new System.EventHandler(this.Maxi_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TOP;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centie ", 13F);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(121, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "₱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Centie ", 13F);
            this.label16.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label16.Location = new System.Drawing.Point(247, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 60;
            this.label16.Text = "₱";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Centie ", 12F);
            this.label17.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label17.Location = new System.Drawing.Point(175, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 16);
            this.label17.TabIndex = 61;
            this.label17.Text = ".00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Centie ", 12F);
            this.label18.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label18.Location = new System.Drawing.Point(304, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 62;
            this.label18.Text = ".00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Centie ", 13F);
            this.label19.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label19.Location = new System.Drawing.Point(792, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 19);
            this.label19.TabIndex = 63;
            this.label19.Text = "₱";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Centie ", 13F);
            this.label20.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label20.Location = new System.Drawing.Point(792, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 19);
            this.label20.TabIndex = 64;
            this.label20.Text = "₱";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Centie ", 13F);
            this.label21.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label21.Location = new System.Drawing.Point(792, 151);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 19);
            this.label21.TabIndex = 65;
            this.label21.Text = "₱";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Centie ", 12F);
            this.label22.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label22.Location = new System.Drawing.Point(710, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 16);
            this.label22.TabIndex = 66;
            this.label22.Text = "-------------------------";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Centie ", 12F);
            this.label23.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label23.Location = new System.Drawing.Point(855, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 16);
            this.label23.TabIndex = 67;
            this.label23.Text = ".00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Centie ", 12F);
            this.label24.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label24.Location = new System.Drawing.Point(855, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 16);
            this.label24.TabIndex = 68;
            this.label24.Text = ".00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Centie ", 12F);
            this.label25.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label25.Location = new System.Drawing.Point(935, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 16);
            this.label25.TabIndex = 69;
            this.label25.Text = ".00";
            // 
            // bnfintransaction
            // 
            this.bnfintransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfintransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnfintransaction.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfintransaction.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bnfintransaction.Location = new System.Drawing.Point(1021, 704);
            this.bnfintransaction.Name = "bnfintransaction";
            this.bnfintransaction.Size = new System.Drawing.Size(154, 33);
            this.bnfintransaction.TabIndex = 70;
            this.bnfintransaction.Text = "Finish Transaction";
            this.bnfintransaction.UseVisualStyleBackColor = true;
            this.bnfintransaction.Click += new System.EventHandler(this.Bnfintransaction_Click);
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptTableAdapter1
            // 
            this.receiptTableAdapter1.ClearBeforeFill = true;
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1368, 757);
            this.Controls.Add(this.bnfintransaction);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtvoid);
            this.Controls.Add(this.bnordercheckout);
            this.Controls.Add(this.bncomputesubtotal);
            this.Controls.Add(this.txtproductprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewreceipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnprintreceipt);
            this.Controls.Add(this.bnexit);
            this.Controls.Add(this.bnpay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.txtamountreceive);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bndeleteorder);
            this.Controls.Add(this.dataGridVieworder);
            this.Controls.Add(this.bnaddorder);
            this.Controls.Add(this.dataGridViewproducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.comboboxproducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAINFORM";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MAINFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDDCAFEDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dddcafeDataSet1)).EndInit();
            this.TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewreceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblamountreceivechange;
        private System.Windows.Forms.Label lblreceiptar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblreceipttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lablar;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblcashiername;
        private System.Windows.Forms.Button bnprintreceipt;
        private System.Windows.Forms.Button bnexit;
        private System.Windows.Forms.Button bnpay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.TextBox txtamountreceive;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bndeleteorder;
        private System.Windows.Forms.DataGridView dataGridVieworder;
        private System.Windows.Forms.Button bnaddorder;
        private System.Windows.Forms.DataGridView dataGridViewproducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.ComboBox comboboxproducts;
        private CAFEDataSet dDDCAFEDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CAFEDataSet dddcafeDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CAFEDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CAFEDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bncomputesubtotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button bnordercheckout;
        private System.Windows.Forms.TextBox txtvoid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcashier;
        private System.Windows.Forms.Panel TOP;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox maxi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button bnfintransaction;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private CAFEDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfPurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReceiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbldatepurchase;
        private CAFEDataSet cAFEDataSet;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private CAFEDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private CAFEDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource receiptBindingSource1;
        private CAFEDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter1;
    }
}