using Android.OS;

namespace DailyReflection.Droid.Permissions;

public class NotificationPermission : BasePlatformPermission
{
	public override (string androidPermission, bool isRuntime)[] RequiredPermissions => GetPermissionList().ToArray();

	private static List<(string androidPermission, bool isRuntime)> GetPermissionList()
	{
		var perms = new List<(string androidPermission, bool isRuntime)>();

		if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu)
		{
			perms.Add((Android.Manifest.Permission.PostNotifications, true));
		}

		return perms;
	}
}