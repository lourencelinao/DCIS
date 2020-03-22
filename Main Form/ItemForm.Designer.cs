namespace Main_Form
{
    partial class ItemForm
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
            this.itemPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addItemDepartmentGroupBox = new System.Windows.Forms.ComboBox();
            this.addItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnItem = new System.Windows.Forms.Button();
            this.borrowItem = new System.Windows.Forms.Button();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.deleteItem = new System.Windows.Forms.Button();
            this.editItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearBtn = new System.Windows.Forms.Button();
            this.itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.itemPanel.Controls.Add(this.clearBtn);
            this.itemPanel.Controls.Add(this.pictureBox2);
            this.itemPanel.Controls.Add(this.label4);
            this.itemPanel.Controls.Add(this.addItemDepartmentGroupBox);
            this.itemPanel.Controls.Add(this.addItemDescriptionTextBox);
            this.itemPanel.Controls.Add(this.label3);
            this.itemPanel.Controls.Add(this.addItemNameTextBox);
            this.itemPanel.Controls.Add(this.label1);
            this.itemPanel.Controls.Add(this.listViewItems);
            this.itemPanel.Controls.Add(this.returnItem);
            this.itemPanel.Controls.Add(this.borrowItem);
            this.itemPanel.Controls.Add(this.searchItemTextBox);
            this.itemPanel.Controls.Add(this.deleteItem);
            this.itemPanel.Controls.Add(this.editItem);
            this.itemPanel.Controls.Add(this.addItem);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Location = new System.Drawing.Point(0, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(1082, 453);
            this.itemPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::Main_Form.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1039, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 182;
            this.label4.Text = "Department";
            // 
            // addItemDepartmentGroupBox
            // 
            this.addItemDepartmentGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemDepartmentGroupBox.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemDepartmentGroupBox.FormattingEnabled = true;
            this.addItemDepartmentGroupBox.Location = new System.Drawing.Point(45, 227);
            this.addItemDepartmentGroupBox.Name = "addItemDepartmentGroupBox";
            this.addItemDepartmentGroupBox.Size = new System.Drawing.Size(238, 30);
            this.addItemDepartmentGroupBox.TabIndex = 181;
            // 
            // addItemDescriptionTextBox
            // 
            this.addItemDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemDescriptionTextBox.Location = new System.Drawing.Point(45, 154);
            this.addItemDescriptionTextBox.Name = "addItemDescriptionTextBox";
            this.addItemDescriptionTextBox.Size = new System.Drawing.Size(238, 30);
            this.addItemDescriptionTextBox.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 179;
            this.label3.Text = "Item Description";
            // 
            // addItemNameTextBox
            // 
            this.addItemNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemNameTextBox.Location = new System.Drawing.Point(45, 83);
            this.addItemNameTextBox.Name = "addItemNameTextBox";
            this.addItemNameTextBox.Size = new System.Drawing.Size(238, 30);
            this.addItemNameTextBox.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 177;
            this.label1.Text = "Item Name";
            // 
            // listViewItems
            // 
            this.listViewItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewItems.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(315, 54);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(755, 348);
            this.listViewItems.TabIndex = 176;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Description";
            this.columnHeader3.Width = 205;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item Department";
            this.columnHeader4.Width = 151;
            // 
            // returnItem
            // 
            this.returnItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnItem.Location = new System.Drawing.Point(445, 7);
            this.returnItem.Name = "returnItem";
            this.returnItem.Size = new System.Drawing.Size(106, 41);
            this.returnItem.TabIndex = 175;
            this.returnItem.Text = "Return Item";
            this.returnItem.UseVisualStyleBackColor = true;
            // 
            // borrowItem
            // 
            this.borrowItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowItem.Location = new System.Drawing.Point(315, 7);
            this.borrowItem.Name = "borrowItem";
            this.borrowItem.Size = new System.Drawing.Size(113, 41);
            this.borrowItem.TabIndex = 174;
            this.borrowItem.Text = "Borrow Item";
            this.borrowItem.UseVisualStyleBackColor = true;
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchItemTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemTextBox.Location = new System.Drawing.Point(832, 18);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(238, 30);
            this.searchItemTextBox.TabIndex = 173;
            this.searchItemTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchItemTextBox_KeyUp);
            // 
            // deleteItem
            // 
            this.deleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItem.Enabled = false;
            this.deleteItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.Location = new System.Drawing.Point(488, 408);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(81, 38);
            this.deleteItem.TabIndex = 172;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteItem_MouseClick);
            // 
            // editItem
            // 
            this.editItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editItem.Enabled = false;
            this.editItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItem.Location = new System.Drawing.Point(401, 408);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(81, 38);
            this.editItem.TabIndex = 171;
            this.editItem.Text = "Edit";
            this.editItem.UseVisualStyleBackColor = true;
            this.editItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editItem_MouseClick_1);
            // 
            // addItem
            // 
            this.addItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(314, 408);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(81, 38);
            this.addItem.TabIndex = 179;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addItem_MouseClick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(755, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(71, 39);
            this.clearBtn.TabIndex = 184;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearBtn_MouseClick);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.itemPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "ItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addItemDepartmentGroupBox;
        private System.Windows.Forms.TextBox addItemDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addItemNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button returnItem;
        private System.Windows.Forms.Button borrowItem;
        private System.Windows.Forms.TextBox searchItemTextBox;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button editItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearBtn;
    }
}