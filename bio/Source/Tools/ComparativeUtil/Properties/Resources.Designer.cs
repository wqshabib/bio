﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComparativeUtil.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ComparativeUtil.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Reads containing ambiguous symbols are not supported..
        /// </summary>
        internal static string AmbiguousReadsNotSupported {
            get {
                return ResourceManager.GetString("AmbiguousReadsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:	   ComparativeUtil.exe [options] &lt;ReferenceGenome&gt; &lt;Reads&gt;
        ///Description: Assembles the given reads using comparative assembly.
        ///
        ///Options:
        ///
        ///-scaffold                            Run scaffolding. (short form /s)
        ///
        ///-kmerlength:&lt;int&gt;                    Sets kmer length. (short form /k)
        ///
        ///-MumLength:&lt;int&gt;                     Minimum length of MUM(short form /m)      
        ///
        ///-help	                             Print the help information. (short form /h)
        ///
        ///-outputFile:&lt;string&gt;                 Output file. ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AssembleHelp {
            get {
                return ResourceManager.GetString("AssembleHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparative Utility v1.0
        ///Copyright (c) 2011, The Outercurve Foundation.
        ///.
        /// </summary>
        internal static string ComparativeSplashScreen {
            get {
                return ResourceManager.GetString("ComparativeSplashScreen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output written to the specified file..
        /// </summary>
        internal static string OutPutWrittenToFileSpecified {
            get {
                return ResourceManager.GetString("OutPutWrittenToFileSpecified", resourceCulture);
            }
        }
    }
}
