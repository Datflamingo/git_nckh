
namespace NCKH_QLHH
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
            this.btn_quanli = new System.Windows.Forms.Button();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quanli
            // 
            this.btn_quanli.Location = new System.Drawing.Point(690, 243);
            this.btn_quanli.Name = "btn_quanli";
            this.btn_quanli.Size = new System.Drawing.Size(259, 98);
            this.btn_quanli.TabIndex = 0;
            this.btn_quanli.Text = "QUẢN LÝ NHẬP HÀNG\r\n";
            this.btn_quanli.UseVisualStyleBackColor = true;
            this.btn_quanli.Click += new System.EventHandler(this.btn_quanli_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Location = new System.Drawing.Point(690, 454);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(259, 98);
            this.btn_chinhsua.TabIndex = 1;
            this.btn_chinhsua.Text = "CHỈNH SỬA";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "QUẢN LÝ XUẤT HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 840);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.btn_quanli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quanli;
        private System.Windows.Forms.Button btn_chinhsua;
        private System.Windows.Forms.Button button1;
    }
}

