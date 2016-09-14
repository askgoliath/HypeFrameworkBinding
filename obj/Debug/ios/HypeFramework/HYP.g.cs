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
	[Register("HYP", true)]
	public unsafe partial class HYP : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("HYP");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HYP () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected HYP (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal HYP (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addMessageObserver:")]
		[CompilerGenerated]
		public virtual void AddMessageObserver (NSObject messageObserver)
		{
			if (messageObserver == null)
				throw new ArgumentNullException ("messageObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addMessageObserver:"), messageObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addMessageObserver:"), messageObserver.Handle);
			}
		}
		
		[Export ("addNetworkObserver:")]
		[CompilerGenerated]
		public virtual void AddNetworkObserver (HYPNetworkObserver networkObserver)
		{
			if (networkObserver == null)
				throw new ArgumentNullException ("networkObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addNetworkObserver:"), networkObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addNetworkObserver:"), networkObserver.Handle);
			}
		}
		
		[Export ("addStateObserver:")]
		[CompilerGenerated]
		public virtual void AddStateObserver (NSObject stateObserver)
		{
			if (stateObserver == null)
				throw new ArgumentNullException ("stateObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addStateObserver:"), stateObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addStateObserver:"), stateObserver.Handle);
			}
		}
		
		[Export ("instance")]
		[CompilerGenerated]
		public static HYP Instance ()
		{
			return  Runtime.GetNSObject<HYP> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("instance")));
		}
		
		[Export ("removeMessageObserver:")]
		[CompilerGenerated]
		public virtual void RemoveMessageObserver (NSObject messageObserver)
		{
			if (messageObserver == null)
				throw new ArgumentNullException ("messageObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeMessageObserver:"), messageObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeMessageObserver:"), messageObserver.Handle);
			}
		}
		
		[Export ("removeNetworkObserver:")]
		[CompilerGenerated]
		public virtual void RemoveNetworkObserver (NSObject networkObserver)
		{
			if (networkObserver == null)
				throw new ArgumentNullException ("networkObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeNetworkObserver:"), networkObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeNetworkObserver:"), networkObserver.Handle);
			}
		}
		
		[Export ("removeStateObserver:")]
		[CompilerGenerated]
		public virtual void RemoveStateObserver (NSObject stateObserver)
		{
			if (stateObserver == null)
				throw new ArgumentNullException ("stateObserver");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeStateObserver:"), stateObserver.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeStateObserver:"), stateObserver.Handle);
			}
		}
		
		[Export ("sendData:toInstance:")]
		[CompilerGenerated]
		public virtual NSObject SendData (NSObject data, NSObject instance)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (instance == null)
				throw new ArgumentNullException ("instance");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendData:toInstance:"), data.Handle, instance.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendData:toInstance:"), data.Handle, instance.Handle));
			}
		}
		
		[Export ("startWithOptions:")]
		[CompilerGenerated]
		public virtual void StartWithOptions (NSObject options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startWithOptions:"), options.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithOptions:"), options.Handle);
			}
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		
		[CompilerGenerated]
		public virtual HYPState State {
			[Export ("state")]
			get {
				HYPState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (HYPState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					} else {
						ret = (HYPState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (HYPState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					} else {
						ret = (HYPState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
					}
				}
				return ret;
			}
			
		}
		
	} /* class HYP */
}
