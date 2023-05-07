namespace SimpleKasse.Forms
{
    partial class Frm_ManageKassiers
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
            this.btn_newKassier = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Kassiers = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_newKassier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_newKassier
            // 
            this.btn_newKassier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newKassier.BorderRadius = 7;
            this.btn_newKassier.CustomizableEdges = customizableEdges1;
            this.btn_newKassier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newKassier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newKassier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newKassier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newKassier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newKassier.ForeColor = System.Drawing.Color.White;
            this.btn_newKassier.Location = new System.Drawing.Point(622, 9);
            this.btn_newKassier.Name = "btn_newKassier";
            this.btn_newKassier.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_newKassier.Size = new System.Drawing.Size(140, 36);
            this.btn_newKassier.TabIndex = 0;
            this.btn_newKassier.Text = "Kassierer hinzufügen";
            this.btn_newKassier.Click += new System.EventHandler(this.btn_newKassier_Click);
            // 
            // pnl_Kassiers
            // 
            this.pnl_Kassiers.AutoScroll = true;
            this.pnl_Kassiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Kassiers.Location = new System.Drawing.Point(0, 54);
            this.pnl_Kassiers.Name = "pnl_Kassiers";
            this.pnl_Kassiers.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnl_Kassiers.Size = new System.Drawing.Size(800, 396);
            this.pnl_Kassiers.TabIndex = 1;
            // 
            // Frm_ManageKassiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Kassiers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ManageKassiers";
            this.Text = "Frm_ManageKassiers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_newKassier;
        private System.Windows.Forms.Panel pnl_Kassiers;
    }
}