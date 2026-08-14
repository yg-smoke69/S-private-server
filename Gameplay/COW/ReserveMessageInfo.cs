using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003274")]
public class ReserveMessageInfo
{
	[Token(Token = "0x401332F")]
	[FieldOffset(Offset = "0x8")]
	public string content;

	[Token(Token = "0x4013330")]
	[FieldOffset(Offset = "0xC")]
	public bool isRequest;

	[Token(Token = "0x4013331")]
	[FieldOffset(Offset = "0xD")]
	public bool isAccepted;

	[Token(Token = "0x4013332")]
	[FieldOffset(Offset = "0x10")]
	public int reason;

	[Token(Token = "0x4013333")]
	[FieldOffset(Offset = "0x14")]
	public int time;

	[Token(Token = "0x4013334")]
	[FieldOffset(Offset = "0x18")]
	public int matchMode;

	[Token(Token = "0x4013335")]
	[FieldOffset(Offset = "0x1C")]
	public int gameMode;

	[Token(Token = "0x4013336")]
	[FieldOffset(Offset = "0x20")]
	public int mapID;

	[Token(Token = "0x6015485")]
	[Address(RVA = "0x240751C", Offset = "0x240751C", VA = "0x240751C")]
	public ReserveMessageInfo()
	{
	}
}
