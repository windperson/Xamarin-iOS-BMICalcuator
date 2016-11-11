using System;

using UIKit;

namespace BMICalcualtor
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
			// Perform any additional setup after loading the view, typically from a nib.
			calculateButton.TouchUpInside += CalculateButton_TouchUpInside;
		}

		void CalculateButton_TouchUpInside(object sender, EventArgs e)
		{
			var height = float.Parse(heightTextField.Text);
			var weight = float.Parse(weightTextField.Text);

			var bmi = weight / (height * height);
			bmiLabel.Text = bmi.ToString();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
