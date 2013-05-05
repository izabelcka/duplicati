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
    internal class FileBackend {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FileBackend() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.FileBackend", typeof(FileBackend).Assembly);
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
        ///   Looks up a localized string similar to This option only works when the --{0} option is also specified. If there are alternate paths specified, this option indicates the name of a marker file that must be present in the folder. This can be used to handle situations where an external drive changes drive letter or mount point. By ensuring that a certain file exists, it is possible to prevent writing data to an unwanted external drive. The contents of the file are never examined, only file existence..
        /// </summary>
        internal static string AlternateDestinationMarkerLong {
            get {
                return ResourceManager.GetString("AlternateDestinationMarkerLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Look for a file in the destination folder.
        /// </summary>
        internal static string AlternateDestinationMarkerShort {
            get {
                return ResourceManager.GetString("AlternateDestinationMarkerShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option allows multiple targets to be specified. The primary target path is placed before the list of paths supplied with this option. Before starting the backup, each folder in the list is checked for existence and optionally the presence of the marker file supplied by --{0}. The first existing path that optionally contains the marker file is then used as the destination. Multiple destinations are separated with a {1},. On Windows, the path may be a UNC path, and the drive letter may be substituted with an asterisk (*), eg.: &quot;*:\backup&quot;, which will examine all drive letters. If a username and password is supplied, the same credentials are used for all destinations..
        /// </summary>
        internal static string AlternateTargetPathsLong {
            get {
                return ResourceManager.GetString("AlternateTargetPathsLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of secondary target paths.
        /// </summary>
        internal static string AlternateTargetPathsShort {
            get {
                return ResourceManager.GetString("AlternateTargetPathsShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This backend can read and write data to an file based backend. Allowed formats are &quot;file://hostname/folder&quot; or &quot;file://username:password@hostname/folder&quot;. You may supply UNC paths (eg: &quot;file://\\server\folder&quot;) or local paths (eg: (win) &quot;file://c:\folder&quot;, (linux) &quot;file:///usr/pub/files&quot;).
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
        ///   Looks up a localized string similar to File based.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} does not exist.
        /// </summary>
        internal static string FolderMissingError {
            get {
                return ResourceManager.GetString("FolderMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The marker file &quot;{0}&quot; was not found in any of the examined destinations: {1}.
        /// </summary>
        internal static string NoDestinationWithMarkerFileError {
            get {
                return ResourceManager.GetString("NoDestinationWithMarkerFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When storing the file, the standard operation is to copy the file and delete the original. This sequence ensures that the operation can be retried if something goes wrong. Activating this option may cause the retry operation to fail.  This option has no effect unless the --disable-streaming-transfers options is activated..
        /// </summary>
        internal static string UseMoveForPutLong {
            get {
                return ResourceManager.GetString("UseMoveForPutLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the file instead of copying it.
        /// </summary>
        internal static string UseMoveForPutShort {
            get {
                return ResourceManager.GetString("UseMoveForPutShort", resourceCulture);
            }
        }
    }
}
