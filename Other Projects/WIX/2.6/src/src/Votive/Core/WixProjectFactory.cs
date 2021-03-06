//-------------------------------------------------------------------------------------------------
// <copyright file="WixProjectFactory.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// 
// <summary>
// Integrates the custom WiX project into the Visual Studio environment.
// </summary>
//-------------------------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstallerXml.VisualStudio
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using Microsoft.Tools.WindowsInstallerXml.VisualStudioInfrastructure;
    using Microsoft.VisualStudio.Shell.Interop;

    using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

    /// <summary>
    /// Implements the IVsProjectFactory and IVsOwnedProjectFactory interfaces, which handle
    /// the creation of our custom WiX projects.
    /// </summary>
    internal sealed class WixProjectFactory : ProjectFactory
    {
        #region Member Variables
        //==========================================================================================
        // Member Variables
        //==========================================================================================
        
        #endregion

        #region Constructors
        //==========================================================================================
        // Constructors
        //==========================================================================================

        /// <summary>
        /// Initializes a new instance of the <see cref="WixProjectFactory"/> class.
        /// </summary>
        public WixProjectFactory(Package parent) : base(parent)
        {
        }
        #endregion

        #region Properties
        //==========================================================================================
        // Properties
        //==========================================================================================

        #endregion

        #region Methods
        //==========================================================================================
        // Methods
        //==========================================================================================

        /// <summary>
        /// Creates a new <see cref="WixProjectSerializer"/> to use for deserializing the specified project file.
        /// </summary>
        /// <param name="filename">The path to the file to deserialize.</param>
        /// <returns>A <see cref="WixProjectSerializer"/> object used for deserializing the specified project file.</returns>
        protected override ProjectSerializer CreateSerializer(string filename)
        {
            return new WixProjectSerializer();
        }
        #endregion
    }
}
