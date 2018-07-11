using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Chiper_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hashbtn_Click(object sender, EventArgs e)
        {
            if((MD5cb.Checked && SHA1cb.Checked)|| (!MD5cb.Checked && !SHA1cb.Checked))
            {
                MessageBox.Show("Only one CheckBox can be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MD5cb.Checked)
                {
                    if(HashInputtb.Text!="")
                    {
                        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                        UTF8Encoding utf8 = new UTF8Encoding();
                        byte[] temp=md5.ComputeHash(utf8.GetBytes(HashInputtb.Text));
                        HashOutputtb.Text = BitConverter.ToString(temp);
                    }
                    else
                    {
                        MessageBox.Show("No text entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(SHA1cb.Checked)
                {
                    if (HashInputtb.Text != "")
                    {
                        SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                        UTF8Encoding utf8 = new UTF8Encoding();
                        byte[] temp = sha1.ComputeHash(utf8.GetBytes(HashInputtb.Text));
                        HashOutputtb.Text = BitConverter.ToString(temp);
                    }
                    else
                    {
                        MessageBox.Show("No text entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        byte[] arr;
        private void Encbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(ETexttb.Text=="" || EKeytb.Text=="")
                {
                    MessageBox.Show("No text or key entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Encryption
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                    tdes.Key = md5.ComputeHash(utf8.GetBytes(EKeytb.Text));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform crypto = tdes.CreateEncryptor();
                    arr = crypto.TransformFinalBlock(utf8.GetBytes(ETexttb.Text), 0, utf8.GetBytes(ETexttb.Text).Length);
                    EOuttb.Text = BitConverter.ToString(arr);
                }
            }
            catch { }
        }

        private void Decbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DKeytb.Text == "")
                {
                    MessageBox.Show("No key entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Decryption
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                    tdes.Key = md5.ComputeHash(utf8.GetBytes(DKeytb.Text));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform crypto = tdes.CreateDecryptor();
                    DOuttb.Text = utf8.GetString(crypto.TransformFinalBlock(arr, 0, arr.Length));
                }
            }
            catch { }
        }
    }
}
