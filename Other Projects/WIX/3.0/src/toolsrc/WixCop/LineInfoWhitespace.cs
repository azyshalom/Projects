//-------------------------------------------------------------------------------------------------
// <copyright file="LineInfoWhitespace.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// 
// <summary>
// Wrapper for XmlWhitespace that implements IXmlLineInfo.
// Originally from www.gotdotnet.com/userfiles/XMLDom/extendDOM.zip
// </summary>
//-------------------------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstaller.Tools
{
    using System;
    using System.Xml;

    /// <summary>
    /// Wrapper for XmlWhitespace that implements IXmlLineInfo.
    /// </summary>
    public class LineInfoWhitespace : XmlWhitespace, IXmlLineInfo
    {
        private int lineNumber = -1;
        private int linePosition = -1;

        /// <summary>
        /// Instantiate a new LineInfoWhitespace class.
        /// </summary>
        /// <param name="data">The data of the node.</param>
        /// <param name="doc">The document that owns this node.</param>
        internal LineInfoWhitespace(string data, XmlDocument doc) : base(data, doc)
        {
        }

        /// <summary>
        /// Gets the line number.
        /// </summary>
        /// <value>The line number.</value>
        public int LineNumber
        {
            get { return this.lineNumber; }
        }

        /// <summary>
        /// Gets the line position.
        /// </summary>
        /// <value>The line position.</value>
        public int LinePosition
        {
            get { return this.linePosition; }
        }

        /// <summary>
        /// Set the line information for this node.
        /// </summary>
        /// <param name="lineNumber">The line number.</param>
        /// <param name="linePosition">The line position.</param>
        public void SetLineInfo(int lineNumber, int linePosition)
        {
            this.lineNumber = lineNumber;
            this.linePosition = linePosition;
        }

        /// <summary>
        /// Determines if this node has line information.
        /// </summary>
        /// <returns>true.</returns>
        public bool HasLineInfo()
        {
            return true;
        }
    }
}