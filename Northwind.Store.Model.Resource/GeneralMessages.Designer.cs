﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.Store.Model.Resource {
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
    public class GeneralMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GeneralMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Northwind.Store.Model.Resource.GeneralMessages", typeof(GeneralMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Se requiere entre {1} caracteres.
        /// </summary>
        public static string CategoryDescriptionLength {
            get {
                return ResourceManager.GetString("CategoryDescriptionLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La descripcion es requerida.
        /// </summary>
        public static string CategoryDescriptionRequired {
            get {
                return ResourceManager.GetString("CategoryDescriptionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Descripcion.
        /// </summary>
        public static string CategoryDescriptionTitle {
            get {
                return ResourceManager.GetString("CategoryDescriptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Se requiere entre {2} y {1} caracteres.
        /// </summary>
        public static string CategoryNameLength {
            get {
                return ResourceManager.GetString("CategoryNameLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El nombre es requerido.
        /// </summary>
        public static string CategoryNameRequired {
            get {
                return ResourceManager.GetString("CategoryNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre.
        /// </summary>
        public static string CategoryNameTitle {
            get {
                return ResourceManager.GetString("CategoryNameTitle", resourceCulture);
            }
        }
    }
}
