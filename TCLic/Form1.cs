using Microsoft.Win32;
using System;
using System.IO;
using System.Management;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TCLic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        [DataContract]
        internal class LicenceResponse
        {
            //[DataMember]
            //internal LicenceResponseCode result;

            [DataMember]
            internal string key = string.Empty;

            [DataMember]
            internal string company = string.Empty;

            [DataMember]
            internal string user = string.Empty;

            [DataMember]
            internal string email = string.Empty;

            [DataMember]
            internal string type = string.Empty;

            [DataMember]
            internal string expiry = string.Empty;

            [DataMember]
            internal string uid = string.Empty;
        }

        private const string _aesKey = "I'd tell you a joke about UDP, but I'm not sure you'd get it";

        private byte[] _aesIV = new byte[32]
        {
            25,
            29,
            13,
            5,
            8,
            9,
            10,
            71,
            76,
            10,
            12,
            19,
            20,
            10,
            10,
            9,
            25,
            29,
            13,
            5,
            8,
            9,
            10,
            71,
            76,
            10,
            12,
            19,
            20,
            10,
            10,
            9
        };

        public string _key;

        public string Username
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }

        public string Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }

        public string Response
        {
            get;
            set;
        }

        public UltamationLicence Licence
        {
            get;
            set;
        } = new UltamationLicence((Type)null);
        private void button1_Click(object sender, EventArgs e)
        {
            //CompanyStr.Text = DateTime.Today.AddYears(10).ToString();
            Register();
        }

        
        public static void StoreLicence(UltamationLicence licence)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string.Format("Software\\Ultamation\\{0}", licence.ProductGUID), true);
            if (registryKey != null)
            {
                registryKey.SetValue("Licence", licence.Encrypt(), RegistryValueKind.Binary);
            }
        }

        public void Register()
        {

            this.Licence.ProductKey = ProductKeyStr.Text;
            this.Licence.LicencedCompany = CompanyStr.Text;
            this.Licence.LicencedIndividual = UserStr.Text;
            this.Licence.EMail = EMailStr.Text;
            this.Licence.UniqueMachineID = this.Licence.BuildUniqueMachineId();
            this.Licence.Type = UltamationLicence.UltamationLicenceType.Full;
            this.Licence.Expiry = DateTime.Today.AddYears(100);
            UltamationLicenceProvider.StoreLicence(this.Licence);
            //Settings.Default.LicenceUsername = this.Username;
            //Settings.Default.LicenceCompany = this.Company;
            //Settings.Default.LicenceKey = this.Key;
            //Settings.Default.Save();
        }

    }
}
