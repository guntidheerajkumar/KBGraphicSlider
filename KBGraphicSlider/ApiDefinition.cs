using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace KBGraphicSlider
{
	// @interface KBSlider : UIControl
	[BaseType(typeof(UIControl))]
	interface KBSlider
	{
		// @property (assign, nonatomic) CGFloat minimumValue;
		[Export("minimumValue")]
		nfloat MinimumValue { get; set; }

		// @property (assign, nonatomic) CGFloat maximumValue;
		[Export("maximumValue")]
		nfloat MaximumValue { get; set; }

		// @property (assign, nonatomic) CGFloat value;
		[Export("value")]
		nfloat Value { get; set; }

		// @property (assign, nonatomic) CGFloat width;
		[Export("width")]
		nfloat Width { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export("radius")]
		nfloat Radius { get; set; }

		// @property (nonatomic, strong) UIColor * minimumColor;
		[Export("minimumColor", ArgumentSemantic.Strong)]
		UIColor MinimumColor { get; set; }

		// @property (nonatomic, strong) UIColor * maximumColor;
		[Export("maximumColor", ArgumentSemantic.Strong)]
		UIColor MaximumColor { get; set; }

		// @property (nonatomic, strong) UIColor * cursorBackgroundColor;
		[Export("cursorBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CursorBackgroundColor { get; set; }
	}
}
