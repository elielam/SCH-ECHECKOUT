namespace e_checkout
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.buttonCaisse = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonHistorique, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCaisse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHistorique.Location = new System.Drawing.Point(403, 227);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(395, 219);
            this.buttonHistorique.TabIndex = 3;
            this.buttonHistorique.Text = "HISTORIQUE DES COMMANDES";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // buttonCaisse
            // 
            this.buttonCaisse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCaisse.Location = new System.Drawing.Point(3, 227);
            this.buttonCaisse.Name = "buttonCaisse";
            this.buttonCaisse.Size = new System.Drawing.Size(394, 219);
            this.buttonCaisse.TabIndex = 2;
            this.buttonCaisse.Text = "CAISSE";
            this.buttonCaisse.UseVisualStyleBackColor = true;
            // 
            // buttonStock
            // 
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStock.Location = new System.Drawing.Point(3, 3);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(394, 218);
            this.buttonStock.TabIndex = 1;
            this.buttonStock.Text = "STOCK";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUser.Location = new System.Drawing.Point(403, 3);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(395, 218);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "USER";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonHistorique;
        private System.Windows.Forms.Button buttonCaisse;
        private System.Windows.Forms.Button buttonStock;
    }
}