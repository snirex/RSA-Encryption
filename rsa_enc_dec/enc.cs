using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace rsa_enc_dec
{
	class enc
	{
		UnicodeEncoding ByteConverter = new UnicodeEncoding();
		RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
		byte[] plaintext;
		byte[] encryptedtext; 

		static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
		{
			try
			{
				byte[] encryptedData;
				using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
				{
					RSA.ImportParameters(RSAKey); 
					encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
				} return encryptedData;
			}
			catch (CryptographicException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}

		static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
		{
			try
			{
				byte[] decryptedData;
				using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
				{
					RSA.ImportParameters(RSAKey);
					decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
				}
				return decryptedData;
			}
			catch (CryptographicException e)
			{
				Console.WriteLine(e.ToString());
				return null;
			}
		}
	}
}
