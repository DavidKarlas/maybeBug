// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace maybeBug
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
        [field: WeakAttribute]
		AppKit.NSButton button1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (button1 != null) {
				button1.Dispose ();
				button1 = null;
			}
		}
	}
}
