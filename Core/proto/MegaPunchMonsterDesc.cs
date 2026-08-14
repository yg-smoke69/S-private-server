using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7B")]
public class MegaPunchMonsterDesc
{
	[Token(Token = "0x400ACE4")]
	[FieldOffset(Offset = "0x8")]
	public uint monster_id;

	[Token(Token = "0x400ACE5")]
	[FieldOffset(Offset = "0xC")]
	public string icon;

	[Token(Token = "0x400ACE6")]
	[FieldOffset(Offset = "0x10")]
	public string dailogue_text;

	[Token(Token = "0x400ACE7")]
	[FieldOffset(Offset = "0x14")]
	public uint rate;

	[Token(Token = "0x60081D6")]
	[Address(RVA = "0x30A86D4", Offset = "0x30A86D4", VA = "0x30A86D4")]
	public MegaPunchMonsterDesc()
	{
	}
}
