namespace Main_Form
{
    partial class EditProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelEditProductBtn = new System.Windows.Forms.Button();
            this.editProductBtn = new System.Windows.Forms.Button();
            this.editProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.editProductPriceTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.editProductQuantityTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cancelEditProductBtn);
            this.panel1.Controls.Add(this.editProductBtn);
            this.panel1.Controls.Add(this.editProductDescriptionTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.editProductNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 577);
            this.panel1.TabIndex = 0;
            // 
            // editProductPriceTextBox
            // 
            this.editProductPriceTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductPriceTextBox.Location = new System.Drawing.Point(168, 378);
            this.editProductPriceTextBox.Name = "editProductPriceTextBox";
            this.editProductPriceTextBox.Size = new System.Drawing.Size(285, 30);
            this.editProductPriceTextBox.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 180;
            this.label5.Text = "Product Price";
            // 
            // editProductQuantityTextBox
            // 
            this.editProductQuantityTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductQuantityTextBox.Location = new System.Drawing.Point(168, 300);
            this.editProductQuantityTextBox.Name = "editProductQuantityTextBox";
            this.editProductQuantityTextBox.Size = new System.Drawing.Size(285, 30);
            this.editProductQuantityTextBox.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 179;
            this.label4.Text = "Product Quantity";
            // 
            // cancelEditProductBtn
            // 
            this.cancelEditProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEditProductBtn.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditProductBtn.Location = new System.Drawing.Point(291, 516);
            this.cancelEditProductBtn.Name = "cancelEditProductBtn";
            this.cancelEditProductBtn.Size = new System.Drawing.Size(147, 53);
            this.cancelEditProductBtn.TabIndex = 178;
            this.cancelEditProductBtn.Text = "Cancel";
            this.cancelEditProductBtn.UseVisualStyleBackColor = true;
            this.cancelEditProductBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelEditProductBtn_MouseClick);
            // 
            // editProductBtn
            // 
            this.editProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProductBtn.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductBtn.Location = new System.Drawing.Point(444, 516);
            this.editProductBtn.Name = "editProductBtn";
            this.editProductBtn.Size = new System.Drawing.Size(147, 53);
            this.editProductBtn.TabIndex = 174;
            this.editProductBtn.Text = "Add";
            this.editProductBtn.UseVisualStyleBackColor = true;
            // 
            // editProductDescriptionTextBox
            // 
            this.editProductDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductDescriptionTextBox.Location = new System.Drawing.Point(168, 224);
            this.editProductDescriptionTextBox.Name = "editProductDescriptionTextBox";
            this.editProductDescriptionTextBox.Size = new System.Drawing.Size(285, 30);
            this.editProductDescriptionTextBox.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 177;
            this.label3.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 69);
            this.label2.TabIndex = 176;
            this.label2.Text = "Edit Product";
            // 
            // editProductNameTextBox
            // 
            this.editProductNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductNameTextBox.Location = new System.Drawing.Point(168, 145);
            this.editProductNameTextBox.Name = "editProductNameTextBox";
            this.editProductNameTextBox.Size = new System.Drawing.Size(285, 30);
            this.editProductNameTextBox.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 175;
            this.label1.Text = "Product Name";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditProductForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editProductPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editProductQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelEditProductBtn;
        private System.Windows.Forms.Button editProductBtn;
        private System.Windows.Forms.TextBox editProductDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editProductNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}