using Android.Content;
using DailyReflection.Controls;
using DailyReflection.Droid.Renderers;



[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace DailyReflection.Droid.Renderers;

public class CustomTimePickerRenderer : TimePickerRenderer
{
	public CustomTimePickerRenderer(Context context) : base(context)
	{

	}

	protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.TimePicker> e)
	{
		base.OnElementChanged(e);
		if (Control != null)
		{
			Control.Background = null;
		}
	}
}