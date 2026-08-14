using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4D")]
public class BermudaAwardDesc
{
	[Token(Token = "0x400ABBC")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x400ABBD")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400ABBE")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award_items;

	[Token(Token = "0x400ABBF")]
	[FieldOffset(Offset = "0x14")]
	public uint progress;

	[Token(Token = "0x60081A8")]
	[Address(RVA = "0x317BA88", Offset = "0x317BA88", VA = "0x317BA88")]
	public BermudaAwardDesc()
	{
	}
}
