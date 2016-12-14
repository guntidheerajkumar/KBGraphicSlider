# KBGraphicSlider

Clean slider with more customization.

This is a binding project based on https://github.com/sreucherand/SRGraphicSlider.

###Usage

```
var label = new UILabel(new CGRect(20, 90, this.View.Frame.Width - 40, 20));
label.TextColor = UIColor.Black;
label.TextAlignment = UITextAlignment.Center;
label.Font = UIFont.PreferredSubheadline;

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
	label.Text = s.Value.ToString();
}, UIControlEvent.ValueChanged);
this.View.AddSubview(slider);
this.View.AddSubview(label);
```


###Output

![](https://github.com/guntidheerajkumar/KBGraphicSlider/blob/master/SliderOutput.gif)
