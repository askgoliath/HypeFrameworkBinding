//
// Copyright (C) 2015 Hype Labs - All Rights Reserved
//
// NOTICE: All information contained herein is, and remains the property of
// Hype Labs. The intellectual and technical concepts contained herein are
// proprietary to Hype Labs and may be covered by U.S. and Foreign Patents,
// patents in process, and are protected by trade secret and copyright law.
// Dissemination of this information or reproduction of this material is
// strictly forbidden unless prior written permission is obtained from
// Hype Labs.
//

#import <Foundation/Foundation.h>

@class HYP;
@class HYPMessage;
@class HYPInstance;

/**
 * @abstract Message observers.
 * @discussion Message observers listen to message events, such as messages
 * being received, delivered, or failing delivery.
 */
@protocol HYPMessageObserver <NSObject>

/**
 * @abstract Notification issued when a message is received.
 * @discussion This notification is issued when a message arrives from a foreign
 * source. The framework passes the data as it is received and makes no attempt
 * of processing it (other than encrypting and decrypting it, when applicable).
 * The instance parameter indicates the sending framework instance.
 * @param hype The HYP singleton instance.
 * @param message A container for the data and metadata for the message received.
 * @param instance The sending framework instance.
 */
- (void)hype:(HYP *)hype didReceiveMessage:(HYPMessage *)message fromInstance:(HYPInstance *)instance;

/**
 * @abstract Notification issue when a message cannot be delivered.
 * @discussion This notification is issued when a message is known to have failed
 * delivery. The current implementation does not acknowledge message reception, and
 * as such this method cannot identify failed delivery when using mesh relaying.
 * Instead, these notifications are triggered only when the message immediately fails,
 * such as when sending content to an unknown or previously lost instance. Future
 * releases will trigger this notification to indicate other kinds of failure, even
 * in mesh.
 * @param hype The HYP singleton instance.
 * @param message A container for the data and metadata for the message being sent.
 * @param instance The instance to which the message was intented.
 * @param error An error indicating the cause of failure.
 */
- (void)hype:(HYP *)hype didFailSending:(HYPMessage *)message toInstance:(HYPInstance *)instance
       error:(NSError *)error;

@end
