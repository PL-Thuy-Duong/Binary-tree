namespace Binary_search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNhan = new System.Windows.Forms.Button();
            this.Tm1 = new System.Windows.Forms.Timer(this.components);
            this.btnLNR = new System.Windows.Forms.Button();
            this.btnLRN = new System.Windows.Forms.Button();
            this.btnNLR = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCB = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhan
            // 
            this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNhan.Location = new System.Drawing.Point(749, 62);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(83, 36);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Khởi tạo";
            this.btnNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnLNR
            // 
            this.btnLNR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLNR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLNR.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLNR.Location = new System.Drawing.Point(749, 238);
            this.btnLNR.Margin = new System.Windows.Forms.Padding(2);
            this.btnLNR.Name = "btnLNR";
            this.btnLNR.Size = new System.Drawing.Size(83, 35);
            this.btnLNR.TabIndex = 3;
            this.btnLNR.Text = "LNR";
            this.btnLNR.UseVisualStyleBackColor = true;
            this.btnLNR.Click += new System.EventHandler(this.btn2_Click);
            this.btnLNR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLNR_MouseDown);
            // 
            // btnLRN
            // 
            this.btnLRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLRN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLRN.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLRN.Location = new System.Drawing.Point(749, 128);
            this.btnLRN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLRN.Name = "btnLRN";
            this.btnLRN.Size = new System.Drawing.Size(83, 33);
            this.btnLRN.TabIndex = 4;
            this.btnLRN.Text = "LRN";
            this.btnLRN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLRN.UseVisualStyleBackColor = true;
            this.btnLRN.Click += new System.EventHandler(this.btn3_Click);
            this.btnLRN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLRN_MouseDown);
            // 
            // btnNLR
            // 
            this.btnNLR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNLR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLR.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNLR.Location = new System.Drawing.Point(749, 189);
            this.btnNLR.Margin = new System.Windows.Forms.Padding(2);
            this.btnNLR.Name = "btnNLR";
            this.btnNLR.Size = new System.Drawing.Size(83, 40);
            this.btnNLR.TabIndex = 5;
            this.btnNLR.Text = "NLR";
            this.btnNLR.UseVisualStyleBackColor = true;
            this.btnNLR.Click += new System.EventHandler(this.btn4_Click);
            this.btnNLR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNLR_MouseDown);
            // 
            // btnRef
            // 
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRef.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRef.Location = new System.Drawing.Point(850, 287);
            this.btnRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(82, 47);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "Làm mới";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnInsert.Location = new System.Drawing.Point(850, 62);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 36);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnInsert_MouseDown);
            // 
            // txtNhap
            // 
            this.txtNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNhap.ForeColor = System.Drawing.Color.Black;
            this.txtNhap.Location = new System.Drawing.Point(251, 34);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(361, 36);
            this.txtNhap.TabIndex = 8;
            this.txtNhap.Text = "50 60 40 30 20 70 80 55 65 35 45 48 43 57 53";
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Location = new System.Drawing.Point(850, 128);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXoa_MouseDown);
            // 
            // btnCB
            // 
            this.btnCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCB.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCB.Location = new System.Drawing.Point(850, 189);
            this.btnCB.Margin = new System.Windows.Forms.Padding(2);
            this.btnCB.Name = "btnCB";
            this.btnCB.Size = new System.Drawing.Size(82, 40);
            this.btnCB.TabIndex = 10;
            this.btnCB.Text = "Cân Bằng";
            this.btnCB.UseVisualStyleBackColor = true;
            this.btnCB.Click += new System.EventHandler(this.btnCB_Click);
            this.btnCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCB_MouseDown);
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnTim.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTim.Location = new System.Drawing.Point(749, 287);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 47);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTim_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(943, 438);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLRN);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnNLR);
            this.Controls.Add(this.btnLNR);
            this.Controls.Add(this.btnCB);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRef);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Timer Tm1;
        private System.Windows.Forms.Button btnLNR;
        private System.Windows.Forms.Button btnLRN;
        private System.Windows.Forms.Button btnNLR;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCB;
        private System.Windows.Forms.Button btnTim;
    }
}

