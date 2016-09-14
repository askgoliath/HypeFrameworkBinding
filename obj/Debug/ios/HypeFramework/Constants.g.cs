//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace HypeFramework {
	public unsafe static partial class Constants  {
		
		[CompilerGenerated]
		static NSString _HYPErrorDomain;
		[Field ("HYPErrorDomain",  "__Internal")]
		public static unsafe NSString HYPErrorDomain {
			get {
				if (_HYPErrorDomain == null)
					_HYPErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "HYPErrorDomain");
				return _HYPErrorDomain;
			}
		}
		[CompilerGenerated]
		static NSString _HYPOptionIdentifierKey;
		[Field ("HYPOptionIdentifierKey",  "__Internal")]
		public static unsafe NSString HYPOptionIdentifierKey {
			get {
				if (_HYPOptionIdentifierKey == null)
					_HYPOptionIdentifierKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "HYPOptionIdentifierKey");
				return _HYPOptionIdentifierKey;
			}
		}
		[CompilerGenerated]
		static NSString _HYPOptionRealmKey;
		[Field ("HYPOptionRealmKey",  "__Internal")]
		public static unsafe NSString HYPOptionRealmKey {
			get {
				if (_HYPOptionRealmKey == null)
					_HYPOptionRealmKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "HYPOptionRealmKey");
				return _HYPOptionRealmKey;
			}
		}
		[Field ("HYPTransportTypeAll",  "__Internal")]
		public static unsafe global::System.IntPtr HYPTransportTypeAll {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "HYPTransportTypeAll");
			}
		}
		[Field ("HYPTransportTypeBonjour",  "__Internal")]
		public static unsafe global::System.IntPtr HYPTransportTypeBonjour {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "HYPTransportTypeBonjour");
			}
		}
		[Field ("HYPTransportTypeNone",  "__Internal")]
		public static unsafe global::System.IntPtr HYPTransportTypeNone {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "HYPTransportTypeNone");
			}
		}
	} /* class Constants */
}
