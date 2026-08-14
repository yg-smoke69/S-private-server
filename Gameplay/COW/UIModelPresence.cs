using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x20031D6")]
public class UIModelPresence : UIBaseModel
{
	[Token(Token = "0x4012F89")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, ulong> m_LastSendTime;

	[Token(Token = "0x4012F8A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ulong, PresenceInfo> m_PresenceCache;

	[Token(Token = "0x4012F8B")]
	[FieldOffset(Offset = "0x14")]
	private List<Action> m_OnTCPFriendPresnceListNtfCallBack;

	[Token(Token = "0x601507A")]
	[Address(RVA = "0x31302D8", Offset = "0x31302D8", VA = "0x31302D8")]
	public UIModelPresence()
	{
	}

	[Token(Token = "0x601507B")]
	[Address(RVA = "0x31303F8", Offset = "0x31303F8", VA = "0x31303F8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601507C")]
	[Address(RVA = "0x3130450", Offset = "0x3130450", VA = "0x3130450", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601507D")]
	[Address(RVA = "0x3130580", Offset = "0x3130580", VA = "0x3130580")]
	public void RequestPresence(EPresenceListType presenceType, ulong[] ids, bool force = false, int cpuKey = 0)
	{
	}

	[Token(Token = "0x601507E")]
	[Address(RVA = "0x3131244", Offset = "0x3131244", VA = "0x3131244")]
	public void AddTCPFriendPresnceListNtfCallBack(Action callBack)
	{
	}

	[Token(Token = "0x601507F")]
	[Address(RVA = "0x31309EC", Offset = "0x31309EC", VA = "0x31309EC")]
	public void OnTCPPresnceListNtf(PresenceListRes resData, bool cachedData = false)
	{
	}

	[Token(Token = "0x6015080")]
	[Address(RVA = "0x3131318", Offset = "0x3131318", VA = "0x3131318")]
	private void OnTcpNotify_Friend()
	{
	}

	[Token(Token = "0x6015081")]
	[Address(RVA = "0x31314D8", Offset = "0x31314D8", VA = "0x31314D8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
