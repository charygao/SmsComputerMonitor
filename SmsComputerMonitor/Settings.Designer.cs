﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmsComputerMonitor {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int CacheMaxCount {
            get {
                return ((int)(this["CacheMaxCount"]));
            }
            set {
                this["CacheMaxCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int InterTime {
            get {
                return ((int)(this["InterTime"]));
            }
            set {
                this["InterTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://172.16.86.113:9100/SMS/SendSMS")]
        public string SmsUrl {
            get {
                return ((string)(this["SmsUrl"]));
            }
            set {
                this["SmsUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public double CpuLimitedValue {
            get {
                return ((double)(this["CpuLimitedValue"]));
            }
            set {
                this["CpuLimitedValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("18521517787|18521517789")]
        public string PhoneList {
            get {
                return ((string)(this["PhoneList"]));
            }
            set {
                this["PhoneList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ContinuityNoticeFrequency {
            get {
                return ((int)(this["ContinuityNoticeFrequency"]));
            }
            set {
                this["ContinuityNoticeFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public double DrivePercentUsedLimited {
            get {
                return ((double)(this["DrivePercentUsedLimited"]));
            }
            set {
                this["DrivePercentUsedLimited"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public double MemoryPercentUsedLimited {
            get {
                return ((double)(this["MemoryPercentUsedLimited"]));
            }
            set {
                this["MemoryPercentUsedLimited"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public double TotalNetSpeedKbpsLimited {
            get {
                return ((double)(this["TotalNetSpeedKbpsLimited"]));
            }
            set {
                this["TotalNetSpeedKbpsLimited"] = value;
            }
        }
    }
}
