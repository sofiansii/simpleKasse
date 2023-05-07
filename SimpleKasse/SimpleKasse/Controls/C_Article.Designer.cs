using Guna.UI2.WinForms;

namespace SimpleKasse.Controls
{
    partial class C_Article
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
            this.btn_details = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btn_details);
            this.panel1.Controls.Add(this.lbl_Quantity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.guna2TileButton1);
            this.panel1.CustomizableEdges = customizableEdges5;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panel1.Size = new System.Drawing.Size(616, 70);
            this.panel1.TabIndex = 0;
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
            this.btn_details.Location = new System.Drawing.Point(524, 18);
            this.btn_details.Name = "btn_details";
            this.btn_details.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_details.Size = new System.Drawing.Size(64, 30);
            this.btn_details.TabIndex = 7;
            this.btn_details.Text = "Details";
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(310, 24);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(46, 21);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "3000";
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
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menge :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(78, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(137, 21);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Mohamed Moulay";
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
            this.guna2TileButton1.Image = global::SimpleKasse.Properties.Resources.cubes;
            this.guna2TileButton1.ImageRotate = 0F;
            this.guna2TileButton1.Location = new System.Drawing.Point(30, 24);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.guna2TileButton1.Size = new System.Drawing.Size(42, 25);
            this.guna2TileButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2TileButton1.TabIndex = 3;
            this.guna2TileButton1.TabStop = false;
            // 
            // C_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "C_Article";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.Size = new System.Drawing.Size(626, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2TileButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panel1;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private Guna.UI2.WinForms.Guna2PictureBox guna2TileButton1;
        private Guna2Button btn_details;
    }
}
