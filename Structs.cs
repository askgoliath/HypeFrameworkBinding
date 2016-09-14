using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace HypeFramework
{
	public static class CFunctions
	{
		// extern int NS_ENUM (int NSUInteger, int HYPState);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int HYPState);

		// extern NSString * HYPDescribeError (NSError *error);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString HYPDescribeError (NSError error);

		// extern NSString * HYPTransportTypeDescription (HYPTransportType transportType);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString HYPTransportTypeDescription (HYPTransportType transportType);

		// extern NSString * HYPTransportTypeShortDescription (HYPTransportType transportType);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString HYPTransportTypeShortDescription (HYPTransportType transportType);

		// extern NSUInteger HYPVersion ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern nuint HYPVersion ();

		// extern NSString * HYPVersionString ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString HYPVersionString ();

		// extern NSUInteger HYPVersionMajor ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern nuint HYPVersionMajor ();

		// extern NSUInteger HYPVersionMinor ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern nuint HYPVersionMinor ();

		// extern NSUInteger HYPVersionPatch ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern nuint HYPVersionPatch ();
	}

	[Native]
	public enum HYPErrorCode : int
	{
		Unknown = 1051,
		AdapterDisabled = 1101,
		AdapterUnauthorized = 1102,
		AdapterNotSupported = 1103,
		AdapterBusy = 1104,
		ProtocolViolation = 1151,
		NotConnected = 1201,
		NotConnectable = 1202,
		ConnectionTimeout = 1203,
		StreamNotOpen = 1251
	}

	[Native]
	public enum HYPTransportType : uint
	{
		BluetoothLowEnergy = 1,
		BluetoothClassic = 2,
		WiFiDirect = 4,
		WiFiInfra = 8,
		Web = 16
	}

	[Native]
	public enum HYPState : ulong
	{
		HYPStateIdle = 0,
    	HYPStateStarting = 1,
    	HYPStateRunning = 2,
    	HYPStateStopping = 3
	}
}