using Android.Content;
using DailyReflection.Controls;
using DailyReflection.Droid.Renderers;



[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace DailyReflection.Droid.Renderers;

public class CustomDatePickerRenderer : DatePickerRenderer
{
	public CustomDatePickerRenderer(Context context) : base(context)
	{

	}

	protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
	{
		base.OnElementChanged(e);
		if (Control != null)
		{
			Control.Background = null;
		}
	}
}