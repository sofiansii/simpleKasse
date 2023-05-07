namespace SimpleKasse.Forms
{
    partial class Frm_Sales
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_newSale = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Sales = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_newSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_newSale
            // 
            this.btn_newSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newSale.BorderRadius = 7;
            this.btn_newSale.CustomizableEdges = customizableEdges1;
            this.btn_newSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newSale.ForeColor = System.Drawing.Color.White;
            this.btn_newSale.Location = new System.Drawing.Point(627, 9);
            this.btn_newSale.Name = "btn_newSale";
            this.btn_newSale.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_newSale.Size = new System.Drawing.Size(135, 36);
            this.btn_newSale.TabIndex = 0;
            this.btn_newSale.Text = "neuer Verkauf";
            this.btn_newSale.Click += new System.EventHandler(this.btn_newSale_Click);
            // 
            // pnl_Sales
            // 
            this.pnl_Sales.AutoScroll = true;
            this.pnl_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Sales.Location = new System.Drawing.Point(0, 54);
            this.pnl_Sales.Name = "pnl_Sales";
            this.pnl_Sales.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnl_Sales.Size = new System.Drawing.Size(800, 396);
            this.pnl_Sales.TabIndex = 1;
            // 
            // Frm_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Sales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Sales";
            this.Text = "Frm_ManageKassiers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_newSale;
        private System.Windows.Forms.Panel pnl_Sales;
    }
}