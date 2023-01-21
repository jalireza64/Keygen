namespace Keygen
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValidDate = new System.Windows.Forms.TextBox();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerNameEncrypted = new System.Windows.Forms.TextBox();
            this.txtValidDateEncrypted = new System.Windows.Forms.TextBox();
            this.txtDeviceIdEncrypted = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(430, 39);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(358, 26);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtValidDate
            // 
            this.txtValidDate.Location = new System.Drawing.Point(430, 82);
            this.txtValidDate.Name = "txtValidDate";
            this.txtValidDate.Size = new System.Drawing.Size(358, 26);
            this.txtValidDate.TabIndex = 2;
            this.txtValidDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(430, 125);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(358, 26);
            this.txtDeviceId.TabIndex = 3;
            this.txtDeviceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = ":نام مشتری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = ":تاریخ اعتبار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":شناسه";
            // 
            // txtCustomerNameEncrypted
            // 
            this.txtCustomerNameEncrypted.Location = new System.Drawing.Point(42, 39);
            this.txtCustomerNameEncrypted.Name = "txtCustomerNameEncrypted";
            this.txtCustomerNameEncrypted.Size = new System.Drawing.Size(358, 26);
            this.txtCustomerNameEncrypted.TabIndex = 7;
            this.txtCustomerNameEncrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValidDateEncrypted
            // 
            this.txtValidDateEncrypted.Location = new System.Drawing.Point(42, 82);
            this.txtValidDateEncrypted.Name = "txtValidDateEncrypted";
            this.txtValidDateEncrypted.Size = new System.Drawing.Size(358, 26);
            this.txtValidDateEncrypted.TabIndex = 8;
            this.txtValidDateEncrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeviceIdEncrypted
            // 
            this.txtDeviceIdEncrypted.Location = new System.Drawing.Point(42, 125);
            this.txtDeviceIdEncrypted.Name = "txtDeviceIdEncrypted";
            this.txtDeviceIdEncrypted.Size = new System.Drawing.Size(358, 26);
            this.txtDeviceIdEncrypted.TabIndex = 9;
            this.txtDeviceIdEncrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(42, 169);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(358, 46);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 247);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDeviceIdEncrypted);
            this.Controls.Add(this.txtValidDateEncrypted);
            this.Controls.Add(this.txtCustomerNameEncrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.txtValidDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "Raadeen Keygen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValidDate;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerNameEncrypted;
        private System.Windows.Forms.TextBox txtValidDateEncrypted;
        private System.Windows.Forms.TextBox txtDeviceIdEncrypted;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

