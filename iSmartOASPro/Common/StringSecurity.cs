using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace iSmartOASPro
{
    class StringSecurity
    {
        public string iSmartOAS_DESEncryption(string data, string strKey, string strVector)
        {
            try
            {
                /*把密钥转换成字符数组*/
                byte[] byteKey = Encoding.UTF8.GetBytes(strKey);
                /*把向量转换成字符数组*/
                byte[] byteVector = Encoding.UTF8.GetBytes(strVector);

                /*创建内存流*/
                MemoryStream memStream = new MemoryStream();
                /*将内存流链接到加密转换的流*/
                CryptoStream cryptStream = new CryptoStream
                (
                    memStream, 
                    new DESCryptoServiceProvider().CreateEncryptor(byteKey, byteVector), 
                    CryptoStreamMode.Write
                );
                /*将需要加密的字符串转换为字符数组*/
                byte[] byteEncrypt = Encoding.UTF8.GetBytes(data);
                /*加密数据并写入内存流*/
                cryptStream.Write(byteEncrypt, 0, byteEncrypt.Length);
                /*清除缓存*/
                cryptStream.FlushFinalBlock();
                /*将加密后的内存流转换为字符数组*/
                byte[] result = memStream.ToArray();

                /*关闭流*/
                cryptStream.Close();
                memStream.Close();

                return Convert.ToBase64String(result);

            }
            catch (Exception)
            {
                MessageBox.Show("Encryption string error.", "ERROR");
                return null;
            }
        }

        public string iSmartOAS_DESDecryption(string data, string strKey, string strVector)
        {
            try
            {
                /*将加密后的字符串转换为字符数组*/
                byte[] byteData = Convert.FromBase64String(data);
                /*将密钥转换成字符数组*/
                byte[] byteKey = Encoding.UTF8.GetBytes(strKey);
                /*将向量转换为字符数组*/
                byte[] byteVector = Encoding.UTF8.GetBytes(strVector);

                /*创建内存流并将加密后的字符数组载入内存流*/
                MemoryStream memStream = new MemoryStream(byteData);
                /*将内存流链接到加密转换的流*/
                CryptoStream cryStream = new CryptoStream
                (
                    memStream, 
                    new DESCryptoServiceProvider().CreateDecryptor(byteKey, byteVector), 
                    CryptoStreamMode.Read
                );

                /*建立临时缓存并读取结果至缓存*/
                byte[] result = new byte[byteData.Length];
                cryStream.Read(result, 0, result.Length);

                /*关闭流*/
                cryStream.Close();
                memStream.Close();

                return Encoding.UTF8.GetString(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Decryption string error.", "ERROR");
                return null;
            }
        }
    }
}
