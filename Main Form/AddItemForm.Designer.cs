namespace Main_Form
{
    partial class AddItemForm
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
            this.cancelItemAddBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addItemDepartmentGroupBox = new System.Windows.Forms.ComboBox();
            this.addItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cancelItemAddBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addItemDepartmentGroupBox);
            this.panel1.Controls.Add(this.addItemDescriptionTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addItemNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 577);
            this.panel1.TabIndex = 0;
            // 
            // cancelItemAddBtn
            // 
            this.cancelItemAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelItemAddBtn.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelItemAddBtn.Location = new System.Drawing.Point(306, 516);
            this.cancelItemAddBtn.Name = "cancelItemAddBtn";
            this.cancelItemAddBtn.Size = new System.Drawing.Size(147, 53);
            this.cancelItemAddBtn.TabIndex = 148;
            this.cancelItemAddBtn.Text = "Cancel";
            this.cancelItemAddBtn.UseVisualStyleBackColor = true;
            // 
            // addItemBtn
            // 
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(459, 516);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(147, 53);
            this.addItemBtn.TabIndex = 147;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 146;
            this.label4.Text = "Department";
            // 
            // addItemDepartmentGroupBox
            // 
            this.addItemDepartmentGroupBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemDepartmentGroupBox.FormattingEnabled = true;
            this.addItemDepartmentGroupBox.Location = new System.Drawing.Point(183, 301);
            this.addItemDepartmentGroupBox.Name = "addItemDepartmentGroupBox";
            this.addItemDepartmentGroupBox.Size = new System.Drawing.Size(285, 32);
            this.addItemDepartmentGroupBox.TabIndex = 145;
            // 
            // addItemDescriptionTextBox
            // 
            this.addItemDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemDescriptionTextBox.Location = new System.Drawing.Point(183, 224);
            this.addItemDescriptionTextBox.Name = "addItemDescriptionTextBox";
            this.addItemDescriptionTextBox.Size = new System.Drawing.Size(285, 30);
            this.addItemDescriptionTextBox.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 143;
            this.label3.Text = "Item Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 69);
            this.label2.TabIndex = 142;
            this.label2.Text = "Add Item";
            // 
            // addItemNameTextBox
            // 
            this.addItemNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemNameTextBox.Location = new System.Drawing.Point(183, 145);
            this.addItemNameTextBox.Name = "addItemNameTextBox";
            this.addItemNameTextBox.Size = new System.Drawing.Size(285, 30);
            this.addItemNameTextBox.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 140;
            this.label1.Text = "Item Name";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelItemAddBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addItemDepartmentGroupBox;
        private System.Windows.Forms.TextBox addItemDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addItemNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}