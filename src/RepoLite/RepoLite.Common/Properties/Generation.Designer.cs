﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepoLite.Common.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    public sealed partial class Generation : global::System.Configuration.ApplicationSettingsBase {
        
        private static Generation defaultInstance = ((Generation)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Generation())));
        
        public static Generation Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NS.Models")]
        public string ModelGenerationNamespace {
            get {
                return ((string)(this["ModelGenerationNamespace"]));
            }
            set {
                this["ModelGenerationNamespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NS")]
        public string RepositoryGenerationNamespace {
            get {
                return ((string)(this["RepositoryGenerationNamespace"]));
            }
            set {
                this["RepositoryGenerationNamespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Temp")]
        public string OutputDirectory {
            get {
                return ((string)(this["OutputDirectory"]));
            }
            set {
                this["OutputDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("m.{Name}")]
        public string ModelFileNameFormat {
            get {
                return ((string)(this["ModelFileNameFormat"]));
            }
            set {
                this["ModelFileNameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{Name}")]
        public string RepositoryFileNameFormat {
            get {
                return ((string)(this["RepositoryFileNameFormat"]));
            }
            set {
                this["RepositoryFileNameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Framework35")]
        public global::RepoLite.Common.Enums.TargetFramework TargetFramework {
            get {
                return ((global::RepoLite.Common.Enums.TargetFramework)(this["TargetFramework"]));
            }
            set {
                this["TargetFramework"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CSharp4")]
        public global::RepoLite.Common.Enums.CSharpVersion CSharpVersion {
            get {
                return ((global::RepoLite.Common.Enums.CSharpVersion)(this["CSharpVersion"]));
            }
            set {
                this["CSharpVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::RepoLite.Common.Enums.PluginEnum Plugin {
            get {
                return ((global::RepoLite.Common.Enums.PluginEnum)(this["Plugin"]));
            }
            set {
                this["Plugin"] = value;
            }
        }
    }
}
