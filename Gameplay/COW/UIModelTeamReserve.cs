using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003275")]
public class UIModelTeamReserve : UIBaseModel, _Attribute
{
	[Token(Token = "0x2003276")]
	public enum ReserveStatus
	{
		[Token(Token = "0x4013347")]
		None,
		[Token(Token = "0x4013348")]
		Reserved,
		[Token(Token = "0x4013349")]
		Reserving,
		[Token(Token = "0x401334A")]
		ReserveRejected
	}

	[Token(Token = "0x2003277")]
	public enum ReserveReplyStatus
	{
		[Token(Token = "0x401334C")]
		None,
		[Token(Token = "0x401334D")]
		Accepted,
		[Token(Token = "0x401334E")]
		Rejected
	}

	[Token(Token = "0x2003278")]
	public enum ReserveRejectedReason
	{
		[Token(Token = "0x4013350")]
		None,
		[Token(Token = "0x4013351")]
		AcceptOther,
		[Token(Token = "0x4013352")]
		MaxLimit,
		[Token(Token = "0x4013353")]
		SettingBlock,
		[Token(Token = "0x4013354")]
		TempBlock,
		[Token(Token = "0x4013355")]
		Repeated,
		[Token(Token = "0x4013356")]
		RejectAfterAll,
		[Token(Token = "0x4013357")]
		NotInGame
	}

	[Token(Token = "0x2003279")]
	private sealed class _003CGetFriendAccountInfoById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013358")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x60154A3")]
		[Address(RVA = "0x1693010", Offset = "0x1693010", VA = "0x1693010")]
		public _003CGetFriendAccountInfoById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60154A4")]
		[Address(RVA = "0x1694BBC", Offset = "0x1694BBC", VA = "0x1694BBC")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013337")]
	public const int PropID_UpdateReserveStatus = 1;

	[Token(Token = "0x4013338")]
	public const int PropID_UpdateReservationList = 2;

	[Token(Token = "0x4013339")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, ReserveStatus> m_ReserveStatusDic;

	[Token(Token = "0x401333A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ulong, long> m_ReserveTimeDic;

	[Token(Token = "0x401333B")]
	[FieldOffset(Offset = "0x14")]
	private bool m_ReserveFlag;

	[Token(Token = "0x401333C")]
	[FieldOffset(Offset = "0x15")]
	private bool m_AutoReject;

	[Token(Token = "0x401333D")]
	[FieldOffset(Offset = "0x16")]
	private bool m_ReturnToLobbyFlag;

	[Token(Token = "0x401333E")]
	[FieldOffset(Offset = "0x18")]
	private List<FriendAccountInfo> m_ReserveReplyInfoList;

	[Token(Token = "0x401333F")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<ulong, ReserveReplyStatus> m_WaitingList;

	[Token(Token = "0x4013340")]
	[FieldOffset(Offset = "0x20")]
	private List<FriendAccountInfo> m_CachedFriends;

	[Token(Token = "0x4013341")]
	[FieldOffset(Offset = "0x24")]
	private bool m_SettingSwitchOn;

	[Token(Token = "0x4013342")]
	[FieldOffset(Offset = "0x25")]
	private bool m_IsReservationBlocked;

	[Token(Token = "0x4013343")]
	[FieldOffset(Offset = "0x26")]
	public bool Unread;

	[Token(Token = "0x4013344")]
	[FieldOffset(Offset = "0x28")]
	private List<ulong> m_NewReservationSenderIds;

	[Token(Token = "0x4013345")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_FriendListTimeoutDelayCallID;

	[Token(Token = "0x17001671")]
	public bool IsReservationBlocked
	{
		[Token(Token = "0x6015487")]
		[Address(RVA = "0x169051C", Offset = "0x169051C", VA = "0x169051C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6015488")]
		[Address(RVA = "0x1690574", Offset = "0x1690574", VA = "0x1690574")]
		set
		{
		}
	}

	[Token(Token = "0x17001672")]
	public Dictionary<ulong, ReserveStatus> ReserveStatusDic
	{
		[Token(Token = "0x6015489")]
		[Address(RVA = "0x16905D4", Offset = "0x16905D4", VA = "0x16905D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601548A")]
		[Address(RVA = "0x169062C", Offset = "0x169062C", VA = "0x169062C")]
		set
		{
		}
	}

	[Token(Token = "0x17001673")]
	public Dictionary<ulong, ReserveReplyStatus> WaitingList
	{
		[Token(Token = "0x601548B")]
		[Address(RVA = "0x169068C", Offset = "0x169068C", VA = "0x169068C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601548C")]
		[Address(RVA = "0x16906E4", Offset = "0x16906E4", VA = "0x16906E4")]
		set
		{
		}
	}

	[Token(Token = "0x6015486")]
	[Address(RVA = "0x169037C", Offset = "0x169037C", VA = "0x169037C")]
	public UIModelTeamReserve()
	{
	}

	[Token(Token = "0x601548D")]
	[Address(RVA = "0x1690744", Offset = "0x1690744", VA = "0x1690744", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601548E")]
	[Address(RVA = "0x1690874", Offset = "0x1690874", VA = "0x1690874", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601548F")]
	[Address(RVA = "0x1690948", Offset = "0x1690948", VA = "0x1690948")]
	private void CheckBlock()
	{
	}

	[Token(Token = "0x6015490")]
	[Address(RVA = "0x1690A14", Offset = "0x1690A14", VA = "0x1690A14")]
	public void UpdateStatus(ulong id)
	{
	}

	[Token(Token = "0x6015491")]
	[Address(RVA = "0x1690E08", Offset = "0x1690E08", VA = "0x1690E08")]
	public void RequestReservationSend(ulong id)
	{
	}

	[Token(Token = "0x6015492")]
	[Address(RVA = "0x1691230", Offset = "0x1691230", VA = "0x1691230")]
	public void NotifyReservationSend(ulong id)
	{
	}

	[Token(Token = "0x6015493")]
	[Address(RVA = "0x16913C0", Offset = "0x16913C0", VA = "0x16913C0")]
	public void NotifyReservationSend()
	{
	}

	[Token(Token = "0x6015494")]
	[Address(RVA = "0x1691D14", Offset = "0x1691D14", VA = "0x1691D14")]
	public void RequestReservationReply(ulong id, ReserveReplyStatus status, ReserveRejectedReason reason = ReserveRejectedReason.None)
	{
	}

	[Token(Token = "0x6015495")]
	[Address(RVA = "0x1692EDC", Offset = "0x1692EDC", VA = "0x1692EDC")]
	public void NotifyReservationReply(ulong id, bool isAccepted)
	{
	}

	[Token(Token = "0x6015496")]
	[Address(RVA = "0x1690CA8", Offset = "0x1690CA8", VA = "0x1690CA8")]
	public FriendAccountInfo GetFriendAccountInfoById(ulong id)
	{
		return null;
	}

	[Token(Token = "0x6015497")]
	[Address(RVA = "0x1691BBC", Offset = "0x1691BBC", VA = "0x1691BBC")]
	public void UpdateFriendList()
	{
	}

	[Token(Token = "0x6015498")]
	[Address(RVA = "0x1693018", Offset = "0x1693018", VA = "0x1693018", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015499")]
	[Address(RVA = "0x1693090", Offset = "0x1693090", VA = "0x1693090")]
	public void ClearData()
	{
	}

	[Token(Token = "0x601549A")]
	[Address(RVA = "0x1693294", Offset = "0x1693294", VA = "0x1693294")]
	public void ReturnToLobby()
	{
	}

	[Token(Token = "0x601549B")]
	[Address(RVA = "0x1693D70", Offset = "0x1693D70", VA = "0x1693D70")]
	public void SendMessage(ulong accountId, string content)
	{
	}

	[Token(Token = "0x601549C")]
	[Address(RVA = "0x1693F94", Offset = "0x1693F94", VA = "0x1693F94")]
	private void UpdateReserveReplyInfoList()
	{
	}

	[Token(Token = "0x601549D")]
	[Address(RVA = "0x1694904", Offset = "0x1694904", VA = "0x1694904", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601549E")]
	[Address(RVA = "0x169495C", Offset = "0x169495C", VA = "0x169495C", Slot = "14")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601549F")]
	[Address(RVA = "0x1694B10", Offset = "0x1694B10", VA = "0x1694B10", Slot = "15")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60154A0")]
	[Address(RVA = "0x1694BA4", Offset = "0x1694BA4", VA = "0x1694BA4")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60154A1")]
	[Address(RVA = "0x1694BAC", Offset = "0x1694BAC", VA = "0x1694BAC")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x60154A2")]
	[Address(RVA = "0x1694BB4", Offset = "0x1694BB4", VA = "0x1694BB4")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
