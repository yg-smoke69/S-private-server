using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003213")]
public class UIModelRetentionPushNotification : UIBaseModel
{
	[Token(Token = "0x2003214")]
	private sealed class _003CGetNotifyInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x40130E3")]
		[FieldOffset(Offset = "0x8")]
		internal RetentionPushNotificationData datum;

		[Token(Token = "0x60151F4")]
		[Address(RVA = "0x2CFF780", Offset = "0x2CFF780", VA = "0x2CFF780")]
		public _003CGetNotifyInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60151F5")]
		[Address(RVA = "0x2CFF944", Offset = "0x2CFF944", VA = "0x2CFF944")]
		internal string _003C_003Em__0()
		{
			return null;
		}

		[Token(Token = "0x60151F6")]
		[Address(RVA = "0x2CFFA2C", Offset = "0x2CFFA2C", VA = "0x2CFFA2C")]
		internal string _003C_003Em__1()
		{
			return null;
		}
	}

	[Token(Token = "0x40130E2")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60151EA")]
	[Address(RVA = "0x2CFDC00", Offset = "0x2CFDC00", VA = "0x2CFDC00")]
	public UIModelRetentionPushNotification()
	{
	}

	[Token(Token = "0x60151EB")]
	[Address(RVA = "0x2CFDC84", Offset = "0x2CFDC84", VA = "0x2CFDC84", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60151EC")]
	[Address(RVA = "0x2CFDCDC", Offset = "0x2CFDCDC", VA = "0x2CFDCDC", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60151ED")]
	[Address(RVA = "0x2CFEF4C", Offset = "0x2CFEF4C", VA = "0x2CFEF4C")]
	private List<RetentionPushNotificationData> GetData(string region = "")
	{
		return null;
	}

	[Token(Token = "0x60151EE")]
	[Address(RVA = "0x2CFDE64", Offset = "0x2CFDE64", VA = "0x2CFDE64")]
	private void CheckForRewards(LoginRes loginRes)
	{
	}

	[Token(Token = "0x60151EF")]
	[Address(RVA = "0x2CFE7EC", Offset = "0x2CFE7EC", VA = "0x2CFE7EC")]
	private void ScheduleNotifications()
	{
	}

	[Token(Token = "0x60151F0")]
	[Address(RVA = "0x2CFF6B0", Offset = "0x2CFF6B0", VA = "0x2CFF6B0")]
	private string _NotifyUrl(object[] parameters)
	{
		return null;
	}

	[Token(Token = "0x60151F1")]
	[Address(RVA = "0x2CFF378", Offset = "0x2CFF378", VA = "0x2CFF378")]
	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, RetentionPushNotificationData datum)
	{
		return null;
	}

	[Token(Token = "0x60151F2")]
	[Address(RVA = "0x2CFF788", Offset = "0x2CFF788", VA = "0x2CFF788")]
	private static void _003CCheckForRewards_003Em__0(HttpErrorCode error, object resObj)
	{
	}

	[Token(Token = "0x60151F3")]
	[Address(RVA = "0x2CFF93C", Offset = "0x2CFF93C", VA = "0x2CFF93C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
