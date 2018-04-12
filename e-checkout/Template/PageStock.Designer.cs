namespace e_checkout
{
    partial class PageStock
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelStock = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.buttonHomeStock = new System.Windows.Forms.Button();
            this.groupBoxCommandStock = new System.Windows.Forms.GroupBox();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.buttonDeleteStock = new System.Windows.Forms.Button();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonHomeProduct = new System.Windows.Forms.Button();
            this.groupBoxCommandProduct = new System.Windows.Forms.GroupBox();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCategory = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.buttonHomeCategory = new System.Windows.Forms.Button();
            this.groupBoxCommandCategory = new System.Windows.Forms.GroupBox();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            this.tableLayoutPanelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.groupBoxCommandStock.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tableLayoutPanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.groupBoxCommandProduct.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.tableLayoutPanelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.groupBoxCommandCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStock);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPageCategory);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Controls.Add(this.tableLayoutPanelStock);
            this.tabPageStock.Location = new System.Drawing.Point(4, 25);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(793, 481);
            this.tabPageStock.TabIndex = 0;
            this.tabPageStock.Text = "Stock";
            this.tabPageStock.UseVisualStyleBackColor = true;
            this.tabPageStock.Click += new System.EventHandler(this.tabPageStock_Click);
            // 
            // tableLayoutPanelStock
            // 
            this.tableLayoutPanelStock.ColumnCount = 1;
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStock.Controls.Add(this.dataGridViewStock, 0, 1);
            this.tableLayoutPanelStock.Controls.Add(this.buttonHomeStock, 0, 0);
            this.tableLayoutPanelStock.Controls.Add(this.groupBoxCommandStock, 0, 2);
            this.tableLayoutPanelStock.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStock.Name = "tableLayoutPanelStock";
            this.tableLayoutPanelStock.RowCount = 3;
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelStock.Size = new System.Drawing.Size(793, 481);
            this.tableLayoutPanelStock.TabIndex = 0;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(787, 368);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // buttonHomeStock
            // 
            this.buttonHomeStock.Location = new System.Drawing.Point(3, 3);
            this.buttonHomeStock.Name = "buttonHomeStock";
            this.buttonHomeStock.Size = new System.Drawing.Size(61, 35);
            this.buttonHomeStock.TabIndex = 1;
            this.buttonHomeStock.Text = "<";
            this.buttonHomeStock.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommandStock
            // 
            this.groupBoxCommandStock.Controls.Add(this.buttonUpdateStock);
            this.groupBoxCommandStock.Controls.Add(this.buttonAddStock);
            this.groupBoxCommandStock.Controls.Add(this.buttonDeleteStock);
            this.groupBoxCommandStock.Location = new System.Drawing.Point(3, 418);
            this.groupBoxCommandStock.Name = "groupBoxCommandStock";
            this.groupBoxCommandStock.Size = new System.Drawing.Size(784, 60);
            this.groupBoxCommandStock.TabIndex = 2;
            this.groupBoxCommandStock.TabStop = false;
            this.groupBoxCommandStock.Text = "Commands";
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(283, 11);
            this.buttonUpdateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(161, 47);
            this.buttonUpdateStock.TabIndex = 5;
            this.buttonUpdateStock.Text = "UPDATE";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Location = new System.Drawing.Point(449, 10);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(161, 47);
            this.buttonAddStock.TabIndex = 4;
            this.buttonAddStock.Text = "ADD";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // buttonDeleteStock
            // 
            this.buttonDeleteStock.Location = new System.Drawing.Point(616, 10);
            this.buttonDeleteStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteStock.Name = "buttonDeleteStock";
            this.buttonDeleteStock.Size = new System.Drawing.Size(161, 47);
            this.buttonDeleteStock.TabIndex = 3;
            this.buttonDeleteStock.Text = "DELETE";
            this.buttonDeleteStock.UseVisualStyleBackColor = true;
            this.buttonDeleteStock.Click += new System.EventHandler(this.buttonDeleteStock_Click);
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.tableLayoutPanelProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(793, 481);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelProduct
            // 
            this.tableLayoutPanelProduct.ColumnCount = 1;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProduct.Controls.Add(this.dataGridViewProduct, 0, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.buttonHomeProduct, 0, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.groupBoxCommandProduct, 0, 2);
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 3;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(793, 481);
            this.tableLayoutPanelProduct.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(787, 368);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // buttonHomeProduct
            // 
            this.buttonHomeProduct.Location = new System.Drawing.Point(3, 3);
            this.buttonHomeProduct.Name = "buttonHomeProduct";
            this.buttonHomeProduct.Size = new System.Drawing.Size(61, 35);
            this.buttonHomeProduct.TabIndex = 1;
            this.buttonHomeProduct.Text = "<";
            this.buttonHomeProduct.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommandProduct
            // 
            this.groupBoxCommandProduct.Controls.Add(this.buttonUpdateProduct);
            this.groupBoxCommandProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxCommandProduct.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxCommandProduct.Location = new System.Drawing.Point(3, 418);
            this.groupBoxCommandProduct.Name = "groupBoxCommandProduct";
            this.groupBoxCommandProduct.Size = new System.Drawing.Size(784, 60);
            this.groupBoxCommandProduct.TabIndex = 2;
            this.groupBoxCommandProduct.TabStop = false;
            this.groupBoxCommandProduct.Text = "Commands";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(283, 11);
            this.buttonUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(161, 47);
            this.buttonUpdateProduct.TabIndex = 5;
            this.buttonUpdateProduct.Text = "UPDATE";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(449, 10);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(161, 47);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "ADD";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(616, 10);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(161, 47);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "DELETE";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.tableLayoutPanelCategory);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(793, 481);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCategory
            // 
            this.tableLayoutPanelCategory.ColumnCount = 1;
            this.tableLayoutPanelCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategory.Controls.Add(this.dataGridViewCategory, 0, 1);
            this.tableLayoutPanelCategory.Controls.Add(this.buttonHomeCategory, 0, 0);
            this.tableLayoutPanelCategory.Controls.Add(this.groupBoxCommandCategory, 0, 2);
            this.tableLayoutPanelCategory.Location = new System.Drawing.Point(-1, 1);
            this.tableLayoutPanelCategory.Name = "tableLayoutPanelCategory";
            this.tableLayoutPanelCategory.RowCount = 3;
            this.tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelCategory.Size = new System.Drawing.Size(793, 481);
            this.tableLayoutPanelCategory.TabIndex = 2;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(787, 368);
            this.dataGridViewCategory.TabIndex = 0;
            // 
            // buttonHomeCategory
            // 
            this.buttonHomeCategory.Location = new System.Drawing.Point(3, 3);
            this.buttonHomeCategory.Name = "buttonHomeCategory";
            this.buttonHomeCategory.Size = new System.Drawing.Size(61, 35);
            this.buttonHomeCategory.TabIndex = 1;
            this.buttonHomeCategory.Text = "<";
            this.buttonHomeCategory.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommandCategory
            // 
            this.groupBoxCommandCategory.Controls.Add(this.buttonUpdateCategory);
            this.groupBoxCommandCategory.Controls.Add(this.buttonAddCategory);
            this.groupBoxCommandCategory.Controls.Add(this.buttonDeleteCategory);
            this.groupBoxCommandCategory.Location = new System.Drawing.Point(3, 418);
            this.groupBoxCommandCategory.Name = "groupBoxCommandCategory";
            this.groupBoxCommandCategory.Size = new System.Drawing.Size(784, 60);
            this.groupBoxCommandCategory.TabIndex = 2;
            this.groupBoxCommandCategory.TabStop = false;
            this.groupBoxCommandCategory.Text = "Commands";
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(284, 11);
            this.buttonUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(161, 47);
            this.buttonUpdateCategory.TabIndex = 5;
            this.buttonUpdateCategory.Text = "UPDATE";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(450, 10);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(161, 47);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "ADD";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(617, 10);
            this.buttonDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(161, 47);
            this.buttonDeleteCategory.TabIndex = 3;
            this.buttonDeleteCategory.Text = "DELETE";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // PageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageStock";
            this.Text = "Gestion du stock";
            this.Load += new System.EventHandler(this.PageStock_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageStock.ResumeLayout(false);
            this.tableLayoutPanelStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.groupBoxCommandStock.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.groupBoxCommandProduct.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tableLayoutPanelCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.groupBoxCommandCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStock;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button buttonHomeStock;
        private System.Windows.Forms.GroupBox groupBoxCommandStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button buttonDeleteStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonHomeProduct;
        private System.Windows.Forms.GroupBox groupBoxCommandProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Button buttonHomeCategory;
        private System.Windows.Forms.GroupBox groupBoxCommandCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
    }
}