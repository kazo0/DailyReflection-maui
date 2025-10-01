using DailyReflection.Data.Models;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace DailyReflection.Presentation.Messages;

public class SoberTimeDisplayPreferenceChangedMessage : ValueChangedMessage<SoberTimeDisplayPreference>
{
	public SoberTimeDisplayPreferenceChangedMessage(SoberTimeDisplayPreference value) : base(value)
	{

	}
}
