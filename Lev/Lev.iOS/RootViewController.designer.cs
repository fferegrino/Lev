// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Lev.iOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton botonCalcula { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField palabra1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField palabra2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel resultadoLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (botonCalcula != null) {
				botonCalcula.Dispose ();
				botonCalcula = null;
			}
			if (palabra1 != null) {
				palabra1.Dispose ();
				palabra1 = null;
			}
			if (palabra2 != null) {
				palabra2.Dispose ();
				palabra2 = null;
			}
			if (resultadoLabel != null) {
				resultadoLabel.Dispose ();
				resultadoLabel = null;
			}
		}
	}
}
