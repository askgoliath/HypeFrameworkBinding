using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace HypeFramework
{
	[Static]
 	partial interface Constants
	{
		// extern int NSString;
		[Field("HYPOptionIdentifierKey", "__Internal")]
		NSString HYPOptionIdentifierKey { get; }

		//// extern int NSString;
		[Field("HYPOptionRealmKey", "__Internal")]
		NSString HYPOptionRealmKey { get; }
	}

	// @interface HYP
	[BaseType(typeof(NSObject))]
	interface HYP
	{
		// @property (readonly, atomic) int state;
		[Export("state")]
		HYPState State { get; }

		// +(instancetype)instance;
		[Static]
		[Export("instance")]
		HYP Instance();

		// -(void)addMessageObserver:(id)messageObserver;
		[Export("addMessageObserver:")]
		void AddMessageObserver(NSObject messageObserver);

		// -(void)removeMessageObserver:(id)messageObserver;
		[Export("removeMessageObserver:")]
		void RemoveMessageObserver(NSObject messageObserver);

		// -(void)addNetworkObserver:(id)networkObserver;
		[Export("addNetworkObserver:")]
		void AddNetworkObserver(HYPNetworkObserver networkObserver);

		// -(void)removeNetworkObserver:(id)networkObserver;
		[Export("removeNetworkObserver:")]
		void RemoveNetworkObserver(NSObject networkObserver);

		// -(void)addStateObserver:(id)stateObserver;
		[Export("addStateObserver:")]
		void AddStateObserver(NSObject stateObserver);

		// -(void)removeStateObserver:(id)stateObserver;
		[Export("removeStateObserver:")]
		void RemoveStateObserver(NSObject stateObserver);

		// -(void)startWithOptions:(id)options;
		[Export("startWithOptions:")]
		void StartWithOptions(NSObject options);

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(id)sendData:(id)data toInstance:(id)instance;
		[Export("sendData:toInstance:")]
		NSObject SendData(NSObject data, NSObject instance);
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const HYPErrorDomain;
		[Field("HYPErrorDomain", "__Internal")]
		NSString HYPErrorDomain { get; }
	}

	// @interface HYPInstance : NSObject
	[BaseType(typeof(NSObject))]
	interface HYPInstance
	{
		// @property (readonly, atomic) NSData * identifier;
		[Export("identifier")]
		NSData Identifier { get; }

		// @property (copy, atomic) NSString * stringIdentifier;
		[Export("stringIdentifier")]
		string StringIdentifier { get; set; }

		// -(instancetype)initWithIdentifier:(NSData *)identifier;
		[Export("initWithIdentifier:")]
		IntPtr Constructor(NSData identifier);
	}

	// @interface HYPMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface HYPMessage
	{
		// @property (readonly, atomic) NSUInteger identifier;
		[Export("identifier")]
		nuint Identifier { get; }

		// @property (readonly, atomic) NSData * data;
		[Export("data")]
		NSData Data { get; }

		// -(instancetype)initWithIdentifier:(NSUInteger)identifier data:(NSData *)data;
		[Export("initWithIdentifier:data:")]
		IntPtr Constructor(nuint identifier, NSData data);
	}

	// @protocol HYPMessageObserver <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface HYPMessageObserver
	{
		// @required -(void)hype:(HYP *)hype didReceiveMessage:(HYPMessage *)message fromInstance:(HYPInstance *)instance;
		[Abstract]
		[Export("hype:didReceiveMessage:fromInstance:")]
		void DidReceiveMessage(HYP hype, HYPMessage message, HYPInstance instance);

		// @required -(void)hype:(HYP *)hype didFailSending:(HYPMessage *)message toInstance:(HYPInstance *)instance error:(NSError *)error;
		[Abstract]
		[Export("hype:didFailSending:toInstance:error:")]
		void DidFailSending(HYP hype, HYPMessage message, HYPInstance instance, NSError error);
	}

	// @protocol HYPNetworkObserver <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface HYPNetworkObserver
	{
		// @required -(void)hype:(HYP *)hype didFindInstance:(HYPInstance *)instance;
		[Abstract]
		[Export("hype:didFindInstance:")]
		void DidFindInstance(HYP hype, HYPInstance instance);

		// @required -(void)hype:(HYP *)hype didLoseInstance:(HYPInstance *)instance error:(NSError *)error;
		[Abstract]
		[Export("hype:didLoseInstance:error:")]
		void DidLoseInstance(HYP hype, HYPInstance instance, NSError error);
	}

	// @protocol HYPStateObserver <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface HYPStateObserver
	{
		// @required -(void)hypeDidStart:(HYP *)hype;
		[Abstract]
		[Export("hypeDidStart:")]
		void HypeDidStart(HYP hype);

		// @required -(void)hypeDidStop:(HYP *)hype error:(NSError *)error;
		[Abstract]
		[Export("hypeDidStop:error:")]
		void HypeDidStop(HYP hype, NSError error);

		// @required -(void)hypeDidFailStarting:(HYP *)hype error:(NSError *)error;
		[Abstract]
		[Export("hypeDidFailStarting:error:")]
		void HypeDidFailStarting(HYP hype, NSError error);

		// @required -(void)hypeDidBecomeReady:(HYP *)hype;
		[Abstract]
		[Export("hypeDidBecomeReady:")]
		void HypeDidBecomeReady(HYP hype);

		// @optional -(void)hypeDidChangeState:(HYP *)hype;
		[Export("hypeDidChangeState:")]
		void HypeDidChangeState(HYP hype);
	}

	//[Static]
	partial interface Constants
	{
		// extern const HYPTransportType HYPTransportTypeNone;
		[Field("HYPTransportTypeNone", "__Internal")]
		IntPtr HYPTransportTypeNone { get; }

		// extern const HYPTransportType HYPTransportTypeAll;
		[Field("HYPTransportTypeAll", "__Internal")]
		IntPtr HYPTransportTypeAll { get; }

		// extern const HYPTransportType HYPTransportTypeBonjour;
		[Field("HYPTransportTypeBonjour", "__Internal")]
		IntPtr HYPTransportTypeBonjour { get; }
	}
}


// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
// to the project by right-clicking (or Control-clicking) the folder containing this source
// file and clicking "Add files..." and then simply select the native library (or libraries)
// that you want to bind.
//
// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
// architectures that the native library supports and fills in that information for you,
// however, it cannot auto-detect any Frameworks or other system libraries that the
// native library may depend on, so you'll need to fill in that information yourself.
//
// Once you've done that, you're ready to move on to binding the API...
//
//
// Here is where you'd define your API definition for the native Objective-C library.
//
// For example, to bind the following Objective-C class:
//
//     @interface Widget : NSObject {
//     }
//
// The C# binding would look like this:
//
//     [BaseType (typeof (NSObject))]
//     interface Widget {
//     }
//
// To bind Objective-C properties, such as:
//
//     @property (nonatomic, readwrite, assign) CGPoint center;
//
// You would add a property definition in the C# interface like so:
//
//     [Export ("center")]
//     CGPoint Center { get; set; }
//
// To bind an Objective-C method, such as:
//
//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
//
// You would add a method definition to the C# interface like so:
//
//     [Export ("doSomething:atIndex:")]
//     void DoSomething (NSObject object, int index);
//
// Objective-C "constructors" such as:
//
//     -(id)initWithElmo:(ElmoMuppet *)elmo;
//
// Can be bound as:
//
//     [Export ("initWithElmo:")]
//     IntPtr Constructor (ElmoMuppet elmo);
//
// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
//