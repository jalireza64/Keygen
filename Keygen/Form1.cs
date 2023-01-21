using DeviceId;
using Keygen.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string deviceId = new DeviceIdBuilder()
                .AddMachineName()
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber()
                .ToString();

            txtDeviceId.Text = deviceId;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtCustomerNameEncrypted.Text = AesEncryptDecryptor.Encrypt(txtCustomerName.Text);
            txtValidDateEncrypted.Text = AesEncryptDecryptor.Encrypt(txtValidDate.Text);
            txtDeviceIdEncrypted.Text = AesEncryptDecryptor.Encrypt(txtDeviceId.Text);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = AesEncryptDecryptor.Decrypt(txtCustomerNameEncrypted.Text);
            txtValidDate.Text = AesEncryptDecryptor.Decrypt(txtValidDateEncrypted.Text);
            txtDeviceId.Text = AesEncryptDecryptor.Decrypt(txtDeviceIdEncrypted.Text);
        }
    }
}
