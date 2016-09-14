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
 * @abstract Hype network instance.
 * @discussion Instances map to devices participating on the network. Instances
 * are advertised on the network and, when found, a notification is issued
 * indicating that the instance is available for communication purposes. Usually,
 * there's no need to instantiate objects of this type at all, as the framework
 * handles that automatically.
 */
@interface HYPInstance : NSObject

/**
 * @abstract Instance identifier.
 * @discussion This property yields an identifier that is unique for each
 * instance on the network.
 */
@property (atomic, readonly) NSData * identifier;

/**
 * @abstract Instance string identifier.
 * @discussion This property yields the instance's identifier in string form.
 * The string is the data object written using hexadecimal notation.
 */
@property (atomic, copy) NSString * stringIdentifier;

/**
 * @abstract Initializer.
 * @discussion Initializes an instance object with the given identifier.
 * @param identifier Instance identifier.
 */
- (instancetype)initWithIdentifier:(NSData *)identifier;

@end