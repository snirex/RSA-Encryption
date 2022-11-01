namespace rsa_enc_dec
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bEncrypt = new System.Windows.Forms.Button();
			this.bDecrypt = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 63);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(454, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Plain Text For Encryption";
			// 
			// bEncrypt
			// 
			this.bEncrypt.Location = new System.Drawing.Point(472, 61);
			this.bEncrypt.Name = "bEncrypt";
			this.bEncrypt.Size = new System.Drawing.Size(75, 98);
			this.bEncrypt.TabIndex = 2;
			this.bEncrypt.Text = "Encrypt";
			this.bEncrypt.UseVisualStyleBackColor = true;
			this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
			// 
			// bDecrypt
			// 
			this.bDecrypt.Location = new System.Drawing.Point(472, 196);
			this.bDecrypt.Name = "bDecrypt";
			this.bDecrypt.Size = new System.Drawing.Size(75, 98);
			this.bDecrypt.TabIndex = 5;
			this.bDecrypt.Text = "Decrypt";
			this.bDecrypt.UseVisualStyleBackColor = true;
			this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(12, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Encrypted Text";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(12, 198);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(454, 96);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(12, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Plain Text After Decryption";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(12, 340);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(535, 96);
			this.richTextBox3.TabIndex = 6;
			this.richTextBox3.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(159, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(247, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "RSA - Asymetric Encryption";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(13, 449);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(384, 13);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Tag = "http://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/";
			this.linkLabel1.Text = "http://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 471);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.bDecrypt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.bEncrypt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bEncrypt;
		private System.Windows.Forms.Button bDecrypt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}

