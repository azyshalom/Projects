/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using System;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using IServiceProvider = System.IServiceProvider;
using Microsoft.VisualStudio.OLE.Interop;

namespace Microsoft.VisualStudio.Package.Automation
{
	[ComVisible(true), CLSCompliant(false)]
	public class OAReferenceItem : OAProjectItem<ReferenceNode>
	{
		#region ctors
		public OAReferenceItem(OAProject proj, ReferenceNode node)
			: base(proj, node)
		{
		}

		#endregion

		#region overridden methods
		/// <summary>
		/// Not implemented. If called throws invalid operation exception.
		/// </summary>	
		public override void Delete()
		{
			throw new InvalidOperationException();
		}


		/// <summary>
		/// Not implemented. If called throws invalid operation exception.
		/// </summary>
		/// <param name="viewKind"> A Constants. vsViewKind indicating the type of view to use.</param>
		/// <returns></returns>
		public override EnvDTE.Window Open(string viewKind)
		{
			throw new InvalidOperationException();
		}
		
		/// <summary>
		/// Gets or sets the name of the object.
		/// </summary>
		public override string Name
		{
			get
			{
				return base.Name;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>
		/// Gets the ProjectItems collection containing the ProjectItem object supporting this property.
		/// </summary>
		public override EnvDTE.ProjectItems Collection
		{
			get 
			{
				// Get the parent node (ReferenceContainerNode)
				ReferenceContainerNode parentNode = this.Node.Parent as ReferenceContainerNode;
				Debug.Assert(parentNode != null, "Failed to get the parent node");

				// Get the ProjectItems object for the parent node
				if (parentNode != null)
				{
					// The root node for the project
					return ((OAReferenceFolderItem)parentNode.GetAutomationObject()).ProjectItems;
				}

				return null;
			}
		}
		#endregion
	}
}
