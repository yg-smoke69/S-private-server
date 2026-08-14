using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002242")]
public class ExtraPlayerDataForMatchResult
{
	[Token(Token = "0x400D61B")]
	[FieldOffset(Offset = "0x8")]
	public ulong accountID;

	[Token(Token = "0x400D61C")]
	[FieldOffset(Offset = "0x10")]
	public string nickName;

	[Token(Token = "0x400D61D")]
	[FieldOffset(Offset = "0x14")]
	public bool isSamoAI;

	[Token(Token = "0x400D61E")]
	[FieldOffset(Offset = "0x18")]
	public uint likedCount;

	[Token(Token = "0x400D61F")]
	[FieldOffset(Offset = "0x1C")]
	public bool hasLike;

	[Token(Token = "0x400D620")]
	[FieldOffset(Offset = "0x1D")]
	public bool isFriend;

	[Token(Token = "0x400D621")]
	[FieldOffset(Offset = "0x1E")]
	public bool isSelf;

	[Token(Token = "0x400D622")]
	[FieldOffset(Offset = "0x1F")]
	public bool hasAddFriend;

	[Token(Token = "0x400D623")]
	[FieldOffset(Offset = "0x20")]
	public bool hasReport;

	[Token(Token = "0x400D624")]
	[FieldOffset(Offset = "0x24")]
	public string region;

	[Token(Token = "0x600B9DA")]
	[Address(RVA = "0x22FF900", Offset = "0x22FF900", VA = "0x22FF900")]
	public ExtraPlayerDataForMatchResult()
	{
	}
}
