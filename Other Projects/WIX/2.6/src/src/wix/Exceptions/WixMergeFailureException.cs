//-------------------------------------------------------------------------------------------------
// <copyright file="WixMergeFailureException.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// 
// <summary>
// WiX merge failure exception.
// </summary>
//-------------------------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstallerXml
{
    using System;

    /// <summary>
    /// WiX merge failure exception.
    /// </summary>
    public class WixMergeFailureException : WixException
    {
        private string tempFiles;
        private long numErrors;

        /// <summary>
        /// Instantiate a new WixMergeFailureException.
        /// </summary>
        /// <param name="sourceLineNumbers">Source line information of the exception.</param>
        /// <param name="tempFiles">Directory containing the merge log.</param>
        /// <param name="numErrors">Number of errors that occurred.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public WixMergeFailureException(SourceLineNumberCollection sourceLineNumbers, string tempFiles, long numErrors, Exception innerException) :
            base(sourceLineNumbers, WixExceptionType.MergeFailure, innerException)
        {
            this.tempFiles = tempFiles;
            this.numErrors = numErrors;
        }

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        /// <value>The error message that explains the reason for the exception, or an empty string("").</value>
        public override string Message
        {
            get 
            {
                if (1 < this.numErrors)
                {
                    return String.Format("Merge completed, but there were {0} errors. See log file in \"{1}\\merge.log\" for details.", this.numErrors, this.tempFiles);
                }
                else
                {
                    return String.Format("Merge completed, but there was an error. See log file in \"{0}\\merge.log\" for details.", this.tempFiles);
                }
            }
        }
    }
}