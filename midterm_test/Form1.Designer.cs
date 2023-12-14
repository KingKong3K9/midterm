namespace midterm_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.lbCpEx = new System.Windows.Forms.Label();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdata = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbcopy = new System.Windows.Forms.Label();
            this.btnCopy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCp2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(402, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copy dữ liệu nhập vào vào clipboard";
            // 
            // rTB
            // 
            this.rTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rTB.Location = new System.Drawing.Point(5, 7);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(479, 197);
            this.rTB.TabIndex = 3;
            this.rTB.Text = resources.GetString("rTB.Text");
            this.rTB.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbCpEx
            // 
            this.lbCpEx.AutoSize = true;
            this.lbCpEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCpEx.Location = new System.Drawing.Point(78, 408);
            this.lbCpEx.Name = "lbCpEx";
            this.lbCpEx.Size = new System.Drawing.Size(172, 29);
            this.lbCpEx.TabIndex = 5;
            this.lbCpEx.Text = "Example Code";
            // 
            // rTB1
            // 
            this.rTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rTB1.Location = new System.Drawing.Point(7, 15);
            this.rTB1.Name = "rTB1";
            this.rTB1.Size = new System.Drawing.Size(549, 82);
            this.rTB1.TabIndex = 6;
            this.rTB1.Text = "1. Người dùng nhập dữ liệu\n2. Nhấn nút\n3. Trỏ chuột vào khoảng trắng bên phải hoặ" +
    "c bất cứ đâu có thể nhập dữ liệu\n4. Nhấn tổ hợp CTRL + Z";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel1.BorderThickness = 3;
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.txtdata);
            this.panel1.Controls.Add(this.lbcopy);
            this.panel1.Location = new System.Drawing.Point(143, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 123);
            this.panel1.TabIndex = 7;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.White;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(491, 26);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(245, 64);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // txtdata
            // 
            this.txtdata.BackColor = System.Drawing.Color.White;
            this.txtdata.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdata.DefaultText = "";
            this.txtdata.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdata.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdata.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdata.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdata.Location = new System.Drawing.Point(88, 26);
            this.txtdata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdata.Name = "txtdata";
            this.txtdata.PasswordChar = '\0';
            this.txtdata.PlaceholderText = "";
            this.txtdata.SelectedText = "";
            this.txtdata.Size = new System.Drawing.Size(247, 64);
            this.txtdata.TabIndex = 3;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // lbcopy
            // 
            this.lbcopy.AutoSize = true;
            this.lbcopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcopy.Location = new System.Drawing.Point(14, 40);
            this.lbcopy.Name = "lbcopy";
            this.lbcopy.Size = new System.Drawing.Size(55, 25);
            this.lbcopy.TabIndex = 2;
            this.lbcopy.Text = "Input";
            this.lbcopy.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(376, 26);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCopy.Size = new System.Drawing.Size(72, 65);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btnCp2);
            this.guna2Panel1.Controls.Add(this.rTB);
            this.guna2Panel1.Location = new System.Drawing.Point(351, 386);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(487, 207);
            this.guna2Panel1.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.rTB1);
            this.guna2Panel2.Location = new System.Drawing.Point(313, 108);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(566, 111);
            this.guna2Panel2.TabIndex = 9;
            // 
            // btnCp2
            // 
            this.btnCp2.BackColor = System.Drawing.Color.Transparent;
            this.btnCp2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCp2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCp2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCp2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCp2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCp2.ForeColor = System.Drawing.Color.White;
            this.btnCp2.Image = ((System.Drawing.Image)(resources.GetObject("btnCp2.Image")));
            this.btnCp2.ImageSize = new System.Drawing.Size(13, 13);
            this.btnCp2.Location = new System.Drawing.Point(437, 159);
            this.btnCp2.Name = "btnCp2";
            this.btnCp2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCp2.Size = new System.Drawing.Size(38, 35);
            this.btnCp2.TabIndex = 10;
            this.btnCp2.UseTransparentBackground = true;
            this.btnCp2.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 632);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCpEx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.Label lbCpEx;
        private System.Windows.Forms.RichTextBox rTB1;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.Label lbcopy;
        private Guna.UI2.WinForms.Guna2TextBox txtdata;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCopy;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnCp2;
    }
}

