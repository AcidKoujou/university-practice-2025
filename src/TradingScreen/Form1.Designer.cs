
namespace TradingScreen
{
    partial class Form1
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
            this.lblMyInventory = new System.Windows.Forms.Label();
            this.VendorInventory = new System.Windows.Forms.Label();
            this.dgvVendorItem = new System.Windows.Forms.DataGridView();
            this.MyItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyInventory
            // 
            this.lblMyInventory.AutoSize = true;
            this.lblMyInventory.Location = new System.Drawing.Point(99, 13);
            this.lblMyInventory.Name = "lblMyInventory";
            this.lblMyInventory.Size = new System.Drawing.Size(88, 17);
            this.lblMyInventory.TabIndex = 0;
            this.lblMyInventory.Text = "My Inventory";
            // 
            // VendorInventory
            // 
            this.VendorInventory.AutoSize = true;
            this.VendorInventory.Location = new System.Drawing.Point(349, 13);
            this.VendorInventory.Name = "VendorInventory";
            this.VendorInventory.Size = new System.Drawing.Size(130, 17);
            this.VendorInventory.TabIndex = 1;
            this.VendorInventory.Text = " Vendor\'s Inventory";
            // 
            // dgvVendorItem
            // 
            this.dgvVendorItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorItem.Location = new System.Drawing.Point(276, 43);
            this.dgvVendorItem.Name = "dgvVendorItem";
            this.dgvVendorItem.RowHeadersWidth = 51;
            this.dgvVendorItem.RowTemplate.Height = 24;
            this.dgvVendorItem.Size = new System.Drawing.Size(240, 216);
            this.dgvVendorItem.TabIndex = 2;
            // 
            // MyItems
            // 
            this.MyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyItems.Location = new System.Drawing.Point(13, 43);
            this.MyItems.Name = "MyItems";
            this.MyItems.RowHeadersWidth = 51;
            this.MyItems.RowTemplate.Height = 24;
            this.MyItems.Size = new System.Drawing.Size(240, 216);
            this.MyItems.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(441, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.MyItems);
            this.Controls.Add(this.dgvVendorItem);
            this.Controls.Add(this.VendorInventory);
            this.Controls.Add(this.lblMyInventory);
            this.Name = "Form1";
            this.Text = "Trade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyInventory;
        private System.Windows.Forms.Label VendorInventory;
        private System.Windows.Forms.DataGridView dgvVendorItem;
        private System.Windows.Forms.DataGridView MyItems;
        private System.Windows.Forms.Button btnClose;
    }
}

