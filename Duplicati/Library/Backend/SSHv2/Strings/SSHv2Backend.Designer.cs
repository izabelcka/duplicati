﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Backend.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SSHv2Backend {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SSHv2Backend() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.SSHv2Backend", typeof(SSHv2Backend).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This backend can read and write data to an SSH based backend, using SFTP. Allowed formats are &quot;ssh://hostname/folder&quot; or &quot;ssh://username:password@hostname/folder&quot;..
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password used to connect to the server. This may also be supplied as the environment variable &quot;AUTH_PASSWORD&quot;..
        /// </summary>
        internal static string DescriptionAuthPasswordLong {
            get {
                return ResourceManager.GetString("DescriptionAuthPasswordLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the password used to connect to the server.
        /// </summary>
        internal static string DescriptionAuthPasswordShort {
            get {
                return ResourceManager.GetString("DescriptionAuthPasswordShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username used to connect to the server. This may also be supplied as the environment variable &quot;AUTH_USERNAME&quot;..
        /// </summary>
        internal static string DescriptionAuthUsernameLong {
            get {
                return ResourceManager.GetString("DescriptionAuthUsernameLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the username used to connect to the server.
        /// </summary>
        internal static string DescriptionAuthUsernameShort {
            get {
                return ResourceManager.GetString("DescriptionAuthUsernameShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SSH backend relies on an external program (sftp) to work. Since the external program may change at any time, this may break the backend. Enable this option to get debug information about the ssh connection written to the console. Only used if the --use-sftp-application option is supplied..
        /// </summary>
        internal static string DescriptionDebugToConsoleLong {
            get {
                return ResourceManager.GetString("DescriptionDebugToConsoleLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prints debug info to the console.
        /// </summary>
        internal static string DescriptionDebugToConsoleShort {
            get {
                return ResourceManager.GetString("DescriptionDebugToConsoleShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Points to a valid OpenSSH keyfile. If the file is encrypted, the password supplied is used to decrypt the keyfile.  If this option is supplied, the password is not used to authenticate. This option only works when using the managed SSH client..
        /// </summary>
        internal static string DescriptionSshkeyfileLong {
            get {
                return ResourceManager.GetString("DescriptionSshkeyfileLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uses a SSH private key to authenticate.
        /// </summary>
        internal static string DescriptionSshkeyfileShort {
            get {
                return ResourceManager.GetString("DescriptionSshkeyfileShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supply any extra commandline arguments, which are passed unaltered to the ssh application.  Only used if the --use-sftp-application option is supplied..
        /// </summary>
        internal static string DescriptionSSHOptionsLong {
            get {
                return ResourceManager.GetString("DescriptionSSHOptionsLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extra options to the ssh commands.
        /// </summary>
        internal static string DescriptionSSHOptionsShort {
            get {
                return ResourceManager.GetString("DescriptionSSHOptionsShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SSH backend relies on an external program (sftp) to work. Since the external program may hang, Duplicati must use a timeout to detect a stall in the external program. Use this option to adjust the timeout. Minimum allowed value is one minute, maximum allowed is one hour. Only used if the --use-sftp-application option is supplied..
        /// </summary>
        internal static string DescriptionTransferTimeoutLong {
            get {
                return ResourceManager.GetString("DescriptionTransferTimeoutLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the timeout for transfering a file.
        /// </summary>
        internal static string DescriptionTransferTimeoutShort {
            get {
                return ResourceManager.GetString("DescriptionTransferTimeoutShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSH based on SSH.NET.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to set folder to {0}, error message: {1}.
        /// </summary>
        internal static string FolderNotFoundManagedError {
            get {
                return ResourceManager.GetString("FolderNotFoundManagedError", resourceCulture);
            }
        }
    }
}
