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

/**
 * @abstract Represents a message sent over the network.
 * @discussion Messages are abstract entities that help keeping track of
 * data as it is sent over the network. This version of the framework does
 * not provide any type of content tracking, and as such this class is
 * meant for future use. Currently, the message's identifier is always
 * set to zero.
 */
@interface HYPMessage : NSObject

/**
 * @abstract Message identifier.
 * @discussion This identifier is used to keep track of delivery state of
 * messages sent of the network. Each message is assigned a unique identifier.
 */
@property (atomic, readonly) NSUInteger identifier;

/**
 * @abstract Message data.
 * @discussion The data holds the content that was sent or received with a
 * given message.
 */
@property (atomic, readonly) NSData * data;

/**
 * @abstract Initializer.
 * @discussion Initializes a message object with the given parameters.
 * @param identifier The message identifier.
 * @param data The data to associate the message with.
 */
- (instancetype)initWithIdentifier:(NSUInteger)identifier
                              data:(NSData* )data;

@end