using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001573")]
public class CupBattleRecord
{
	[Token(Token = "0x400933A")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400933B")]
	[FieldOffset(Offset = "0x10")]
	public bool win;

	[Token(Token = "0x400933C")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x400933D")]
	[FieldOffset(Offset = "0x18")]
	public uint head_pic;

	[Token(Token = "0x6007BBB")]
	[Address(RVA = "0x309D9D4", Offset = "0x309D9D4", VA = "0x309D9D4")]
	public CupBattleRecord()
	{
	}
}
