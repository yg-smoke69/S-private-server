using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030C6")]
public class UIModelLab : UIBaseModel
{
	[Token(Token = "0x20030C7")]
	public enum LabEntranceState
	{
		[Token(Token = "0x40128D0")]
		Unknown,
		[Token(Token = "0x40128D1")]
		NotFound,
		[Token(Token = "0x40128D2")]
		BeforePre,
		[Token(Token = "0x40128D3")]
		Pre,
		[Token(Token = "0x40128D4")]
		Open,
		[Token(Token = "0x40128D5")]
		Closed
	}

	[Token(Token = "0x40128C9")]
	[FieldOffset(Offset = "0xC")]
	private List<LabDesc> m_LabSystemDesc;

	[Token(Token = "0x40128CA")]
	public const uint PropID_LabReady = 1u;

	[Token(Token = "0x40128CB")]
	public const string PlayerPresKey_LabLobbyEntrance_Time = "LabLobbyEntranceTime_{0}";

	[Token(Token = "0x40128CC")]
	public const string PlayerPresKey_LabLobbyEntrance_NewTips = "LabLobbyEntranceNewTips_{0}";

	[Token(Token = "0x40128CD")]
	public const string PlayerPresKey_LabLobbyEntrance_LengenCloth = "LabLobbyEntrance_LengenCloth_{0}";

	[Token(Token = "0x40128CE")]
	public const string PlayerPresKey_LabLobbyEntrance_HyperBook = "LabLobbyEntrance_HyperBook_{0}";

	[Token(Token = "0x17001539")]
	private bool IsReady
	{
		[Token(Token = "0x6014703")]
		[Address(RVA = "0x326C650", Offset = "0x326C650", VA = "0x326C650")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6014702")]
	[Address(RVA = "0x326C5CC", Offset = "0x326C5CC", VA = "0x326C5CC")]
	public UIModelLab()
	{
	}

	[Token(Token = "0x6014704")]
	[Address(RVA = "0x326C6B4", Offset = "0x326C6B4", VA = "0x326C6B4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014705")]
	[Address(RVA = "0x326C70C", Offset = "0x326C70C", VA = "0x326C70C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014706")]
	[Address(RVA = "0x326C770", Offset = "0x326C770", VA = "0x326C770", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6014707")]
	[Address(RVA = "0x326C7D4", Offset = "0x326C7D4", VA = "0x326C7D4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014708")]
	[Address(RVA = "0x326C92C", Offset = "0x326C92C", VA = "0x326C92C")]
	public void RequestLabSetting(bool silence, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014709")]
	[Address(RVA = "0x326CBF0", Offset = "0x326CBF0", VA = "0x326CBF0")]
	private void OnRequestLabSettingFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x601470A")]
	[Address(RVA = "0x326CD54", Offset = "0x326CD54", VA = "0x326CD54")]
	public bool ResendRequestIfPreviousFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x601470B")]
	[Address(RVA = "0x326CE28", Offset = "0x326CE28", VA = "0x326CE28")]
	private static LabEntranceState GetLabEntranceStateInternal(LabDesc desc)
	{
		return default(LabEntranceState);
	}

	[Token(Token = "0x601470C")]
	[Address(RVA = "0x326CF54", Offset = "0x326CF54", VA = "0x326CF54")]
	private static bool IsLabEntranceStateVisibleInternal(LabEntranceState state)
	{
		return default(bool);
	}

	[Token(Token = "0x601470D")]
	[Address(RVA = "0x326CFC0", Offset = "0x326CFC0", VA = "0x326CFC0")]
	public bool IsSystemAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x601470E")]
	[Address(RVA = "0x326D020", Offset = "0x326D020", VA = "0x326D020")]
	public int GetVisibleLabEntranceCount()
	{
		return default(int);
	}

	[Token(Token = "0x601470F")]
	[Address(RVA = "0x326D1D4", Offset = "0x326D1D4", VA = "0x326D1D4")]
	public LabEntranceState GetLabEntranceStateByID(uint systemID)
	{
		return default(LabEntranceState);
	}

	[Token(Token = "0x6014710")]
	[Address(RVA = "0x326D3C4", Offset = "0x326D3C4", VA = "0x326D3C4")]
	public uint GetLabEntranceSortID(uint systemID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014711")]
	[Address(RVA = "0x326D5A8", Offset = "0x326D5A8", VA = "0x326D5A8")]
	public long GetLabEntranceOpenTime(uint systemID)
	{
		return default(long);
	}

	[Token(Token = "0x6014712")]
	[Address(RVA = "0x326D78C", Offset = "0x326D78C", VA = "0x326D78C")]
	public void UpdateLabRedTips()
	{
	}

	[Token(Token = "0x6014713")]
	[Address(RVA = "0x326E340", Offset = "0x326E340", VA = "0x326E340")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014714")]
	[Address(RVA = "0x326E348", Offset = "0x326E348", VA = "0x326E348")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x6014715")]
	[Address(RVA = "0x326E350", Offset = "0x326E350", VA = "0x326E350")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
