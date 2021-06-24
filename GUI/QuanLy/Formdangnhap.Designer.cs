namespace GUI.QuanLy
{
    partial class Formdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdangnhap));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btndangnhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txbmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(452, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 37);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbtaikhoan);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Controls.Add(this.txbmatkhau);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 462);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(164, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 45;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbtaikhoan
            // 
            this.txbtaikhoan.Animated = true;
            this.txbtaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.txbtaikhoan.BorderRadius = 8;
            this.txbtaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbtaikhoan.DefaultText = "5951071030";
            this.txbtaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbtaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbtaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbtaikhoan.DisabledState.Parent = this.txbtaikhoan;
            this.txbtaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbtaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txbtaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbtaikhoan.FocusedState.Parent = this.txbtaikhoan;
            this.txbtaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbtaikhoan.ForeColor = System.Drawing.Color.Gray;
            this.txbtaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbtaikhoan.HoverState.Parent = this.txbtaikhoan;
            this.txbtaikhoan.Location = new System.Drawing.Point(128, 194);
            this.txbtaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbtaikhoan.Name = "txbtaikhoan";
            this.txbtaikhoan.PasswordChar = '\0';
            this.txbtaikhoan.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbtaikhoan.PlaceholderText = "Username";
            this.txbtaikhoan.SelectedText = "";
            this.txbtaikhoan.SelectionStart = 10;
            this.txbtaikhoan.ShadowDecoration.Parent = this.txbtaikhoan;
            this.txbtaikhoan.Size = new System.Drawing.Size(237, 37);
            this.txbtaikhoan.TabIndex = 43;
            this.txbtaikhoan.TextChanged += new System.EventHandler(this.txbtaikhoan_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(268, 329);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(111, 17);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "Forgot Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(111, 330);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 16);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Remember Me";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Animated = true;
            this.btndangnhap.AutoRoundedCorners = true;
            this.btndangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btndangnhap.BorderRadius = 17;
            this.btndangnhap.CheckedState.Parent = this.btndangnhap;
            this.btndangnhap.CustomImages.Parent = this.btndangnhap;
            this.btndangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btndangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btndangnhap.ForeColor = System.Drawing.Color.Black;
            this.btndangnhap.HoverState.Parent = this.btndangnhap;
            this.btndangnhap.Location = new System.Drawing.Point(149, 365);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.ShadowDecoration.Parent = this.btndangnhap;
            this.btndangnhap.Size = new System.Drawing.Size(182, 37);
            this.btndangnhap.TabIndex = 39;
            this.btndangnhap.Text = "LOGIN";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txbmatkhau
            // 
            this.txbmatkhau.Animated = true;
            this.txbmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.txbmatkhau.BorderRadius = 8;
            this.txbmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbmatkhau.DefaultText = "1";
            this.txbmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbmatkhau.DisabledState.Parent = this.txbmatkhau;
            this.txbmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbmatkhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txbmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbmatkhau.FocusedState.Parent = this.txbmatkhau;
            this.txbmatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbmatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbmatkhau.HoverState.Parent = this.txbmatkhau;
            this.txbmatkhau.Location = new System.Drawing.Point(128, 256);
            this.txbmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbmatkhau.Name = "txbmatkhau";
            this.txbmatkhau.PasswordChar = '\0';
            this.txbmatkhau.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbmatkhau.PlaceholderText = "Password";
            this.txbmatkhau.SelectedText = "";
            this.txbmatkhau.SelectionStart = 1;
            this.txbmatkhau.ShadowDecoration.Parent = this.txbmatkhau;
            this.txbmatkhau.Size = new System.Drawing.Size(237, 37);
            this.txbmatkhau.TabIndex = 38;
            this.txbmatkhau.UseSystemPasswordChar = true;
            // 
            // Formdangnhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(491, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Formdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formdangnhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        internal Guna.UI2.WinForms.Guna2TextBox txbtaikhoan;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal Guna.UI2.WinForms.Guna2GradientButton btndangnhap;
        internal Guna.UI2.WinForms.Guna2TextBox txbmatkhau;
        private System.Windows.Forms.Label label3;
    }
}