using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001DC5")]
public static class PermissionUtility
{
	[Token(Token = "0x2001DC6")]
	public enum Permission
	{
		[Token(Token = "0x400BC8D")]
		None,
		[Token(Token = "0x400BC8E")]
		ReadExternalStorage,
		[Token(Token = "0x400BC8F")]
		WriteExternalStorage,
		[Token(Token = "0x400BC90")]
		PhoneState,
		[Token(Token = "0x400BC91")]
		Microphone,
		[Token(Token = "0x400BC92")]
		Photo
	}

	[Token(Token = "0x2001DC7")]
	public delegate void OnPermissionsResult(Dictionary<int, bool> results);

	[Token(Token = "0x2001DC8")]
	private sealed class _003C_ShowPermissionRationale_Android_003Ec__AnonStorey0
	{
		[Token(Token = "0x400BC93")]
		[FieldOffset(Offset = "0x8")]
		internal Permission permission;

		[Token(Token = "0x400BC94")]
		[FieldOffset(Offset = "0xC")]
		internal bool critical;

		[Token(Token = "0x6008E27")]
		[Address(RVA = "0x2DE2930", Offset = "0x2DE2930", VA = "0x2DE2930")]
		public _003C_ShowPermissionRationale_Android_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6008E28")]
		[Address(RVA = "0x2DE2F3C", Offset = "0x2DE2F3C", VA = "0x2DE2F3C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6008E29")]
		[Address(RVA = "0x2DE2FD0", Offset = "0x2DE2FD0", VA = "0x2DE2FD0")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2001DC9")]
	private sealed class _003C_ShowGotoApplicationDetailsSettings_Android_003Ec__AnonStorey1
	{
		[Token(Token = "0x400BC95")]
		[FieldOffset(Offset = "0x8")]
		internal bool critical;

		[Token(Token = "0x6008E2A")]
		[Address(RVA = "0x2DE2938", Offset = "0x2DE2938", VA = "0x2DE2938")]
		public _003C_ShowGotoApplicationDetailsSettings_Android_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6008E2B")]
		[Address(RVA = "0x2DE2E10", Offset = "0x2DE2E10", VA = "0x2DE2E10")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6008E2C")]
		[Address(RVA = "0x2DE2EA4", Offset = "0x2DE2EA4", VA = "0x2DE2EA4")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2001DCA")]
	private sealed class _003C_RequestPermission_Android_003Ec__AnonStorey2
	{
		[Token(Token = "0x400BC96")]
		[FieldOffset(Offset = "0x8")]
		internal bool critical;

		[Token(Token = "0x6008E2D")]
		[Address(RVA = "0x2DE2940", Offset = "0x2DE2940", VA = "0x2DE2940")]
		public _003C_RequestPermission_Android_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6008E2E")]
		[Address(RVA = "0x2DE2D64", Offset = "0x2DE2D64", VA = "0x2DE2D64")]
		internal void _003C_003Em__0(PlatformUtility_Android.RequestPermissionResult result)
		{
		}
	}

	[Token(Token = "0x400BC7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] CRITICAL_PERMISSIONS_ANDROID_29_AND_BELOW;

	[Token(Token = "0x400BC7F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int[] CRITICAL_PERMISSIONS_ANDROID_30_AND_ABOVE;

	[Token(Token = "0x400BC80")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[] CRITICAL_PERMISSIONS_NONE;

	[Token(Token = "0x400BC81")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int[] Permissions_Trivial;

	[Token(Token = "0x400BC82")]
	[FieldOffset(Offset = "0x10")]
	private static OnPermissionsResult _OnPermissionsResultCallback;

	[Token(Token = "0x400BC83")]
	[FieldOffset(Offset = "0x14")]
	private static readonly Dictionary<int, string> _AndroidPermissions;

	[Token(Token = "0x400BC84")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, bool> _PermissionStatus_Android;

	[Token(Token = "0x400BC85")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<int, bool> _PermissionAttempt_Android;

	[Token(Token = "0x400BC86")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<int, bool> _PermissionRationale_Android;

	[Token(Token = "0x400BC87")]
	[FieldOffset(Offset = "0x24")]
	private static int[] _RequestingTrivialPermissions;

	[Token(Token = "0x400BC88")]
	private const string PERMISSION_RATIONALES_ALERT_DIALOG_IDENTIFIER = "PermissionRationalesAlertDialogIdentifier";

	[Token(Token = "0x400BC89")]
	private const string PERMISSION_RATIONALE_ALERT_DIALOG_IDENTIFIER = "PermissionRationaleAlertDialogIdentifier";

	[Token(Token = "0x400BC8A")]
	private const string GOTO_APPLICATION_DETAILS_SETTINGS_ALERT_DIALOG_IDENTIFIER = "GotoApplicationDetailsSettingsAlertDialogIdentifier";

	[Token(Token = "0x400BC8B")]
	[FieldOffset(Offset = "0x28")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000F05")]
	public static int[] Permissions_Critical
	{
		[Token(Token = "0x6008E14")]
		[Address(RVA = "0x2DE04EC", Offset = "0x2DE04EC", VA = "0x2DE04EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008E11")]
	[Address(RVA = "0x2DE02DC", Offset = "0x2DE02DC", VA = "0x2DE02DC")]
	public static bool CheckPermission(Permission permission)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E12")]
	[Address(RVA = "0x2DE042C", Offset = "0x2DE042C", VA = "0x2DE042C")]
	public static bool CheckCriticalPermissions()
	{
		return default(bool);
	}

	[Token(Token = "0x6008E13")]
	[Address(RVA = "0x2DE0800", Offset = "0x2DE0800", VA = "0x2DE0800")]
	public static bool CheckPermissions(int[] permissions)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E15")]
	[Address(RVA = "0x2DE08C8", Offset = "0x2DE08C8", VA = "0x2DE08C8")]
	public static void RequestCriticalPermissions(OnPermissionsResult callback)
	{
	}

	[Token(Token = "0x6008E16")]
	[Address(RVA = "0x2DE1098", Offset = "0x2DE1098", VA = "0x2DE1098")]
	public static void RequestTrivialPermissions(int[] permissions, OnPermissionsResult callback)
	{
	}

	[Token(Token = "0x6008E17")]
	[Address(RVA = "0x2DE0634", Offset = "0x2DE0634", VA = "0x2DE0634")]
	private static bool CheckPermissions_Android(int[] permissions)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E18")]
	[Address(RVA = "0x2DE1364", Offset = "0x2DE1364", VA = "0x2DE1364")]
	private static void UpdatePermissionStatus_Android()
	{
	}

	[Token(Token = "0x6008E19")]
	[Address(RVA = "0x2DE1794", Offset = "0x2DE1794", VA = "0x2DE1794")]
	private static void DoCallback_Android()
	{
	}

	[Token(Token = "0x6008E1A")]
	[Address(RVA = "0x2DE0E64", Offset = "0x2DE0E64", VA = "0x2DE0E64")]
	private static void RequestCriticalPermissions_Android()
	{
	}

	[Token(Token = "0x6008E1B")]
	[Address(RVA = "0x2DE1AEC", Offset = "0x2DE1AEC", VA = "0x2DE1AEC")]
	private static void _RequestPermissions_Android(bool critical)
	{
	}

	[Token(Token = "0x6008E1C")]
	[Address(RVA = "0x2DE1284", Offset = "0x2DE1284", VA = "0x2DE1284")]
	private static void RequestTrivialPermissions_Android(int[] permissions)
	{
	}

	[Token(Token = "0x6008E1D")]
	[Address(RVA = "0x2DE1E9C", Offset = "0x2DE1E9C", VA = "0x2DE1E9C")]
	private static void RequestPermission_Android(Permission permission, bool critical)
	{
	}

	[Token(Token = "0x6008E1E")]
	[Address(RVA = "0x2DE24E4", Offset = "0x2DE24E4", VA = "0x2DE24E4")]
	private static void _ShowPermissionRationale_Android(Permission permission, bool critical)
	{
	}

	[Token(Token = "0x6008E1F")]
	[Address(RVA = "0x2DE271C", Offset = "0x2DE271C", VA = "0x2DE271C")]
	private static void _ShowGotoApplicationDetailsSettings_Android(Permission permission, bool critical)
	{
	}

	[Token(Token = "0x6008E20")]
	[Address(RVA = "0x2DE22AC", Offset = "0x2DE22AC", VA = "0x2DE22AC")]
	private static void _RequestPermission_Android(Permission permission, bool critical)
	{
	}

	[Token(Token = "0x6008E22")]
	[Address(RVA = "0x2DE2CE8", Offset = "0x2DE2CE8", VA = "0x2DE2CE8")]
	private static void _003CRequestCriticalPermissions_Android_003Em__0()
	{
	}
}
