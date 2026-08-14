using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030B2")]
public class UIModelInGameChat : UIBaseModel
{
	[Token(Token = "0x4012858")]
	private const int MAXMESSAGECOUNT = 50;

	[Token(Token = "0x4012859")]
	public const uint PropID_InGameChatReceiveNewMessage = 2u;

	[Token(Token = "0x401285A")]
	public const uint PropID_InGameChatRevived = 4u;

	[Token(Token = "0x401285B")]
	[FieldOffset(Offset = "0xC")]
	private List<ClientInGameChatMessage> m_ChatMessages;

	[Token(Token = "0x401285C")]
	[FieldOffset(Offset = "0x10")]
	private List<ClientInGameChatMessage> m_AllChatMessages;

	[Token(Token = "0x601461E")]
	[Address(RVA = "0x12C5364", Offset = "0x12C5364", VA = "0x12C5364")]
	public UIModelInGameChat()
	{
	}

	[Token(Token = "0x601461F")]
	[Address(RVA = "0x12C5434", Offset = "0x12C5434", VA = "0x12C5434", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014620")]
	[Address(RVA = "0x12C548C", Offset = "0x12C548C", VA = "0x12C548C")]
	public List<ClientInGameChatMessage> GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x6014621")]
	[Address(RVA = "0x12C54E4", Offset = "0x12C54E4", VA = "0x12C54E4")]
	public List<ClientInGameChatMessage> GetAllMessageList()
	{
		return null;
	}

	[Token(Token = "0x6014622")]
	[Address(RVA = "0x12C553C", Offset = "0x12C553C", VA = "0x12C553C")]
	public void ReturnToLobby()
	{
	}

	[Token(Token = "0x6014623")]
	[Address(RVA = "0x12C5628", Offset = "0x12C5628", VA = "0x12C5628")]
	public void OnRevived()
	{
	}

	[Token(Token = "0x6014624")]
	[Address(RVA = "0x12C5784", Offset = "0x12C5784", VA = "0x12C5784")]
	public int GetMsgMaxCnt()
	{
		return default(int);
	}

	[Token(Token = "0x6014625")]
	[Address(RVA = "0x12C586C", Offset = "0x12C586C", VA = "0x12C586C")]
	public void OnMessageReveiced(List<ClientInGameChatMessage> messages)
	{
	}
}
