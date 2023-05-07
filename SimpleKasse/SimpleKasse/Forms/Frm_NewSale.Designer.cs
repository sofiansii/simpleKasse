namespace SimpleKasse.Forms
{
    partial class Frm_NewSale
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Items = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AddItem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Verkaufsartikel :";
            // 
            // pnl_Items
            // 
            this.pnl_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Items.BorderColor = System.Drawing.Color.SteelBlue;
            this.pnl_Items.BorderRadius = 4;
            this.pnl_Items.BorderThickness = 1;
            this.pnl_Items.CustomizableEdges = customizableEdges1;
            this.pnl_Items.Location = new System.Drawing.Point(12, 46);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.pnl_Items.Size = new System.Drawing.Size(776, 348);
            this.pnl_Items.TabIndex = 13;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddItem.BorderRadius = 12;
            this.btn_AddItem.CustomizableEdges = customizableEdges3;
            this.btn_AddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddItem.ForeColor = System.Drawing.Color.White;
            this.btn_AddItem.Location = new System.Drawing.Point(657, 9);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btn_AddItem.Size = new System.Drawing.Size(131, 31);
            this.btn_AddItem.TabIndex = 14;
            this.btn_AddItem.Text = "Artikel hinzufügen";
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckOut.BorderRadius = 12;
            this.btn_CheckOut.CustomizableEdges = customizableEdges5;
            this.btn_CheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.Location = new System.Drawing.Point(694, 407);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btn_CheckOut.Size = new System.Drawing.Size(94, 31);
            this.btn_CheckOut.TabIndex = 14;
            this.btn_CheckOut.Text = "auschecken";
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.BorderRadius = 12;
            this.btn_Cancel.CustomizableEdges = customizableEdges7;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 407);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.btn_Cancel.Size = new System.Drawing.Size(94, 31);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "abbrechen";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.Location = new System.Drawing.Point(323, 421);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(130, 20);
            this.lbl_Total.TabIndex = 15;
            this.lbl_Total.Text = "Gesamtbetrag : 0";
            // 
            // Frm_NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.pnl_Items);
            this.Controls.Add(this.label5);
            this.Name = "Frm_NewSale";
            this.Text = "Frm_NewSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel pnl_Items;
        private Guna.UI2.WinForms.Guna2Button btn_AddItem;
        private Guna.UI2.WinForms.Guna2Button btn_CheckOut;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Total;
    }
}