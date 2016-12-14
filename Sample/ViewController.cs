using System;
using KBGraphicSlider;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var slider = new KBSlider();
			slider.Frame = new CGRect(20, 60, this.View.Frame.Width - 40, 20);
			slider.Width = this.View.Frame.Width - 60;
			slider.CursorBackgroundColor = UIColor.Blue;
			slider.MinimumColor = UIColor.Black;
			slider.MaximumColor = UIColor.Green;
			slider.MinimumValue = 0;
			slider.MaximumValue = 100;
			slider.AddTarget((sender, e) => {
				var s = (KBSlider)sender;
				Console.WriteLine(s.Value);
			}, UIControlEvent.ValueChanged);
			this.View.AddSubview(slider);
		}
	}
}
