using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace TCLic
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    public sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Select a compiled theme to import...")]
        public string ImportCompiledThemeFilepath
        {
            get
            {
                return (string)((SettingsBase)this)["ImportCompiledThemeFilepath"];
            }
            set
            {
                ((SettingsBase)this)["ImportCompiledThemeFilepath"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Select a working directory for the theme...")]
        public string ImportThemeWorkingDirectory
        {
            get
            {
                return (string)((SettingsBase)this)["ImportThemeWorkingDirectory"];
            }
            set
            {
                ((SettingsBase)this)["ImportThemeWorkingDirectory"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool LoadLastProjectOnStart
        {
            get
            {
                return (bool)((SettingsBase)this)["LoadLastProjectOnStart"];
            }
            set
            {
                ((SettingsBase)this)["LoadLastProjectOnStart"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string LastProjectFilepath
        {
            get
            {
                return (string)((SettingsBase)this)["LastProjectFilepath"];
            }
            set
            {
                ((SettingsBase)this)["LastProjectFilepath"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string LicenceUsername
        {
            get
            {
                return (string)((SettingsBase)this)["LicenceUsername"];
            }
            set
            {
                ((SettingsBase)this)["LicenceUsername"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string LicenceCompany
        {
            get
            {
                return (string)((SettingsBase)this)["LicenceCompany"];
            }
            set
            {
                ((SettingsBase)this)["LicenceCompany"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string LicenceKey
        {
            get
            {
                return (string)((SettingsBase)this)["LicenceKey"];
            }
            set
            {
                ((SettingsBase)this)["LicenceKey"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string FlexSDKLocation
        {
            get
            {
                return (string)((SettingsBase)this)["FlexSDKLocation"];
            }
            set
            {
                ((SettingsBase)this)["FlexSDKLocation"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string NewThemeWorkingDirectory
        {
            get
            {
                return (string)((SettingsBase)this)["NewThemeWorkingDirectory"];
            }
            set
            {
                ((SettingsBase)this)["NewThemeWorkingDirectory"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string ImageImportDirectory
        {
            get
            {
                return (string)((SettingsBase)this)["ImageImportDirectory"];
            }
            set
            {
                ((SettingsBase)this)["ImageImportDirectory"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool UpgradeSettingsRequired
        {
            get
            {
                return (bool)((SettingsBase)this)["UpgradeSettingsRequired"];
            }
            set
            {
                ((SettingsBase)this)["UpgradeSettingsRequired"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string JavaLocation
        {
            get
            {
                return (string)((SettingsBase)this)["JavaLocation"];
            }
            set
            {
                ((SettingsBase)this)["JavaLocation"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("100")]
        public double WindowTop
        {
            get
            {
                return (double)((SettingsBase)this)["WindowTop"];
            }
            set
            {
                ((SettingsBase)this)["WindowTop"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("100")]
        public double WindowLeft
        {
            get
            {
                return (double)((SettingsBase)this)["WindowLeft"];
            }
            set
            {
                ((SettingsBase)this)["WindowLeft"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("800")]
        public double WindowHeight
        {
            get
            {
                return (double)((SettingsBase)this)["WindowHeight"];
            }
            set
            {
                ((SettingsBase)this)["WindowHeight"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1024")]
        public double WindowWidth
        {
            get
            {
                return (double)((SettingsBase)this)["WindowWidth"];
            }
            set
            {
                ((SettingsBase)this)["WindowWidth"] = value;
            }
        }

        //[UserScopedSetting]
        //[DebuggerNonUserCode]
        //[DefaultSettingValue("Normal")]
        //public WindowState WindowState
        //{
        //    get
        //    {
        //        return (WindowState)((SettingsBase)this)["WindowState"];
        //    }
        //    set
        //    {
        //        ((SettingsBase)this)["WindowState"] = value;
        //    }
        //}

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool OptionAlwaysSaveBeforeCompile
        {
            get
            {
                return (bool)((SettingsBase)this)["OptionAlwaysSaveBeforeCompile"];
            }
            set
            {
                ((SettingsBase)this)["OptionAlwaysSaveBeforeCompile"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string MRUList
        {
            get
            {
                return (string)((SettingsBase)this)["MRUList"];
            }
            set
            {
                ((SettingsBase)this)["MRUList"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool OptionWarnIfOrphanedStylesExist
        {
            get
            {
                return (bool)((SettingsBase)this)["OptionWarnIfOrphanedStylesExist"];
            }
            set
            {
                ((SettingsBase)this)["OptionWarnIfOrphanedStylesExist"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool OptionWarnIfIncompleteControlStylesExist
        {
            get
            {
                return (bool)((SettingsBase)this)["OptionWarnIfIncompleteControlStylesExist"];
            }
            set
            {
                ((SettingsBase)this)["OptionWarnIfIncompleteControlStylesExist"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool OptionWarnIfMissingImages
        {
            get
            {
                return (bool)((SettingsBase)this)["OptionWarnIfMissingImages"];
            }
            set
            {
                ((SettingsBase)this)["OptionWarnIfMissingImages"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool ExpertMode
        {
            get
            {
                return (bool)((SettingsBase)this)["ExpertMode"];
            }
            set
            {
                ((SettingsBase)this)["ExpertMode"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public int JavaHeapMax
        {
            get
            {
                return (int)((SettingsBase)this)["JavaHeapMax"];
            }
            set
            {
                ((SettingsBase)this)["JavaHeapMax"] = value;
            }
        }
    }
}
