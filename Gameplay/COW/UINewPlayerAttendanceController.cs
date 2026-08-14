using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002276")]
public class UINewPlayerAttendanceController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002277")]
	public enum EAttendanceStatus
	{
		[Token(Token = "0x400D7D2")]
		UnStarted = 0,
		[Token(Token = "0x400D7D3")]
		Award = 2,
		[Token(Token = "0x400D7D4")]
		Claimed = 3
	}

	[Token(Token = "0x400D7BF")]
	private const string CLAIM_ANIM_NAME = "UINewPlayerAttendance_AttendanceReward_Receive";

	[Token(Token = "0x400D7C0")]
	[FieldOffset(Offset = "0x28")]
	private UINewPlayerAttendanceView m_View;

	[Token(Token = "0x400D7C1")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelNewPlayer m_ModelNewPlayer;

	[Token(Token = "0x400D7C2")]
	[FieldOffset(Offset = "0x30")]
	private UINewPlayerMissionItemController[] m_MissionCtrlList;

	[Token(Token = "0x400D7C3")]
	[FieldOffset(Offset = "0x34")]
	private EAttendanceStatus m_Attendance;

	[Token(Token = "0x400D7C4")]
	[FieldOffset(Offset = "0x38")]
	private EActivity.State m_MissionToday;

	[Token(Token = "0x400D7C5")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsSelectAttendance;

	[Token(Token = "0x400D7C6")]
	[FieldOffset(Offset = "0x40")]
	private uint m_Day;

	[Token(Token = "0x400D7C7")]
	[FieldOffset(Offset = "0x44")]
	private uint m_MissionTodayId;

	[Token(Token = "0x400D7C8")]
	public const string UnStart_Button_Key = "T_16_D_SPCHALL_ICON_LOCKED";

	[Token(Token = "0x400D7C9")]
	public const string Goto_Button_Key = "TXT_LOBBY_EVENT_GOTO";

	[Token(Token = "0x400D7CA")]
	public const string Award_Button_Key = "TXT_OB9_GXQ_GIFTMALL_MIAL_CLAIM";

	[Token(Token = "0x400D7CB")]
	public const string Claimed_Button_Key = "T_13_I_DISCOUNT_STORE_CLAIMED";

	[Token(Token = "0x400D7CC")]
	public const string Attend_Button_Key = "T_31_P_VETERAN_ACT_SIGNIN";

	[Token(Token = "0x400D7CD")]
	public const string Pending_Button_Key = "TXT_EVENT_UNFINISHED";

	[Token(Token = "0x400D7CE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Color GrayColor;

	[Token(Token = "0x400D7CF")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Color SelectClaimColor;

	[Token(Token = "0x400D7D0")]
	private const uint MISSION_COUNT = 3u;

	[Token(Token = "0x1700108C")]
	public EAttendanceStatus Attendance
	{
		[Token(Token = "0x600BCE1")]
		[Address(RVA = "0x27A5A80", Offset = "0x27A5A80", VA = "0x27A5A80")]
		get
		{
			return default(EAttendanceStatus);
		}
	}

	[Token(Token = "0x1700108D")]
	public EActivity.State MissionToday
	{
		[Token(Token = "0x600BCE2")]
		[Address(RVA = "0x27A5AD8", Offset = "0x27A5AD8", VA = "0x27A5AD8")]
		get
		{
			return default(EActivity.State);
		}
	}

	[Token(Token = "0x600BCE0")]
	[Address(RVA = "0x27A59D0", Offset = "0x27A59D0", VA = "0x27A59D0")]
	public UINewPlayerAttendanceController()
	{
	}

	[Token(Token = "0x600BCE3")]
	[Address(RVA = "0x27A5B30", Offset = "0x27A5B30", VA = "0x27A5B30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BCE4")]
	[Address(RVA = "0x27A5BD8", Offset = "0x27A5BD8", VA = "0x27A5BD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BCE5")]
	[Address(RVA = "0x27A6054", Offset = "0x27A6054", VA = "0x27A6054", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BCE6")]
	[Address(RVA = "0x27A6240", Offset = "0x27A6240", VA = "0x27A6240")]
	public void SetViewData(int index)
	{
	}

	[Token(Token = "0x600BCE7")]
	[Address(RVA = "0x27A7738", Offset = "0x27A7738", VA = "0x27A7738")]
	private bool IsNormalIcon(uint awardId)
	{
		return default(bool);
	}

	[Token(Token = "0x600BCE8")]
	[Address(RVA = "0x27A78E8", Offset = "0x27A78E8", VA = "0x27A78E8")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x600BCE9")]
	[Address(RVA = "0x27A8AB8", Offset = "0x27A8AB8", VA = "0x27A8AB8")]
	public void RefreshSign()
	{
	}

	[Token(Token = "0x600BCEA")]
	[Address(RVA = "0x27A8CA8", Offset = "0x27A8CA8", VA = "0x27A8CA8")]
	private void OnAttendanceRewardButtonClick()
	{
	}

	[Token(Token = "0x600BCEB")]
	[Address(RVA = "0x27A8E10", Offset = "0x27A8E10", VA = "0x27A8E10")]
	private void OnAttendanceButtonClick()
	{
	}

	[Token(Token = "0x600BCEC")]
	[Address(RVA = "0x27A9168", Offset = "0x27A9168", VA = "0x27A9168")]
	private void OnMissonToadyRewardButtonClick()
	{
	}

	[Token(Token = "0x600BCED")]
	[Address(RVA = "0x27A92CC", Offset = "0x27A92CC", VA = "0x27A92CC")]
	private void OnMissonTodayButtonClick()
	{
	}

	[Token(Token = "0x600BCEE")]
	[Address(RVA = "0x27A9624", Offset = "0x27A9624", VA = "0x27A9624", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BCEF")]
	[Address(RVA = "0x27A9D04", Offset = "0x27A9D04", VA = "0x27A9D04", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BCF1")]
	[Address(RVA = "0x27A9E4C", Offset = "0x27A9E4C", VA = "0x27A9E4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BCF2")]
	[Address(RVA = "0x27A9E54", Offset = "0x27A9E54", VA = "0x27A9E54")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
