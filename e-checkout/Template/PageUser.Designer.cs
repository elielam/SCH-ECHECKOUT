namespace e_checkout
{
    partial class pageUser
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.groupBoxCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(9, 10);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 28);
            this.buttonHome.TabIndex = 0;
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
            this.labelTitle.Text = "GESTION DES STOCKS";
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
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(10, 41);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(581, 309);
            this.dataGridViewUser.TabIndex = 5;
            // 
            // pageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 414);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.buttonHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pageUser";
            this.Text = "Gestion des Users";
            this.Load += new System.EventHandler(this.pageUser_Load);
            this.groupBoxCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewUser;
    }
}