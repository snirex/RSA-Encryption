using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace rsa_enc_dec
{
	public partial class Form1 : Form
	{
		byte[] plaintext;
		byte[] encryptedtext;
		UnicodeEncoding ByteConverter = new UnicodeEncoding();
		RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

		public Form1()
		{
			InitializeComponent();
		}

		private void bEncrypt_Click(object sender, EventArgs e)
		{
			plaintext = ByteConverter.GetBytes(richTextBox1.Text);
			encryptedtext = enc.Encryption(plaintext, RSA.ExportParameters(false), false);
			richTextBox2.Text = ByteConverter.GetString(encryptedtext);
		}

		private void bDecrypt_Click(object sender, EventArgs e)
		{
			byte[] decryptedtex = enc.Decryption(encryptedtext, RSA.ExportParameters(true), false);
			richTextBox3.Text = ByteConverter.GetString(decryptedtex);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/");
		}

	}
}
