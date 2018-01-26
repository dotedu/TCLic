using System;
using System.ComponentModel;
using System.IO;
using System.Management;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;

namespace TCLic
{
    public class UltamationLicence : License
    {
        public enum UltamationLicenceType
        {
            Demo,
            Full,
            Development,
            TimeLimited,
            FreeIssue
        }

        [DataContract]
        internal class LicenceRegistryValue
        {
            [DataMember]
            internal string Key;

            [DataMember]
            internal string Company;

            [DataMember]
            internal string User;

            [DataMember]
            internal string Email;

            [DataMember]
            internal string Type;

            [DataMember]
            internal string Expiry;

            [DataMember]
            internal string UniqueMachineID;
        }

        private const string _aesKey = "I'd tell you a joke about UDP, but I'm not sure you'd get it";

        private byte[] _aesIV = new byte[16]
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
            9
        };

        private Type _type;

        private static string KeyTable = "ACDEFGHJKLMNPRTWXY0123456789";

        public string ProductKey
        {
            get;
            set;
        }

        public string LicencedCompany
        {
            get;
            set;
        }

        public string LicencedIndividual
        {
            get;
            set;
        }

        public string EMail
        {
            get;
            set;
        }

        public string ProductGUID
        {
            get
            {
                return "1274C135-08E5-4825-9378-AF3423C93C23";
            }
        }

        public UltamationLicenceType Type
        {
            get;
            set;
        }

        public DateTime Expiry
        {
            get;
            set;
        }

        public string UniqueMachineID
        {
            get;
            set;
        }

        public string TypeString
        {
            get
            {
                switch (this.Type)
                {
                    case UltamationLicenceType.Demo:
                        return "Demo - Limited Functionality";
                    case UltamationLicenceType.Development:
                        return "Full - For Development Use Only";
                    case UltamationLicenceType.FreeIssue:
                        return "Full - Free Issue";
                    case UltamationLicenceType.Full:
                        return "Full";
                    case UltamationLicenceType.TimeLimited:
                        return string.Format("Full - Time Limited: {0} days to go", (this.Expiry - DateTime.Now).Days);
                    default:
                        return "Demo - Unknown";
                }
            }
        }

        public override string LicenseKey
        {
            get
            {
                return this.ProductKey;
            }
        }

        public UltamationLicence(Type type)
        {
            
            this.SetToUnlicenced();
        }

        public void SetToUnlicenced()
        {
            this.ProductKey = "*****-*****-*****-*****-*****";
            this.LicencedCompany = "Unlicenced";
            this.LicencedIndividual = "Unlicenced";
            this.EMail = "";
            this.Type = UltamationLicenceType.Demo;
            this.Expiry = DateTime.Today;
            this.UniqueMachineID = this.BuildUniqueMachineId();
        }

        public bool IsUnlicenced()
        {
            return this.Type == UltamationLicenceType.Demo;
        }

        public bool IsValidForThisMachine()
        {
            return this.UniqueMachineID == this.BuildUniqueMachineId();
        }

        public byte[] Encrypt()
        {
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(LicenceRegistryValue));
            MemoryStream memoryStream = new MemoryStream();
            LicenceRegistryValue licenceRegistryValue = new LicenceRegistryValue();
            licenceRegistryValue.Key = this.ProductKey;
            licenceRegistryValue.Company = this.LicencedCompany;
            licenceRegistryValue.User = this.LicencedIndividual;
            licenceRegistryValue.Email = this.EMail;
            licenceRegistryValue.UniqueMachineID = this.UniqueMachineID;
            licenceRegistryValue.Expiry = this.Expiry.ToLongDateString();
            licenceRegistryValue.Type = Enum.GetName(typeof(UltamationLicenceType), this.Type);
            try
            {
                dataContractJsonSerializer.WriteObject(memoryStream, licenceRegistryValue);
                byte[] buffer = memoryStream.GetBuffer();
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.ASCII.GetBytes("I'd tell you a joke about UDP, but I'm not sure you'd get it".Substring(0, 32));
                    aes.IV = this._aesIV;
                    ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream2, transform, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(buffer, 0, buffer.Length);
                            cryptoStream.FlushFinalBlock();
                            return memoryStream2.ToArray();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Decrypt(byte[] encLic)
        {
            byte[] array = default(byte[]);
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.ASCII.GetBytes("I'd tell you a joke about UDP, but I'm not sure you'd get it".Substring(0, 32));
                    aes.IV = this._aesIV;
                    ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
                    using (MemoryStream stream = new MemoryStream(encLic))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read))
                        {
                            array = new byte[encLic.Length];
                            cryptoStream.Read(array, 0, array.Length);
                        }
                    }
                }
            }
            catch (Exception)
            {
                array = new byte[0];
                return false;
            }
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(LicenceRegistryValue));
            int num = Array.IndexOf(array, (byte)0);
            if (num == -1)
            {
                num = array.Length;
            }
            MemoryStream stream2 = new MemoryStream(array, 0, num);
            try
            {
                LicenceRegistryValue licenceRegistryValue = (LicenceRegistryValue)dataContractJsonSerializer.ReadObject(stream2);
                this.ProductKey = licenceRegistryValue.Key;
                this.LicencedCompany = licenceRegistryValue.Company;
                this.LicencedIndividual = licenceRegistryValue.User;
                this.EMail = licenceRegistryValue.Email;
                this.UniqueMachineID = licenceRegistryValue.UniqueMachineID;
                this.Expiry = DateTime.Parse(licenceRegistryValue.Expiry);
                this.Type = (UltamationLicenceType)Enum.Parse(typeof(UltamationLicenceType), licenceRegistryValue.Type);
            }
            catch (Exception)
            {
                this.SetToUnlicenced();
                return false;
            }
            return true;
        }

        public string BuildUniqueMachineId()
        {
            string str = string.Empty;
            using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
            {
                if (managementObjectEnumerator.MoveNext())
                {
                    str = ((ManagementObject)managementObjectEnumerator.Current).Properties["processorID"].Value.ToString();
                }
            }
            string str2 = "C";
            ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str2 + ":\"");
            managementObject.Get();
            string str3 = ((ManagementBaseObject)managementObject)["VolumeSerialNumber"].ToString();
            return str + str3;
        }

        public override void Dispose()
        {
        }

        public string NormaliseKey(string inKey)
        {
            return inKey.ToUpper().Trim().Replace(" ", "")
                .Replace("-", "");
        }

        public bool IsKeyValid(string key)
        {
            string text = this.NormaliseKey(key);
            if (text.Length != 25)
            {
                return false;
            }
            for (int i = 0; i < 5; i++)
            {
                int num = i * 4;
                for (int j = 0; j < 4; j++)
                {
                    num += UltamationLicence.KeyTable.IndexOf(text[i * 5 + j]);
                }
                num %= UltamationLicence.KeyTable.Length;
                if (text[i * 5 + 4] != UltamationLicence.KeyTable[num])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
