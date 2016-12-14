

#import <UIKit/UIKit.h>

@interface KBSlider : UIControl
@property (assign, nonatomic) CGFloat minimumValue;
@property (assign, nonatomic) CGFloat maximumValue;
@property (assign, nonatomic) CGFloat value;
@property (assign, nonatomic) CGFloat width;
@property (assign, nonatomic) CGFloat lineWidth;
@property (assign, nonatomic) CGFloat radius;

@property (strong, nonatomic) UIColor *minimumColor;
@property (strong, nonatomic) UIColor *maximumColor;
@property (strong, nonatomic) UIColor *cursorBackgroundColor;
@end
