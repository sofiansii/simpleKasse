using Guna.UI2.WinForms;

namespace SimpleKasse.Controls
{
    partial class C_Sale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ItemsInCart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_details = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2TileButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderRadius = 14;
            this.panel1.Controls.Add(this.lbl_ItemsInCart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_details);
            this.panel1.Controls.Add(this.lbl_TotalPrice);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2TileButton1);
            this.panel1.CustomizableEdges = customizableEdges5;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panel1.Size = new System.Drawing.Size(660, 70);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ItemsInCart
            // 
            this.lbl_ItemsInCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ItemsInCart.AutoSize = true;
            this.lbl_ItemsInCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ItemsInCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ItemsInCart.Location = new System.Drawing.Point(351, 27);
            this.lbl_ItemsInCart.Name = "lbl_ItemsInCart";
            this.lbl_ItemsInCart.Size = new System.Drawing.Size(28, 21);
            this.lbl_ItemsInCart.TabIndex = 8;
            this.lbl_ItemsInCart.Text = "20";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(201, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Artikel im Warenkorb :";
            // 
            // btn_details
            // 
            this.btn_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_details.BackColor = System.Drawing.Color.Transparent;
            this.btn_details.BorderRadius = 12;
            this.btn_details.CustomizableEdges = customizableEdges1;
            this.btn_details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_details.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_details.ForeColor = System.Drawing.Color.White;
            this.btn_details.Location = new System.Drawing.Point(576, 21);
            this.btn_details.Name = "btn_details";
            this.btn_details.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_details.Size = new System.Drawing.Size(64, 30);
            this.btn_details.TabIndex = 7;
            this.btn_details.Text = "Details";
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPrice.Location = new System.Drawing.Point(481, 27);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(37, 21);
            this.lbl_TotalPrice.TabIndex = 4;
            this.lbl_TotalPrice.Text = "300";
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.SteelBlue;
            this.label.Location = new System.Drawing.Point(382, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 21);
            this.label.TabIndex = 5;
            this.label.Text = "Gesamtpreis :";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(115, 26);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(88, 21);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "03.02.2022";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datum :";
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.CustomizableEdges = customizableEdges3;
            this.guna2TileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Image = global::SimpleKasse.Properties.Resources.Facture;
            this.guna2TileButton1.ImageRotate = 0F;
            this.guna2TileButton1.Location = new System.Drawing.Point(3, 21);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.guna2TileButton1.Size = new System.Drawing.Size(42, 30);
            this.guna2TileButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2TileButton1.TabIndex = 3;
            this.guna2TileButton1.TabStop = false;
            // 
            // C_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "C_Sale";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.Size = new System.Drawing.Size(670, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2TileButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2TileButton1;
        private Guna2Button btn_details;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_ItemsInCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_date;
    }
}
