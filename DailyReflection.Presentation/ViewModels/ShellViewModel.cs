using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyReflection.Presentation.ViewModels;

public partial class ShellViewModel : ViewModelBase
{
	[ObservableProperty]
	private DailyReflectionViewModel _dailyReflectionViewModel;

	[ObservableProperty]
	private SobrietyTimeViewModel _sobrietyTimeViewModel;

	[ObservableProperty]
	private SettingsViewModel _settingsViewModel;

	public ShellViewModel(DailyReflectionViewModel dailyReflectionViewModel,
						   SobrietyTimeViewModel sobrietyTimeViewModel,
						   SettingsViewModel settingsViewModel)
	{
		_dailyReflectionViewModel = dailyReflectionViewModel;
		_sobrietyTimeViewModel = sobrietyTimeViewModel;
		_settingsViewModel = settingsViewModel;
	}
}
