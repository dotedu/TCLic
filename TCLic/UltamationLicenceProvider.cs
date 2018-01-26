using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCLic
{
    public class UltamationLicenceProvider : LicenseProvider
    {
        public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
        {
            if (context.UsageMode == LicenseUsageMode.Runtime)
            {
                return UltamationLicenceProvider.RetrieveLicence(type);
            }
            return null;
        }
        public static UltamationLicence RetrieveLicence(Type type)
        {
            RegistryKey currentUser = Registry.CurrentUser;
            Guid gUID = type.GUID;
            RegistryKey registryKey = currentUser.OpenSubKey(string.Format("Software\\Ultamation\\{0}", gUID.ToString()));
            if (registryKey != null)
            {
                UltamationLicence ultamationLicence = new UltamationLicence(type);
                byte[] array = (byte[])registryKey.GetValue("Licence");
                if (array != null)
                {
                    if (!ultamationLicence.Decrypt(array))
                    {
                        throw new LicenseException(type, null, "Your installation is corrupt.\nPlease re-install.");
                    }
                    if (!ultamationLicence.IsValidForThisMachine())
                    {
                        ultamationLicence.Type = UltamationLicence.UltamationLicenceType.Demo;
                    }
                    if (ultamationLicence.Type == UltamationLicence.UltamationLicenceType.TimeLimited && ultamationLicence.Expiry > DateTime.Now)
                    {
                        //MessageBox.Show("Your licence has expired.\nThe product will continue in demo mode.", "Licence Expired", MessageBoxButton.OK, MessageBoxImage.Hand);
                        ultamationLicence.Type = UltamationLicence.UltamationLicenceType.Demo;
                        return ultamationLicence;
                    }
                    //BackgroundWorker backgroundWorker = new BackgroundWorker();
                    //backgroundWorker.DoWork += UltamationLicenceProvider.VersionCheckBackgroundWorker;
                    //backgroundWorker.RunWorkerAsync(ultamationLicence);
                }
                return ultamationLicence;
            }
            RegistryKey currentUser2 = Registry.CurrentUser;
            gUID = type.GUID;
            currentUser2.CreateSubKey(string.Format("Software\\Ultamation\\{0}", gUID.ToString()));
            return new UltamationLicence(type);
        }
        public static void StoreLicence(UltamationLicence licence)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string.Format("Software\\Ultamation\\{0}", licence.ProductGUID), true);
            if (registryKey != null)
            {
                registryKey.SetValue("Licence", licence.Encrypt(), RegistryValueKind.Binary);
            }
        }
    }
}
