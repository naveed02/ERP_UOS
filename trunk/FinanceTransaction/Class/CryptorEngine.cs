using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ERP_UOS
{
    public class CryptorEngine
    {


        /// <summary>
        /// Encrypt a string using dual encryption method. Return a encrypted cipher Text
        /// </summary>
        /// <param name="toEncrypt">string to be encrypted</param>
        /// <param name="useHashing">use hashing? send to for extra secirity</param>
        /// <returns></returns>
        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file
            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            //System.Windows.Forms.MessageBox.Show(key);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        /// <summary>
        /// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
        /// </summary>
        /// <param name="cipherString">encrypted string</param>
        /// <param name="useHashing">Did you use hashing to encrypt this data? pass true is yes</param>
        /// <returns></returns>
        public static string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            //Get your key from config file to open the lock!
            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                        
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


        public static string DBConnection() 
        {
            string DbConString = string.Empty;

            string provider = string.Empty;
            string PSecInfo = string.Empty;
            string UserID = string.Empty;
            string InitCat = string.Empty;
            string DataSrc = string.Empty;
            string Pwd = string.Empty;   

            List<string> cipherText = new List<string>();
            List<string> clearText = new List<string>();
            List<string> decryptedText = new List<string>();

            try
            {
                //Stream myStream = null;
                //OpenFileDialog openFileDialog1 = new OpenFileDialog();

                //openFileDialog1.InitialDirectory = "D:\\Projects\\DBConnect\\DBConnect\\bin\\Debug";
                //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog1.FilterIndex = 2;
                //openFileDialog1.RestoreDirectory = true;

                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                    int counter = 0;
                    string line;

                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader("DBConnect.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        decryptedText.Add(CryptorEngine.Decrypt(line, true));
                        //text.Add(line);
                        counter++;
                    }

                    provider = decryptedText[0];
                    PSecInfo = decryptedText[1];
                    UserID = decryptedText[2];
                    InitCat = decryptedText[3];
                    DataSrc = decryptedText[4];
                    Pwd = decryptedText[5];

                    file.Close();


                    //txtPwd.Enabled = true;
                    //string ConString1 = string.Empty;
                    DbConString = "Data Source= " + DataSrc + ";Initial Catalog=" + InitCat + ";User ID=" + UserID + "; Password=" + Pwd;

                    
                //}
            }

            catch (Exception ex)
            {
                //LoadDefaultValues();
                //txtPwd.Enabled = true;
                MessageBox.Show(ex.ToString());
            }
            return DbConString;
        }

        public static string BranchID()
        {
            string BranchID = "1";
            string BranchName = string.Empty;
            string BranchAddress = string.Empty;

            List<string> cipherText = new List<string>();
            List<string> clearText = new List<string>();
            List<string> decryptedText = new List<string>();

            try
            {
                //Stream myStream = null;
                //OpenFileDialog openFileDialog1 = new OpenFileDialog();

                //openFileDialog1.InitialDirectory = "D:\\Projects\\DBConnect\\DBConnect\\bin\\Debug";
                //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog1.FilterIndex = 2;
                //openFileDialog1.RestoreDirectory = true;

                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Branch.txt");
                while ((line = file.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    decryptedText.Add(CryptorEngine.Decrypt(line, true));
                    //text.Add(line);
                    counter++;
                }

                BranchID = decryptedText[0];
                BranchName = decryptedText[1];
                BranchAddress = decryptedText[2];

                file.Close();


                //txtPwd.Enabled = true;
                //string ConString1 = string.Empty;
                //DbConString = "Data Source= " + DataSrc + ";Initial Catalog=" + InitCat + ";User ID=" + UserID + "; Password=" + Pwd;
                //}
            }

            catch (Exception ex)
            {
                //LoadDefaultValues();
                //txtPwd.Enabled = true;
                MessageBox.Show(ex.ToString());
            }
            return BranchID;
        }
    }
}
