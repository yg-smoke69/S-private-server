using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030C5")]
internal class UIModelInvitation : UIBaseModel
{
	[Token(Token = "0x40128C2")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, ulong> m_IgnorePlayerDict;

	[Token(Token = "0x40128C3")]
	[FieldOffset(Offset = "0x10")]
	public Queue<object[]> InvitationDataQueue;

	[Token(Token = "0x40128C4")]
	[FieldOffset(Offset = "0x14")]
	public Queue<ulong> InvitationTimeQueue;

	[Token(Token = "0x40128C5")]
	[FieldOffset(Offset = "0x18")]
	public Queue<ulong> InvitationIDQueue;

	[Token(Token = "0x40128C6")]
	[FieldOffset(Offset = "0x20")]
	private ulong m_InvitationID;

	[Token(Token = "0x40128C7")]
	[FieldOffset(Offset = "0x28")]
	public ulong NowTopInvitationID;

	[Token(Token = "0x40128C8")]
	[FieldOffset(Offset = "0x30")]
	private bool _003CIsBlockAllInvitation_003Ek__BackingField;

	[Token(Token = "0x17001538")]
	public bool IsBlockAllInvitation
	{
		[Token(Token = "0x60146F5")]
		[Address(RVA = "0x326BC7C", Offset = "0x326BC7C", VA = "0x326BC7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60146F4")]
		[Address(RVA = "0x326BC74", Offset = "0x326BC74", VA = "0x326BC74")]
		private set
		{
		}
	}

	[Token(Token = "0x60146F3")]
	[Address(RVA = "0x326BB2C", Offset = "0x326BB2C", VA = "0x326BB2C")]
	public UIModelInvitation()
	{
	}

	[Token(Token = "0x60146F6")]
	[Address(RVA = "0x326BC84", Offset = "0x326BC84", VA = "0x326BC84", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60146F7")]
	[Address(RVA = "0x326BCDC", Offset = "0x326BCDC", VA = "0x326BCDC", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60146F8")]
	[Address(RVA = "0x326BD40", Offset = "0x326BD40", VA = "0x326BD40", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60146F9")]
	[Address(RVA = "0x326BDB8", Offset = "0x326BDB8", VA = "0x326BDB8")]
	public void ClearData()
	{
	}

	[Token(Token = "0x60146FA")]
	[Address(RVA = "0x326BE78", Offset = "0x326BE78", VA = "0x326BE78")]
	public void AddInvitationData(object[] args)
	{
	}

	[Token(Token = "0x60146FB")]
	[Address(RVA = "0x326C070", Offset = "0x326C070", VA = "0x326C070")]
	public void AddIgnorePlayer(ulong accountId)
	{
	}

	[Token(Token = "0x60146FC")]
	[Address(RVA = "0x326C244", Offset = "0x326C244", VA = "0x326C244")]
	public void RemoveIgnorePlayer(ulong accountId)
	{
	}

	[Token(Token = "0x60146FD")]
	[Address(RVA = "0x326C36C", Offset = "0x326C36C", VA = "0x326C36C")]
	public bool CheckIsInIgnoreList(ulong accountId)
	{
		return default(bool);
	}

	[Token(Token = "0x60146FE")]
	[Address(RVA = "0x326C504", Offset = "0x326C504", VA = "0x326C504")]
	public void StartBlockAll()
	{
	}

	[Token(Token = "0x60146FF")]
	[Address(RVA = "0x326C560", Offset = "0x326C560", VA = "0x326C560")]
	public void CancelBlockAll()
	{
	}

	[Token(Token = "0x6014700")]
	[Address(RVA = "0x326C5BC", Offset = "0x326C5BC", VA = "0x326C5BC")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014701")]
	[Address(RVA = "0x326C5C4", Offset = "0x326C5C4", VA = "0x326C5C4")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
