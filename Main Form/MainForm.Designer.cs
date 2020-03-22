namespace Main_Form
{
    partial class MainForm
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
            this.mainFormPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.itemBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.mainFormPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mainFormPanel.Controls.Add(this.navPanel);
            this.mainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Size = new System.Drawing.Size(782, 553);
            this.mainFormPanel.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navPanel.BackColor = System.Drawing.Color.White;
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.productBtn);
            this.navPanel.Controls.Add(this.itemBtn);
            this.navPanel.Controls.Add(this.employeesBtn);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(782, 53);
            this.navPanel.TabIndex = 0;
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.White;
            this.productBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Black;
            this.productBtn.Location = new System.Drawing.Point(301, 3);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(145, 45);
            this.productBtn.TabIndex = 2;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productBtn_MouseClick);
            // 
            // itemBtn
            // 
            this.itemBtn.BackColor = System.Drawing.Color.White;
            this.itemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBtn.ForeColor = System.Drawing.Color.Black;
            this.itemBtn.Location = new System.Drawing.Point(150, 3);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(145, 45);
            this.itemBtn.TabIndex = 1;
            this.itemBtn.Text = "Items";
            this.itemBtn.UseVisualStyleBackColor = false;
            this.itemBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemBtn_MouseClick);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BackColor = System.Drawing.Color.White;
            this.employeesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesBtn.ForeColor = System.Drawing.Color.Black;
            this.employeesBtn.Location = new System.Drawing.Point(-1, 3);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(145, 45);
            this.employeesBtn.TabIndex = 0;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = false;
            this.employeesBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.employeesBtn_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mainFormPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainFormPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Button productBtn;
    }
}