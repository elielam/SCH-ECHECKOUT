using e_checkout.Classes;
using System.Data;

namespace e_checkout.Template
{
    partial class UpdateModal
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
        /// 
        

        private void InitializeComponentStock(Stock stock)
        {
            Bdd bdd = new Bdd();
            DataSet productReq = bdd.GetProductById(stock.GetIdProduct());
            Product selectedStockProduct = new Product();
            selectedStockProduct.Init(productReq);

            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.buttonSave);
            this.groupBoxForm.Controls.Add(this.buttonReturn);
            this.groupBoxForm.Controls.Add(this.labelQuantity);
            this.groupBoxForm.Controls.Add(this.labelProduct);
            this.groupBoxForm.Controls.Add(this.labelId);
            this.groupBoxForm.Controls.Add(this.textBoxQuantity);
            this.groupBoxForm.Controls.Add(this.textBoxProduct);
            this.groupBoxForm.Controls.Add(this.textBoxId);
            this.groupBoxForm.Location = new System.Drawing.Point(13, 13);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(455, 305);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Stock";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(90, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(55, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Text = stock.GetId().ToString();
            this.textBoxId.Enabled = false;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(90, 66);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(259, 20);
            this.textBoxProduct.TabIndex = 1;
            this.textBoxProduct.Text = selectedStockProduct.GetLibelle();
            this.textBoxProduct.Enabled = false;

            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(90, 102);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(55, 20);
            this.textBoxQuantity.TabIndex = 2;
            this.textBoxQuantity.Text = stock.GetQuantity().ToString();
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(10, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(74, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProduct
            // 
            this.labelProduct.Location = new System.Drawing.Point(10, 65);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(74, 20);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Product";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Location = new System.Drawing.Point(10, 101);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 20);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(374, 276);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(293, 276);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UpdateModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "UpdateModal";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.UpdateModal_Load);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitializeComponentUser(User user)
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxIsAdmin = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIsAdmin = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.buttonSave);
            this.groupBoxForm.Controls.Add(this.buttonReturn);
            this.groupBoxForm.Controls.Add(this.labelName);
            this.groupBoxForm.Controls.Add(this.labelLastname);
            this.groupBoxForm.Controls.Add(this.labelUsername);
            this.groupBoxForm.Controls.Add(this.labelPassword);
            this.groupBoxForm.Controls.Add(this.labelIsAdmin);
            this.groupBoxForm.Controls.Add(this.labelId);
            this.groupBoxForm.Controls.Add(this.textBoxName);
            this.groupBoxForm.Controls.Add(this.textBoxLastname);
            this.groupBoxForm.Controls.Add(this.textBoxUsername);
            this.groupBoxForm.Controls.Add(this.textBoxPassword);
            this.groupBoxForm.Controls.Add(this.textBoxIsAdmin);
            this.groupBoxForm.Controls.Add(this.textBoxId);
            this.groupBoxForm.Location = new System.Drawing.Point(13, 13);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(455, 305);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "User";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(90, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(55, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Text = user.GetId().ToString();
            this.textBoxId.Enabled = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(259, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = user.GetName();
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(90, 102);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(55, 20);
            this.textBoxLastname.TabIndex = 2;
            this.textBoxLastname.Text = user.GetLastname();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(90, 137);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(55, 20);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = user.GetUsername();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(90, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(55, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxIsAdmin
            // 
            this.textBoxIsAdmin.Location = new System.Drawing.Point(90, 202);
            this.textBoxIsAdmin.Name = "textBoxIsAdmin";
            this.textBoxIsAdmin.Size = new System.Drawing.Size(55, 20);
            this.textBoxIsAdmin.TabIndex = 2;
            this.textBoxIsAdmin.Text = user.GetIsAdmin().ToString();
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(10, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(74, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(10, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastname
            // 
            this.labelLastname.Location = new System.Drawing.Point(10, 101);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(74, 20);
            this.labelLastname.TabIndex = 5;
            this.labelLastname.Text = "Lastname";
            this.labelLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(10, 136);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 20);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(10, 171);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIsAdmin
            // 
            this.labelIsAdmin.Location = new System.Drawing.Point(10, 201);
            this.labelIsAdmin.Name = "labelIsAdmin";
            this.labelIsAdmin.Size = new System.Drawing.Size(74, 20);
            this.labelIsAdmin.TabIndex = 5;
            this.labelIsAdmin.Text = "Admin";
            this.labelIsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(374, 276);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(293, 276);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UpdateModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "UpdateModal";
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.UpdateModal_Load);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitializeComponentProduct(Product product)
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.buttonSave);
            this.groupBoxForm.Controls.Add(this.buttonReturn);
            this.groupBoxForm.Controls.Add(this.labelCategory);
            this.groupBoxForm.Controls.Add(this.labelLibelle);
            this.groupBoxForm.Controls.Add(this.labelPrice);
            this.groupBoxForm.Controls.Add(this.labelId);
            this.groupBoxForm.Controls.Add(this.textBoxCategory);
            this.groupBoxForm.Controls.Add(this.textBoxLibelle);
            this.groupBoxForm.Controls.Add(this.textBoxPrice);
            this.groupBoxForm.Controls.Add(this.textBoxId);
            this.groupBoxForm.Location = new System.Drawing.Point(13, 13);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(455, 305);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Product";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(90, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(55, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Text = product.GetId().ToString();
            this.textBoxId.Enabled = false;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(90, 66);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(259, 20);
            this.textBoxCategory.TabIndex = 1;
            this.textBoxCategory.Text = product.GetIdCategory().ToString();
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(90, 102);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(55, 20);
            this.textBoxLibelle.TabIndex = 2;
            this.textBoxLibelle.Text = product.GetLibelle();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(90, 137);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(55, 20);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.Text = product.GetPrice().ToString();
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(10, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(74, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(10, 65);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(74, 20);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLibelle
            // 
            this.labelLibelle.Location = new System.Drawing.Point(10, 101);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(74, 20);
            this.labelLibelle.TabIndex = 5;
            this.labelLibelle.Text = "Libelle";
            this.labelLibelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(10, 136);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(374, 276);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(293, 276);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UpdateModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "UpdateModal";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateModal_Load);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitializeComponentPayment(Payment payment)
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCart = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCart = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.buttonSave);
            this.groupBoxForm.Controls.Add(this.buttonReturn);
            this.groupBoxForm.Controls.Add(this.labelCart);
            this.groupBoxForm.Controls.Add(this.labelId);
            this.groupBoxForm.Controls.Add(this.textBoxCart);
            this.groupBoxForm.Controls.Add(this.textBoxId);
            this.groupBoxForm.Location = new System.Drawing.Point(13, 13);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(455, 305);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Payment";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(90, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(55, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Text = payment.GetId().ToString();
            this.textBoxId.Enabled = false;
            // 
            // textBoxCart
            // 
            this.textBoxCart.Location = new System.Drawing.Point(90, 66);
            this.textBoxCart.Name = "textBoxCart";
            this.textBoxCart.Size = new System.Drawing.Size(259, 20);
            this.textBoxCart.TabIndex = 1;
            this.textBoxCart.Text = payment.GetIdCart().ToString();
            this.textBoxCart.Enabled = false;
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(10, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(74, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCart
            // 
            this.labelCart.Location = new System.Drawing.Point(10, 65);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(74, 20);
            this.labelCart.TabIndex = 4;
            this.labelCart.Text = "Cart";
            this.labelCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(374, 276);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(293, 276);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UpdateModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "UpdateModal";
            this.Text = "Update Payment";
            this.Load += new System.EventHandler(this.UpdateModal_Load);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        
        
        /* STOCK */
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelProduct;
        /* USER */
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxIsAdmin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelIsAdmin;
        /* PRODUCT */
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labelPrice;
        /* PAYMENT */
        private System.Windows.Forms.TextBox textBoxCart;
        private System.Windows.Forms.Label labelCart;
        /* ALL */
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        /* FRAME */
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReturn;
    }
}