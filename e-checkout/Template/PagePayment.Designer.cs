namespace e_checkout
{
    partial class PagePayment
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.labelVendor = new System.Windows.Forms.Label();
            this.labelItemsNumber = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClientAdress = new System.Windows.Forms.Label();
            this.labelClientCity = new System.Windows.Forms.Label();
            this.groupBoxCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(9, 10);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 28);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "<";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(70, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(467, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "GESTION DES FACTURES";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Controls.Add(this.buttonUpdate);
            this.groupBoxCommand.Controls.Add(this.buttonAdd);
            this.groupBoxCommand.Controls.Add(this.buttonDelete);
            this.groupBoxCommand.Location = new System.Drawing.Point(10, 356);
            this.groupBoxCommand.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCommand.Size = new System.Drawing.Size(581, 51);
            this.groupBoxCommand.TabIndex = 6;
            this.groupBoxCommand.TabStop = false;
            this.groupBoxCommand.Text = "Commands";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(206, 10);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 38);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(331, 9);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 38);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(456, 9);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 38);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(10, 52);
            this.dataGridViewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowTemplate.Height = 24;
            this.dataGridViewPayment.Size = new System.Drawing.Size(233, 102);
            this.dataGridViewPayment.TabIndex = 5;
            // 
            // labelVendor
            // 
            this.labelVendor.Location = new System.Drawing.Point(487, 44);
            this.labelVendor.Name = "labelVendor";
            this.labelVendor.Size = new System.Drawing.Size(100, 23);
            this.labelVendor.TabIndex = 8;
            this.labelVendor.Text = "Vendors";
            this.labelVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelItemsNumber
            // 
            this.labelItemsNumber.Location = new System.Drawing.Point(487, 67);
            this.labelItemsNumber.Name = "labelItemsNumber";
            this.labelItemsNumber.Size = new System.Drawing.Size(100, 23);
            this.labelItemsNumber.TabIndex = 9;
            this.labelItemsNumber.Text = "Nbr Items";
            this.labelItemsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Location = new System.Drawing.Point(487, 90);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "Total €";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(11, 168);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(576, 159);
            this.dataGridViewProducts.TabIndex = 11;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.Location = new System.Drawing.Point(248, 81);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(100, 23);
            this.labelPaymentMethod.TabIndex = 14;
            this.labelPaymentMethod.Text = "Payment Method";
            this.labelPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClientName
            // 
            this.labelClientName.Location = new System.Drawing.Point(248, 58);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(100, 23);
            this.labelClientName.TabIndex = 12;
            this.labelClientName.Text = "Name Client";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClientAdress
            // 
            this.labelClientAdress.Location = new System.Drawing.Point(248, 104);
            this.labelClientAdress.Name = "labelClientAdress";
            this.labelClientAdress.Size = new System.Drawing.Size(100, 23);
            this.labelClientAdress.TabIndex = 15;
            this.labelClientAdress.Text = "Adress Client";
            this.labelClientAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClientCity
            // 
            this.labelClientCity.Location = new System.Drawing.Point(248, 126);
            this.labelClientCity.Name = "labelClientCity";
            this.labelClientCity.Size = new System.Drawing.Size(100, 23);
            this.labelClientCity.TabIndex = 16;
            this.labelClientCity.Text = "City Client";
            this.labelClientCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 414);
            this.Controls.Add(this.labelClientCity);
            this.Controls.Add(this.labelClientAdress);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelItemsNumber);
            this.Controls.Add(this.labelVendor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.buttonHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagePayment";
            this.Text = "Historique des commandes";
            this.Load += new System.EventHandler(this.PagePayment_Load);
            this.groupBoxCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.Label labelVendor;
        private System.Windows.Forms.Label labelItemsNumber;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientAdress;
        private System.Windows.Forms.Label labelClientCity;
    }
}