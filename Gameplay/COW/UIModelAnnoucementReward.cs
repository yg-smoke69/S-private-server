using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EA3")]
public class UIModelAnnoucementReward : UIBaseModel
{
	[Token(Token = "0x2002EA4")]
	public class NotifyArgs
	{
		[Token(Token = "0x4011CF1")]
		[FieldOffset(Offset = "0x8")]
		public bool success;

		[Token(Token = "0x4011CF2")]
		[FieldOffset(Offset = "0xC")]
		public uint signId;

		[Token(Token = "0x60137F7")]
		[Address(RVA = "0x30AE6D8", Offset = "0x30AE6D8", VA = "0x30AE6D8")]
		public NotifyArgs()
		{
		}
	}

	[Token(Token = "0x2002EA5")]
	private sealed class _003CAttendanceSignin_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011CF3")]
		[FieldOffset(Offset = "0x8")]
		internal int AttendaceInfoIndex;

		[Token(Token = "0x4011CF4")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelAnnoucementReward _0024this;

		[Token(Token = "0x60137F8")]
		[Address(RVA = "0x30AD3CC", Offset = "0x30AD3CC", VA = "0x30AD3CC")]
		public _003CAttendanceSignin_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60137F9")]
		[Address(RVA = "0x30AE734", Offset = "0x30AE734", VA = "0x30AE734")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EA6")]
	private sealed class _003CTurntableAttendanceSignin_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011CF5")]
		[FieldOffset(Offset = "0x8")]
		internal uint sign_id;

		[Token(Token = "0x60137FA")]
		[Address(RVA = "0x30AE6E0", Offset = "0x30AE6E0", VA = "0x30AE6E0")]
		public _003CTurntableAttendanceSignin_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60137FB")]
		[Address(RVA = "0x30AEB70", Offset = "0x30AEB70", VA = "0x30AEB70")]
		internal bool _003C_003Em__0(AttendanceItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011CDC")]
	public const uint PropID_AttendanceLisUpdate = 8u;

	[Token(Token = "0x4011CDD")]
	public const uint PropID_GetReward = 16u;

	[Token(Token = "0x4011CDE")]
	public const uint PropID_TurntableAttendanceListUpdate = 32u;

	[Token(Token = "0x4011CDF")]
	public const uint PropID_TurntableSigned = 64u;

	[Token(Token = "0x4011CE0")]
	[FieldOffset(Offset = "0xC")]
	private List<AttendaceItemInfo> m_AttendaceInfoList;

	[Token(Token = "0x4011CE1")]
	[FieldOffset(Offset = "0x10")]
	public bool HaveGetAttendance;

	[Token(Token = "0x4011CE2")]
	[FieldOffset(Offset = "0x18")]
	private DateTime m_AttendanceEndTime;

	[Token(Token = "0x4011CE3")]
	[FieldOffset(Offset = "0x28")]
	private AwardItemInfo m_CurrentAwardInfo;

	[Token(Token = "0x4011CE4")]
	[FieldOffset(Offset = "0x30")]
	private DateTimeOffset m_BeijingLastSignedTime;

	[Token(Token = "0x4011CE5")]
	[FieldOffset(Offset = "0x48")]
	private int m_LastSignedIndex;

	[Token(Token = "0x4011CE6")]
	[FieldOffset(Offset = "0x4C")]
	private string m_SignPictureUrl;

	[Token(Token = "0x4011CE7")]
	[FieldOffset(Offset = "0x50")]
	private string m_SignDesc;

	[Token(Token = "0x4011CE8")]
	[FieldOffset(Offset = "0x54")]
	private bool m_WaitingForReponse;

	[Token(Token = "0x4011CE9")]
	[FieldOffset(Offset = "0x55")]
	private bool m_IsSignedToday;

	[Token(Token = "0x4011CEA")]
	[FieldOffset(Offset = "0x58")]
	private uint m_ConfigId;

	[Token(Token = "0x4011CEB")]
	[FieldOffset(Offset = "0x5C")]
	private AttendanceList m_TurntableAttendanceRes;

	[Token(Token = "0x4011CEC")]
	[FieldOffset(Offset = "0x60")]
	private DateTime m_LastRefreshTurntableDateTime;

	[Token(Token = "0x4011CED")]
	[FieldOffset(Offset = "0x70")]
	private bool waitTurntableResponse;

	[Token(Token = "0x4011CEE")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AttendanceItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011CEF")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AttendanceItem> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011CF0")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AttendaceItemInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17001444")]
	public List<AttendaceItemInfo> AttendaceInfoList
	{
		[Token(Token = "0x60137D8")]
		[Address(RVA = "0x30AB5EC", Offset = "0x30AB5EC", VA = "0x30AB5EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001445")]
	public DateTime AttendanceEndTime
	{
		[Token(Token = "0x60137D9")]
		[Address(RVA = "0x30AB644", Offset = "0x30AB644", VA = "0x30AB644")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17001446")]
	public AwardItemInfo CurrentAwardInfo
	{
		[Token(Token = "0x60137DA")]
		[Address(RVA = "0x30AB6B0", Offset = "0x30AB6B0", VA = "0x30AB6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001447")]
	public DateTimeOffset LastSingedTime
	{
		[Token(Token = "0x60137DB")]
		[Address(RVA = "0x30AB708", Offset = "0x30AB708", VA = "0x30AB708")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Token(Token = "0x17001448")]
	public int LastSignedIndex
	{
		[Token(Token = "0x60137DC")]
		[Address(RVA = "0x30AB77C", Offset = "0x30AB77C", VA = "0x30AB77C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001449")]
	public string SignPictureUrl
	{
		[Token(Token = "0x60137DD")]
		[Address(RVA = "0x30AB7D4", Offset = "0x30AB7D4", VA = "0x30AB7D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144A")]
	public string SignDesc
	{
		[Token(Token = "0x60137DE")]
		[Address(RVA = "0x30AB82C", Offset = "0x30AB82C", VA = "0x30AB82C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144B")]
	public AttendanceList TurntableAttendanceRes
	{
		[Token(Token = "0x60137DF")]
		[Address(RVA = "0x30AB884", Offset = "0x30AB884", VA = "0x30AB884")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60137D6")]
	[Address(RVA = "0x30AB3AC", Offset = "0x30AB3AC", VA = "0x30AB3AC")]
	public UIModelAnnoucementReward()
	{
	}

	[Token(Token = "0x60137D7")]
	[Address(RVA = "0x30AB594", Offset = "0x30AB594", VA = "0x30AB594", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60137E0")]
	[Address(RVA = "0x30AB8DC", Offset = "0x30AB8DC", VA = "0x30AB8DC")]
	public bool IsSignedToday()
	{
		return default(bool);
	}

	[Token(Token = "0x60137E1")]
	[Address(RVA = "0x30AB934", Offset = "0x30AB934", VA = "0x30AB934")]
	public bool CheckIsNeedAutoSign()
	{
		return default(bool);
	}

	[Token(Token = "0x60137E2")]
	[Address(RVA = "0x30ABB5C", Offset = "0x30ABB5C", VA = "0x30ABB5C")]
	public bool CheckNeedRefreshTurntableSign()
	{
		return default(bool);
	}

	[Token(Token = "0x60137E3")]
	[Address(RVA = "0x30ABE68", Offset = "0x30ABE68", VA = "0x30ABE68", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60137E4")]
	[Address(RVA = "0x30AC038", Offset = "0x30AC038", VA = "0x30AC038")]
	public void RequestAttendanceRes(uint httpOp = 0u, bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60137E5")]
	[Address(RVA = "0x30AC528", Offset = "0x30AC528", VA = "0x30AC528")]
	public HttpRequest RequestTurntableAttendance()
	{
		return null;
	}

	[Token(Token = "0x60137E6")]
	[Address(RVA = "0x30AC7BC", Offset = "0x30AC7BC", VA = "0x30AC7BC")]
	public void ProcessTurntableRes(AttendanceList rewards)
	{
	}

	[Token(Token = "0x60137E7")]
	[Address(RVA = "0x30AC9B0", Offset = "0x30AC9B0", VA = "0x30AC9B0")]
	public void RefreshTurntableSigninTips()
	{
	}

	[Token(Token = "0x60137E8")]
	[Address(RVA = "0x30ACBB4", Offset = "0x30ACBB4", VA = "0x30ACBB4")]
	public void ProcessAttendanceRes(AttendanceList res)
	{
	}

	[Token(Token = "0x60137E9")]
	[Address(RVA = "0x30AD094", Offset = "0x30AD094", VA = "0x30AD094")]
	public void AttendanceSignin(AwardItemInfo itemInfo, int AttendaceInfoIndex)
	{
	}

	[Token(Token = "0x60137EA")]
	[Address(RVA = "0x30AD3D4", Offset = "0x30AD3D4", VA = "0x30AD3D4")]
	public void TurntableAttendanceSignin()
	{
	}

	[Token(Token = "0x60137EB")]
	[Address(RVA = "0x30AD80C", Offset = "0x30AD80C", VA = "0x30AD80C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60137EC")]
	[Address(RVA = "0x30AD94C", Offset = "0x30AD94C", VA = "0x30AD94C")]
	public bool HasUnclaimedSignInReward()
	{
		return default(bool);
	}

	[Token(Token = "0x60137ED")]
	[Address(RVA = "0x30ADA9C", Offset = "0x30ADA9C", VA = "0x30ADA9C")]
	public bool CheckAllSigned()
	{
		return default(bool);
	}

	[Token(Token = "0x60137EE")]
	[Address(RVA = "0x30ADB9C", Offset = "0x30ADB9C", VA = "0x30ADB9C")]
	public int GetSignedCount()
	{
		return default(int);
	}

	[Token(Token = "0x60137EF")]
	[Address(RVA = "0x30ADD00", Offset = "0x30ADD00", VA = "0x30ADD00")]
	private void _003CRequestAttendanceRes_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60137F0")]
	[Address(RVA = "0x30AE1A8", Offset = "0x30AE1A8", VA = "0x30AE1A8")]
	private void _003CRequestTurntableAttendance_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60137F1")]
	[Address(RVA = "0x30AE3C0", Offset = "0x30AE3C0", VA = "0x30AE3C0")]
	private static int _003CProcessTurntableRes_003Em__2(AttendanceItem x, AttendanceItem y)
	{
		return default(int);
	}

	[Token(Token = "0x60137F2")]
	[Address(RVA = "0x30AE408", Offset = "0x30AE408", VA = "0x30AE408")]
	private static bool _003CRefreshTurntableSigninTips_003Em__3(AttendanceItem e)
	{
		return default(bool);
	}

	[Token(Token = "0x60137F3")]
	[Address(RVA = "0x30AE438", Offset = "0x30AE438", VA = "0x30AE438")]
	private void _003CTurntableAttendanceSignin_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60137F4")]
	[Address(RVA = "0x30AE6E8", Offset = "0x30AE6E8", VA = "0x30AE6E8")]
	private static bool _003CHasUnclaimedSignInReward_003Em__5(AttendaceItemInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60137F5")]
	[Address(RVA = "0x30AE724", Offset = "0x30AE724", VA = "0x30AE724")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x60137F6")]
	[Address(RVA = "0x30AE72C", Offset = "0x30AE72C", VA = "0x30AE72C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
