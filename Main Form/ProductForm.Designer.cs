namespace Main_Form
{
    partial class ProductForm
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
            this.productPanel = new System.Windows.Forms.Panel();
            this.addProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProductQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.editProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.productPanel.Controls.Add(this.clearBtn);
            this.productPanel.Controls.Add(this.addProductPrice);
            this.productPanel.Controls.Add(this.label4);
            this.productPanel.Controls.Add(this.addProductQuantity);
            this.productPanel.Controls.Add(this.label2);
            this.productPanel.Controls.Add(this.pictureBox2);
            this.productPanel.Controls.Add(this.addProductDescriptionTextBox);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.addProductNameTextBox);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.listViewProducts);
            this.productPanel.Controls.Add(this.searchProductTextBox);
            this.productPanel.Controls.Add(this.deleteProduct);
            this.productPanel.Controls.Add(this.editProduct);
            this.productPanel.Controls.Add(this.addProduct);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(0, 0);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1082, 453);
            this.productPanel.TabIndex = 0;
            // 
            // addProductPrice
            // 
            this.addProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPrice.Location = new System.Drawing.Point(31, 294);
            this.addProductPrice.Name = "addProductPrice";
            this.addProductPrice.Size = new System.Drawing.Size(238, 30);
            this.addProductPrice.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 200;
            this.label4.Text = "Product Price";
            // 
            // addProductQuantity
            // 
            this.addProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantity.Location = new System.Drawing.Point(31, 225);
            this.addProductQuantity.Name = "addProductQuantity";
            this.addProductQuantity.Size = new System.Drawing.Size(238, 30);
            this.addProductQuantity.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 198;
            this.label2.Text = "Product Quantity";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::Main_Form.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1025, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 197;
            this.pictureBox2.TabStop = false;
            // 
            // addProductDescriptionTextBox
            // 
            this.addProductDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductDescriptionTextBox.Location = new System.Drawing.Point(31, 154);
            this.addProductDescriptionTextBox.Name = "addProductDescriptionTextBox";
            this.addProductDescriptionTextBox.Size = new System.Drawing.Size(238, 30);
            this.addProductDescriptionTextBox.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 193;
            this.label3.Text = "Product Description";
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameTextBox.Location = new System.Drawing.Point(31, 83);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(238, 30);
            this.addProductNameTextBox.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 191;
            this.label1.Text = "Product Name";
            // 
            // listViewProducts
            // 
            this.listViewProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProducts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(301, 54);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(755, 348);
            this.listViewProducts.TabIndex = 190;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Description";
            this.columnHeader3.Width = 205;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 80;
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchProductTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductTextBox.Location = new System.Drawing.Point(810, 18);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(246, 30);
            this.searchProductTextBox.TabIndex = 187;
            this.searchProductTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchProductTextBox_KeyUp);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteProduct.Enabled = false;
            this.deleteProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(474, 408);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(81, 38);
            this.deleteProduct.TabIndex = 186;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteProduct_MouseClick);
            // 
            // editProduct
            // 
            this.editProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editProduct.Enabled = false;
            this.editProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProduct.Location = new System.Drawing.Point(387, 408);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(81, 38);
            this.editProduct.TabIndex = 185;
            this.editProduct.Text = "Edit";
            this.editProduct.UseVisualStyleBackColor = true;
            this.editProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editProduct_MouseClick_1);
            // 
            // addProduct
            // 
            this.addProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(300, 408);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(81, 38);
            this.addProduct.TabIndex = 196;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addProduct_MouseClick_1);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(723, 14);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(81, 38);
            this.clearBtn.TabIndex = 201;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearBtn_MouseClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.productPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "ProductForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.TextBox addProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox addProductDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button editProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button clearBtn;
    }
}