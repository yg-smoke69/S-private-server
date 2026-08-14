using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A6")]
public class CSGetRecommandedFriendsByCdtReq
{
	[Token(Token = "0x40096AC")]
	[FieldOffset(Offset = "0x8")]
	public ESocial.Language language;

	[Token(Token = "0x40096AD")]
	[FieldOffset(Offset = "0xC")]
	public ESocial.Gender gender;

	[Token(Token = "0x40096AE")]
	[FieldOffset(Offset = "0x10")]
	public ESocial.TimeActive time_active;

	[Token(Token = "0x40096AF")]
	[FieldOffset(Offset = "0x14")]
	public ESocial.ModePrefer mode_prefer;

	[Token(Token = "0x40096B0")]
	[FieldOffset(Offset = "0x18")]
	public uint rank;

	[Token(Token = "0x6007D07")]
	[Address(RVA = "0x30950C4", Offset = "0x30950C4", VA = "0x30950C4")]
	public CSGetRecommandedFriendsByCdtReq()
	{
	}
}
