namespace New_UI_draft
{
    partial class CASHIERLOGIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttnlogin = new System.Windows.Forms.Button();
            this.lblcashierid = new System.Windows.Forms.Label();
            this.lclcashierlogin = new System.Windows.Forms.Label();
            this.txtcashierid = new System.Windows.Forms.TextBox();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDDDCAFE = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TOP = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.maxi = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cashierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cAFEDataSet = new New_UI_draft.CAFEDataSet();
            this.cashierTableAdapter = new New_UI_draft.CAFEDataSetTableAdapters.CashierTableAdapter();           
            this.cashierBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cashierTableAdapter1 = new New_UI_draft.CAFEDataSetTableAdapters.CashierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnlogin
            // 
            this.bttnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnlogin.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bttnlogin.Location = new System.Drawing.Point(270, 207);
            this.bttnlogin.Name = "bttnlogin";
            this.bttnlogin.Size = new System.Drawing.Size(81, 26);
            this.bttnlogin.TabIndex = 13;
            this.bttnlogin.Text = "LOGIN";
            this.bttnlogin.UseVisualStyleBackColor = true;
            this.bttnlogin.Click += new System.EventHandler(this.Bttnlogin_Click_1);
            // 
            // lblcashierid
            // 
            this.lblcashierid.AutoSize = true;
            this.lblcashierid.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashierid.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblcashierid.Location = new System.Drawing.Point(152, 169);
            this.lblcashierid.Name = "lblcashierid";
            this.lblcashierid.Size = new System.Drawing.Size(86, 16);
            this.lblcashierid.TabIndex = 12;
            this.lblcashierid.Text = "Cashier ID:";
            // 
            // lclcashierlogin
            // 
            this.lclcashierlogin.AutoSize = true;
            this.lclcashierlogin.Font = new System.Drawing.Font("Centie ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclcashierlogin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lclcashierlogin.Location = new System.Drawing.Point(240, 101);
            this.lclcashierlogin.Name = "lclcashierlogin";
            this.lclcashierlogin.Size = new System.Drawing.Size(134, 21);
            this.lclcashierlogin.TabIndex = 11;
            this.lclcashierlogin.Text = "Cashier Login";
            // 
            // txtcashierid
            // 
            this.txtcashierid.Font = new System.Drawing.Font("Centie ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashierid.Location = new System.Drawing.Point(244, 165);
            this.txtcashierid.Name = "txtcashierid";
            this.txtcashierid.Size = new System.Drawing.Size(153, 25);
            this.txtcashierid.TabIndex = 10;
            this.txtcashierid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.bindingSource1;
            // 
            // lblDDDCAFE
            // 
            this.lblDDDCAFE.AutoSize = true;
            this.lblDDDCAFE.Font = new System.Drawing.Font("Alakita", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDDCAFE.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDDDCAFE.Location = new System.Drawing.Point(206, 39);
            this.lblDDDCAFE.Name = "lblDDDCAFE";
            this.lblDDDCAFE.Size = new System.Drawing.Size(208, 62);
            this.lblDDDCAFE.TabIndex = 16;
            this.lblDDDCAFE.Text = "DDD Cafe";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TOP;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.SaddleBrown;
            this.TOP.Controls.Add(this.mini);
            this.TOP.Controls.Add(this.close);
            this.TOP.Controls.Add(this.maxi);
            this.TOP.Location = new System.Drawing.Point(-2, -1);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(625, 31);
            this.TOP.TabIndex = 21;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = global::New_UI_draft.Properties.Resources.maxi;
            this.mini.Location = new System.Drawing.Point(55, 8);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(16, 16);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 20;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::New_UI_draft.Properties.Resources.close2;
            this.close.Location = new System.Drawing.Point(11, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 18;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // maxi
            // 
            this.maxi.BackColor = System.Drawing.Color.Transparent;
            this.maxi.Image = global::New_UI_draft.Properties.Resources.mini;
            this.maxi.Location = new System.Drawing.Point(33, 8);
            this.maxi.MaximumSize = new System.Drawing.Size(16, 16);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(16, 16);
            this.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxi.TabIndex = 19;
            this.maxi.TabStop = false;
            this.maxi.Click += new System.EventHandler(this.maxi_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cashierBindingSource1
            // 
            this.cashierBindingSource1.DataMember = "Cashier";
            this.cashierBindingSource1.DataSource = this.bindingSource1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.cashierIdDataGridViewTextBoxColumn,
            this.cashierNameDataGridViewTextBoxColumn,
            this.cashierLastNameDataGridViewTextBoxColumn,
            this.cashierStatusDataGridViewTextBoxColumn,
            this.dateStartedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cashierBindingSource2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Centie ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.Sienna;
            this.dataGridView1.Location = new System.Drawing.Point(18, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(527, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // cashierIdDataGridViewTextBoxColumn
            // 
            this.cashierIdDataGridViewTextBoxColumn.DataPropertyName = "cashierId";
            this.cashierIdDataGridViewTextBoxColumn.HeaderText = "cashierId";
            this.cashierIdDataGridViewTextBoxColumn.Name = "cashierIdDataGridViewTextBoxColumn";
            this.cashierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashierIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cashierIdDataGridViewTextBoxColumn.Width = 87;
            // 
            // cashierNameDataGridViewTextBoxColumn
            // 
            this.cashierNameDataGridViewTextBoxColumn.DataPropertyName = "cashierName";
            this.cashierNameDataGridViewTextBoxColumn.HeaderText = "cashierName";
            this.cashierNameDataGridViewTextBoxColumn.Name = "cashierNameDataGridViewTextBoxColumn";
            // 
            // cashierLastNameDataGridViewTextBoxColumn
            // 
            this.cashierLastNameDataGridViewTextBoxColumn.DataPropertyName = "cashierLastName";
            this.cashierLastNameDataGridViewTextBoxColumn.HeaderText = "cashierLastName";
            this.cashierLastNameDataGridViewTextBoxColumn.Name = "cashierLastNameDataGridViewTextBoxColumn";
            this.cashierLastNameDataGridViewTextBoxColumn.Width = 136;
            // 
            // cashierStatusDataGridViewTextBoxColumn
            // 
            this.cashierStatusDataGridViewTextBoxColumn.DataPropertyName = "cashierStatus";
            this.cashierStatusDataGridViewTextBoxColumn.HeaderText = "cashierStatus";
            this.cashierStatusDataGridViewTextBoxColumn.Name = "cashierStatusDataGridViewTextBoxColumn";
            // 
            // dateStartedDataGridViewTextBoxColumn
            // 
            this.dateStartedDataGridViewTextBoxColumn.DataPropertyName = "dateStarted";
            this.dateStartedDataGridViewTextBoxColumn.HeaderText = "dateStarted";
            this.dateStartedDataGridViewTextBoxColumn.Name = "dateStartedDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cAFEDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dDDCAFEDataSet
            // 
            this.cAFEDataSet.DataSetName = "DDDCAFEDataSet";
            this.cAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // cAFEDataSet
            // 
            this.cAFEDataSet.DataSetName = "CAFEDataSet";
            this.cAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierBindingSource2
            // 
            this.cashierBindingSource2.DataMember = "Cashier";
            this.cashierBindingSource2.DataSource = this.cAFEDataSet;
            // 
            // cashierTableAdapter1
            // 
            this.cashierTableAdapter1.ClearBeforeFill = true;
            // 
            // CASHIERLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(571, 459);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.lblDDDCAFE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnlogin);
            this.Controls.Add(this.lblcashierid);
            this.Controls.Add(this.lclcashierlogin);
            this.Controls.Add(this.txtcashierid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CASHIERLOGIN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            this.TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnlogin;
        private System.Windows.Forms.Label lblcashierid;
        private System.Windows.Forms.Label lclcashierlogin;
        private System.Windows.Forms.TextBox txtcashierid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CAFEDataSet cAFEDataSet;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private CAFEDataSetTableAdapters.CashierTableAdapter cashierTableAdapter;
        private System.Windows.Forms.Label lblDDDCAFE;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox maxi;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.BindingSource cashierBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartedDataGridViewTextBoxColumn;        
        private System.Windows.Forms.BindingSource cashierBindingSource2;
        private CAFEDataSetTableAdapters.CashierTableAdapter cashierTableAdapter1;
    }
}

